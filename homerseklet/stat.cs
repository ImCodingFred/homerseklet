using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace homerseklet
{
    public partial class stat : Form
    {
        public stat()
        {
            InitializeComponent();
        }

        private void stat_Load(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item.Name.StartsWith("l_"))
                {
                    item.Text = null;
                }
            }
            rb_mind.Checked = true;
            abload();
        }

        private void abload()
        {
            DGV.Rows.Clear();
            if (rb_mind.Checked)
            {
                string querry = "SELECT Count(*),avg(ertek),sum(csapadek),min(ertek),max(csapadek) FROM homerseklet";
                adatbazis db = new adatbazis(querry);
                while (db.Dr.Read())
                {
                    DGV.Rows.Add("", db.Dr[0], db.Dr[1], db.Dr[2], db.Dr[3], db.Dr[4]);
                }
            }
            if (rb_ev.Checked)
            {
                string querry = "SELECT Year(datum),Count(Year(datum)),avg(ertek),sum(csapadek),min(ertek),max(csapadek) FROM homerseklet group by Year(datum)";
                adatbazis db = new adatbazis(querry);
                while (db.Dr.Read())
                {
                    DGV.Rows.Add(db.Dr[0], db.Dr[1], db.Dr[2], db.Dr[3], db.Dr[4], db.Dr[5]);
                }
            }
            if (rb_havi.Checked)
            {
                string querry = "SELECT Year(datum), Month(datum),Count(Year(datum)),avg(ertek),sum(csapadek),min(ertek),max(csapadek) FROM homerseklet group by Month(datum), Year(datum)";
                adatbazis db = new adatbazis(querry);
                while (db.Dr.Read())
                {
                    DGV.Rows.Add($"{db.Dr[0]}.{db.Dr[1]}", db.Dr[2], db.Dr[3], db.Dr[4], db.Dr[5], db.Dr[6]);
                }
            }
            if (rb_napi.Checked)
            {
                string querry = "SELECT Year(datum), Month(datum),Day(datum),Count(Year(datum)),avg(ertek),sum(csapadek),min(ertek),max(csapadek) FROM homerseklet group by Day(datum),Month(datum), Year(datum)";
                adatbazis db = new adatbazis(querry);
                while (db.Dr.Read())
                {
                    DGV.Rows.Add($"{db.Dr[0]}.{db.Dr[1]}.{db.Dr[2]}", db.Dr[3], db.Dr[4], db.Dr[5], db.Dr[6], db.Dr[7]);
                }
            }
            if (rb_napszak.Checked)
            {
                string querry = "SELECT napszak,Count(napszak),avg(ertek),sum(csapadek),min(ertek),max(csapadek) FROM homerseklet group by napszak";
                adatbazis db = new adatbazis(querry);
                while (db.Dr.Read())
                {
                    DGV.Rows.Add($"{db.Dr[0]}", db.Dr[1], db.Dr[2], db.Dr[3], db.Dr[4], db.Dr[5]);
                }
            }
            if (rb_varos.Checked)
            {
                string querry = "SELECT varos,Count(napszak),avg(ertek),sum(csapadek),min(ertek),max(csapadek) FROM homerseklet group by varos";
                adatbazis db = new adatbazis(querry);
                while (db.Dr.Read())
                {
                    DGV.Rows.Add($"{db.Dr[0]}", db.Dr[1], db.Dr[2], db.Dr[3], db.Dr[4], db.Dr[5]);
                }
            }
            string lekerdez = "SELECT Count(*),avg(ertek),sum(csapadek),min(ertek),max(csapadek) FROM homerseklet";
            adatbazis ab = new adatbazis(lekerdez);
            while (ab.Dr.Read())
            {
                l_adatsum.Text = ab.Dr[0].ToString();
                l_atlho.Text = ab.Dr[1].ToString();
                l_sumcsap.Text = ab.Dr[2].ToString();
                l_minho.Text = ab.Dr[3].ToString();
                l_maxcsap.Text = ab.Dr[4].ToString();
            }
        }

        private void rb_mind_CheckedChanged(object sender, EventArgs e)
        {
            abload();
        }

        private void rb_ev_CheckedChanged(object sender, EventArgs e)
        {
            abload();

        }

        private void rb_havi_CheckedChanged(object sender, EventArgs e)
        {
            abload();

        }

        private void rb_napi_CheckedChanged(object sender, EventArgs e)
        {
            abload();

        }

        private void rb_napszak_CheckedChanged(object sender, EventArgs e)
        {
            abload();

        }

        private void rb_varos_CheckedChanged(object sender, EventArgs e)
        {
            abload();

        }

        private void btn_ment_Click(object sender, EventArgs e)
        {
            string filename = "";
            foreach (Control item in groupBox1.Controls)
            {
                if (item is RadioButton)
                {
                    if (((RadioButton)item).Checked)
                    {
                        filename = $"{item.Name.Remove(0, 3)}_{DateTime.Now.ToString("yyyyMMddHHmmss")}.txt";
                    }
                }
            }
            var sw = new StreamWriter(filename);
            sw.WriteLine($"{DGV.Columns[0].HeaderText};{DGV.Columns[1].HeaderText};{DGV.Columns[2].HeaderText};{DGV.Columns[3].HeaderText};{DGV.Columns[4].HeaderText};{DGV.Columns[5].HeaderText};");
            foreach (DataGridViewRow item in DGV.Rows)
            {
                sw.WriteLine($"{item.Cells[0].Value.ToString()},{item.Cells[1].Value.ToString()},{item.Cells[2].Value.ToString()},{item.Cells[3].Value.ToString()},{item.Cells[4].Value.ToString()},{item.Cells[5].Value.ToString()};");
            }
            sw.Close();
        }

        private void btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
