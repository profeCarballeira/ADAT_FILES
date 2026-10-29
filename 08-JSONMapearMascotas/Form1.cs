using System.ComponentModel.Design.Serialization;
using System.Text.Json;

namespace _08_JSONMapearMascotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string GetJsonFromUrl(string url)
        {
            try
            {
                using (HttpClient cli = new HttpClient())
                {
                    HttpResponseMessage response = cli.GetAsync(url).Result; //asynchronous call
                    response.EnsureSuccessStatusCode();
                    return response.Content.ReadAsStringAsync().Result; //async call
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener JSON {ex.Message}");
                return string.Empty;
            }

        }
        private void btnMapearMascotas_Click(object sender, EventArgs e)
        {
            string jsonData = GetJsonFromUrl("  https://raw.githubusercontent.com/LearnWebCode/json-example/master/pets-data.json");
            if (!string.IsNullOrEmpty(jsonData))
            {
                try
                {
                    //Deserializamos JSON en un objeto (lista de Pet)
                    PetList petsData = JsonSerializer.Deserialize<PetList>(jsonData);

                    //si hay datos ==> al DataGridView
                    if (petsData != null && petsData.pets != null)
                    {
                        dgvMascotas.DataSource = petsData.pets;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erorr deserializando JSON: {ex.Message}");
                }
            }
        }
    }
}
