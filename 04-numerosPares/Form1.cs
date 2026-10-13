namespace _04_numerosPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ficheroIN = "numeros.txt";
            string ficheroOUT = "pares.txt";

            if (File.Exists(ficheroIN))
            {
                using (StreamReader sr = new StreamReader(ficheroIN))
                {
                    using (StreamWriter sw = new StreamWriter(ficheroOUT))
                    {
                        string? linea;
                        while ((linea = sr.ReadLine()) != null)
                        {
                            // Intenta convertir una linea a número
                            if (int.TryParse(linea, out int numero))
                            {
                                if (numero % 2 == 0)
                                {
                                    sw.WriteLine(numero);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ficheroNum = "numeros.txt";
            int acumulador = 0;
            if (File.Exists(ficheroNum))
            {

                using (StreamReader sr = new StreamReader(ficheroNum))
                {
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Intenta convertir la línea a número
                        if (int.TryParse(line, out int number))
                        {
                            acumulador += number;
                        }
                    }
                }
                using (StreamWriter sw = File.AppendText(ficheroNum))
                {
                    sw.WriteLine(acumulador);
                }
            }
        }
    }
}
