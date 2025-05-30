namespace Tasks
{
    partial class InputDialog
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
            lb_Text = new Label();
            txtInput = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lb_Text
            // 
            lb_Text.AutoSize = true;
            lb_Text.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Text.Location = new Point(22, 23);
            lb_Text.Name = "lb_Text";
            lb_Text.Size = new Size(213, 28);
            lb_Text.TabIndex = 0;
            lb_Text.Text = "Введите новый текст:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(22, 67);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(463, 27);
            txtInput.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.FlatAppearance.BorderColor = Color.Black;
            btnOK.FlatAppearance.BorderSize = 3;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(55, 158);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(157, 60);
            btnOK.TabIndex = 2;
            btnOK.Text = "ОК";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.Black;
            btnCancel.FlatAppearance.BorderSize = 3;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(285, 158);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(157, 60);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // InputDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 262);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtInput);
            Controls.Add(lb_Text);
            Name = "InputDialog";
            Text = "InputDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Text;
        private TextBox txtInput;
        private Button btnOK;
        private Button btnCancel;
    }
}