﻿namespace Tasks
{
    public partial class TaskItemControl : UserControl
    {
        public event Action<TaskItem> EditClicked;
        public event Action<TaskItem> DeleteClicked;

        private TaskItem _task;

        public TaskItem Task
        {
            get { return _task; }
            set
            {
                _task = value;
                UpdateUI();
            }
        }

        public TaskItemControl()
        {
            InitializeComponent();
        }

        public TaskItemControl(TaskItem task) : this()
        {
            Task = task;
        }

        private void TaskItemControl_Load(object sender, EventArgs e)
        {

        }

        private void UpdateUI()
        {
            if (_task != null)
            {
                lblTitle.Text = _task.Title;
                chkCompleted.Checked = _task.IsCompleted;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var inputForm = new InputDialog("Редактировать задачу", "Введите новый текст:", _task.Title))
            {
                if (inputForm.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(inputForm.Input))
                {
                    _task.Title = inputForm.Input;
                    EditClicked?.Invoke(_task);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(_task);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ShowTaskDetails(_task);
        }

        private void ShowTaskDetails(TaskItem task)
        {
            string message = $"Название: {task.Title}\n" +
                              $"Исполнитель: {task.AssignedTo}\n" +
                              $"Срок выполнения: {(task.DueDate.HasValue ? task.DueDate.Value.ToShortDateString() : "Не указан")}\n" +
                              $"Статус: {(task.IsCompleted ? "Выполнено" : "В процессе")}";

            MessageBox.Show(message, "Детали задачи", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
