using EduAngel.Application.Services;
using EduAngel.WinForms.Redes;

namespace EduAngel.WinForms
{
    public partial class EduAngel : Form
    {
        private readonly TipoRedeService? _tipoRedeService;

        public EduAngel()
        {
            InitializeComponent();
        }

        public EduAngel(TipoRedeService service) : this()
        {
            ArgumentNullException.ThrowIfNull(service);
            _tipoRedeService = service;
        }

        private void tiposDeRedeMenuItem_Click(
            object sender, EventArgs e)
        {
            if (_tipoRedeService is null)
            {
                MessageBox.Show("O serviço não foi configurado.");
                return;
            }

            foreach (Form janela in MdiChildren)
            {
                if (janela is TiposRedes)
                {
                    janela.Activate();
                    return;
                }
            }

            var formulario = new TiposRedes(_tipoRedeService)
            {
                MdiParent = this
            };

            formulario.Show();
        }
    }
}