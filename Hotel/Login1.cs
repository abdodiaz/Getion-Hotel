using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

     

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin" && textBox2.Text=="admin")
            {
                Gestion1 gs = new Gestion1();
                gs.Show();
                this.Hide();
            }
          
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
