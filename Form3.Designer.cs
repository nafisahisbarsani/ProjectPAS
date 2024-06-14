namespace ProjectPAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNamaObat = new TextBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            txtKodeObat = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtStok = new TextBox();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnCreate = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(289, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(365, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 24);
            label1.TabIndex = 1;
            label1.Text = "Pharma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSeaGreen;
            label2.Location = new Point(434, 32);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 2;
            label2.Text = "Care";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(27, 195);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 3;
            label3.Text = "Nama Obat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(107, 191);
            label4.Name = "label4";
            label4.Size = new Size(12, 18);
            label4.TabIndex = 4;
            label4.Text = ":";
            // 
            // txtNamaObat
            // 
            txtNamaObat.BackColor = Color.White;
            txtNamaObat.Location = new Point(125, 190);
            txtNamaObat.Name = "txtNamaObat";
            txtNamaObat.Size = new Size(174, 27);
            txtNamaObat.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(28, 134);
            label5.Name = "label5";
            label5.Size = new Size(73, 18);
            label5.TabIndex = 7;
            label5.Text = "Kode Obat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(107, 134);
            label6.Name = "label6";
            label6.Size = new Size(12, 18);
            label6.TabIndex = 8;
            label6.Text = ":";
            // 
            // txtKodeObat
            // 
            txtKodeObat.BackColor = Color.White;
            txtKodeObat.Location = new Point(125, 129);
            txtKodeObat.Name = "txtKodeObat";
            txtKodeObat.Size = new Size(174, 27);
            txtKodeObat.TabIndex = 9;
            txtKodeObat.KeyPress += textBox2_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(28, 251);
            label7.Name = "label7";
            label7.Size = new Size(35, 18);
            label7.TabIndex = 10;
            label7.Text = "Stok";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(107, 251);
            label8.Name = "label8";
            label8.Size = new Size(12, 18);
            label8.TabIndex = 11;
            label8.Text = ":";
            // 
            // txtStok
            // 
            txtStok.BackColor = Color.White;
            txtStok.Location = new Point(125, 242);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(75, 27);
            txtStok.TabIndex = 12;
            txtStok.KeyPress += txtStok_KeyPress;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Navy;
            btnUpdate.Location = new Point(146, 477);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Navy;
            btnClear.Location = new Point(546, 477);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 15;
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
            btnDelete.Location = new Point(674, 477);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(518, 129);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(270, 27);
            txtSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Navy;
            btnSearch.Location = new Point(365, 129);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCreate
            // 
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.Navy;
            btnCreate.Location = new Point(10, 477);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 20;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(361, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(427, 211);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 530);
            Controls.Add(dataGridView1);
            Controls.Add(btnCreate);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(txtStok);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtKodeObat);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(txtNamaObat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNamaObat;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private TextBox txtKodeObat;
        private Label label7;
        private Label label8;
        private TextBox txtStok;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnCreate;
        private DataGridView dataGridView1;
    }
}