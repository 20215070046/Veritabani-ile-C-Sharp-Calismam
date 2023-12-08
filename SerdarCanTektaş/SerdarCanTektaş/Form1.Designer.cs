namespace SerdarCanTektaş
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rentcarDataSet = new SerdarCanTektaş.rentcarDataSet();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter = new SerdarCanTektaş.rentcarDataSetTableAdapters.musteriTableAdapter();
            this.rentcarDataSet1 = new SerdarCanTektaş.rentcarDataSet1();
            this.adminpanelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminpanelTableAdapter = new SerdarCanTektaş.rentcarDataSet1TableAdapters.adminpanelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminpanelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 30);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 60);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(338, 30);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(469, 16);
            this.dataGridView1.TabIndex = 9;
            // 
            // rentcarDataSet
            // 
            this.rentcarDataSet.DataSetName = "rentcarDataSet";
            this.rentcarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "musteri";
            this.musteriBindingSource.DataSource = this.rentcarDataSet;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // rentcarDataSet1
            // 
            this.rentcarDataSet1.DataSetName = "rentcarDataSet1";
            this.rentcarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminpanelBindingSource
            // 
            this.adminpanelBindingSource.DataMember = "adminpanel";
            this.adminpanelBindingSource.DataSource = this.rentcarDataSet1;
            // 
            // adminpanelTableAdapter
            // 
            this.adminpanelTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(470, 153);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentcarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminpanelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private rentcarDataSet rentcarDataSet;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private rentcarDataSetTableAdapters.musteriTableAdapter musteriTableAdapter;
        private rentcarDataSet1 rentcarDataSet1;
        private System.Windows.Forms.BindingSource adminpanelBindingSource;
        private rentcarDataSet1TableAdapters.adminpanelTableAdapter adminpanelTableAdapter;
    }
}

