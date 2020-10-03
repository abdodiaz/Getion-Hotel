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
namespace Hotel
{
    public partial class Client1 : Form
    {
        PhotelEntities db = new PhotelEntities();

        public Client1()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'photelDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            // TODO: cette ligne de code charge les données dans la table 'photelDataSet.Reservation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            // TODO: cette ligne de code charge les données dans la table 'photelDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.photelDataSet.Client);
            // TODO: cette ligne de code charge les données dans la table 'tSDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            PhotelEntities db = new PhotelEntities();
       
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
           // textBox1.Enabled = false;
           
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

           
            Client cli = new Client();
            cli.CodeClient = int.Parse(textBox1.Text);
            cli.Nom = textBox2.Text;
            cli.Prènom = textBox3.Text;
            cli.Civillité = comboBox1.Text;
            cli.CIN = textBox4.Text;
            cli.Pays = textBox6.Text;
            cli.Ville = textBox7.Text;
            cli.Email = textBox8.Text;
            cli.Telephon = textBox9.Text;
            db.Client.Add(cli);
            db.SaveChanges();
            this.clientTableAdapter.Fill(this.photelDataSet.Client);
                vider();
            }
            catch (Exception)
            {

                MessageBox.Show("verifier les informations!");
            }
        }

        private void vider()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
            textBox2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("selectioner un client");
            }
            else
            {
                bool cond = MessageBox.Show("", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK;
                if (cond)
                {
                    try
                    {
                        int i = int.Parse(textBox1.Text.Trim());
                        Client cli = db.Client.FirstOrDefault(x => x.CodeClient == i);
                        db.Client.Remove(cli);
                        db.SaveChanges();
                        MessageBox.Show("le client " + i.ToString() + " est supprimer");
                        this.clientTableAdapter.Fill(this.photelDataSet.Client);
                        vider();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("sel");
                    }
                }
            }
           
               
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
    
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
      
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.photelDataSet);

        }

        private void clientBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.photelDataSet);

        }

        private void clientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            textBox1.Text = clientDataGridView.Rows[clientDataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            int i = int.Parse(textBox1.Text.Trim());
            Client cli = db.Client.FirstOrDefault(x => x.CodeClient == i);
             textBox2.Text=cli.Nom;
             textBox3.Text=cli.Prènom ;
            comboBox1.Text= cli.Civillité ;
            textBox4.Text=cli.CIN  ;
            textBox6.Text =cli.Pays ;
           textBox7.Text  =cli.Ville ;
            textBox8.Text= cli.Email ;
            textBox9.Text =cli.Telephon ;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text.Trim());
            Client cli = db.Client.FirstOrDefault(x => x.CodeClient == i);
            cli.Nom = textBox2.Text;
            cli.Prènom = textBox3.Text;
            cli.Civillité = comboBox1.Text;
            cli.CIN = textBox4.Text;
            cli.Pays = textBox6.Text;
            cli.Ville = textBox7.Text;
            cli.Email = textBox8.Text;
            cli.Telephon = textBox9.Text;
            db.SaveChanges();
            this.clientTableAdapter.Fill(this.photelDataSet.Client);
            vider();

        }
    }
}
