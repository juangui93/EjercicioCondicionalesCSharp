namespace TallerCondicionales
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbxDescuentos = new System.Windows.Forms.PictureBox();
            this.pbxNotas = new System.Windows.Forms.PictureBox();
            this.pbxEdad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENÚ DE OPCIONES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dar click en la imagen para validar Edad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dar click en la imagen para validar Notas: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dar click en la imagen para validar Descuentos: ";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::TallerCondicionales.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(561, 186);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 110);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbxDescuentos
            // 
            this.pbxDescuentos.Image = global::TallerCondicionales.Properties.Resources.descuentos;
            this.pbxDescuentos.Location = new System.Drawing.Point(368, 350);
            this.pbxDescuentos.Name = "pbxDescuentos";
            this.pbxDescuentos.Size = new System.Drawing.Size(102, 90);
            this.pbxDescuentos.TabIndex = 8;
            this.pbxDescuentos.TabStop = false;
            this.pbxDescuentos.Click += new System.EventHandler(this.pbxDescuentos_Click);
            // 
            // pbxNotas
            // 
            this.pbxNotas.Image = global::TallerCondicionales.Properties.Resources.notas;
            this.pbxNotas.Location = new System.Drawing.Point(368, 206);
            this.pbxNotas.Name = "pbxNotas";
            this.pbxNotas.Size = new System.Drawing.Size(102, 90);
            this.pbxNotas.TabIndex = 7;
            this.pbxNotas.TabStop = false;
            this.pbxNotas.Click += new System.EventHandler(this.pbxNotas_Click);
            // 
            // pbxEdad
            // 
            this.pbxEdad.Image = global::TallerCondicionales.Properties.Resources.edad;
            this.pbxEdad.Location = new System.Drawing.Point(368, 68);
            this.pbxEdad.Name = "pbxEdad";
            this.pbxEdad.Size = new System.Drawing.Size(102, 90);
            this.pbxEdad.TabIndex = 6;
            this.pbxEdad.TabStop = false;
            this.pbxEdad.Click += new System.EventHandler(this.pbxEdad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 444);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbxDescuentos);
            this.Controls.Add(this.pbxNotas);
            this.Controls.Add(this.pbxEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Taller de Condicionales";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxEdad;
        private System.Windows.Forms.PictureBox pbxNotas;
        private System.Windows.Forms.PictureBox pbxDescuentos;
        private System.Windows.Forms.Button btnSalir;
    }
}

