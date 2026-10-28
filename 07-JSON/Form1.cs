using System.Text.Json;

namespace _07_JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerJSONlocal_Click(object sender, EventArgs e)
        {
            String fichoroJSON = "persona.json";
            if (File.Exists(fichoroJSON))
            {
                string jsonText = File.ReadAllText(fichoroJSON);

                Persona p = JsonSerializer.Deserialize<Persona>(jsonText);

                this.lblPersona.Text = "Nombre: " + p.nombre + System.Environment.NewLine +
                                        "Edad: " + p.edad + System.Environment.NewLine +
                                        "Profesion: " + p.profesion;
            }
            else
                this.lblPersona.Text = "El fichero no existe";
        }

        private void btnGrabarJSON_Click(object sender, EventArgs e)
        {
            string ficheroJSON = "persona_guardada.json";
            Persona p = new Persona
            {
                nombre = "Adrián",
                edad = 19,
                profesion = "Desarrollador c#"
            };

            string jsonText = JsonSerializer.Serialize(p, new JsonSerializerOptions {
                WriteIndented = true ,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping //para las tildes, ñ...
            });
            File.WriteAllText(ficheroJSON, jsonText, System.Text.Encoding.UTF8);

            MessageBox.Show("Archivo JSon guardado correctamente");

        }

        //añade un nuevo objeto persona al final de nuestra lista en JSON
        private void btnAddPersona_Click(object sender, EventArgs e)
        {
            string ficheroJSON = "ListaPersonas.json";

            List<Persona> personas = new List<Persona>();

            //Leer el archivo si existe y deserializar la lista
            if (File.Exists(ficheroJSON))
            {
                string jsonText = File.ReadAllText(ficheroJSON);
                try
                {
                    personas = JsonSerializer.Deserialize<List<Persona>>(jsonText);
                }
                catch
                {
                    //si el archivo no contiene lista válida, lo ignora
                    personas = new List<Persona>();
                }
            }
            //Crear una persona desde el formulario
            Persona nueva = new Persona();
            nueva.nombre = this.txtNombre.Text;
            nueva.edad = System.Convert.ToInt32(this.txtEdad.Text);
            nueva.profesion = this.txtProfesion.Text;

            personas.Add(nueva);
            string nuevoJson = JsonSerializer.Serialize(personas, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(ficheroJSON, nuevoJson);
            MessageBox.Show("Persona añadida correctamente");
        }

        private void btnLeerListaPersonas_Click(object sender, EventArgs e)
        {
            string ficheroJSON = "ListaPersonas.json";
            this.lblListadoPersonas.Text = ""; //limpiar el contenido previo

            if (File.Exists(ficheroJSON))
            {
                string jsonText = File.ReadAllText(ficheroJSON);
                try
                {
                    List<Persona> personas = JsonSerializer.Deserialize<List<Persona>>(jsonText);
                    foreach (Persona p in personas)
                    {
                        this.lblListadoPersonas.Text += "Nombre: " + p.nombre + Environment.NewLine +
                                                    "Edad: " + p.edad + Environment.NewLine +
                                                    "Profesión:" + p.profesion + Environment.NewLine +
                                                    "---------------------------" + Environment.NewLine;
                    }

                }
                catch
                {

                    this.lblListadoPersonas.Text = "El archivo no contiene una lista JSON válida";
                }


            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblPersona_Click(object sender, EventArgs e)
        {

        }
    }
}
