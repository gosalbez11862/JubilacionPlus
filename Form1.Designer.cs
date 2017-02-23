namespace Trabajador
{
    partial class Trabajador
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
            this.BCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BJubilacion = new System.Windows.Forms.Button();
            this.TupDownEdad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TApellido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TupDownEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // BCrear
            // 
            this.BCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCrear.Location = new System.Drawing.Point(482, 18);
            this.BCrear.Name = "BCrear";
            this.BCrear.Size = new System.Drawing.Size(82, 38);
            this.BCrear.TabIndex = 0;
            this.BCrear.Text = "Crear";
            this.BCrear.UseVisualStyleBackColor = true;
            this.BCrear.Click += new System.EventHandler(this.BCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // TNombre
            // 
            this.TNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.Location = new System.Drawing.Point(107, 27);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(208, 29);
            this.TNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad";
            // 
            // BJubilacion
            // 
            this.BJubilacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BJubilacion.Location = new System.Drawing.Point(450, 74);
            this.BJubilacion.Name = "BJubilacion";
            this.BJubilacion.Size = new System.Drawing.Size(114, 38);
            this.BJubilacion.TabIndex = 5;
            this.BJubilacion.Text = "Jubiliacion";
            this.BJubilacion.UseVisualStyleBackColor = true;
            this.BJubilacion.Click += new System.EventHandler(this.BJubilacion_Click);
            // 
            // TupDownEdad
            // 
            this.TupDownEdad.Location = new System.Drawing.Point(74, 138);
            this.TupDownEdad.Name = "TupDownEdad";
            this.TupDownEdad.Size = new System.Drawing.Size(67, 20);
            this.TupDownEdad.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos";
            // 
            // TApellido
            // 
            this.TApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TApellido.Location = new System.Drawing.Point(107, 83);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(208, 29);
            this.TApellido.TabIndex = 8;
            // 
            // Trabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 196);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TupDownEdad);
            this.Controls.Add(this.BJubilacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCrear);
            this.Name = "Trabajador";
            this.Text = "Trabajador";
            ((System.ComponentModel.ISupportInitialize)(this.TupDownEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BJubilacion;
        private System.Windows.Forms.NumericUpDown TupDownEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TApellido;
    }
}

