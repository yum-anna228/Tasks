using System.Windows;

namespace Tasks
{
    partial class MainForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtNewTask = new TextBox();
            btnAdd = new Button();
            panel1 = new Panel();
            flowTasks = new FlowLayoutPanel();
            lb_Name = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNewTask
            // 
            txtNewTask.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewTask.ForeColor = Color.Silver;
            txtNewTask.Location = new Point(4, 3);
            txtNewTask.Name = "txtNewTask";
            txtNewTask.Size = new Size(738, 27);
            txtNewTask.TabIndex = 0;
            txtNewTask.Text = "\r\n";
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderColor = Color.Black;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 20);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Malgun Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(671, 438);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 66);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(txtNewTask);
            panel1.Location = new Point(99, 377);
            panel1.Name = "panel1";
            panel1.Size = new Size(745, 32);
            panel1.TabIndex = 2;
            // 
            // flowTasks
            // 
            flowTasks.BackColor = Color.Transparent;
            flowTasks.Dock = DockStyle.Top;
            flowTasks.Location = new Point(0, 0);
            flowTasks.Name = "flowTasks";
            flowTasks.Size = new Size(934, 253);
            flowTasks.TabIndex = 6;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Name.Location = new Point(99, 346);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(226, 28);
            lb_Name.TabIndex = 7;
            lb_Name.Text = "Введите новую задачу";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 537);
            Controls.Add(lb_Name);
            Controls.Add(flowTasks);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewTask;
        private Button btnAdd;
        private Panel panel1;
        private FlowLayoutPanel flowTasks;
        private Label lb_Name;
    }
}