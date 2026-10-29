

using CDS.Markdown;

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
            //IMPRESCINDIBLE añadir WebView2 al proyecto a través de Nuget
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

        //private MarkdownViewer markdownViewer1;
        private async void btnCargarMD_Click(object sender, EventArgs e)
        {
            // 1. Definir la ruta del archivo .md
            string rutaArchivo = @"holaMarkDown.md";

            // 2. Validar que el archivo realmente exista
            if (!System.IO.File.Exists(rutaArchivo))
            {
                MessageBox.Show($"No se encontró el archivo en la ruta:\n{rutaArchivo}",
                                "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 3. Crear el control visor dinámicamente si no lo has arrastrado al diseño
                // (Si ya arrastraste el control desde la caja de herramientas y se llama markdownViewer1,
                // puedes borrar estas 3 líneas de inicialización).
                if (markdownViewer1 == null)
                {
                    markdownViewer1 = new CDS.Markdown.MarkdownViewer();
                    markdownViewer1.Dock = DockStyle.Fill;
                    this.Controls.Add(markdownViewer1);
                    markdownViewer1.BringToFront(); // Asegura que se vea por encima de otros controles
                }

                // 4. Cargar y renderizar el archivo .md con una sola línea
                await markdownViewer1.LoadMarkdownAsync(rutaArchivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar el archivo: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
