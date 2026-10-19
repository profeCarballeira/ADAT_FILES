namespace _05_FicheroRegistroCampos
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
            panel1 = new Panel();
            btnModificarGuardar = new Button();
            btnGuardarNota = new Button();
            numNota = new NumericUpDown();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lstNotas = new ListBox();
            btnNotas = new Button();
            btnMejorNota = new Button();
            lblMejorNota = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNota).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnModificarGuardar);
            panel1.Controls.Add(btnGuardarNota);
            panel1.Controls.Add(numNota);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(45, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 198);
            panel1.TabIndex = 0;
            // 
            // btnModificarGuardar
            // 
            btnModificarGuardar.Location = new Point(228, 89);
            btnModificarGuardar.Name = "btnModificarGuardar";
            btnModificarGuardar.Size = new Size(163, 45);
            btnModificarGuardar.TabIndex = 6;
            btnModificarGuardar.Text = "Guardar/Modificar";
            btnModificarGuardar.UseVisualStyleBackColor = true;
            btnModificarGuardar.Click += btnModificarGuardar_Click;
            // 
            // btnGuardarNota
            // 
            btnGuardarNota.Location = new Point(306, 26);
            btnGuardarNota.Name = "btnGuardarNota";
            btnGuardarNota.Size = new Size(85, 45);
            btnGuardarNota.TabIndex = 5;
            btnGuardarNota.Text = "Guardar";
            btnGuardarNota.UseVisualStyleBackColor = true;
            btnGuardarNota.Click += btnGuardarNota_Click;
            // 
            // numNota
            // 
            numNota.Location = new Point(132, 97);
            numNota.Name = "numNota";
            numNota.Size = new Size(73, 31);
            numNota.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(132, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 99);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 2;
            label2.Text = "Nota:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 36);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lstNotas);
            panel2.Controls.Add(btnNotas);
            panel2.Location = new Point(45, 260);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 483);
            panel2.TabIndex = 1;
            // 
            // lstNotas
            // 
            lstNotas.FormattingEnabled = true;
            lstNotas.Location = new Point(31, 99);
            lstNotas.Name = "lstNotas";
            lstNotas.Size = new Size(344, 354);
            lstNotas.TabIndex = 8;
            // 
            // btnNotas
            // 
            btnNotas.FlatStyle = FlatStyle.Flat;
            btnNotas.Location = new Point(145, 17);
            btnNotas.Name = "btnNotas";
            btnNotas.Size = new Size(85, 45);
            btnNotas.TabIndex = 7;
            btnNotas.Text = "Listar";
            btnNotas.UseVisualStyleBackColor = true;
            btnNotas.Click += btnNotas_Click;
            // 
            // btnMejorNota
            // 
            btnMejorNota.Location = new Point(47, 789);
            btnMejorNota.Name = "btnMejorNota";
            btnMejorNota.Size = new Size(112, 34);
            btnMejorNota.TabIndex = 2;
            btnMejorNota.Text = "Mejor Nota";
            btnMejorNota.UseVisualStyleBackColor = true;
            btnMejorNota.Click += btnMejorNota_Click;
            // 
            // lblMejorNota
            // 
            lblMejorNota.AutoSize = true;
            lblMejorNota.Location = new Point(235, 798);
            lblMejorNota.Name = "lblMejorNota";
            lblMejorNota.Size = new Size(0, 25);
            lblMejorNota.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 864);
            Controls.Add(lblMejorNota);
            Controls.Add(btnMejorNota);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNota).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnGuardarNota;
        private NumericUpDown numNota;
        private TextBox txtNombre;
        private Button btnModificarGuardar;
        private Panel panel2;
        private ListBox lstNotas;
        private Button btnNotas;
        private Button btnMejorNota;
        private Label lblMejorNota;
    }
}
