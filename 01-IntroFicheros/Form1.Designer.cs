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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 450);
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
    }
}
