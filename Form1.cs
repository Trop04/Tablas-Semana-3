using Tablas_Semana_3.Productos_y_Publicaciones;

namespace Tablas_Semana_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            Operaciones.frmTiendas frmtiendas = new Operaciones.frmTiendas();
            frmtiendas.ShowDialog();
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            Operaciones.FrmDescuento frmDescuento = new Operaciones.FrmDescuento();
            frmDescuento.ShowDialog();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Personal.FrmEmpleado frmEmpleado = new Personal.FrmEmpleado();
            frmEmpleado.ShowDialog();
        }

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            Personal.FrmTrabajos frmTrabajos = new Personal.FrmTrabajos();
            frmTrabajos.ShowDialog();
        }

        private void btnTitulo_Click(object sender, EventArgs e)
        {
            Productos_y_Publicaciones.FrmTitulos frmTitulos = new FrmTitulos();
            frmTitulos.ShowDialog();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            Productos_y_Publicaciones.FrmAutores frmAutores = new FrmAutores();
            frmAutores.ShowDialog();
        }

        private void btnAutTit_Click(object sender, EventArgs e)
        {
            Productos_y_Publicaciones.FrmAutorTitulo frmAutorTitulo = new FrmAutorTitulo();
            frmAutorTitulo.ShowDialog();
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            Productos_y_Publicaciones.FrmEditor frmEditor = new FrmEditor();
            frmEditor.ShowDialog();
        }

        private void btnInfoEditor_Click(object sender, EventArgs e)
        {
            Productos_y_Publicaciones.FrmInfoEdit frmInfoEdit = new FrmInfoEdit();
            frmInfoEdit.ShowDialog();
        }

        private void btnRoyalties_Click(object sender, EventArgs e)
        {
            Finanzas.FrmRegalias frmRegalias = new Finanzas.FrmRegalias();
            frmRegalias.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Finanzas.FrmVentas frmVentas = new Finanzas.FrmVentas();
            frmVentas.ShowDialog();
        }
    }
}
