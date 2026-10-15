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

        private void button3_Click(object sender, EventArgs e)
        {
            string ficheroIN = "numeros.txt";
            string ficheroOUT = "numerosPekes.txt";

            if (File.Exists(ficheroIN))
            {
                using (StreamReader reader = new StreamReader(ficheroIN))
                {
                    using (StreamWriter writer = new StreamWriter(ficheroOUT))
                    {
                        string? line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Intenta convertir la línea a número
                            if (int.TryParse(line, out int number))
                            {
                                if (number <= 10)
                                {
                                    writer.WriteLine(number);
                                }
                            }
                        }
                    }
                }
                File.Move(ficheroOUT, ficheroIN, true);
                //File.Replace(ficheroOUT, ficheroIN,"numerosBak.txt");
                //también podría ser con File.Copy +File.Delete
                ;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ficheroIN1 = "numeros1.txt";
            string ficheroIN2 = "numeros2.txt";
            string ficheroOUT = "numerosFusion.txt";

            if (File.Exists(ficheroIN1) && File.Exists(ficheroIN2))
            {
                using (StreamWriter sw = new StreamWriter(ficheroOUT))
                {
                    using (StreamReader sr = new StreamReader(ficheroIN1))
                    {
                        string? line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            sw.WriteLine(line);
                        }
                    }
                    using (StreamReader sr = new StreamReader(ficheroIN2))
                    {
                        string? line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            sw.WriteLine(line);
                        }
                    }

                }
            }
        }
    }
}
