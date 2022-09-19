namespace TP1Lab2FaustWaigandt
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
            this.NudX = new System.Windows.Forms.NumericUpDown();
            this.NudY = new System.Windows.Forms.NumericUpDown();
            this.bIniciar = new System.Windows.Forms.Button();
            this.NudQuesos = new System.Windows.Forms.NumericUpDown();
            this.NudRatones = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRatones)).BeginInit();
            this.SuspendLayout();
            // 
            // NudX
            // 
            this.NudX.Location = new System.Drawing.Point(48, 23);
            this.NudX.Name = "NudX";
            this.NudX.Size = new System.Drawing.Size(79, 20);
            this.NudX.TabIndex = 0;
            // 
            // NudY
            // 
            this.NudY.Location = new System.Drawing.Point(48, 67);
            this.NudY.Name = "NudY";
            this.NudY.Size = new System.Drawing.Size(79, 20);
            this.NudY.TabIndex = 1;
            // 
            // bIniciar
            // 
            this.bIniciar.Location = new System.Drawing.Point(180, 23);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(75, 23);
            this.bIniciar.TabIndex = 2;
            this.bIniciar.Text = "Iniciar";
            this.bIniciar.UseVisualStyleBackColor = true;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // NudQuesos
            // 
            this.NudQuesos.Location = new System.Drawing.Point(48, 116);
            this.NudQuesos.Name = "NudQuesos";
            this.NudQuesos.Size = new System.Drawing.Size(79, 20);
            this.NudQuesos.TabIndex = 1;
            // 
            // NudRatones
            // 
            this.NudRatones.Location = new System.Drawing.Point(48, 165);
            this.NudRatones.Name = "NudRatones";
            this.NudRatones.Size = new System.Drawing.Size(79, 20);
            this.NudRatones.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.NudRatones);
            this.Controls.Add(this.NudQuesos);
            this.Controls.Add(this.NudY);
            this.Controls.Add(this.NudX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRatones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NudX;
        private System.Windows.Forms.NumericUpDown NudY;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.NumericUpDown NudQuesos;
        private System.Windows.Forms.NumericUpDown NudRatones;
    }
}

