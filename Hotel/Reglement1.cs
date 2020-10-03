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
    public partial class Reglement1 : Form
    {
        PhotelEntities db = new PhotelEntities();
        public Reglement1()
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

        private void Reglement1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'photelDataSet.Payment'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.paymentTableAdapter.Fill(this.photelDataSet.Payment);
            
            var list = db.ClientNonPayee().ToList();
            list.Insert(0,new ClientNonPayee_Result { numr = -1, nomComplet = "Selectionner une reservation" });
            cb_reservation.DataSource = list;
            cb_reservation.DisplayMember = "nomComplet";
            cb_reservation.ValueMember = "numr";
         


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Payment pm = new Payment();
                pm.PaymentId = int.Parse(tb_id.Text);
                pm.NumR = (int)cb_reservation.SelectedValue;
                pm.PaymentDate = dt_pay.Value;
                pm.PaymentType = cm_mode.Text;
                pm.PaymentTotal = Decimal.Parse(tb_montan.Text);
                db.Payment.Add(pm);
                db.SaveChanges();
                tb_id.Text = tb_montan.Text = "";

                this.paymentTableAdapter.Fill(this.photelDataSet.Payment);


            }
            catch (Exception)
            {

                MessageBox.Show("virefier les zones de text");
            }
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                MessageBox.Show("selectioner un client");
            }
            else
            {
                bool cond = MessageBox.Show("vous voulez vraiment supprimer cette paiment", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK;
                if (cond)
                {
                    try
                    {
                        int i = int.Parse(tb_id.Text.Trim());
                       Payment paym = db.Payment.FirstOrDefault(x => x.PaymentId == i);
                        db.Payment.Remove(paym);
                        db.SaveChanges();
                        MessageBox.Show("le client " + i.ToString() + " est supprimer");
                        this.paymentTableAdapter.Fill(this.photelDataSet.Payment);

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("sel");
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = int.Parse(tb_id.Text.Trim());
            Payment pm = db.Payment.FirstOrDefault(x => x.PaymentId == i);
          //  pm.PaymentId = int.Parse(tb_id.Text);
           // pm.NumR = (int)cb_reservation.SelectedValue;
            pm.PaymentDate = dt_pay.Value;
            pm.PaymentType = cm_mode.Text;
            pm.PaymentTotal = Decimal.Parse(tb_montan.Text);

           
            db.SaveChanges();
            tb_id.Text = tb_montan.Text = "";
            this.paymentTableAdapter.Fill(this.photelDataSet.Payment);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_montan.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cm_mode.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dt_pay.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());

        }
    }
}
