using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homerseklet
{
    public partial class AdatokFrm : Form
    {
        public AdatokFrm()
        {
            InitializeComponent();
        }

        private void AdatokFrm_Load(object sender, EventArgs e)
        {
            abload();
        }

        private void abload()
        {
            DGV.Rows.Clear();
            string querry = "SELECT * FROM homerseklet";
            adatbazis db = new adatbazis(querry);
            DGV.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
            while (db.Dr.Read())
            {
                DGV.Rows.Add(db.Dr["azon"], db.Dr["varos"], db.Dr["datum"], db.Dr["napszak"], db.Dr["ertek"], db.Dr["csapadek"]);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rb_mod_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_mod.Checked)
            {
                tb_azon.Enabled = false;
                foreach (Control item in panel1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = null;
                    }
                }
                cb_napszak.SelectedIndex = 0;
            }
            else
            {
                tb_azon.Enabled = true;
                foreach (Control item in panel1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = null;
                    }
                }
                cb_napszak.SelectedIndex = 0;
            }
        }

        private void btn_ment_Click(object sender, EventArgs e)
        {
            if (tb_azon.TextLength == 0)
            {
                MessageBox.Show("töltse ki a mezőt!");
                tb_azon.Focus();
            }
            else if (tb_varos.TextLength == 0)
            {
                MessageBox.Show("töltse ki a mezőt!");
                tb_varos.Focus();
            }
            else if (tb_mho.TextLength == 0)
            {
                MessageBox.Show("töltse ki a mezőt!");
                tb_mho.Focus();
            }
            else if (tb_csap.TextLength == 0)
            {
                MessageBox.Show("töltse ki a mezőt!");
                tb_csap.Focus();
            }
            else
            {
                if (rb_uj.Checked)
                {
                    try
                    {
                        string querry = "INSERT INTO homerseklet(azon,varos,napszak,datum,ertek,csapadek) " +
                            $"Values('{tb_azon.Text}','{tb_varos.Text}','{cb_napszak.SelectedItem.ToString()}','{dtp_datum.Value.ToString("yyyy-MM-dd")}','{tb_mho.Text.Replace(',', '.')}','{tb_csap.Text}')";
                        adatbazis db = new adatbazis(querry);
                        abload();
                    }
                    catch
                    {
                        MessageBox.Show("hibás művelet!");
                    }
                }
                else
                {
                    abload();
                    try
                    {
                        string querry = $"UPDATE homerseklet SET varos = '{tb_varos.Text}', napszak = '{cb_napszak.SelectedItem.ToString()}', datum = '{dtp_datum.Value.ToString("yyyy-MM-dd")}', ertek = '{tb_mho.Text.Replace(',', '.')}', csapadek = '{tb_csap.Text}' WHERE azon = '{tb_azon.Text}'";
                        adatbazis db = new adatbazis(querry);
                    }
                    catch
                    {
                        MessageBox.Show("hibás művelet!");
                    }
                }
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rb_mod.Checked)
            {
                tb_azon.Text = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_varos.Text = DGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                cb_napszak.SelectedItem = DGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtp_datum.Text = DGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_mho.Text = DGV.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_csap.Text = DGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btn_elvetés_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = null;
                }
            }
            cb_napszak.SelectedIndex = 0;
        }

        private void tb_azon_TextChanged(object sender, EventArgs e)
        {
            if (tb_azon.TextLength > 0)
            {
                try
                {
                    int a = int.Parse(tb_azon.Text);
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg!");
                    tb_azon.Clear();
                    tb_azon.Focus();
                }
            }
        }

        private void tb_mho_TextChanged(object sender, EventArgs e)
        {
            if (tb_mho.TextLength > 0)
            {
                try
                {
                    double a = double.Parse(tb_mho.Text);
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg!");
                    tb_mho.Clear();
                    tb_mho.Focus();
                }
            }
        }

        private void tb_csap_TextChanged(object sender, EventArgs e)
        {
            if (tb_csap.TextLength > 0)
            {
                try
                {
                    int a = int.Parse(tb_csap.Text);
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg!");
                    tb_csap.Clear();
                    tb_csap.Focus();
                }
            }
        }
    }
}
