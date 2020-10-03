using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Hotel
{
    public partial class Reservation1 : Form
    {
        PhotelEntities db = new PhotelEntities();
        Reservation ri = new Reservation();
        public Reservation1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gestion1 gs = new Gestion1();
            gs.Show();
            this.Hide();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'photelDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.photelDataSet.Client);
            // TODO: cette ligne de code charge les données dans la table 'photelDataSet.Chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.photelDataSet.Chambre);
            // TODO: cette ligne de code charge les données dans la table 'photelDataSet.Reservation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.reservationTableAdapter.Fill(this.photelDataSet.Reservation);
            // TODO: cette ligne de code charge les données dans la table 'photelDataSet1.Reservation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
          
            radioButton1.Checked = true;
           
        


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            int b;
                 
            ri.CodeClient = (int)comboBox1.SelectedValue;
            ri.NumR = int.Parse(textBox2.Text);
            ri.NumChambre = (int)comboBox2.SelectedValue;
            ri.Dated = dateTimePicker1.Value;
            ri.Datef = dateTimePicker2.Value;
            if (radioButton1.Checked)
                b = 1;
            else if (radioButton2.Checked)
                b = 2;
            else
                b = 3;
            ri.NombrePlace = b;
                db.Reservation.Add(ri);
                db.SaveChanges();
              textBox2.Text = "";
                this.reservationTableAdapter.Fill(this.photelDataSet.Reservation);
            }
            catch (Exception)
            {

                MessageBox.Show("verifier les informations!");
            }

}

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

          
            int b;
            int i = int.Parse(textBox2.Text.Trim());
           Reservation rev = db.Reservation.FirstOrDefault(x => x.NumR == i);

            ri.CodeClient = (int)comboBox1.SelectedValue;
          //  ri.NumR = int.Parse(textBox2.Text);
            ri.NumChambre = (int)comboBox2.SelectedValue;
            ri.Dated = dateTimePicker1.Value;
            ri.Datef = dateTimePicker2.Value;
            if (radioButton1.Checked)
                b = 1;
            else if (radioButton2.Checked)
                b = 2;
            else
                b = 3;
            ri.NombrePlace = b;
          
            db.SaveChanges();
            textBox2.Text = "";
            this.reservationTableAdapter.Fill(this.photelDataSet.Reservation);
            }
            catch (Exception)
            {

                MessageBox.Show("virifier num de reservation!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("selectioner le num de resrvation");
            }
            else
            {
                bool cond = MessageBox.Show("", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK;
                if (cond)
                {
                    try
                    {
                        int i = int.Parse(textBox2.Text.Trim());
                        Reservation ri = db.Reservation.FirstOrDefault(x => x.NumR == i);
                        db.Reservation.Remove(ri);
                        db.SaveChanges();
                        MessageBox.Show("cette reservation " + i.ToString() + " annuler");
                        this.reservationTableAdapter.Fill(this.photelDataSet.Reservation);

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("cette reservation ..");
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox2.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox1.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Value= Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
        }
    }

   
    }

