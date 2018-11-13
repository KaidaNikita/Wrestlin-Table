using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static WindowsFormsApp1.Form4;

namespace WindowsFormsApp1
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text == "admin" && metroTextBox3.Text == "1234")
            {
                Form1 form = new Form1();
                form.ShowDialog();
                Close();
            }
            else
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(metroTextBox2.Text + ".txt", FileMode.OpenOrCreate, FileAccess.Read))
                    {
                        Person newPerson = (Person)formatter.Deserialize(fs);
                        if (metroTextBox3.Text==newPerson.Pass)
                        {
                            Form1 form = new Form1();
                            form.Controls["groupBox2"].Enabled=false;
                          //  form.Controls["flowLayoutPanel1"].Controls.AddRange(Controls[]
                          //  {
                          //
                          //  })
                            form.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Password is wrong!!!");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No account(please sign up)");
                }
            }
        }
    }
}
