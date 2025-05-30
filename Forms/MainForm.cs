using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public partial class MainForm : Form
    {
        private readonly ITaskService _taskService;

        public MainForm(ITaskService taskService)
        {
            InitializeComponent();
            _taskService = taskService;
            Load += async (s, e) => await LoadTasksAsync();
        }

        private async Task LoadTasksAsync()
        {
            flowTasks.Controls.Clear();

            var tasks = await _taskService.GetAllTasksAsync();

            foreach (var task in tasks)
            {
                var control = new TaskItemControl(task);
                control.EditClicked += async (t) =>
                {
                    t.IsCompleted = !t.IsCompleted;
                    await _taskService.UpdateTaskAsync(t);
                    await LoadTasksAsync();
                };
                control.DeleteClicked += async (t) =>
                {
                    await _taskService.DeleteTaskAsync(t.Id);
                    await LoadTasksAsync();
                };

                flowTasks.Controls.Add(control);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewTask.Text))
            {
                var newTask = new TaskItem
                {
                    Id = Guid.NewGuid(),
                    Title = txtNewTask.Text,
                    IsCompleted = false
                };

                await _taskService.AddTaskAsync(newTask);
                txtNewTask.Clear();
                await LoadTasksAsync(); 
            }
            else
            {
                MessageBox.Show("Введите текст задачи.");
            }
        }

    }
}