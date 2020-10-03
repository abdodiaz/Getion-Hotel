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
    public partial class Chambre1 : Form
    {
        PhotelEntities db = new PhotelEntities();
        public Chambre1()
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

        private void Chambre1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'photelDataSet.Chambre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chambreTableAdapter.Fill(this.photelDataSet.Chambre);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Chambre cham = new Chambre();
                cham.NumChambre = int.Parse(textBox2.Text);
                cham.Etage = int.Parse(textBox3.Text);
                cham.typechambre = comboBox1.Text;
                cham.Prixchambre = Decimal.Parse(tb_prix.Text);
                db.Chambre.Add(cham);
                db.SaveChanges();
                this.chambreTableAdapter.Fill(this.photelDataSet.Chambre);

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
                int i = int.Parse(textBox2.Text.Trim());
                Chambre cham = db.Chambre.FirstOrDefault(x => x.NumChambre == i);
                cham.Etage = int.Parse(textBox3.Text);
                cham.typechambre = comboBox1.Text;
                db.SaveChanges();
                this.chambreTableAdapter.Fill(this.photelDataSet.Chambre);
            }
            catch (Exception )
            {

                MessageBox.Show("!!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("selectioner un chambre");
            }
            else
            {
                bool cond = MessageBox.Show("", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK;
                if (cond)
                {
                    try
                    {
                        int i = int.Parse(textBox2.Text.Trim());
                        Chambre cham = db.Chambre.FirstOrDefault(x => x.NumChambre == i);
                        db.Chambre.Remove(cham);
                        db.SaveChanges();
                        MessageBox.Show("la chambre " + i.ToString() + " est supprimer");
                        this.chambreTableAdapter.Fill(this.photelDataSet.Chambre);
                    }
                    catch (Exception ee)
                    {

                        MessageBox.Show("cette chambre non trouver!");
                    }
                }
            }

        }
    }
}
