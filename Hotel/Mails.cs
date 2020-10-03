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
    public partial class Mails : Form
    {
        public Mails()
        {
            InitializeComponent();
        }

        private void mailingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mailingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.photelDataSet);

        }

        private void Mails_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'photelDataSet.mailing'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.mailingTableAdapter.Fill(this.photelDataSet.mailing);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gestion1 form = new Gestion1();
            form.Show();
            this.Close();
        }
    }
}
