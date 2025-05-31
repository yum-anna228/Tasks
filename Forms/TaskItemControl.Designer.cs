namespace Tasks
{
    partial class TaskItemControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnEdit = new Button();
            button1 = new Button();
            chkCompleted = new CheckBox();
            btnInfo = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(36, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Подготовиться к сесии";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(250, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(350, 5);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkCompleted
            // 
            chkCompleted.AutoSize = true;
            chkCompleted.Location = new Point(3, 9);
            chkCompleted.Name = "chkCompleted";
            chkCompleted.Size = new Size(18, 17);
            chkCompleted.TabIndex = 3;
            chkCompleted.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(465, 5);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(28, 29);
            btnInfo.TabIndex = 4;
            btnInfo.Text = "i";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // TaskItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Transparent;
            Controls.Add(btnInfo);
            Controls.Add(chkCompleted);
            Controls.Add(button1);
            Controls.Add(btnEdit);
            Controls.Add(lblTitle);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "TaskItemControl";
            Size = new Size(624, 100);
            Load += TaskItemControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnEdit;
        private Button button1;
        private CheckBox chkCompleted;
        private Button btnInfo;
    }
}
