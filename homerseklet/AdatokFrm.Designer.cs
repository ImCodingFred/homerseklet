namespace homerseklet
{
    partial class AdatokFrm
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
            DGV = new DataGridView();
            azon = new DataGridViewTextBoxColumn();
            varos = new DataGridViewTextBoxColumn();
            datum = new DataGridViewTextBoxColumn();
            napszak = new DataGridViewTextBoxColumn();
            ertek = new DataGridViewTextBoxColumn();
            csapadek = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            rb_mod = new RadioButton();
            rb_uj = new RadioButton();
            label1 = new Label();
            tb_azon = new TextBox();
            l1 = new Label();
            tb_varos = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tb_mho = new TextBox();
            label6 = new Label();
            tb_csap = new TextBox();
            cb_napszak = new ComboBox();
            dtp_datum = new DateTimePicker();
            btn_ment = new Button();
            btn_elvetés = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { azon, varos, datum, napszak, ertek, csapadek });
            DGV.Location = new Point(12, 12);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.Size = new Size(627, 426);
            DGV.TabIndex = 0;
            DGV.CellClick += DGV_CellClick;
            // 
            // azon
            // 
            azon.HeaderText = "Azonosító";
            azon.Name = "azon";
            azon.ReadOnly = true;
            // 
            // varos
            // 
            varos.HeaderText = "Város";
            varos.Name = "varos";
            varos.ReadOnly = true;
            // 
            // datum
            // 
            datum.HeaderText = "Dátum";
            datum.Name = "datum";
            datum.ReadOnly = true;
            // 
            // napszak
            // 
            napszak.HeaderText = "Napszak";
            napszak.Name = "napszak";
            napszak.ReadOnly = true;
            // 
            // ertek
            // 
            ertek.HeaderText = "Mért hőmérséklet";
            ertek.Name = "ertek";
            ertek.ReadOnly = true;
            // 
            // csapadek
            // 
            csapadek.HeaderText = "Mért csapadék";
            csapadek.Name = "csapadek";
            csapadek.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_mod);
            groupBox1.Controls.Add(rb_uj);
            groupBox1.Location = new Point(663, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "müveletek";
            // 
            // rb_mod
            // 
            rb_mod.AutoSize = true;
            rb_mod.Location = new Point(16, 56);
            rb_mod.Name = "rb_mod";
            rb_mod.Size = new Size(80, 19);
            rb_mod.TabIndex = 1;
            rb_mod.Text = "Módosítás";
            rb_mod.UseVisualStyleBackColor = true;
            rb_mod.CheckedChanged += rb_mod_CheckedChanged;
            // 
            // rb_uj
            // 
            rb_uj.AutoSize = true;
            rb_uj.Checked = true;
            rb_uj.Location = new Point(15, 27);
            rb_uj.Name = "rb_uj";
            rb_uj.Size = new Size(83, 19);
            rb_uj.TabIndex = 0;
            rb_uj.TabStop = true;
            rb_uj.Text = "Új felvétele";
            rb_uj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Azonosító";
            // 
            // tb_azon
            // 
            tb_azon.Location = new Point(71, 19);
            tb_azon.Name = "tb_azon";
            tb_azon.Size = new Size(100, 23);
            tb_azon.TabIndex = 3;
            tb_azon.TextChanged += tb_azon_TextChanged;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Location = new Point(6, 51);
            l1.Name = "l1";
            l1.Size = new Size(35, 15);
            l1.TabIndex = 2;
            l1.Text = "Város";
            l1.Click += label2_Click;
            // 
            // tb_varos
            // 
            tb_varos.Location = new Point(50, 47);
            tb_varos.Name = "tb_varos";
            tb_varos.Size = new Size(100, 23);
            tb_varos.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 87);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Napszak";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 118);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 2;
            label4.Text = "Dátum";
            label4.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 145);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 2;
            label5.Text = "Mért hőmérséklet";
            label5.Click += label2_Click;
            // 
            // tb_mho
            // 
            tb_mho.Location = new Point(112, 142);
            tb_mho.Name = "tb_mho";
            tb_mho.Size = new Size(100, 23);
            tb_mho.TabIndex = 3;
            tb_mho.TextChanged += tb_mho_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 174);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 2;
            label6.Text = "Mért csapadék";
            label6.Click += label2_Click;
            // 
            // tb_csap
            // 
            tb_csap.Location = new Point(96, 171);
            tb_csap.Name = "tb_csap";
            tb_csap.Size = new Size(100, 23);
            tb_csap.TabIndex = 3;
            tb_csap.TextChanged += tb_csap_TextChanged;
            // 
            // cb_napszak
            // 
            cb_napszak.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_napszak.FormattingEnabled = true;
            cb_napszak.Items.AddRange(new object[] { "reggel", "délelőtt", "délután", "este" });
            cb_napszak.Location = new Point(63, 84);
            cb_napszak.Name = "cb_napszak";
            cb_napszak.Size = new Size(121, 23);
            cb_napszak.TabIndex = 4;
            // 
            // dtp_datum
            // 
            dtp_datum.CustomFormat = "yyyy-MM-dd";
            dtp_datum.Format = DateTimePickerFormat.Custom;
            dtp_datum.Location = new Point(50, 113);
            dtp_datum.Name = "dtp_datum";
            dtp_datum.Size = new Size(111, 23);
            dtp_datum.TabIndex = 5;
            // 
            // btn_ment
            // 
            btn_ment.Location = new Point(672, 332);
            btn_ment.Name = "btn_ment";
            btn_ment.Size = new Size(104, 106);
            btn_ment.TabIndex = 6;
            btn_ment.Text = "Mentés";
            btn_ment.UseVisualStyleBackColor = true;
            btn_ment.Click += btn_ment_Click;
            // 
            // btn_elvetés
            // 
            btn_elvetés.Location = new Point(800, 332);
            btn_elvetés.Name = "btn_elvetés";
            btn_elvetés.Size = new Size(109, 106);
            btn_elvetés.TabIndex = 7;
            btn_elvetés.Text = "Elvetés";
            btn_elvetés.UseVisualStyleBackColor = true;
            btn_elvetés.Click += btn_elvetés_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(cb_napszak);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tb_azon);
            panel1.Controls.Add(dtp_datum);
            panel1.Controls.Add(l1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tb_csap);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tb_mho);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tb_varos);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(663, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 214);
            panel1.TabIndex = 8;
            // 
            // AdatokFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 450);
            Controls.Add(panel1);
            Controls.Add(btn_elvetés);
            Controls.Add(btn_ment);
            Controls.Add(groupBox1);
            Controls.Add(DGV);
            Name = "AdatokFrm";
            Text = "AdatokFrm";
            Load += AdatokFrm_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn azon;
        private DataGridViewTextBoxColumn varos;
        private DataGridViewTextBoxColumn datum;
        private DataGridViewTextBoxColumn napszak;
        private DataGridViewTextBoxColumn ertek;
        private DataGridViewTextBoxColumn csapadek;
        private RadioButton rb_mod;
        private RadioButton rb_uj;
        private Label label1;
        private TextBox tb_azon;
        private Label l1;
        private TextBox tb_varos;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_mho;
        private Label label6;
        private TextBox tb_csap;
        private ComboBox cb_napszak;
        private DateTimePicker dtp_datum;
        private Button btn_ment;
        private Button btn_elvetés;
        private Panel panel1;
    }
}