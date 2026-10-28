namespace _07_JSON
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
            btnLeerJSONlocal = new Button();
            lblPersona = new Label();
            btnGrabarJSON = new Button();
            groupBox1 = new GroupBox();
            lblListadoPersonas = new Label();
            btnLeerListaPersonas = new Button();
            btnAddPersona = new Button();
            txtProfesion = new TextBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLeerJSONlocal
            // 
            btnLeerJSONlocal.Location = new Point(24, 20);
            btnLeerJSONlocal.Margin = new Padding(2, 2, 2, 2);
            btnLeerJSONlocal.Name = "btnLeerJSONlocal";
            btnLeerJSONlocal.Size = new Size(147, 25);
            btnLeerJSONlocal.TabIndex = 0;
            btnLeerJSONlocal.Text = "Deserializar";
            btnLeerJSONlocal.UseVisualStyleBackColor = true;
            btnLeerJSONlocal.Click += btnLeerJSONlocal_Click;
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Location = new Point(191, 28);
            lblPersona.Margin = new Padding(2, 0, 2, 0);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(38, 15);
            lblPersona.TabIndex = 1;
            lblPersona.Text = "label1";
            lblPersona.Click += lblPersona_Click;
            // 
            // btnGrabarJSON
            // 
            btnGrabarJSON.Location = new Point(272, 23);
            btnGrabarJSON.Margin = new Padding(2, 2, 2, 2);
            btnGrabarJSON.Name = "btnGrabarJSON";
            btnGrabarJSON.Size = new Size(218, 25);
            btnGrabarJSON.TabIndex = 2;
            btnGrabarJSON.Text = "Serializar Grabar";
            btnGrabarJSON.UseVisualStyleBackColor = true;
            btnGrabarJSON.Click += btnGrabarJSON_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblListadoPersonas);
            groupBox1.Controls.Add(btnLeerListaPersonas);
            groupBox1.Controls.Add(btnAddPersona);
            groupBox1.Controls.Add(txtProfesion);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 74);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(491, 298);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "lista de objeto JSON";

            // 
            // lblListadoPersonas
            // 
            lblListadoPersonas.AutoSize = true;
            lblListadoPersonas.Location = new Point(24, 120);
            lblListadoPersonas.Margin = new Padding(2, 0, 2, 0);
            lblListadoPersonas.Name = "lblListadoPersonas";
            lblListadoPersonas.Size = new Size(38, 15);
            lblListadoPersonas.TabIndex = 8;
            lblListadoPersonas.Text = "label1";
            lblListadoPersonas.Click += label4_Click;
            // 
            // btnLeerListaPersonas
            // 
            btnLeerListaPersonas.Location = new Point(288, 77);
            btnLeerListaPersonas.Margin = new Padding(2, 2, 2, 2);
            btnLeerListaPersonas.Name = "btnLeerListaPersonas";
            btnLeerListaPersonas.Size = new Size(160, 25);
            btnLeerListaPersonas.TabIndex = 7;
            btnLeerListaPersonas.Text = "Leer Lista";
            btnLeerListaPersonas.UseVisualStyleBackColor = true;
            btnLeerListaPersonas.Click += btnLeerListaPersonas_Click;
            // 
            // btnAddPersona
            // 
            btnAddPersona.Location = new Point(288, 43);
            btnAddPersona.Margin = new Padding(2, 2, 2, 2);
            btnAddPersona.Name = "btnAddPersona";
            btnAddPersona.Size = new Size(160, 25);
            btnAddPersona.TabIndex = 6;
            btnAddPersona.Text = "Añadir Persona";
            btnAddPersona.UseVisualStyleBackColor = true;
            btnAddPersona.Click += btnAddPersona_Click;
            // 
            // txtProfesion
            // 
            txtProfesion.Location = new Point(98, 77);
            txtProfesion.Margin = new Padding(2, 2, 2, 2);
            txtProfesion.Name = "txtProfesion";
            txtProfesion.Size = new Size(106, 23);
            txtProfesion.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(98, 49);
            txtEdad.Margin = new Padding(2, 2, 2, 2);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(106, 23);
            txtEdad.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 25);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(106, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 77);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Profesión:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 53);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Edad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 492);
            Controls.Add(groupBox1);
            Controls.Add(btnGrabarJSON);
            Controls.Add(lblPersona);
            Controls.Add(btnLeerJSONlocal);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeerJSONlocal;
        private Label lblPersona;
        private Button btnGrabarJSON;
        private GroupBox groupBox1;
        private Button btnAddPersona;
        private TextBox txtProfesion;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLeerListaPersonas;
        private Label lblListadoPersonas;
    }
}
