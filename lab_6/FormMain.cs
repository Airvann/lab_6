using System;
using System.Windows.Forms;

namespace lab_6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormMap formMap = new FormMap();
            formMap.Show();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            richTextBoxInfo.Text += "Самолет отправлен\n";
        }
    }
}
