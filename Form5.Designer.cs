namespace ProjectPAS
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            txtNamaProduk = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            txtKodeStruk = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtHarga = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txtTotal = new TextBox();
            dataGridView1 = new DataGridView();
            btnCreate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnPrint = new Button();
            btnPay = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnUpdate = new Button();
            btnShow = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(442, 32);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 5;
            label2.Text = "Care";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(373, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 24);
            label1.TabIndex = 4;
            label1.Text = "Pharma";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(297, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 62);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(56, 173);
            label3.Name = "label3";
            label3.Size = new Size(91, 18);
            label3.TabIndex = 29;
            label3.Text = "Nama Produk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(153, 173);
            label4.Name = "label4";
            label4.Size = new Size(12, 18);
            label4.TabIndex = 30;
            label4.Text = ":";
            // 
            // txtNamaProduk
            // 
            txtNamaProduk.Location = new Point(171, 168);
            txtNamaProduk.Name = "txtNamaProduk";
            txtNamaProduk.Size = new Size(125, 27);
            txtNamaProduk.TabIndex = 31;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numericUpDown1.ForeColor = Color.Navy;
            numericUpDown1.Location = new Point(439, 130);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 26);
            numericUpDown1.TabIndex = 32;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(421, 134);
            label5.Name = "label5";
            label5.Size = new Size(12, 18);
            label5.TabIndex = 33;
            label5.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(324, 134);
            label6.Name = "label6";
            label6.Size = new Size(52, 18);
            label6.TabIndex = 34;
            label6.Text = "Jumlah";
            // 
            // txtKodeStruk
            // 
            txtKodeStruk.Location = new Point(171, 130);
            txtKodeStruk.Name = "txtKodeStruk";
            txtKodeStruk.Size = new Size(125, 27);
            txtKodeStruk.TabIndex = 37;
            txtKodeStruk.KeyPress += txtNoStruk_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(153, 135);
            label7.Name = "label7";
            label7.Size = new Size(12, 18);
            label7.TabIndex = 36;
            label7.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(56, 135);
            label8.Name = "label8";
            label8.Size = new Size(65, 18);
            label8.TabIndex = 35;
            label8.Text = "No. Struk";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(324, 177);
            label9.Name = "label9";
            label9.Size = new Size(43, 18);
            label9.TabIndex = 38;
            label9.Text = "Harga";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(421, 177);
            label10.Name = "label10";
            label10.Size = new Size(12, 18);
            label10.TabIndex = 39;
            label10.Text = ":";
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(442, 177);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(125, 27);
            txtHarga.TabIndex = 40;
            txtHarga.KeyPress += txtHarga_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(587, 130);
            label11.Name = "label11";
            label11.Size = new Size(38, 18);
            label11.TabIndex = 41;
            label11.Text = "Total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Navy;
            label12.Location = new Point(631, 130);
            label12.Name = "label12";
            label12.Size = new Size(12, 18);
            label12.TabIndex = 42;
            label12.Text = ":";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(663, 129);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 43;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(87, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(681, 188);
            dataGridView1.TabIndex = 44;
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnCreate
            // 
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.Navy;
            btnCreate.Location = new Point(131, 439);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 45;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Navy;
            btnClear.Location = new Point(587, 439);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 47;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Navy;
            btnDelete.Location = new Point(694, 439);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 48;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPrint
            // 
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Popup;
            btnPrint.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.Navy;
            btnPrint.Location = new Point(473, 439);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 49;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click_1;
            // 
            // btnPay
            // 
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Popup;
            btnPay.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.ForeColor = Color.Navy;
            btnPay.Location = new Point(12, 439);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(94, 29);
            btnPay.TabIndex = 50;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Navy;
            btnUpdate.Location = new Point(249, 439);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 51;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnShow
            // 
            btnShow.Cursor = Cursors.Hand;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatStyle = FlatStyle.Popup;
            btnShow.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.ForeColor = Color.Navy;
            btnShow.Location = new Point(363, 439);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 52;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 480);
            Controls.Add(btnShow);
            Controls.Add(btnUpdate);
            Controls.Add(btnPay);
            Controls.Add(btnPrint);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnCreate);
            Controls.Add(dataGridView1);
            Controls.Add(txtTotal);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtHarga);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtKodeStruk);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numericUpDown1);
            Controls.Add(txtNamaProduk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private TextBox txtNamaProduk;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Label label6;
        private TextBox txtKodeStruk;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtHarga;
        private Label label11;
        private Label label12;
        private TextBox txtTotal;
        private DataGridView dataGridView1;
        private Button btnCreate;
        private Button btnClear;
        private Button btnDelete;
        private Button btnPrint;
        private Button btnPay;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnUpdate;
        private Button btnShow;
    }
}