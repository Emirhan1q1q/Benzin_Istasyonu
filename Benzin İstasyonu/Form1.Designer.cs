namespace Benzin_İstasyonu
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pompa_TakipDataSet1 = new Benzin_İstasyonu.Pompa_TakipDataSet1();
            this.yakitStokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakit_StokTableAdapter = new Benzin_İstasyonu.Pompa_TakipDataSet1TableAdapters.yakit_StokTableAdapter();
            this.yakıtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mİktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_yakitisim = new System.Windows.Forms.TextBox();
            this.textBox_yakitmiktar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pompa_TakipDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitStokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(680, 244);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(12, 12);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yakıtDataGridViewTextBoxColumn,
            this.mİktarDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.yakitStokBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(590, 115);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(478, 234);
            this.dataGridView2.TabIndex = 1;
            // 
            // pompa_TakipDataSet1
            // 
            this.pompa_TakipDataSet1.DataSetName = "Pompa_TakipDataSet1";
            this.pompa_TakipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yakitStokBindingSource
            // 
            this.yakitStokBindingSource.DataMember = "yakit_Stok";
            this.yakitStokBindingSource.DataSource = this.pompa_TakipDataSet1;
            // 
            // yakit_StokTableAdapter
            // 
            this.yakit_StokTableAdapter.ClearBeforeFill = true;
            // 
            // yakıtDataGridViewTextBoxColumn
            // 
            this.yakıtDataGridViewTextBoxColumn.DataPropertyName = "Yakıt";
            this.yakıtDataGridViewTextBoxColumn.HeaderText = "Yakıt";
            this.yakıtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yakıtDataGridViewTextBoxColumn.Name = "yakıtDataGridViewTextBoxColumn";
            this.yakıtDataGridViewTextBoxColumn.Width = 125;
            // 
            // mİktarDataGridViewTextBoxColumn
            // 
            this.mİktarDataGridViewTextBoxColumn.DataPropertyName = "Mİktar";
            this.mİktarDataGridViewTextBoxColumn.HeaderText = "Mİktar";
            this.mİktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mİktarDataGridViewTextBoxColumn.Name = "mİktarDataGridViewTextBoxColumn";
            this.mİktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // textBox_yakitisim
            // 
            this.textBox_yakitisim.Location = new System.Drawing.Point(249, 164);
            this.textBox_yakitisim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_yakitisim.Name = "textBox_yakitisim";
            this.textBox_yakitisim.Size = new System.Drawing.Size(148, 30);
            this.textBox_yakitisim.TabIndex = 2;
            // 
            // textBox_yakitmiktar
            // 
            this.textBox_yakitmiktar.Location = new System.Drawing.Point(249, 222);
            this.textBox_yakitmiktar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_yakitmiktar.Name = "textBox_yakitmiktar";
            this.textBox_yakitmiktar.Size = new System.Drawing.Size(148, 30);
            this.textBox_yakitmiktar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yakıt Miktarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yakıt İsmi";
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(138, 367);
            this.button_ekle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(88, 42);
            this.button_ekle.TabIndex = 6;
            this.button_ekle.Text = "Ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(272, 367);
            this.button_sil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(88, 42);
            this.button_sil.TabIndex = 7;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            // 
            // button_guncelle
            // 
            this.button_guncelle.Location = new System.Drawing.Point(399, 367);
            this.button_guncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(103, 42);
            this.button_guncelle.TabIndex = 8;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_yakitmiktar);
            this.Controls.Add(this.textBox_yakitisim);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pompa_TakipDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitStokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Pompa_TakipDataSet1 pompa_TakipDataSet1;
        private System.Windows.Forms.BindingSource yakitStokBindingSource;
        private Pompa_TakipDataSet1TableAdapters.yakit_StokTableAdapter yakit_StokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakıtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mİktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_yakitisim;
        private System.Windows.Forms.TextBox textBox_yakitmiktar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_guncelle;
    }
}

