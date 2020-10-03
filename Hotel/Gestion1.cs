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
    public partial class Gestion1 : Form
    {
        public Gestion1()
        {
            InitializeComponent();
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client1 cl = new Client1();
            cl.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reglement1 rg = new Reglement1();
            rg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reservation1 rv = new Reservation1();
            rv.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Chambre1 ch = new Chambre1();
            ch.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mails m = new Mails();
            m.Show();
            this.Hide();
           
        }
    }
}
