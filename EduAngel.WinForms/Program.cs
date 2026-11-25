using EduAngel.Application.Services;
using EduAngel.Infrastructure.Repositories;
using System.Text.Json;

namespace EduAngel.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            string connectionString;

            try
            {
                string caminho = Path.Combine(
                    AppContext.BaseDirectory,
                    "appsettings.json");

                using var documento = JsonDocument.Parse(
                    File.ReadAllText(caminho));

                connectionString = documento.RootElement
                    .GetProperty("ConnectionStrings")
                    .GetProperty("EduAngel")
                    .GetString()
                    ?? throw new InvalidOperationException();

                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    throw new InvalidOperationException();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Não foi possível carregar a configuração. " +
                    "Verifique o arquivo appsettings.json.",
                    "EduAngel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            var repository =
                new TiposRedeRepository(connectionString);

            var service = new TipoRedeService(repository);

            System.Windows.Forms.Application.Run(
                new EduAngel(service));
        }
    }
}