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
            btnGuardarNota = new Button();
            numNota = new NumericUpDown();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnModificar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNota).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnModificar);
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
            // btnModificar
            // 
            btnModificar.Location = new Point(273, 89);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(118, 45);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 864);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNota).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnGuardarNota;
        private NumericUpDown numNota;
        private TextBox txtNombre;
        private Button btnModificar;
    }
}
