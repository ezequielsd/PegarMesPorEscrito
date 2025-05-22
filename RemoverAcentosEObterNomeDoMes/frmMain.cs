using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RemoverAcentosEObterNomeDoMes
{
    public partial class frmMain : Form
    {
        DateTime dataAtual;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dataAtual = DateTime.Now;
            lblData.Text = dataAtual.ToString("dd/MM/yyyy");
        }

        private void btnObterMes_Click(object sender, EventArgs e)
        {
            txtMes.Text = ObterNomeMes(dataAtual);
        }

        private void btnObterMesSemAcento_Click(object sender, EventArgs e)
        {
            txtMes.Text = ObterNomeMesSemAcento(dataAtual);
        }

        private static string ObterNomeMes(DateTime data)
        {
            string nomeMes = data.ToString("MMMM", new CultureInfo("pt-BR"));
            return char.ToUpper(nomeMes[0]) + nomeMes.Substring(1);
        }

        private static string ObterNomeMesSemAcento(DateTime data)
        {
            string nomeMes = data.ToString("MMMM", new CultureInfo("pt-BR"));
            string nomeMesSemAcento = RemoverAcentos(nomeMes);
            return char.ToUpper(nomeMesSemAcento[0]) + nomeMesSemAcento.Substring(1);
        }

        private static string RemoverAcentos(string texto)
        {
            var textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var c in textoNormalizado)
            {
                var unicodeCategoria = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategoria != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMes.Clear();
        }
    }
}
