using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public partial class InputDialog : Form
    {
        public InputDialog(string title, string promptText, string defaultValue = "")
        {
            InitializeComponent();
            this.Text = title;
            lb_Text.Text = promptText;
            txtInput.Text = defaultValue;

            this.AcceptButton = btnOK; 
            this.CancelButton = btnCancel; 
        }

        public string Input => txtInput.Text;

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
