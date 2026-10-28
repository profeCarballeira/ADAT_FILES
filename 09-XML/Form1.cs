using System.Xml.Linq;

namespace _09_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerXMLlocal_Click(object sender, EventArgs e)
        {
            String ficheroXML = "persona.xml";

            if (File.Exists(ficheroXML))
            {
                XDocument documentoXML = XDocument.Load(ficheroXML);

                XElement raiz = documentoXML.Root;

                Persona p = new Persona
                {
                    nombre = raiz.Element("nombre").Value,
                    edad = int.Parse(raiz.Element("edad").Value),
                    profesion = raiz.Element("profesion").Value
                };

                this.lblPersona.Text = "Nombre: " + p.nombre + System.Environment.NewLine +
                                       "Edad: " + p.edad + System.Environment.NewLine +
                                       "Profesion: " + p.profesion;
            }
            else
                this.lblPersona.Text = "El fichero no existe";
        }

        private void btnGrabarXML_Click(object sender, EventArgs e)
        {
            string ficheroXML = "persona_guardada.xml";

            Persona p = new Persona
            {
                nombre = "Adrián",
                edad = 19,
                profesion = "Desarrollador c#"
            };

            XDocument documentoXML = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("persona",
                    new XElement("nombre", p.nombre),
                    new XElement("edad", p.edad),
                    new XElement("profesion", p.profesion)
                )
            );

            documentoXML.Save(ficheroXML);

            MessageBox.Show("Archivo XML guardado correctamente");
        }

        private void btnAddPersona_Click(object sender, EventArgs e)
        {
            string ficheroXML = "ListaPersonas.xml";

            List<Persona> personas = new List<Persona>();

            // Leer el archivo si existe y cargar la lista
            if (File.Exists(ficheroXML))
            {
                try
                {
                    XDocument documentoXML = XDocument.Load(ficheroXML);

                    personas = documentoXML.Root
                        .Elements("persona")
                        .Select(elemento => new Persona
                        {
                            nombre = elemento.Element("nombre").Value,
                            edad = int.Parse(elemento.Element("edad").Value),
                            profesion = elemento.Element("profesion").Value
                        })
                        .ToList();
                }
                catch
                {
                    // Si el archivo no contiene una lista XML válida, lo ignora
                    personas = new List<Persona>();
                }
            }

            // Crear una persona desde el formulario
            Persona nueva = new Persona();
            nueva.nombre = this.txtNombre.Text;
            nueva.edad = System.Convert.ToInt32(this.txtEdad.Text);
            nueva.profesion = this.txtProfesion.Text;

            personas.Add(nueva);

            // Crear el documento XML con la lista completa
            XDocument nuevoXML = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("personas",
                    personas.Select(p =>
                        new XElement("persona",
                            new XElement("nombre", p.nombre),
                            new XElement("edad", p.edad),
                            new XElement("profesion", p.profesion)
                        )
                    )
                )
            );

            nuevoXML.Save(ficheroXML);

            MessageBox.Show("Persona añadida correctamente");
        }

        private void btnLeerListaPersonas_Click(object sender, EventArgs e)
        {
            string ficheroXML = "ListaPersonas.xml";

            this.lblListadoPersonas.Text = ""; // Limpiar el contenido previo

            if (File.Exists(ficheroXML))
            {
                try
                {
                    XDocument documentoXML = XDocument.Load(ficheroXML);

                    List<Persona> personas = documentoXML.Root
                        .Elements("persona")
                        .Select(elemento => new Persona
                        {
                            nombre = elemento.Element("nombre").Value,
                            edad = int.Parse(elemento.Element("edad").Value),
                            profesion = elemento.Element("profesion").Value
                        })
                        .ToList();

                    foreach (Persona p in personas)
                    {
                        this.lblListadoPersonas.Text += "Nombre: " + p.nombre + Environment.NewLine +
                                                        "Edad: " + p.edad + Environment.NewLine +
                                                        "Profesión: " + p.profesion + Environment.NewLine +
                                                        "---------------------------" + Environment.NewLine;
                    }
                }
                catch
                {
                    this.lblListadoPersonas.Text = "El archivo no contiene una lista XML válida";
                }
            }
            else
            {
                this.lblListadoPersonas.Text = "El fichero no existe";
            }
        }
    }
}
