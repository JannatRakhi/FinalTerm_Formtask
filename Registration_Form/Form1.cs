using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;
            if(user== "Rakhi" && pass=="12345")
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Error");
            }
            Form2 ob1 = new Form2();
            ob1.Show();

        }
    }
}
