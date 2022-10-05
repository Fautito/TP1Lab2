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
            this.NudRatones = new System.Windows.Forms.NumericUpDown();
            this.NudGatos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRatones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudGatos)).BeginInit();
            this.SuspendLayout();
            // 
            // NudX
            // 
            this.NudX.Location = new System.Drawing.Point(81, 23);
            this.NudX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudX.Name = "NudX";
            this.NudX.Size = new System.Drawing.Size(79, 20);
            this.NudX.TabIndex = 0;
            this.NudX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // NudY
            // 
            this.NudY.Location = new System.Drawing.Point(81, 67);
            this.NudY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudY.Name = "NudY";
            this.NudY.Size = new System.Drawing.Size(79, 20);
            this.NudY.TabIndex = 1;
            this.NudY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
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
            // NudRatones
            // 
            this.NudRatones.Location = new System.Drawing.Point(81, 113);
            this.NudRatones.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NudRatones.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudRatones.Name = "NudRatones";
            this.NudRatones.Size = new System.Drawing.Size(79, 20);
            this.NudRatones.TabIndex = 1;
            this.NudRatones.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // NudGatos
            // 
            this.NudGatos.Location = new System.Drawing.Point(81, 157);
            this.NudGatos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NudGatos.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NudGatos.Name = "NudGatos";
            this.NudGatos.Size = new System.Drawing.Size(79, 20);
            this.NudGatos.TabIndex = 1;
            this.NudGatos.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tamaño X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamaño Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ratones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gatos";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(180, 160);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Depredadores";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 208);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.NudGatos);
            this.Controls.Add(this.NudRatones);
            this.Controls.Add(this.NudY);
            this.Controls.Add(this.NudX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRatones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudGatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NudX;
        private System.Windows.Forms.NumericUpDown NudY;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.NumericUpDown NudRatones;
        private System.Windows.Forms.NumericUpDown NudGatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

