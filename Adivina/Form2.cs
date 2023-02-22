using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adivina
{
    public partial class Form2 : Form
    {
                
        int num1;
        int i;        
        int num2;
        Boolean mouseAction;
        Point FormPosition;

        public Form2()
        {
            InitializeComponent();
            Random rdn = new Random();
            num1 = rdn.Next(0,50);
        }

        private void button1_Click(object sender, EventArgs e)
        {   

            if (textBox1.Text == "")
            {
                MessageBox.Show("Has d'introduir un número");
            }
            else
            {
                int val;                
                if (!int.TryParse(textBox1.Text, out val))
                {
                    MessageBox.Show(" Només números");
                    textBox1.Undo();                                       
                }
                else {
                    num2 = Convert.ToInt32(textBox1.Text);
                    if (num1 == num2)
                    {
                        MessageBox.Show(" Enhorabona, has acertat el número");
                        Close();
                        Application.Exit();
                    }
                    else
                    {
                        if (num2 > 50 || num2 < 0)
                        {
                            MessageBox.Show(" Només valors entre 0 i 50");
                            textBox1.Clear();
                        }
                        else if (num1 > num2)
                        {
                            MessageBox.Show(" El número és major  ");
                            textBox1.Clear();
                            i++;
                        }
                        else 
                        {
                            MessageBox.Show(" El número és menor  ");
                            textBox1.Clear();
                            i++;
                        }                        
                    }

                    if (i == 5)
                    {
                        MessageBox.Show(" No queden més intents, el número era el " + num1);
                        Close();
                        Application.Exit();
                    }
                }                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            FormPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - FormPosition.X, Cursor.Position.Y - FormPosition.Y);
                mouseAction = true;
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }
    }
}
