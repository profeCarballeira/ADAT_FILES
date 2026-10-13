namespace _03_ListarCiudades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(this.openFileDialog1.FileName);
            }
            using (StreamReader sr = File.OpenText(this.openFileDialog1.FileName))
            {
                string? Provincia;
                while ((Provincia = sr.ReadLine()) != null)
                {
                    this.listBox1.Items.Add(Provincia);
                }
            }
        }
    }
}
