using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Met_Alberti
{
    public partial class FrmAlberti : Form
    {
        public FrmAlberti()
        {
            InitializeComponent();
        }

        private void FrmAlberti_Load(object sender, EventArgs e)
        {
            cmbGiro.Items.Add("SELECCIONE UNO");
            cmbGiro.Items.Add("IZQUIERDA");
            cmbGiro.Items.Add("DERECHA");

            txtMcla.Enabled = false;
            txtLlave.Enabled = false;
            nudSust.Enabled = false;
            nudCantPos.Enabled = false;
            cmbGiro.Enabled = false;
            btnCifrado.Enabled = false;
            radCparametros.Checked = false;
            radSparametros.Checked = false;

        }

        private void btnCifrado_Click(object sender, EventArgs e)
        {
            try
            {
                Alberti miAlberti = new Alberti();

                miAlberti.Mcla = txtMcla.Text.ToUpper().Replace(" ", "");
                miAlberti.Llave = txtLlave.Text;
                if(radSparametros.Checked == true)
                {
                    miAlberti.TpoCifrado = radSparametros.Text;
                }
                if(radCparametros.Checked == true)
                {
                    miAlberti.Sustituciones = int.Parse(nudSust.Value.ToString());
                    miAlberti.CantPos = int.Parse(nudCantPos.Value.ToString());
                    miAlberti.Giro = cmbGiro.Text;
                    miAlberti.TpoCifrado = radCparametros.Text;
                }

                txtCripto.Text = miAlberti.Cifrar();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radSparametros_CheckedChanged(object sender, EventArgs e)
        {
            txtMcla.Enabled = true;
            txtLlave.Enabled = true;
            nudSust.Enabled = false;
            nudCantPos.Enabled = false;
            cmbGiro.Enabled = false;
            btnCifrado.Enabled = true;
        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            try
            {
                Alberti miAlberti = new Alberti();

                miAlberti.Mcla = txtMcla.Text.Replace(" ", "");
                miAlberti.Llave = txtLlave.Text;
                if (radSparametros.Checked == true)
                {
                    miAlberti.TpoCifrado = radSparametros.Text;
                }
                if (radCparametros.Checked == true)
                {
                    miAlberti.Sustituciones = int.Parse(nudSust.Value.ToString());
                    miAlberti.CantPos = int.Parse(nudCantPos.Value.ToString());
                    miAlberti.Giro = cmbGiro.Text;
                    miAlberti.TpoCifrado = radCparametros.Text;
                }

                txtCripto.Text = miAlberti.DESCIFRAR();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblLimpiar_Click(object sender, EventArgs e)
        {
            txtMcla.Clear();
            txtLlave.Clear();
            nudSust.Value = 0;
            nudCantPos.Value = 0;
            cmbGiro.SelectedIndex = 0;
            radSparametros.Checked = false;
            radCparametros.Checked = false;
            txtCripto.Clear();
            txtMcla.Focus();
        }

        private void radCparametros_CheckedChanged(object sender, EventArgs e)
        {
            txtMcla.Enabled = true;
            txtLlave.Enabled = true;
            nudSust.Enabled = true;
            nudCantPos.Enabled = true;
            cmbGiro.Enabled = true;
            btnCifrado.Enabled = true;
        }
    }
}
