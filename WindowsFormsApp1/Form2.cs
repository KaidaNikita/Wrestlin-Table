using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Log_in form = new Log_in();
            form.ShowDialog();
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fill all blanks and press 'add wrestler' / When you fill all table press 'print table' to print tournament table / To remove wrestler from table press 'remove wrestler'");
        }
    }

}
