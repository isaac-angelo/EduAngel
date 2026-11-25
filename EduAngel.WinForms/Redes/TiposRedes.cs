using EduAngel.Application.Services;
using EduAngel.Domain.Entities;

namespace EduAngel.WinForms.Redes
{
    public partial class TiposRedes : Form
    {
        private readonly TipoRedeService? _service;

        public TiposRedes()
        {
            InitializeComponent();

            id.ReadOnly = true;
            nome.MaxLength = 100;

            novoBotao.Text = "Novo";
            salvarBotao.Text = "Salvar";

            novoBotao.Click += novoBotao_Click;
            salvarBotao.Click += salvarBotao_Click;
        }

        public TiposRedes(TipoRedeService service) : this()
        {
            ArgumentNullException.ThrowIfNull(service);
            _service = service;
        }

        private void novoBotao_Click(object? sender, EventArgs e)
        {
            id.Clear();
            nome.Clear();

            nome.Focus();
        }

        private async void salvarBotao_Click(
            object? sender, EventArgs e)
        {
            if (_service is null)
            {
                MessageBox.Show("O serviço não foi configurado.");
                return;
            }

            var tipoRede = new Domain.Entities.TiposRedes
            {
                Nome = nome.Text,
            };

            if (!string.IsNullOrWhiteSpace(id.Text))
            {
                if (!int.TryParse(id.Text, out int codigo)
                    || codigo <= 0)
                {
                    MessageBox.Show("Código inválido.");
                    return;
                }

                tipoRede.Id = codigo;
            }

            toolStrip1.Enabled = false;
            containePainel.Enabled = false;

            try
            {
                if (tipoRede.Id == 0)
                {
                    tipoRede.Id =
                        await _service.AdicionarAsync(tipoRede);
                }
                else
                {
                    await _service.AtualizarAsync(tipoRede);
                }

                id.Text = tipoRede.Id.ToString();
                nome.Text = tipoRede.Nome;

                MessageBox.Show(
                    this,
                    "Tipo de rede salvo com sucesso.",
                    "EduAngel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(this, ex.Message, "Verifique os dados");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(this, ex.Message, "Não foi possível salvar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro ao salvar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                toolStrip1.Enabled = true;
                containePainel.Enabled = true;
            }
        }
    }
}