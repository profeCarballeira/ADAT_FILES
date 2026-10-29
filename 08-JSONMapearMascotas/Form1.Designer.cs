namespace _08_JSONMapearMascotas
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
            btnMapearMascotas = new Button();
            dgvMascotas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).BeginInit();
            SuspendLayout();
            // 
            // btnMapearMascotas
            // 
            btnMapearMascotas.Location = new Point(53, 24);
            btnMapearMascotas.Name = "btnMapearMascotas";
            btnMapearMascotas.Size = new Size(200, 58);
            btnMapearMascotas.TabIndex = 0;
            btnMapearMascotas.Text = "Cargar Mascotas";
            btnMapearMascotas.UseVisualStyleBackColor = true;
            btnMapearMascotas.Click += btnMapearMascotas_Click;
            // 
            // dgvMascotas
            // 
            dgvMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMascotas.Location = new Point(29, 177);
            dgvMascotas.Name = "dgvMascotas";
            dgvMascotas.RowHeadersWidth = 62;
            dgvMascotas.Size = new Size(640, 239);
            dgvMascotas.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMascotas);
            Controls.Add(btnMapearMascotas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMascotas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMapearMascotas;
        private DataGridView dgvMascotas;
    }
}
