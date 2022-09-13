using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_form
{
    public partial class Form1 : Form
    {
        static int attempt = 3;
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if ((this.textBox1.Text == "Admin") && (this.textBox2.Text == "admin"))
            {
                attempt = 0;
                pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Desktop\granted.jpg");
                MessageBox.Show("you are granted with access");


            }
            else if ((attempt == 3) && (attempt > 0))
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Desktop\images1.jpg");
                label4.Text = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                --attempt;
            }
            else
            {
                pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Desktop\denied.jpg");
                MessageBox.Show("you are not granted with access");
            }

        }
    }
}

