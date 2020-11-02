using CAI_Prestamo.Entidades.Entidades;
using CAI_Prestamo.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAI_Prestamo.Entidades;

namespace CAI_Prestamo
{
    public partial class Menu : Form
    {
        private TipoPrestamoServicio tpservicio;
        public Menu()
        {
            InitializeComponent();
            tpservicio = new TipoPrestamoServicio();
            lstTipoPrestamos.ClearSelected();
        }

        private void lstTipoPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Como hacer que por default no haya nada seleccionado? Entra aca igual.
            TipoPrestamo tp = ObtenerTipoPrestamoSeleccionado();
            txtLinea.Text = tp.Linea;
            txtTNA.Text = tp.TNA.ToString();
            txtMonto.Enabled = true;
            txtPlazo.Enabled = true;
        }

        private TipoPrestamo ObtenerTipoPrestamoSeleccionado()
        {
            return (TipoPrestamo)lstTipoPrestamos.SelectedItem;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lstTipoPrestamos.DataSource = tpservicio.GetTipoPrestamo();
            
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            string mensaje="";
            List<string> errores = new List<string>();
            errores.Add(Validacion.ValidarNumero(txtMonto.Text, "monto"));
            errores.Add(Validacion.ValidarNumero(txtPlazo.Text, "plazo"));
            if (errores.Any())
            {
                foreach (string error in errores)
                {
                    mensaje += error + "\n";
                }
            }
            if (mensaje != "")
            {
                Prestamo simulacro = new Prestamo(ObtenerTipoPrestamoSeleccionado(), Convert.ToDouble(txtMonto.Text), Convert.ToInt32(txtMonto.Text));
                txtCapital.Text = (simulacro.CuotaCapital()).ToString();
                txtInteres.Text = simulacro.CuotaInteres().ToString();
                txtCuota.Text = simulacro.Cuota().ToString();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
    }
}
