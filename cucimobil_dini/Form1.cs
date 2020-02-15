using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cucimobil_dini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bersih();
            disable();
            kolom();
        }

        void bersih()
        {
            tbno.Clear();
            tbnop.Clear();
            tbnama.Clear();
            tbhp.Clear();
            rbmini.Checked = false;
            rbangkot.Checked = false;
            rbbus.Checked = false;
            rbsedan.Checked = false;
            cbvacum.Checked = false;
            cbpolesb.Checked = false;
            cbpolesk.Checked = false;
            biayacuci.Text = "0";
            biayaextra.Text = "0";
            tot.Text = "0";
            tbbayar.Clear();
            kembali.Text = "0";
        }

        void disable()
        {
            panel1.Enabled = false;
            tbbayar.Enabled = false;

        }

        void enable()
        {
            panel1.Enabled = true;
            tbbayar.Enabled = false;
        }

        private void btnbersih_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void btninput_Click(object sender, EventArgs e)
        {
            enable();
        }


        string j;
        double dibayar, total_biaya, kembalianku, biaya_ekstra, cuci;


        void jenis_mobil()
        {
            if (rbmini.Checked)
            {
                j = rbmini.Text;
                biayacuci.Text = "22000";
                cuci = Convert.ToInt32(biayacuci.Text);
            }
            if (rbbus.Checked)
            {
                j = rbbus.Text;
                biayacuci.Text = "45000";
                cuci = Convert.ToInt32(biayacuci.Text);
            }
            if (rbangkot.Checked)
            {
                j = rbangkot.Text;
                biayacuci.Text = "15000";
                cuci = Convert.ToInt32(biayacuci.Text);
            }
            if (rbsedan.Checked)
            {
                j = rbsedan.Text;
                biayacuci.Text = "25000";
                cuci = Convert.ToInt32(biayacuci.Text);
            }
        }

        private void rbmini_CheckedChanged(object sender, EventArgs e)
        {
            jenis_mobil();

        }

        private void rbangkot_CheckedChanged(object sender, EventArgs e)
        {
            jenis_mobil();

        }

        private void rbbus_CheckedChanged(object sender, EventArgs e)
        {
            jenis_mobil();

        }

        private void rbsedan_CheckedChanged(object sender, EventArgs e)
        {
            jenis_mobil();

        }

        
        void hitung_ekstra()
        {
            if (rbmini.Checked && cbvacum.Checked)
            {
                biayaextra.Text = "10000";               
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbmini.Checked && cbpolesb.Checked)
            {
                biayaextra.Text = "50000";                
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbmini.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "25000";               
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbmini.Checked && cbvacum.Checked && cbpolesb.Checked)
            {
                biayaextra.Text = "60000";             
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbmini.Checked && cbvacum.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "35000";            
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbmini.Checked && cbpolesb.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "75000";              
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbmini.Checked && cbvacum.Checked && cbpolesb.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "85000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbmini.Checked && cbvacum.Checked == false && cbpolesb.Checked == false && cbpolesk.Checked == false)
            {
                biayaextra.Text = "0";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }

            //----------------------------------------------///

            if (rbbus.Checked && cbvacum.Checked)
            {
                biayaextra.Text = "20000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbbus.Checked && cbpolesb.Checked)
            {
                biayaextra.Text = "75000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbbus.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "50000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbbus.Checked && cbvacum.Checked && cbpolesb.Checked)
            {
                biayaextra.Text = "95000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbbus.Checked && cbvacum.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "70000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbbus.Checked && cbpolesb.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "125000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbbus.Checked && cbvacum.Checked && cbpolesb.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "145000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbbus.Checked && cbvacum.Checked == false && cbpolesb.Checked == false && cbpolesk.Checked == false)
            {
                biayaextra.Text = "0";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }

            //-----------------------------------------------//

            if (rbangkot.Checked && cbvacum.Checked)
            {
                biayaextra.Text = "10000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbangkot.Checked && cbpolesb.Checked)
            {
                biayaextra.Text = "50000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbangkot.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "25000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbangkot.Checked && cbvacum.Checked && cbpolesb.Checked)
            {
                biayaextra.Text = "60000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbangkot.Checked && cbvacum.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "35000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbangkot.Checked && cbpolesb.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "75000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbangkot.Checked && cbvacum.Checked && cbpolesb.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "85000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbangkot.Checked && cbvacum.Checked == false && cbpolesb.Checked == false && cbpolesk.Checked == false)
            {
                biayaextra.Text = "0";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }

            //---------------------------------------/
            if (rbsedan.Checked && cbvacum.Checked)
            {
                biayaextra.Text = "25000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbsedan.Checked && cbpolesb.Checked)
            {
                biayaextra.Text = "50000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbsedan.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "35000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbsedan.Checked && cbvacum.Checked && cbpolesb.Checked)
            {
                biayaextra.Text = "75000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }

            if (rbsedan.Checked && cbpolesb.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "85000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbsedan.Checked && cbvacum.Checked && cbpolesb.Checked && cbpolesk.Checked)
            {
                biayaextra.Text = "140000";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
            if (rbsedan.Checked && cbvacum.Checked == false && cbpolesb.Checked == false && cbpolesk.Checked == false)
            {
                biayaextra.Text = "0";
                biaya_ekstra = Convert.ToInt32(biayaextra.Text);
            }
        }


        //--------------------------------------------------/

        private void biayaextra_Click(object sender, EventArgs e)
        {

        }

        private void biayacuci_Click(object sender, EventArgs e)
        {
            
        }

        private void cbvacum_CheckedChanged(object sender, EventArgs e)
        {
            layanan_extra();
            hitung_ekstra();
        }

        void kolom()
        {
            dgv.Columns.Add("0", "no cuci");
            dgv.Columns.Add("1", "no pol");
            dgv.Columns.Add("2", "nama customer");
            dgv.Columns.Add("3", "no handphone");
            dgv.Columns.Add("4", "jenis mobil");
            dgv.Columns.Add("5", "layanan extra");
            dgv.Columns.Add("6", "biaya cuci");
            dgv.Columns.Add("7", "biaya extra");
            dgv.Columns.Add("8", "total biaya");
            dgv.Columns.Add("9", "dibayarkan");
            dgv.Columns.Add("10", "kembalian");
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbpolesb_CheckedChanged(object sender, EventArgs e)
        {
            layanan_extra();
            hitung_ekstra();
        }

        private void cbpolesk_CheckedChanged(object sender, EventArgs e)
        {
            layanan_extra();
            hitung_ekstra();
        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            hitung_ekstra();
            TB();
            tot.Text = Convert.ToString(total_biaya);
            tbbayar.Enabled = true;
        }


        

        private void tot_Click(object sender, EventArgs e)
        {

        }

        

        private void tbbayar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kembali_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                DataGridViewRow BARIS = this.dgv.Rows[e.RowIndex];
                tbno.Text = BARIS.Cells["0"].Value.ToString();
                tbnop.Text = BARIS.Cells["1"].Value.ToString();
                tbnama.Text = BARIS.Cells["2"].Value.ToString();
                tbhp.Text = BARIS.Cells["3"].Value.ToString();
                if (BARIS.Cells["4"].Value.ToString() == "MINI BUS")
                {
                    rbmini.Checked = true;

                }
                if (BARIS.Cells["4"].Value.ToString() == "BUS")
                {
                    rbbus.Checked = true;
                }
                if (BARIS.Cells["4"].Value.ToString() == "ANGKOT")
                {
                    rbangkot.Checked = true;
                }
                if (BARIS.Cells["4"].Value.ToString() == "SEDAN")
                {
                    
                    rbsedan.Checked = true;
                }
                if (BARIS.Cells["5"].Value.ToString() == "VACUM")
                {
                    cbvacum.Checked = true;
                }
                if (BARIS.Cells["5"].Value.ToString() == "POLES BODY")
                {
                    cbpolesb.Checked = true;
                }
                if (BARIS.Cells["5"].Value.ToString() == "POLES KACA")
                {
                    cbpolesk.Checked = true;
                }
                if (BARIS.Cells["5"].Value.ToString() == "VACUM-POLES BODY")
                {
                    cbvacum.Checked = true;
                    cbpolesb.Checked = true;
                    cbpolesk.Checked = false;
                }
                if (BARIS.Cells["5"].Value.ToString() == "VACUM-POLES KACA")
                {
                    cbvacum.Checked = true;
                    cbpolesb.Checked = false;
                    cbpolesk.Checked = true;
                }
                if (BARIS.Cells["5"].Value.ToString() == "POLES BODY-POLES KACA")
                {
                    cbvacum.Checked = false;
                    cbpolesb.Checked = true;
                    cbpolesk.Checked = true;
                }
                if (BARIS.Cells["5"].Value.ToString() == "VACUM-POLES BODY-POLES KACA")
                {
                    cbvacum.Checked = true;
                    cbpolesb.Checked = true;
                    cbpolesk.Checked = true;
                }                
                biayacuci.Text = BARIS.Cells["6"].Value.ToString();
                biayaextra.Text = BARIS.Cells["7"].Value.ToString();
                tot.Text = BARIS.Cells["8"].Value.ToString();
                tbbayar.Text = BARIS.Cells["9"].Value.ToString();
                kembali.Text = BARIS.Cells["10"].Value.ToString();

            }
            catch
            {
                MessageBox.Show("PILIHLAH BARIS YG BENAR");
            }

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (tbno.Text == "" || tbnop.Text == "")
            {
                MessageBox.Show("MAAF DATA BELUM LENGKAP");
            }
            else
            {
                string[] baris = new string[] { tbno.Text, tbnop.Text, tbnama.Text, tbhp.Text, j, ekstra, biayacuci.Text, biayaextra.Text, tot.Text, tbbayar.Text, kembali.Text };
                dgv.Rows.Add(baris);
                MessageBox.Show("transaksi cuci mobil berhasil");
            }
        }
        

        void TB()
        {
            total_biaya = cuci + biaya_ekstra;
            tbbayar.Enabled = true;
        }

        private void biayaextra_TextChanged(object sender, EventArgs e)
        {
            TB();
        }

        private void tbbayar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dibayar = Convert.ToInt32(tbbayar.Text);
                if (total_biaya > dibayar)
                {
                    MessageBox.Show("uang kurang");
                }
                if (total_biaya < dibayar)
                {
                    kembalianku = dibayar - total_biaya;
                    kembali.Text = Convert.ToString(kembalianku);
                }
                if (total_biaya == dibayar)
                {
                    kembalianku = 0;
                    kembali.Text = Convert.ToString(kembalianku);
                }
            }
        }

        string ekstra;
        void layanan_extra()
        {
            if (cbvacum.Checked)
            {
                ekstra = cbvacum.Text;
            }
            if (cbpolesb.Checked)
            {
                ekstra = cbpolesb.Text;
            }
            if (cbpolesk.Checked)
            {
                ekstra = cbpolesk.Text;
            }
            if (cbvacum.Checked && cbpolesb.Checked)
            {
                ekstra = cbvacum.Text + "-" + cbpolesb.Text;
            }
            if (cbvacum.Checked && cbpolesk.Checked)
            {
                ekstra = cbvacum.Text + "-" + cbpolesk.Text;
            }
            if (cbpolesb.Checked && cbpolesk.Checked)
            {
                ekstra = cbpolesb.Text + "-" + cbpolesk.Text;
            }
            if (cbvacum.Checked && cbpolesb.Checked && cbpolesk.Checked)
            {
                ekstra = cbvacum.Text + "-" + cbpolesb.Text + "-" + cbpolesk.Text;
            }
            if (cbvacum.Checked == false && cbpolesb.Checked == false && cbpolesk.Checked == false)
            {
                ekstra = "";
            }
        }
    }
}
