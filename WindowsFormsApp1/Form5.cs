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
    public partial class Form5 : MetroForm
    {

      public Form5()
        {
            InitializeComponent();   
        }
        List<Form1.Wrestler> wrestlers = Form1.wrestlers;
        List<Form1.Wrestler> winers = new List<Form1.Wrestler>();

        public  Form1.Wrestler CheckWinner(string surname)
        {
            Form1.Wrestler wrestler = new Form1.Wrestler();
            for (int i = 0; i < wrestlers.Count; i++)
            {
             if (surname== wrestlers[i].Surname+" "+ wrestlers[i].Name[0].ToString() + ".")
            {
                    wrestler = wrestlers[i];
            }
            }
            return wrestler;
        }

        public void CheckWinners()
        {
            for (int i = 3; i < metroPanel1.Controls.Count; i++)
            {
                for (int j = 2; j < 4; j++)
                {
                    if (((metroPanel1.Controls[i].Controls[j]) as RadioButton).Checked)
                    {
                        if (j == 2)
                        {
                         winers.Add(CheckWinner((metroPanel1.Controls[i].Controls[j - 1] as Label).Text));
                         ((metroPanel1.Controls[i].Controls[j]) as RadioButton).Checked = false;
                        }
                        if (j == 3)
                        {
                            winers.Add(CheckWinner((metroPanel1.Controls[i].Controls[j - 3] as Label).Text));
                            ((metroPanel1.Controls[i].Controls[j]) as RadioButton).Checked = false;
                        }
                    }
                }
            }
        }
            int temp_x = 250;
            int temp_y = 69;
            int temp2_x;
            int temp2_y;
            int k = 0;
        public void NextStage(int smth)
        {
            for (int i = 0; i < winers.Count; i+=2)
            {
              string _name1 = winers[i].Surname + " " + winers[i].Name[0].ToString() + ".", _name2 = winers[i+1].Surname + " " + winers[i+1].Name[0].ToString() + ".";
              var name1 = new Label
            {
                Name = _name1,
                Text = _name1,
                Location = new Point { X = 6, Y = 40 },
            };

            var name2 = new Label
            {
                Name = _name2,
                Text = _name2,
                Location = new Point { X = name1.Location.X, Y = name1.Location.Y - 22 },
            };

            var m_radio = new RadioButton
            {
                Name = "Radio" + i.ToString(),
                Text = "Win 2",
                Checked = false,
                AutoSize = true,
                Location = new Point { X = name1.Location.X + 100, Y = name1.Location.Y },
            };

            var m_radio2 = new RadioButton
            {
                Text = "Win 1",
                Name = "Radio" + (i + 1).ToString(),
                Checked = false,
                AutoSize = true,
                Location = new Point { X = name2.Location.X + 100, Y = name2.Location.Y },
            };              
                GroupBox g_b = new GroupBox();

             if (smth < wrestlers.Count / 4)
            {
                 g_b = new GroupBox
            {

                    Name = "groupBox" + i.ToString(),
                Text = String.Empty,
                Location = new Point {X=temp_x,Y=temp_y },
                Width = 162,
                Height = 69
            };

            }
                else
                {
                    if (k == 0)
                    {
                        temp2_x = temp_x + 200;
                        temp2_y = temp_y - 150;
                        k++;
                    }
                    g_b = new GroupBox
                    {
                        Name = "groupBox" + i.ToString(),
                        Text = String.Empty,
                        Location = new Point { X = temp2_x, Y = temp2_y },
                        Width = 162,
                        Height = 69
                    };
                    temp2_y = temp_y + 100;
                }
         
            g_b.Controls.AddRange(new Control[]
            {
            name1,name2,m_radio2,m_radio
            });

            metroPanel1.Controls.AddRange(new Control[]
             {
                  g_b
             });

                if (smth<wrestlers.Count/4)
                {
                temp_x = g_b.Location.X;
                temp_y = g_b.Location.Y + 100;
                winers.RemoveAt(i);
                winers.RemoveAt(i+i);
                }
                else
                {
                    winers.RemoveRange(0,winers.Count);
                }

                return;
            }
        }
        int smth = 0;
        private void MetroButton1_Click(object sender, EventArgs e)
        {
            CheckWinners();
            NextStage(smth);
            smth++;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
