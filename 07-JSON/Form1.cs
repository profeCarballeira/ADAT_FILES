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
    }
}
