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

            string fichero = "personasEncabezadoComa.csv";

            this.lblContenidoCSV.Text = "";

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            { };

            StreamReader sr = new StreamReader(fichero);
            using (var csv = new CsvReader(sr, config))
            {
                var personas = csv.GetRecords<Persona>();

                foreach (var persona in personas)
                {
                    this.lblContenidoCSV.Text += persona.nombre + " " +
                                                  persona.edad + " " +
                                                  persona.altura + System.Environment.NewLine;
                }

            }
            sr.Close();


        }

        private void btnLeerCSVHelperPuntoComa_Click(object sender, EventArgs e)
        {
            string fichero = "personasEncabezadoPuntoComa.csv";

            this.lblContenidoCSV.Text = "";

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";" //establece el delimitador en ";"
            };

            StreamReader sr = new StreamReader(fichero);
            using (var csv = new CsvReader(sr, config))
            {
                var personas = csv.GetRecords<Persona>();

                foreach (var persona in personas)
                {
                    this.lblContenidoCSV.Text += persona.nombre + " " +
                                                  persona.edad + " " +
                                                  persona.altura + System.Environment.NewLine;
                }

            }
            sr.Close();
        }

        private void btnLeerCSVHelperPuntoComaSinHeaders_Click(object sender, EventArgs e)
        {
            string fichero = "personasSINEncabezadoPuntoComa.csv";

            this.lblContenidoCSV.Text = "";

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";", //establece el delimitador en ";"
                HasHeaderRecord = false, //csv sin encabezados
            };

            StreamReader sr = new StreamReader(fichero);
            using (var csv = new CsvReader(sr, config))
            {
                var personas = csv.GetRecords<Persona>();

                foreach (var persona in personas)
                {
                    this.lblContenidoCSV.Text += persona.nombre + " " +
                                                  persona.edad + " " +
                                                  persona.altura + System.Environment.NewLine;
                }

            }
            sr.Close();
        }

        private void btnGuardarCSVHelper_Click(object sender, EventArgs e)
        {
            String fichero = "personas_guardadas.csv";

            //Crear una lista de ejmplo de personas...
            var personas = new List<Persona> {
                new Persona { nombre = "Carlos", edad = 37, altura = 175 },
                new Persona { nombre = "María", edad = 27, altura = 165 },
                new Persona { nombre = "Pedro", edad = 17, altura = 155 }
            };

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";", //establece el delimitador en ";"
                HasHeaderRecord = true, //csv sin encabezados
            };

            try {
                using (var sw = new StreamWriter(fichero, false, new System.Text.UTF8Encoding(true)))
                    using (var csv = new CsvWriter(sw, config)) { 
                        csv.WriteRecords(personas);
                    }


            }
            catch (Exception ex) {
                MessageBox.Show($"Errror al guar el fichoro csv: {ex.Message}");
            
            }



        }
    }
}
