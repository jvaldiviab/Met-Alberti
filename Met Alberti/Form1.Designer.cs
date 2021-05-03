
namespace Met_Alberti
{
    partial class FrmAlberti
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDescifrar = new System.Windows.Forms.Button();
            this.btnCifrado = new System.Windows.Forms.Button();
            this.nudSust = new System.Windows.Forms.NumericUpDown();
            this.nudCantPos = new System.Windows.Forms.NumericUpDown();
            this.cmbGiro = new System.Windows.Forms.ComboBox();
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.txtMcla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radCparametros = new System.Windows.Forms.RadioButton();
            this.radSparametros = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCripto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDescifrar);
            this.groupBox1.Controls.Add(this.btnCifrado);
            this.groupBox1.Controls.Add(this.nudSust);
            this.groupBox1.Controls.Add(this.nudCantPos);
            this.groupBox1.Controls.Add(this.cmbGiro);
            this.groupBox1.Controls.Add(this.txtLlave);
            this.groupBox1.Controls.Add(this.txtMcla);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENTRADA";
            // 
            // btnDescifrar
            // 
            this.btnDescifrar.Location = new System.Drawing.Point(350, 167);
            this.btnDescifrar.Name = "btnDescifrar";
            this.btnDescifrar.Size = new System.Drawing.Size(75, 23);
            this.btnDescifrar.TabIndex = 12;
            this.btnDescifrar.Text = "Descifrar";
            this.btnDescifrar.UseVisualStyleBackColor = true;
            this.btnDescifrar.Click += new System.EventHandler(this.btnDescifrar_Click);
            // 
            // btnCifrado
            // 
            this.btnCifrado.Location = new System.Drawing.Point(174, 167);
            this.btnCifrado.Name = "btnCifrado";
            this.btnCifrado.Size = new System.Drawing.Size(75, 23);
            this.btnCifrado.TabIndex = 11;
            this.btnCifrado.Text = "Cifrar";
            this.btnCifrado.UseVisualStyleBackColor = true;
            this.btnCifrado.Click += new System.EventHandler(this.btnCifrado_Click);
            // 
            // nudSust
            // 
            this.nudSust.Location = new System.Drawing.Point(350, 75);
            this.nudSust.Name = "nudSust";
            this.nudSust.Size = new System.Drawing.Size(47, 23);
            this.nudSust.TabIndex = 10;
            // 
            // nudCantPos
            // 
            this.nudCantPos.Location = new System.Drawing.Point(165, 111);
            this.nudCantPos.Name = "nudCantPos";
            this.nudCantPos.Size = new System.Drawing.Size(42, 23);
            this.nudCantPos.TabIndex = 9;
            // 
            // cmbGiro
            // 
            this.cmbGiro.FormattingEnabled = true;
            this.cmbGiro.Location = new System.Drawing.Point(313, 111);
            this.cmbGiro.Name = "cmbGiro";
            this.cmbGiro.Size = new System.Drawing.Size(121, 23);
            this.cmbGiro.TabIndex = 8;
            // 
            // txtLlave
            // 
            this.txtLlave.Location = new System.Drawing.Point(104, 75);
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(145, 23);
            this.txtLlave.TabIndex = 7;
            // 
            // txtMcla
            // 
            this.txtMcla.Location = new System.Drawing.Point(165, 41);
            this.txtMcla.Name = "txtMcla";
            this.txtMcla.Size = new System.Drawing.Size(323, 23);
            this.txtMcla.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sustituciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cant. Posiciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Llave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mensaje en Claro: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radCparametros);
            this.groupBox3.Controls.Add(this.radSparametros);
            this.groupBox3.Location = new System.Drawing.Point(555, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 108);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TIPO DE CIFRADO";
            // 
            // radCparametros
            // 
            this.radCparametros.AutoSize = true;
            this.radCparametros.Location = new System.Drawing.Point(22, 70);
            this.radCparametros.Name = "radCparametros";
            this.radCparametros.Size = new System.Drawing.Size(128, 19);
            this.radCparametros.TabIndex = 1;
            this.radCparametros.TabStop = true;
            this.radCparametros.Text = "CON PARÁMETROS";
            this.radCparametros.UseVisualStyleBackColor = true;
            this.radCparametros.CheckedChanged += new System.EventHandler(this.radCparametros_CheckedChanged);
            // 
            // radSparametros
            // 
            this.radSparametros.AutoSize = true;
            this.radSparametros.Location = new System.Drawing.Point(22, 29);
            this.radSparametros.Name = "radSparametros";
            this.radSparametros.Size = new System.Drawing.Size(120, 19);
            this.radSparametros.TabIndex = 0;
            this.radSparametros.TabStop = true;
            this.radSparametros.Text = "SIN PARÁMETROS";
            this.radSparametros.UseVisualStyleBackColor = true;
            this.radSparametros.CheckedChanged += new System.EventHandler(this.radSparametros_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCripto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(27, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SALIDA";
            // 
            // txtCripto
            // 
            this.txtCripto.Location = new System.Drawing.Point(136, 56);
            this.txtCripto.Name = "txtCripto";
            this.txtCripto.Size = new System.Drawing.Size(352, 23);
            this.txtCripto.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Criptograma";
            // 
            // lblLimpiar
            // 
            this.lblLimpiar.Location = new System.Drawing.Point(324, 395);
            this.lblLimpiar.Name = "lblLimpiar";
            this.lblLimpiar.Size = new System.Drawing.Size(75, 23);
            this.lblLimpiar.TabIndex = 2;
            this.lblLimpiar.Text = "Limpiar";
            this.lblLimpiar.UseVisualStyleBackColor = true;
            this.lblLimpiar.Click += new System.EventHandler(this.lblLimpiar_Click);
            // 
            // FrmAlberti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAlberti";
            this.Text = "Metodo Alberti";
            this.Load += new System.EventHandler(this.FrmAlberti_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantPos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radCparametros;
        private System.Windows.Forms.RadioButton radSparametros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLlave;
        private System.Windows.Forms.TextBox txtMcla;
        private System.Windows.Forms.TextBox txtCripto;
        private System.Windows.Forms.NumericUpDown nudSust;
        private System.Windows.Forms.NumericUpDown nudCantPos;
        private System.Windows.Forms.ComboBox cmbGiro;
        private System.Windows.Forms.Button btnDescifrar;
        private System.Windows.Forms.Button btnCifrado;
        private System.Windows.Forms.Button lblLimpiar;
    }
}

