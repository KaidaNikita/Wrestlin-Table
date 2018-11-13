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

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
           InitializeComponent();
        }
        [Serializable]
    public  class Person
        {
            public string Pass { get; set; }
            public Person(){}
            public Person(string pass)
            {
                Pass = pass;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(metroTextBox1.Text!=String.Empty&& metroTextBox2.Text != String.Empty)
            {
                Person person = new Person(metroTextBox2.Text);
                BinaryFormatter binFormat = new BinaryFormatter();
                using (Stream fStream = new FileStream(metroTextBox1.Text+".txt",FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    binFormat.Serialize(fStream,person);
                }
            }
        }
    }
}
