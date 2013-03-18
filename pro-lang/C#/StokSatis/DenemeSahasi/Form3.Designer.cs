namespace DenemeSahasi
{
    partial class Form3
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
            this.mengiDataSet = new DenemeSahasi.mengiDataSet();
            this.kayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kayitTableAdapter = new DenemeSahasi.mengiDataSetTableAdapters.KayitTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mengiDataSet1 = new DenemeSahasi.mengiDataSet1();
            this.kayitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kayitTableAdapter1 = new DenemeSahasi.mengiDataSet1TableAdapters.KayitTableAdapter();
            this.ürünKatogorisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünFiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taksitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aylikTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAlimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mengiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mengiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(358, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mengiDataSet
            // 
            this.mengiDataSet.DataSetName = "mengiDataSet";
            this.mengiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayitBindingSource
            // 
            this.kayitBindingSource.DataMember = "Kayit";
            this.kayitBindingSource.DataSource = this.mengiDataSet;
            // 
            // kayitTableAdapter
            // 
            this.kayitTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ürünKatogorisiDataGridViewTextBoxColumn,
            this.ürünAdiDataGridViewTextBoxColumn,
            this.ürünFiyatiDataGridViewTextBoxColumn,
            this.taksitDataGridViewTextBoxColumn,
            this.ürünAdetiDataGridViewTextBoxColumn,
            this.aylikTutarDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn,
            this.ürünAlimTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kayitBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // mengiDataSet1
            // 
            this.mengiDataSet1.DataSetName = "mengiDataSet1";
            this.mengiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayitBindingSource1
            // 
            this.kayitBindingSource1.DataMember = "Kayit";
            this.kayitBindingSource1.DataSource = this.mengiDataSet1;
            // 
            // kayitTableAdapter1
            // 
            this.kayitTableAdapter1.ClearBeforeFill = true;
            // 
            // ürünKatogorisiDataGridViewTextBoxColumn
            // 
            this.ürünKatogorisiDataGridViewTextBoxColumn.DataPropertyName = "ÜrünKatogorisi";
            this.ürünKatogorisiDataGridViewTextBoxColumn.HeaderText = "ÜrünKatogorisi";
            this.ürünKatogorisiDataGridViewTextBoxColumn.Name = "ürünKatogorisiDataGridViewTextBoxColumn";
            // 
            // ürünAdiDataGridViewTextBoxColumn
            // 
            this.ürünAdiDataGridViewTextBoxColumn.DataPropertyName = "ÜrünAdi";
            this.ürünAdiDataGridViewTextBoxColumn.HeaderText = "ÜrünAdi";
            this.ürünAdiDataGridViewTextBoxColumn.Name = "ürünAdiDataGridViewTextBoxColumn";
            // 
            // ürünFiyatiDataGridViewTextBoxColumn
            // 
            this.ürünFiyatiDataGridViewTextBoxColumn.DataPropertyName = "ÜrünFiyati";
            this.ürünFiyatiDataGridViewTextBoxColumn.HeaderText = "ÜrünFiyati";
            this.ürünFiyatiDataGridViewTextBoxColumn.Name = "ürünFiyatiDataGridViewTextBoxColumn";
            // 
            // taksitDataGridViewTextBoxColumn
            // 
            this.taksitDataGridViewTextBoxColumn.DataPropertyName = "Taksit";
            this.taksitDataGridViewTextBoxColumn.HeaderText = "Taksit";
            this.taksitDataGridViewTextBoxColumn.Name = "taksitDataGridViewTextBoxColumn";
            // 
            // ürünAdetiDataGridViewTextBoxColumn
            // 
            this.ürünAdetiDataGridViewTextBoxColumn.DataPropertyName = "ÜrünAdeti";
            this.ürünAdetiDataGridViewTextBoxColumn.HeaderText = "ÜrünAdeti";
            this.ürünAdetiDataGridViewTextBoxColumn.Name = "ürünAdetiDataGridViewTextBoxColumn";
            // 
            // aylikTutarDataGridViewTextBoxColumn
            // 
            this.aylikTutarDataGridViewTextBoxColumn.DataPropertyName = "AylikTutar";
            this.aylikTutarDataGridViewTextBoxColumn.HeaderText = "AylikTutar";
            this.aylikTutarDataGridViewTextBoxColumn.Name = "aylikTutarDataGridViewTextBoxColumn";
            // 
            // toplamTutarDataGridViewTextBoxColumn
            // 
            this.toplamTutarDataGridViewTextBoxColumn.DataPropertyName = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.HeaderText = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.Name = "toplamTutarDataGridViewTextBoxColumn";
            // 
            // ürünAlimTarihiDataGridViewTextBoxColumn
            // 
            this.ürünAlimTarihiDataGridViewTextBoxColumn.DataPropertyName = "ÜrünAlimTarihi";
            this.ürünAlimTarihiDataGridViewTextBoxColumn.HeaderText = "ÜrünAlimTarihi";
            this.ürünAlimTarihiDataGridViewTextBoxColumn.Name = "ürünAlimTarihiDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 286);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mengiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mengiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayitBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private mengiDataSet mengiDataSet;
        private System.Windows.Forms.BindingSource kayitBindingSource;
        private mengiDataSetTableAdapters.KayitTableAdapter kayitTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mengiDataSet1 mengiDataSet1;
        private System.Windows.Forms.BindingSource kayitBindingSource1;
        private mengiDataSet1TableAdapters.KayitTableAdapter kayitTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünKatogorisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünFiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taksitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aylikTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAlimTarihiDataGridViewTextBoxColumn;
    }
}