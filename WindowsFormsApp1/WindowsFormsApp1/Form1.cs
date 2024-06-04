using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1
               && comboBox4.SelectedIndex != -1 && (radioButton1.Checked != false || radioButton2.Checked != false)
              )
            {
                button1.Enabled = true;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1
               && comboBox4.SelectedIndex != -1 && radioButton1.Checked != false || radioButton2.Checked != false
              )
            {
                button1.Enabled = true;
            }
            if (comboBox1.SelectedIndex==0 && comboBox2.SelectedIndex==0)
            {
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources.white_american;
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources.american_black;
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources.cream;
            }
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 3)
            {
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources.cinnamon;
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources.breed_blue_point;
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 1)
            {
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources.chooklet_breed;
            }
            if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources.lilaac;
            }
            if (comboBox1.SelectedIndex == 2 )
            {
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources.cute_munchkin_cat;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add("white \n".ToString());
                comboBox2.Items.Add("black \n".ToString());
                comboBox2.Items.Add("cream \n".ToString());
                comboBox2.Items.Add("cinnamon \n".ToString());
        


            }
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Blue Point \n".ToString());
                comboBox2.Items.Add(" Chocolate Point\n".ToString());
                comboBox2.Items.Add("Lilac Point \n".ToString());
            }
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Colors and Patterns Vary \n".ToString());
            }
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1
               && comboBox4.SelectedIndex != -1 && radioButton1.Checked != false || radioButton2.Checked != false
              )
            {
                button1.Enabled = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.SelectedIndex == 0)
            {
                for (int i = 1; i <= 12; i++)
                {
                    comboBox4.Items.Add(i.ToString());
                }
            }
            if (comboBox3.SelectedIndex == 1)
            {

                for (int b = 1; b <= 30; b++)
                {
                    comboBox2.Items.Clear();
                    comboBox4.Items.Add(b.ToString());
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1
                && comboBox4.SelectedIndex != -1 && (radioButton1.Checked != false || radioButton2.Checked != false)
               )
            {
                button1.Enabled = true;

            }
            if (button1.Enabled == true)
                groupBox2.Enabled = true;




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1
               && comboBox4.SelectedIndex != -1 && (radioButton1.Checked != false || radioButton2.Checked != false)
              )
            {
                button1.Enabled = true;
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1
               && comboBox4.SelectedIndex != -1 && (radioButton1.Checked != false || radioButton2.Checked != false)
              )
            {
                button1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != " " && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                button2.Enabled = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = $"cat category:{comboBox1.SelectedItem}\n" + $"cat color:{comboBox2.SelectedItem}\n"
                 + $"cat age:{comboBox3.SelectedItem}{comboBox4.SelectedItem}\n" + $"cat gender:{(radioButton1.Checked ? "female" : "male")}\n"
                 + $"notes:{richTextBox1.Text}\n" + $"full name:{textBox1.Text}{textBox2.Text}\n" + $"adress:{textBox4.Text}\n"
                 + $"phone number:{textBox3.Text}\n";
            button3.Enabled = true;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = $"cat category:{comboBox1.SelectedItem}\n" + $"cat color:{comboBox2.SelectedItem}\n"
                + $"cat age:{comboBox3.SelectedItem}{comboBox4.SelectedItem}\n" + $"cat gender:{(radioButton1.Checked ? "female" : "male")}\n"
                + $"notes:{richTextBox1.Text}\n" + $"full name:{textBox1.Text}{textBox2.Text}\n" + $"adress:{textBox4.Text}\n"
                + $"phone number:{textBox3.Text}\n";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != " " && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                button2.Enabled = true;
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != " " && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                button2.Enabled = true;
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != " " && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                button2.Enabled = true;
            }

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        int counter = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (counter)
            {
                case 0:
                    {
                        richTextBox3.Text = "A group of cats is called a clowder, a male cat is called a tom, a female cat is called a molly or queen while young cats are called kittens.";
                        counter++;
                        break;

                    }
                case 1:
                    {

                        richTextBox3.Text = "Cats have powerful night vision, allowing them to see at light levels six times lower than what a human need in order to see.";

                        counter++;
                        break;
                    }
                case 2:


                    {

                        richTextBox3.Text = "Cats also have excellent hearing and a powerful sense of smell.";

                        counter++;
                        break;
                    }
                case 3:
                    {
                        richTextBox3.Text = "Older cats can at times act aggressively towards kittens.";

                        counter = 0;
                        break;
                    }
            }





        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this application is to adopt cats", "about", MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                writer.WriteLine(richTextBox2.Text);
                writer.Close();
                richTextBox2.Text = "";

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                string st = reader.ReadToEnd();
                richTextBox2.Text = st;
                reader.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                writer.WriteLine(richTextBox2.Text);
                writer.Close();
                richTextBox2.Text = "";

            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0 )
            {
                pictureBox1.Image = WindowsFormsApp1.Properties.Resources.white_american;
            }
        }
    }
}
