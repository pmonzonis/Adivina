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
    public partial class Form1 : Form
    {
        
        Boolean mouseAction;
        Point FormPosition;       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            FormPosition = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouseAction = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseAction == true)
            {
                Location = new Point(Cursor.Position.X - FormPosition.X, Cursor.Position.Y - FormPosition.Y);
                mouseAction = true;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAction = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();            
            form2.Show();            
        }        
    }
}
