namespace Hotel
{
    partial class Mails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mailingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photelDataSet = new Hotel.PhotelDataSet();
            this.mailingTableAdapter = new Hotel.PhotelDataSetTableAdapters.mailingTableAdapter();
            this.tableAdapterManager = new Hotel.PhotelDataSetTableAdapters.TableAdapterManager();
            this.mailingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mailingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mailingBindingSource
            // 
            this.mailingBindingSource.DataMember = "mailing";
            this.mailingBindingSource.DataSource = this.photelDataSet;
            // 
            // photelDataSet
            // 
            this.photelDataSet.DataSetName = "PhotelDataSet";
            this.photelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mailingTableAdapter
            // 
            this.mailingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategorieTableAdapter = null;
            this.tableAdapterManager.ChambreTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.EmploiyeTableAdapter = null;
            this.tableAdapterManager.FactureTableAdapter = null;
            this.tableAdapterManager.mailingTableAdapter = this.mailingTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel.PhotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // mailingDataGridView
            // 
            this.mailingDataGridView.AllowUserToAddRows = false;
            this.mailingDataGridView.AllowUserToDeleteRows = false;
            this.mailingDataGridView.AutoGenerateColumns = false;
            this.mailingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mailingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.mailingDataGridView.DataSource = this.mailingBindingSource;
            this.mailingDataGridView.Location = new System.Drawing.Point(-1, 29);
            this.mailingDataGridView.Name = "mailingDataGridView";
            this.mailingDataGridView.ReadOnly = true;
            this.mailingDataGridView.Size = new System.Drawing.Size(800, 421);
            this.mailingDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idMail";
            this.dataGridViewTextBoxColumn1.HeaderText = "idMail";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn2.HeaderText = "Email";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Mails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel.Properties.Resources.photo_1489549132488_d00b7eee80f1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mailingDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mails";
            this.Load += new System.EventHandler(this.Mails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mailingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PhotelDataSet photelDataSet;
        private System.Windows.Forms.BindingSource mailingBindingSource;
        private PhotelDataSetTableAdapters.mailingTableAdapter mailingTableAdapter;
        private PhotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView mailingDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}