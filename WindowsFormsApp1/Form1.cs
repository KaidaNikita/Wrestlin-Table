using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public partial class Form1 : MetroForm
    {

        public Form1()
        {
            InitializeComponent();
        }

        [Serializable]
        public partial class SaveTable
        {
            public FlowLayoutPanel Temp_panel { get; set; }
            public SaveTable() {}

            public SaveTable(FlowLayoutPanel controls)
            {
                Temp_panel = controls;
            }
        }

        static public List<Wrestler> wrestlers = new List<Wrestler>();
        public class Wrestler
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Lot { get; set; }
           
            public Wrestler(){}

            public Wrestler(string name, string surname, string city, string lot)
            {
                Name=name;
                Surname=surname;
                City=city;
                Lot =lot;
            }
    }
        public void GetAllWrestlers()
        {
            try
            {
 Form5 form = new Form5();
            for (int i = 0; i <wrestlers.Count; i+=2)
            {
            var m_label = new Label
            {
                Name = "Label" + i.ToString(),
                Text = wrestlers[i].Surname+" "+wrestlers[i].Name[0]+".",
                Location = new Point { X = 6, Y = 40 },
            };

                var m_label2 = new Label
                {
                    Name = "Label" + (i + 1).ToString(),
                    Text = wrestlers[i+1].Surname + " " + wrestlers[i+1].Name[0] + ".",
                    Location = new Point { X = m_label.Location.X, Y = m_label.Location.Y - 22 },
               };

                var m_radio = new RadioButton
                {
                    Name = "Radio" + i.ToString(),
                    Text = "Win 2",
                    Checked = false,
                    AutoSize = true,
                    Location = new Point { X = m_label.Location.X+100, Y = m_label.Location.Y },
                };

                var m_radio2 = new RadioButton
                {
                    Text = "Win 1",
                    Name = "Radio" + (i + 1).ToString(),
                    Checked = false,
                    AutoSize = true,
                    Location = new Point { X = m_label2.Location.X + 100, Y = m_label2.Location.Y },
                };

                var g_b = new GroupBox
            {
                Name= "groupBox"+i.ToString(),
                Text = String.Empty,
                Location = new Point { X = 58, Y = i*50 },
                Width = 162,
                Height = 69
            };
                g_b.Controls.AddRange(new Control[]{
                    m_label,m_label2,m_radio2,m_radio
                 });
                    form.Controls["metroPanel1"].Controls.AddRange(new Control[]
                {
                    g_b
                });

            }
            form.Show(); 
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill all area");
            }

        }

        public bool IsDigit(string str)
        {
            try
            {
                Int32.Parse(str);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        int max = 0;
        private void MetroButton2_Click(object sender, EventArgs e)
        {

            wrestlers.Add(new Wrestler(textBox1.Text,textBox2.Text, textBox3.Text, textBox4.Text));
                 toolStripStatusLabel1.Text = "Count of wreslers:"+wrestlers.Count.ToString();
            if (int.Parse(textBox4.Text)>max)
            {
                max = int.Parse(textBox4.Text);
                toolStripStatusLabel2.Text ="Max lot:"+max.ToString();
            }

            var m_textbox = new TextBox
            {
                Text = textBox1.Text,
                Location = new Point { X = 10, Y = 20 },
            };
            var m_textbox2 = new TextBox
            {
                Text = textBox2.Text,
                Location = new Point { X = 110, Y = 20 },
            };
            var m_textbox3 = new TextBox
            {
                Text = textBox3.Text,
                Location = new Point { X = 210, Y = 20 },
            };

            var m_label = new Label
            {
                Text = "Name",
                Location = new Point { X = m_textbox.Location.X, Y = m_textbox.Location.Y - 12 },
            };

            var m_label2 = new Label
            {
                Text = "Surname",
                Location = new Point { X = m_textbox2.Location.X, Y = m_textbox2.Location.Y - 12 },
            };

            var m_label3 = new Label
            {
                Text = "City",
                Location = new Point { X = m_textbox3.Location.X, Y = m_textbox3.Location.Y - 12 },
            };

            var m_textbox4 = new MaskedTextBox
            {
                Text = textBox4.Text,
                Location = new Point { X = 310, Y = 20 },
                Size = new Size(25, 25)
            };

            var m_label4 = new Label
            {
                Text = "Lot",
                Location = new Point { X = m_textbox4.Location.X, Y = m_textbox.Location.Y - 12 },
            };

            var g_b = new GroupBox
            {
                Text = String.Empty,
                Width = 350,
                Height = 50,
                Enabled=false
                
            };

            g_b.Controls.AddRange(new Control[]{
                m_textbox,m_textbox2,m_textbox3,m_textbox4,m_label,m_label2,m_label3,m_label4
                 });

            flowLayoutPanel1.Controls.AddRange(new Control[]
            {
                g_b
            });
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                    flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                    wrestlers.Remove(wrestlers[wrestlers.Count - 1]);
            }
            catch (Exception) { }

        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Привет", new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        public bool CheckTwo(int count)
        {
            for (int i = 0; i < 10; i++)
            {
            if (System.Math.Pow(count, i)%8==0)
            {
                    return true;
            }
            }
            return false;
        }

        List<Wrestler> free = new List<Wrestler>();

        void SortWrestlers()
        {
            try
            {
            Wrestler tmp;
           if (CheckTwo(wrestlers.Count))
           {
            for (int i = 0; i < wrestlers.Count-1 ; ++i)
            {
                for (int j = 0; j < wrestlers.Count-1 ; ++j)
                {
                    if (Int32.Parse(wrestlers[j + 1].Lot) < Int32.Parse(wrestlers[j].Lot))
                    {
                        tmp = wrestlers[j + 1];
                        wrestlers[j + 1] = wrestlers[j];
                        wrestlers[j] = tmp;
                    }
                }
            }
          }
                else
                {
                    int k = 0;
                    for (int i = 0; i < wrestlers.Count - 1; ++i)
                    {
                        if (k==0)
                        {
                        for (int j = 0; j < wrestlers.Count - 1; ++j)
                        {
                            if (Int32.Parse(wrestlers[j + 1].Lot) < Int32.Parse(wrestlers[j].Lot))
                            {
                                tmp = wrestlers[j + 1];
                                wrestlers[j + 1] = wrestlers[j];
                                wrestlers[j] = tmp;
                            }
                        }
                        }
                      if (wrestlers.Count > 8 && wrestlers.Count < 16 || wrestlers.Count > 16 && i < 32)
                        {
                            free.Add(wrestlers[i]);
                            k++;
                        }
                   
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill all area");
            }

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            int number;

            bool result = Int32.TryParse(textBox4.Text, out number);
            if (result)
            {
                textBox4.Text = number.ToString();  
            }
            else
            {
                textBox4.Text = string.Empty;
            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintPageHandler;
            printDoc.Print();
        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            SortWrestlers();
            GetAllWrestlers();
        }

        private void MetroButton5_Click(object sender, EventArgs e)
        {
            try
            {
            SaveTable person = new SaveTable(flowLayoutPanel1);
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("My_table.txt", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, person);
            }
            }
            catch (Exception){}

        }

        private void MetroButton6_Click(object sender, EventArgs e)
        {
            try
            {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("My_table.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                SaveTable newTable = (SaveTable)formatter.Deserialize(fs);
                flowLayoutPanel1 = newTable.Temp_panel;
            }
            }
            catch (Exception){}
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fill all blanks and press 'add wrestler' / When you fill all table press 'print table' to print tournament table / To remove wrestler from table press 'remove wrestler'");
        }

    }


}

