

namespace _02_Ver_rtf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.LoadFile("Contrato_Uso_Software.rtf");
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {

        }

        private async void btnCargarPDF_Click(object sender, EventArgs e)
        {
            // Añadir esta variable arriba o dentro del método
            Microsoft.Web.WebView2.WinForms.WebView2 webViewPDF = new Microsoft.Web.WebView2.WinForms.WebView2();
            webViewPDF.Dock = DockStyle.Fill;

            this.panel1.Controls.Clear(); // Limpiamos controles antiguos del panel
            this.panel1.Controls.Add(webViewPDF);

            // 1. Obtener la ruta absoluta del archivo PDF
            string rutaPDF = Path.GetFullPath("hola.pdf");

            if (File.Exists(rutaPDF))
            {
                // 2. Asegurar que el motor del navegador esté inicializado
                await webViewPDF.EnsureCoreWebView2Async(null);

                // Opcional: Oculta la barra de estado inferior para una apariencia más limpia
                webViewPDF.CoreWebView2.Settings.IsStatusBarEnabled = false;

                // 3. Cargar el PDF usando su URI absoluta
                webViewPDF.CoreWebView2.Navigate(new Uri(rutaPDF).AbsoluteUri);
            }
            else
            {
                MessageBox.Show($"No se encontró el archivo en: {rutaPDF}", "Error de archivo");
            }
        }
    }
}
