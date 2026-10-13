namespace _01_IntroFicheros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombreFichero = new TextBox();
            btnCrearFichro = new Button();
            btnCrearCarpeta = new Button();
            txtCarpeta = new TextBox();
            btnCrearFicheroEnCarpeta = new Button();
            btnMoverFicheroACarpeta = new Button();
            btnBorrarCarpeta = new Button();
            btnBorrarFichero = new Button();
            txtFicheroLeer = new TextBox();
            btnLeerFichero = new Button();
            txtLineas = new TextBox();
            groupBox1 = new GroupBox();
            btnInsertarLinea = new Button();
            label2 = new Label();
            label1 = new Label();
            txtLineaGrabar = new TextBox();
            txtFicheroGrabar = new TextBox();
            btnAnadirLinea = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreFichero
            // 
            txtNombreFichero.Location = new Point(27, 26);
            txtNombreFichero.Name = "txtNombreFichero";
            txtNombreFichero.Size = new Size(157, 23);
            txtNombreFichero.TabIndex = 0;
            // 
            // btnCrearFichro
            // 
            btnCrearFichro.Location = new Point(209, 25);
            btnCrearFichro.Name = "btnCrearFichro";
            btnCrearFichro.Size = new Size(126, 23);
            btnCrearFichro.TabIndex = 1;
            btnCrearFichro.Text = "crear Fichero";
            btnCrearFichro.UseVisualStyleBackColor = true;
            btnCrearFichro.Click += btnCrearFichro_Click;
            // 
            // btnCrearCarpeta
            // 
            btnCrearCarpeta.Location = new Point(209, 67);
            btnCrearCarpeta.Name = "btnCrearCarpeta";
            btnCrearCarpeta.Size = new Size(126, 23);
            btnCrearCarpeta.TabIndex = 3;
            btnCrearCarpeta.Text = "crear Carpeta";
            btnCrearCarpeta.UseVisualStyleBackColor = true;
            btnCrearCarpeta.Click += btnCrearCarpeta_Click;
            // 
            // txtCarpeta
            // 
            txtCarpeta.Location = new Point(27, 68);
            txtCarpeta.Name = "txtCarpeta";
            txtCarpeta.Size = new Size(157, 23);
            txtCarpeta.TabIndex = 2;
            // 
            // btnCrearFicheroEnCarpeta
            // 
            btnCrearFicheroEnCarpeta.Location = new Point(352, 45);
            btnCrearFicheroEnCarpeta.Name = "btnCrearFicheroEnCarpeta";
            btnCrearFicheroEnCarpeta.Size = new Size(186, 23);
            btnCrearFicheroEnCarpeta.TabIndex = 4;
            btnCrearFicheroEnCarpeta.Text = "crearFichero en Carpeta";
            btnCrearFicheroEnCarpeta.UseVisualStyleBackColor = true;
            btnCrearFicheroEnCarpeta.Click += btnCrearFicheroEnCarpeta_Click;
            // 
            // btnMoverFicheroACarpeta
            // 
            btnMoverFicheroACarpeta.Location = new Point(557, 45);
            btnMoverFicheroACarpeta.Name = "btnMoverFicheroACarpeta";
            btnMoverFicheroACarpeta.Size = new Size(186, 23);
            btnMoverFicheroACarpeta.TabIndex = 5;
            btnMoverFicheroACarpeta.Text = "mover fichero a Carpeta";
            btnMoverFicheroACarpeta.UseVisualStyleBackColor = true;
            btnMoverFicheroACarpeta.Click += btnMoverFicheroACarpeta_Click;
            // 
            // btnBorrarCarpeta
            // 
            btnBorrarCarpeta.Location = new Point(749, 68);
            btnBorrarCarpeta.Name = "btnBorrarCarpeta";
            btnBorrarCarpeta.Size = new Size(126, 23);
            btnBorrarCarpeta.TabIndex = 7;
            btnBorrarCarpeta.Text = "borrar Carpeta";
            btnBorrarCarpeta.UseVisualStyleBackColor = true;
            btnBorrarCarpeta.Click += btnBorrarCarpeta_Click;
            // 
            // btnBorrarFichero
            // 
            btnBorrarFichero.Location = new Point(749, 26);
            btnBorrarFichero.Name = "btnBorrarFichero";
            btnBorrarFichero.Size = new Size(126, 23);
            btnBorrarFichero.TabIndex = 6;
            btnBorrarFichero.Text = "borrar Fichero";
            btnBorrarFichero.UseVisualStyleBackColor = true;
            btnBorrarFichero.Click += btnBorrarFichero_Click;
            // 
            // txtFicheroLeer
            // 
            txtFicheroLeer.Location = new Point(27, 117);
            txtFicheroLeer.Name = "txtFicheroLeer";
            txtFicheroLeer.Size = new Size(157, 23);
            txtFicheroLeer.TabIndex = 8;
            // 
            // btnLeerFichero
            // 
            btnLeerFichero.Location = new Point(209, 117);
            btnLeerFichero.Name = "btnLeerFichero";
            btnLeerFichero.Size = new Size(126, 23);
            btnLeerFichero.TabIndex = 9;
            btnLeerFichero.Text = "Leer Fichero";
            btnLeerFichero.UseVisualStyleBackColor = true;
            btnLeerFichero.Click += btnLeerFichero_Click;
            // 
            // txtLineas
            // 
            txtLineas.Location = new Point(377, 118);
            txtLineas.Multiline = true;
            txtLineas.Name = "txtLineas";
            txtLineas.Size = new Size(196, 133);
            txtLineas.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAnadirLinea);
            groupBox1.Controls.Add(btnInsertarLinea);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLineaGrabar);
            groupBox1.Controls.Add(txtFicheroGrabar);
            groupBox1.Location = new Point(27, 276);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(698, 145);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "GrabarFichero";
            // 
            // btnInsertarLinea
            // 
            btnInsertarLinea.Location = new Point(309, 63);
            btnInsertarLinea.Name = "btnInsertarLinea";
            btnInsertarLinea.Size = new Size(126, 23);
            btnInsertarLinea.TabIndex = 4;
            btnInsertarLinea.Text = "Insertar Linea";
            btnInsertarLinea.UseVisualStyleBackColor = true;
            btnInsertarLinea.Click += btnInsertarLinea_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 88);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 3;
            label2.Text = "Linea a grabar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 43);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre de fichero:";
            // 
            // txtLineaGrabar
            // 
            txtLineaGrabar.Location = new Point(131, 80);
            txtLineaGrabar.Name = "txtLineaGrabar";
            txtLineaGrabar.Size = new Size(146, 23);
            txtLineaGrabar.TabIndex = 1;
            // 
            // txtFicheroGrabar
            // 
            txtFicheroGrabar.Location = new Point(137, 35);
            txtFicheroGrabar.Name = "txtFicheroGrabar";
            txtFicheroGrabar.Size = new Size(146, 23);
            txtFicheroGrabar.TabIndex = 0;
            // 
            // btnAnadirLinea
            // 
            btnAnadirLinea.Location = new Point(441, 63);
            btnAnadirLinea.Name = "btnAnadirLinea";
            btnAnadirLinea.Size = new Size(126, 23);
            btnAnadirLinea.TabIndex = 5;
            btnAnadirLinea.Text = "Añadir Linea";
            btnAnadirLinea.UseVisualStyleBackColor = true;
            btnAnadirLinea.Click += btnAnadirLinea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 450);
            Controls.Add(groupBox1);
            Controls.Add(txtLineas);
            Controls.Add(btnLeerFichero);
            Controls.Add(txtFicheroLeer);
            Controls.Add(btnBorrarCarpeta);
            Controls.Add(btnBorrarFichero);
            Controls.Add(btnMoverFicheroACarpeta);
            Controls.Add(btnCrearFicheroEnCarpeta);
            Controls.Add(btnCrearCarpeta);
            Controls.Add(txtCarpeta);
            Controls.Add(btnCrearFichro);
            Controls.Add(txtNombreFichero);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreFichero;
        private Button btnCrearFichro;
        private Button btnCrearCarpeta;
        private TextBox txtCarpeta;
        private Button btnCrearFicheroEnCarpeta;
        private Button btnMoverFicheroACarpeta;
        private Button btnBorrarCarpeta;
        private Button btnBorrarFichero;
        private TextBox txtFicheroLeer;
        private Button btnLeerFichero;
        private TextBox txtLineas;
        private GroupBox groupBox1;
        private Button btnInsertarLinea;
        private Label label2;
        private Label label1;
        private TextBox txtLineaGrabar;
        private TextBox txtFicheroGrabar;
        private Button btnAnadirLinea;
    }
}
