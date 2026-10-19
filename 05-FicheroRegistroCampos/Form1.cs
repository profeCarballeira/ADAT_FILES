namespace _05_FicheroRegistroCampos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            string fichero = "notas.txt";

            // Abrir el fichero en modo append
            using (StreamWriter sw = File.AppendText(fichero))
            {
                //string linea = txtNombre.Text + "#" + numNota.Value.ToString();
                //sw.WriteLine(linea);
                sw.WriteLine($"{txtNombre.Text}#{numNota.Value.ToString()}");
            }
        }


        private void btnModificarGuardar_Click(object sender, EventArgs e)
        {
            string fichero = "notas.txt";
            string nombre = this.txtNombre.Text.Trim();
            string nuevaNota = this.numNota.Value.ToString();

            // Si el fichero no existe, lo creamos directamente
            if (!File.Exists(fichero))
            {
                using (StreamWriter sw = File.AppendText(fichero))
                {
                    sw.WriteLine($"{nombre}#{nuevaNota}");
                }
                MessageBox.Show("Nota guardada correctamente (nuevo registro).");
                return;
            }

            // Leemos todas las líneas
            string[] lineas = File.ReadAllLines(fichero);

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] partes = lineas[i].Split('#');
                if (partes.Length == 2 && partes[0].Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    DialogResult respuesta = MessageBox.Show(
                        $"El nombre '{nombre}' ya existe con la nota {partes[1]}. ¿Deseas modificarla?",
                        "Modificar nota",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (respuesta == DialogResult.Yes)
                    {
                        // Modificamos la nota
                        lineas[i] = $"{nombre}#{nuevaNota}";
                        File.WriteAllLines(fichero, lineas);
                        MessageBox.Show("Nota modificada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se realizaron cambios.");
                    }

                    return; // Salimos del método ya que encontramos el registro
                }
            }

            // Si recorrió todo el archivo y no se encontró el nombre, lo añadimos al final
            using (StreamWriter sw = File.AppendText(fichero))
            {
                sw.WriteLine($"{nombre}#{nuevaNota}");
            }
            MessageBox.Show("Nota guardada correctamente (nuevo registro).");
        }


        private void btnNotas_Click(object sender, EventArgs e)
        {
            string fichero = "notas.txt";

            // Limpiamos el ListBox antes de cargar los datos
            this.lstNotas.Items.Clear();

            if (File.Exists(fichero))
            {
                using (StreamReader sr = new StreamReader(fichero))
                {
                    string? linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        // Dividir la línea por el carácter '#'
                        string[] partes = linea.Split('#');

                        // Verificamos que haya dos partes (nombre y nota)
                        if (partes.Length == 2)
                        {
                            string nombre = partes[0];
                            string nota = partes[1];

                            // Añadimos al ListBox en formato "Nombre - Nota"
                            this.lstNotas.Items.Add($"{nombre} \t\t {nota}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró el fichero " + fichero, "Error");
            }
        }

        private void btnMejorNota_Click(object sender, EventArgs e)
        {
            String Fichero = "notas.txt";

            if (File.Exists(Fichero))
            {
                string mejorNombre = "";
                int mejorNota = -1;

                using (StreamReader sr = new StreamReader(Fichero))
                {
                    string? linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] partes = linea.Split('#');
                        if (partes.Length == 2)
                        {
                            if (int.TryParse(partes[1], out int nota))
                            {
                                if (nota > mejorNota)
                                {
                                    mejorNota = nota;
                                    mejorNombre = partes[0];
                                }
                            }
                        }
                    }
                    this.lblMejorNota.Text = mejorNombre + "=>" + mejorNota.ToString();
                }
            }
        }



        private void btnCargarChecklist_Click(object sender, EventArgs e)
        {
            string fichero = "notas.txt";

            // Limpiamos el CheckedListBox antes de cargar los datos
            this.clbNotas.Items.Clear();

            // Comprobamos si el fichero existe
            if (File.Exists(fichero))
            {
                using (StreamReader sr = new StreamReader(fichero))
                {
                    string? linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        // Dividimos la línea por '#'
                        string[] partes = linea.Split('#');

                        if (partes.Length == 2)
                        {
                            string nombre = partes[0];
                            string nota = partes[1];

                            // Añadimos al CheckedListBox en formato "Nombre - Nota"
                            this.clbNotas.Items.Add($"{nombre}\t\t{nota}", false);
                        }
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string fichero = "notas.txt";

            if (!File.Exists(fichero))
            {
                MessageBox.Show("No se encontró el fichero " + fichero, "Error");
                return;
            }

            // Obtener los elementos marcados en el CheckedListBox
            var itemsMarcados = new HashSet<string>();
            foreach (var item in clbNotas.CheckedItems)
            {
                itemsMarcados.Add(item.ToString());
            }

            // Leer todas las líneas del fichero
            var lineas = File.ReadAllLines(fichero);
            var nuevasLineas = new List<string>();

            foreach (var linea in lineas)
            {
                string[] partes = linea.Split('#');
                if (partes.Length == 2)
                {
                    string nombre = partes[0];
                    string nota = partes[1];
                    string formatoLista = $"{nombre}\t\t{nota}";

                    // Si el registro NO está marcado, lo conservamos
                    if (!itemsMarcados.Contains(formatoLista))
                    {
                        nuevasLineas.Add(linea);
                    }
                }
                else
                {
                    // Si la línea no tiene el formato esperado, la conservamos
                    nuevasLineas.Add(linea);
                }
            }

            // Sobrescribir el fichero con las líneas no marcadas
            File.WriteAllLines(fichero, nuevasLineas);

            // Recargar el CheckedListBox para reflejar los cambios
            btnCargarChecklist_Click(sender, e);            

            MessageBox.Show("Registros marcados eliminados correctamente.");
        }
    }
}
