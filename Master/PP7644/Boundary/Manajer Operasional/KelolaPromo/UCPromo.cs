using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PP7644.Control;
using PP7644.Entity;

namespace PP7644.Boundary.Manajer_Operasional.KelolaPromo
{
    public partial class UCPromo : UserControl
    {
        public UCPromo()
        {
            InitializeComponent();
        }

        static int flagCommand = 0;

        public void setflag(int flag)
        {
            flagCommand = flag;
        }

        PromoControl PC = new PromoControl();

        private void UCPegawai_Load(object sender, EventArgs e)
        {
            
            //cbJabatan.DataSource = PC.getJabatan();
           // cbJabatan.DisplayMember = "nama_jabatan";
        }



        private bool cekInput()
        {
            var temp = true;

            if (txtNama.Text == "")
            {
                errorProvider1.SetError(txtNama, "Silahkan isi bidang nama");
                txtNama.Focus();
                temp = false;
            }

            
            return temp;
        }

        private void clearInput()
        {
            txtNama.Clear();
           txtJenis.Clear();
            txtHarga.Clear();
            txtBonus.Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (flagCommand == 1) //tambah data
            {
                if (cekInput())
                {
                    errorProvider1.Clear();
                    //
                    var P = new Entity.PromoEntity(txtNama.Text, txtJenis.Text, int.Parse(txtHarga.Text),
                        int.Parse(txtBonus.Text));
                    PC.addPromo(P);
                    this.Hide();
                    var myParent = (FormPromo)Parent;
                   myParent.enable();
                }

            }
        }

        private string getKolom(DataGridView dg, int i)
        {
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Hide();
            var kk = new FormPromo();
            kk.ShowDialog();
        }
        

    }
}
