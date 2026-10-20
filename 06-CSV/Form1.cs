using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace _06_CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerCSV_Click(object sender, EventArgs e)
        {
            String fichero = "personas_puntocoma.csv";
            if (File.Exists(fichero))
            {
                this.lblContenidoCSV.Text = "";
                using (StreamReader sr = new StreamReader(fichero))
                {
                    string? linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        //dividir por ;
                        var campos = linea.Split(';');

                        foreach (var campo in campos)
                        {
                            this.lblContenidoCSV.Text += campo + " ";
                        }
                        this.lblContenidoCSV.Text += System.Environment.NewLine;

                    }

                }
            }
        }

        private void btnLeerCSVHelper_Click(object sender, EventArgs e)
        {
            //1. crear una clase persona
            //2. incluir la libreria csvHelper en nuGet
            //3. crear el using correspondiente

            string fichero = "personasEncabezado.csv";

            this.lblContenidoCSV.Text = "";

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            { };

            StreamReader sr = new StreamReader(fichero);
            using (var csv = new CsvReader(sr, config))
            {
                var personas = csv.GetRecords<Persona>();

                foreach (var persona in personas) {
                    this.lblContenidoCSV.Text  += persona.nombre + " " +
                                                  persona.edad + " " +
                                                  persona.altura + System.Environment.NewLine;
                }
            
            }
            sr.Close();


        }
    }
}
