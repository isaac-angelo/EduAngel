using EduAngel.WinForms.Redes;

namespace EduAngel.WinForms
{
    public partial class EduAngel : Form
    {
        public EduAngel()
        {
            InitializeComponent();
        }

        private void tiposDeRedeMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new TiposRedes();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
