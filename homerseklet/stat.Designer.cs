namespace homerseklet
{
    partial class stat
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
            groupBox1 = new GroupBox();
            rb_varos = new RadioButton();
            rb_havi = new RadioButton();
            rb_napszak = new RadioButton();
            rb_napi = new RadioButton();
            rb_ev = new RadioButton();
            rb_mind = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            l_adatsum = new Label();
            l_atlho = new Label();
            l_sumcsap = new Label();
            l_minho = new Label();
            l_maxcsap = new Label();
            DGV = new DataGridView();
            lekerdez = new DataGridViewTextBoxColumn();
            adatoksz = new DataGridViewTextBoxColumn();
            avgho = new DataGridViewTextBoxColumn();
            osszcsap = new DataGridViewTextBoxColumn();
            legkissebbho = new DataGridViewTextBoxColumn();
            legtobbcsap = new DataGridViewTextBoxColumn();
            btn_ment = new Button();
            btn_kilep = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_varos);
            groupBox1.Controls.Add(rb_havi);
            groupBox1.Controls.Add(rb_napszak);
            groupBox1.Controls.Add(rb_napi);
            groupBox1.Controls.Add(rb_ev);
            groupBox1.Controls.Add(rb_mind);
            groupBox1.Location = new Point(36, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 178);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mi szerint kéri a lekérdezést?";
            // 
            // rb_varos
            // 
            rb_varos.AutoSize = true;
            rb_varos.Location = new Point(9, 148);
            rb_varos.Name = "rb_varos";
            rb_varos.Size = new Size(90, 19);
            rb_varos.TabIndex = 0;
            rb_varos.TabStop = true;
            rb_varos.Text = "Városonként";
            rb_varos.UseVisualStyleBackColor = true;
            rb_varos.CheckedChanged += rb_varos_CheckedChanged;
            // 
            // rb_havi
            // 
            rb_havi.AutoSize = true;
            rb_havi.Location = new Point(9, 71);
            rb_havi.Name = "rb_havi";
            rb_havi.Size = new Size(49, 19);
            rb_havi.TabIndex = 0;
            rb_havi.TabStop = true;
            rb_havi.Text = "Havi";
            rb_havi.UseVisualStyleBackColor = true;
            rb_havi.CheckedChanged += rb_havi_CheckedChanged;
            // 
            // rb_napszak
            // 
            rb_napszak.AutoSize = true;
            rb_napszak.Location = new Point(9, 123);
            rb_napszak.Name = "rb_napszak";
            rb_napszak.Size = new Size(106, 19);
            rb_napszak.TabIndex = 0;
            rb_napszak.TabStop = true;
            rb_napszak.Text = "Napszakonként";
            rb_napszak.UseVisualStyleBackColor = true;
            rb_napszak.CheckedChanged += rb_napszak_CheckedChanged;
            // 
            // rb_napi
            // 
            rb_napi.AutoSize = true;
            rb_napi.Location = new Point(9, 98);
            rb_napi.Name = "rb_napi";
            rb_napi.Size = new Size(50, 19);
            rb_napi.TabIndex = 0;
            rb_napi.TabStop = true;
            rb_napi.Text = "Napi";
            rb_napi.UseVisualStyleBackColor = true;
            rb_napi.CheckedChanged += rb_napi_CheckedChanged;
            // 
            // rb_ev
            // 
            rb_ev.AutoSize = true;
            rb_ev.Location = new Point(9, 46);
            rb_ev.Name = "rb_ev";
            rb_ev.Size = new Size(73, 19);
            rb_ev.TabIndex = 0;
            rb_ev.TabStop = true;
            rb_ev.Text = "Évenként";
            rb_ev.UseVisualStyleBackColor = true;
            rb_ev.CheckedChanged += rb_ev_CheckedChanged;
            // 
            // rb_mind
            // 
            rb_mind.AutoSize = true;
            rb_mind.Location = new Point(9, 21);
            rb_mind.Name = "rb_mind";
            rb_mind.Size = new Size(53, 19);
            rb_mind.TabIndex = 0;
            rb_mind.TabStop = true;
            rb_mind.Text = "Mind";
            rb_mind.UseVisualStyleBackColor = true;
            rb_mind.CheckedChanged += rb_mind_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(377, 51);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Összes adat száma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 78);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Átlag hőmérséklet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 103);
            label3.Name = "label3";
            label3.Size = new Size(161, 15);
            label3.TabIndex = 1;
            label3.Text = "Összes csapadék mennyisége";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 128);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 1;
            label4.Text = "Legkissebb hőmérséklet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(377, 153);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 1;
            label5.Text = "Legtöbb csapadék";
            // 
            // l_adatsum
            // 
            l_adatsum.AutoSize = true;
            l_adatsum.Location = new Point(487, 51);
            l_adatsum.Name = "l_adatsum";
            l_adatsum.Size = new Size(38, 15);
            l_adatsum.TabIndex = 2;
            l_adatsum.Text = "label6";
            // 
            // l_atlho
            // 
            l_atlho.AutoSize = true;
            l_atlho.Location = new Point(486, 78);
            l_atlho.Name = "l_atlho";
            l_atlho.Size = new Size(38, 15);
            l_atlho.TabIndex = 2;
            l_atlho.Text = "label6";
            // 
            // l_sumcsap
            // 
            l_sumcsap.AutoSize = true;
            l_sumcsap.Location = new Point(544, 103);
            l_sumcsap.Name = "l_sumcsap";
            l_sumcsap.Size = new Size(38, 15);
            l_sumcsap.TabIndex = 2;
            l_sumcsap.Text = "label6";
            // 
            // l_minho
            // 
            l_minho.AutoSize = true;
            l_minho.Location = new Point(516, 128);
            l_minho.Name = "l_minho";
            l_minho.Size = new Size(38, 15);
            l_minho.TabIndex = 2;
            l_minho.Text = "label6";
            // 
            // l_maxcsap
            // 
            l_maxcsap.AutoSize = true;
            l_maxcsap.Location = new Point(486, 153);
            l_maxcsap.Name = "l_maxcsap";
            l_maxcsap.Size = new Size(38, 15);
            l_maxcsap.TabIndex = 2;
            l_maxcsap.Text = "label6";
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { lekerdez, adatoksz, avgho, osszcsap, legkissebbho, legtobbcsap });
            DGV.Location = new Point(12, 212);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.Size = new Size(699, 222);
            DGV.TabIndex = 3;
            // 
            // lekerdez
            // 
            lekerdez.HeaderText = "";
            lekerdez.Name = "lekerdez";
            lekerdez.ReadOnly = true;
            // 
            // adatoksz
            // 
            adatoksz.HeaderText = "Adatok száma";
            adatoksz.Name = "adatoksz";
            adatoksz.ReadOnly = true;
            // 
            // avgho
            // 
            avgho.HeaderText = "Átlag hőmérséklet";
            avgho.Name = "avgho";
            avgho.ReadOnly = true;
            // 
            // osszcsap
            // 
            osszcsap.HeaderText = "Összes csapadék mennyisége";
            osszcsap.Name = "osszcsap";
            osszcsap.ReadOnly = true;
            // 
            // legkissebbho
            // 
            legkissebbho.HeaderText = "Legkisebb hőmérséklet";
            legkissebbho.Name = "legkissebbho";
            legkissebbho.ReadOnly = true;
            // 
            // legtobbcsap
            // 
            legtobbcsap.HeaderText = "Legtöbb csapadék";
            legtobbcsap.Name = "legtobbcsap";
            legtobbcsap.ReadOnly = true;
            // 
            // btn_ment
            // 
            btn_ment.Location = new Point(74, 452);
            btn_ment.Name = "btn_ment";
            btn_ment.Size = new Size(205, 81);
            btn_ment.TabIndex = 4;
            btn_ment.Text = "Fájlba mentés";
            btn_ment.UseVisualStyleBackColor = true;
            btn_ment.Click += btn_ment_Click;
            // 
            // btn_kilep
            // 
            btn_kilep.Location = new Point(438, 452);
            btn_kilep.Name = "btn_kilep";
            btn_kilep.Size = new Size(205, 81);
            btn_kilep.TabIndex = 4;
            btn_kilep.Text = "Kilépés";
            btn_kilep.UseVisualStyleBackColor = true;
            btn_kilep.Click += btn_kilep_Click;
            // 
            // stat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 545);
            Controls.Add(btn_kilep);
            Controls.Add(btn_ment);
            Controls.Add(DGV);
            Controls.Add(l_maxcsap);
            Controls.Add(l_minho);
            Controls.Add(l_sumcsap);
            Controls.Add(l_atlho);
            Controls.Add(l_adatsum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "stat";
            Text = "stat";
            Load += stat_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rb_varos;
        private RadioButton rb_havi;
        private RadioButton rb_napszak;
        private RadioButton rb_napi;
        private RadioButton rb_ev;
        private RadioButton rb_mind;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label l_adatsum;
        private Label l_atlho;
        private Label l_sumcsap;
        private Label l_minho;
        private Label l_maxcsap;
        private DataGridView DGV;
        private DataGridViewTextBoxColumn lekerdez;
        private DataGridViewTextBoxColumn adatoksz;
        private DataGridViewTextBoxColumn avgho;
        private DataGridViewTextBoxColumn osszcsap;
        private DataGridViewTextBoxColumn legkissebbho;
        private DataGridViewTextBoxColumn legtobbcsap;
        private Button btn_ment;
        private Button btn_kilep;
    }
}