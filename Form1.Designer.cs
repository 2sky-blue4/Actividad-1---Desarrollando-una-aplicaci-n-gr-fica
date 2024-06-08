namespace WindowsForms_Sueldo_Neto
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDescuentosSFS = new System.Windows.Forms.Label();
            this.labelTotalDescuentos = new System.Windows.Forms.Label();
            this.labelSueldoNeto = new System.Windows.Forms.Label();
            this.txt_descuento_sfs = new System.Windows.Forms.TextBox();
            this.txt_total_descuento = new System.Windows.Forms.TextBox();
            this.txt_sueldo_neto = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_sueldo_bruto = new System.Windows.Forms.TextBox();
            this.txt_descuento_afp = new System.Windows.Forms.TextBox();
            this.labelSueldoBruto = new System.Windows.Forms.Label();
            this.labelDescuentosAFP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxSueldoBase = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.numericUpDownHijos = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHijos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(187, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sueldo Neto de un empleado";
            // 
            // labelDescuentosSFS
            // 
            this.labelDescuentosSFS.AutoSize = true;
            this.labelDescuentosSFS.BackColor = System.Drawing.Color.Transparent;
            this.labelDescuentosSFS.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescuentosSFS.ForeColor = System.Drawing.Color.White;
            this.labelDescuentosSFS.Location = new System.Drawing.Point(32, 367);
            this.labelDescuentosSFS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDescuentosSFS.Name = "labelDescuentosSFS";
            this.labelDescuentosSFS.Size = new System.Drawing.Size(188, 31);
            this.labelDescuentosSFS.TabIndex = 3;
            this.labelDescuentosSFS.Text = "Descuento SFS";
            // 
            // labelTotalDescuentos
            // 
            this.labelTotalDescuentos.AutoSize = true;
            this.labelTotalDescuentos.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalDescuentos.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDescuentos.ForeColor = System.Drawing.Color.White;
            this.labelTotalDescuentos.Location = new System.Drawing.Point(27, 427);
            this.labelTotalDescuentos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTotalDescuentos.Name = "labelTotalDescuentos";
            this.labelTotalDescuentos.Size = new System.Drawing.Size(213, 31);
            this.labelTotalDescuentos.TabIndex = 4;
            this.labelTotalDescuentos.Text = "Total Descuentos";
            // 
            // labelSueldoNeto
            // 
            this.labelSueldoNeto.AutoSize = true;
            this.labelSueldoNeto.BackColor = System.Drawing.Color.Transparent;
            this.labelSueldoNeto.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSueldoNeto.ForeColor = System.Drawing.Color.White;
            this.labelSueldoNeto.Location = new System.Drawing.Point(27, 480);
            this.labelSueldoNeto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSueldoNeto.Name = "labelSueldoNeto";
            this.labelSueldoNeto.Size = new System.Drawing.Size(155, 31);
            this.labelSueldoNeto.TabIndex = 5;
            this.labelSueldoNeto.Text = "Sueldo Neto";
            // 
            // txt_descuento_sfs
            // 
            this.txt_descuento_sfs.Location = new System.Drawing.Point(265, 323);
            this.txt_descuento_sfs.Margin = new System.Windows.Forms.Padding(5);
            this.txt_descuento_sfs.Name = "txt_descuento_sfs";
            this.txt_descuento_sfs.Size = new System.Drawing.Size(207, 29);
            this.txt_descuento_sfs.TabIndex = 8;
            // 
            // txt_total_descuento
            // 
            this.txt_total_descuento.Location = new System.Drawing.Point(265, 383);
            this.txt_total_descuento.Margin = new System.Windows.Forms.Padding(5);
            this.txt_total_descuento.Name = "txt_total_descuento";
            this.txt_total_descuento.Size = new System.Drawing.Size(207, 29);
            this.txt_total_descuento.TabIndex = 9;
            // 
            // txt_sueldo_neto
            // 
            this.txt_sueldo_neto.Location = new System.Drawing.Point(265, 436);
            this.txt_sueldo_neto.Margin = new System.Windows.Forms.Padding(5);
            this.txt_sueldo_neto.Name = "txt_sueldo_neto";
            this.txt_sueldo_neto.Size = new System.Drawing.Size(207, 29);
            this.txt_sueldo_neto.TabIndex = 10;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(5, 144);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(191, 39);
            this.buttonCalcular.TabIndex = 11;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(5, 255);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(191, 39);
            this.btn_limpiar.TabIndex = 12;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(5, 397);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(5);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(191, 39);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_sueldo_bruto
            // 
            this.txt_sueldo_bruto.Location = new System.Drawing.Point(265, 216);
            this.txt_sueldo_bruto.Margin = new System.Windows.Forms.Padding(5);
            this.txt_sueldo_bruto.Name = "txt_sueldo_bruto";
            this.txt_sueldo_bruto.Size = new System.Drawing.Size(207, 29);
            this.txt_sueldo_bruto.TabIndex = 6;
            // 
            // txt_descuento_afp
            // 
            this.txt_descuento_afp.Location = new System.Drawing.Point(265, 266);
            this.txt_descuento_afp.Margin = new System.Windows.Forms.Padding(5);
            this.txt_descuento_afp.Name = "txt_descuento_afp";
            this.txt_descuento_afp.Size = new System.Drawing.Size(207, 29);
            this.txt_descuento_afp.TabIndex = 7;
            // 
            // labelSueldoBruto
            // 
            this.labelSueldoBruto.AutoSize = true;
            this.labelSueldoBruto.BackColor = System.Drawing.Color.Transparent;
            this.labelSueldoBruto.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSueldoBruto.ForeColor = System.Drawing.Color.White;
            this.labelSueldoBruto.Location = new System.Drawing.Point(33, 255);
            this.labelSueldoBruto.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSueldoBruto.Name = "labelSueldoBruto";
            this.labelSueldoBruto.Size = new System.Drawing.Size(165, 31);
            this.labelSueldoBruto.TabIndex = 1;
            this.labelSueldoBruto.Text = "Sueldo bruto";
            this.labelSueldoBruto.Click += new System.EventHandler(this.labelSueldoBruto_Click);
            // 
            // labelDescuentosAFP
            // 
            this.labelDescuentosAFP.AutoSize = true;
            this.labelDescuentosAFP.BackColor = System.Drawing.Color.Transparent;
            this.labelDescuentosAFP.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescuentosAFP.ForeColor = System.Drawing.Color.White;
            this.labelDescuentosAFP.Location = new System.Drawing.Point(32, 310);
            this.labelDescuentosAFP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelDescuentosAFP.Name = "labelDescuentosAFP";
            this.labelDescuentosAFP.Size = new System.Drawing.Size(193, 31);
            this.labelDescuentosAFP.TabIndex = 2;
            this.labelDescuentosAFP.Text = "Descuento AFP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sueldo Base";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(33, 200);
            this.label.MinimumSize = new System.Drawing.Size(10, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(207, 31);
            this.label.TabIndex = 15;
            this.label.Tag = "Value";
            this.label.Text = "Numero de hijos";
            this.toolTip1.SetToolTip(this.label, "Value");
            // 
            // textBoxSueldoBase
            // 
            this.textBoxSueldoBase.Location = new System.Drawing.Point(265, 94);
            this.textBoxSueldoBase.Name = "textBoxSueldoBase";
            this.textBoxSueldoBase.Size = new System.Drawing.Size(143, 29);
            this.textBoxSueldoBase.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // numericUpDownHijos
            // 
            this.numericUpDownHijos.Location = new System.Drawing.Point(265, 162);
            this.numericUpDownHijos.Name = "numericUpDownHijos";
            this.numericUpDownHijos.Size = new System.Drawing.Size(163, 29);
            this.numericUpDownHijos.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.labelSueldoBruto);
            this.panel1.Controls.Add(this.labelDescuentosAFP);
            this.panel1.Controls.Add(this.labelDescuentosSFS);
            this.panel1.Controls.Add(this.labelTotalDescuentos);
            this.panel1.Controls.Add(this.labelSueldoNeto);
            this.panel1.Location = new System.Drawing.Point(-18, -44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 588);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.buttonCalcular);
            this.panel2.Controls.Add(this.btn_limpiar);
            this.panel2.Controls.Add(this.btn_salir);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(560, -14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 611);
            this.panel2.TabIndex = 21;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-15, -21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 79);
            this.panel3.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 506);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numericUpDownHijos);
            this.Controls.Add(this.textBoxSueldoBase);
            this.Controls.Add(this.txt_sueldo_neto);
            this.Controls.Add(this.txt_total_descuento);
            this.Controls.Add(this.txt_descuento_sfs);
            this.Controls.Add(this.txt_descuento_afp);
            this.Controls.Add(this.txt_sueldo_bruto);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHijos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDescuentosSFS;
        private System.Windows.Forms.Label labelTotalDescuentos;
        private System.Windows.Forms.Label labelSueldoNeto;
        private System.Windows.Forms.TextBox txt_descuento_sfs;
        private System.Windows.Forms.TextBox txt_total_descuento;
        private System.Windows.Forms.TextBox txt_sueldo_neto;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_sueldo_bruto;
        private System.Windows.Forms.TextBox txt_descuento_afp;
        private System.Windows.Forms.Label labelSueldoBruto;
        private System.Windows.Forms.Label labelDescuentosAFP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxSueldoBase;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown numericUpDownHijos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

