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
            TipoPrestamo tp = (TipoPrestamo)lstTipoPrestamos.SelectedItem;
            txtLinea.Text = tp.Linea;
            txtTNA.Text = tp.TNA.ToString();
            txtMonto.Enabled = true;
            txtPlazo.Enabled = true;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lstTipoPrestamos.DataSource = tpservicio.GetTipoPrestamo();
            
        }
    }
}
