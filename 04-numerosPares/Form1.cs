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

        private void button5_Click(object sender, EventArgs e)
        {
            string ficheroIN = "numeros.txt";
            string ficheroOUT = "numerosOrdenados.txt";

            if (File.Exists(ficheroIN))
            {
                List<int> numeros = new List<int>();

                // Leer todos los números del fichero
                using (StreamReader sr = new StreamReader(ficheroIN))
                {
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (int.TryParse(line, out int number))
                        {
                            numeros.Add(number);
                        }
                    }
                }

                // Ordenar la lista
                numeros.Sort();

                // Escribir los números ordenados en el fichero de salida
                using (StreamWriter writer = new StreamWriter(ficheroOUT))
                {
                    foreach (int n in numeros)
                    {
                        writer.WriteLine(n);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ficheroIN = "numeros.txt";
            int numeroBuscado = System.Convert.ToInt32(this.textBox1.Text);
            int lineaEncontrada = -1;

            if (File.Exists(ficheroIN))
            {
                using (StreamReader sr = new StreamReader(ficheroIN))
                {
                    string? linea;
                    int numeroLinea = 0;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        numeroLinea++; // Cuenta la línea actual (empezando en 1)

                        // Intenta convertir la línea a número
                        if (int.TryParse(linea, out int numeroActual))
                        {
                            if (numeroActual == numeroBuscado)
                            {
                                lineaEncontrada = numeroLinea;
                                break; // Detiene la búsqueda al encontrar la primera coincidencia
                            }
                        }
                    }
                }
            }

            if (lineaEncontrada != -1)
            {
                MessageBox.Show($"El número {numeroBuscado} está en la línea {lineaEncontrada}.");
            }
            else
            {
                MessageBox.Show($"El número {numeroBuscado} no se encuentra en el fichero (o el archivo no existe).");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ficheroIN = "numeros.txt";
            string ficheroOUT = "numerosTemp.txt";

            // Validamos que los inputs del usuario sean números correctos
            if (!int.TryParse(textBox2.Text, out int numeroOriginal) || !int.TryParse(textBox3.Text, out int numeroNuevo))
            {
                MessageBox.Show("Por favor, introduce números válidos en ambos campos.");
                return;
            }

            if (File.Exists(ficheroIN))
            {
                // Abrimos el fichero original para leer y el temporal para escribir
                using (StreamReader sr = new StreamReader(ficheroIN))
                {
                    using (StreamWriter sw = new StreamWriter(ficheroOUT))
                    {
                        string? linea;
                        while ((linea = sr.ReadLine()) != null)
                        {
                            // Intenta convertir la línea a número
                            if (int.TryParse(linea, out int numeroActual))
                            {
                                if (numeroActual == numeroOriginal)
                                {
                                    // Si coincide, escribimos el nuevo número
                                    sw.WriteLine(numeroNuevo);
                                }
                                else
                                {
                                    // Si no coincide, mantenemos el número original
                                    sw.WriteLine(numeroActual);
                                }
                            }
                            else
                            {
                                // Si la línea está vacía o no es un número válido, la copiamos tal cual
                                sw.WriteLine(linea);
                            }
                        }
                    }
                }

                // Reemplazamos el fichero original con el fichero modificado
                File.Move(ficheroOUT, ficheroIN, true);
                MessageBox.Show("Reemplazo completado correctamente.");
            }
            else
            {
                MessageBox.Show("El fichero numeros.txt no existe.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string ficheroIN = "numeros.txt";

            // Validamos que el número de líneas por fichero introducido sea válido y mayor que cero
            if (!int.TryParse(textBox4.Text, out int lineasPorFichero) || lineasPorFichero <= 0)
            {
                MessageBox.Show("Por favor, introduce un número de líneas válido y mayor que 0.");
                return;
            }

            if (File.Exists(ficheroIN))
            {
                using (StreamReader sr = new StreamReader(ficheroIN))
                {
                    string? linea;
                    int contadorLineas = 0;
                    int numeroFichero = 1;
                    StreamWriter? sw = null;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        // Si el escritor está cerrado o es nulo, creamos el siguiente fichero
                        if (sw == null)
                        {
                            string ficheroOUT = $"numeros{numeroFichero}.txt";
                            sw = new StreamWriter(ficheroOUT);
                        }

                        // Escribimos la línea en el fichero actual
                        sw.WriteLine(linea);
                        contadorLineas++;

                        // Si alcanzamos el límite de líneas, cerramos el fichero actual y nos preparamos para el siguiente
                        if (contadorLineas >= lineasPorFichero)
                        {
                            sw.Dispose(); // Cierra y libera el fichero actual de forma segura
                            sw = null;
                            contadorLineas = 0;
                            numeroFichero++;
                        }
                    }

                    // Si al terminar el bucle el último fichero se quedó abierto, lo cerramos
                    if (sw != null)
                    {
                        sw.Dispose();
                    }

                    MessageBox.Show($"Fichero dividido correctamente en {numeroFichero} partes.");
                }
            }
            else
            {
                MessageBox.Show("El fichero numeros.txt no existe.");
            }
        }
    }
}
