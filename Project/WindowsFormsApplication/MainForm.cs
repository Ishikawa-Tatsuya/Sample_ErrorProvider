using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _textBox_Validating(object sender, CancelEventArgs e)
        {
            int val = 0;
            if (int.TryParse(_textBox.Text, out val))
            {
                _errorProvider.SetError(_textBox, string.Empty);
            }
            else
            {
                _errorProvider.SetError(_textBox, "数字じゃないよ。");
            }
        }
    }
}
