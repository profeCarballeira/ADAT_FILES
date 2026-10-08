using System.Reflection.PortableExecutable;

namespace _01_IntroFicheros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCrearFichro_Click(object sender, EventArgs e)
        {
            //solo vamos a crear el fichero si no existe
            if (!File.Exists(this.txtNombreFichero.Text))
            {
                //crear fichero de forma simple
                //File.CreateText(this.txtNombreFichero.Text);

                //Obtener Stream para escritura
                StreamWriter sw = File.CreateText(this.txtNombreFichero.Text);
                sw.WriteLine("Mi primera linea");
                //sw.Flush(); //sincroniza RAM con disco (dispositivo externo)
                sw.Close(); //implica un flush() implicito

            }
            else
            {
                MessageBox.Show("El fichero ya existe");
            }
        }

        private void btnCrearCarpeta_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.txtCarpeta.Text))
            {
                Directory.CreateDirectory(this.txtCarpeta.Text);
            }
        }

        private void btnCrearFicheroEnCarpeta_Click(object sender, EventArgs e)
        {
            //la carpeta debe existir, en caso contrario da excepción CreateText no sabe crearla en la misma invocación
            if (Directory.Exists(this.txtCarpeta.Text))
            {
                string rutaCompleta = Path.Combine(this.txtCarpeta.Text, this.txtNombreFichero.Text);
                File.CreateText(rutaCompleta);
            }
        }

        private void btnMoverFicheroACarpeta_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.txtNombreFichero.Text) &&
                Directory.Exists(this.txtCarpeta.Text))
            {
                File.Move(this.txtCarpeta.Text, this.txtCarpeta + "/" + this.txtNombreFichero.Text);
            }
        }

        private void btnBorrarFichero_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.txtNombreFichero.Text))
            {
                File.Delete(this.txtNombreFichero.Text);
            }
            else
            {
                MessageBox.Show("El fichero que quieres borrar no existe");
            }
        }

        private void btnBorrarCarpeta_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(this.txtCarpeta.Text)){
                Directory.Delete (this.txtCarpeta.Text);
            }
        }
    }
}
