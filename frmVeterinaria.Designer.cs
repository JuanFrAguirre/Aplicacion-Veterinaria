namespace ParcialProgHernan
{
    partial class frmVeterinaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.rdoMacho = new System.Windows.Forms.RadioButton();
            this.rdoHembra = new System.Windows.Forms.RadioButton();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPerros = new System.Windows.Forms.Label();
            this.lblGatos = new System.Windows.Forms.Label();
            this.lblAves = new System.Windows.Forms.Label();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.lblPromedioHembras = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Especie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(209, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 31);
            this.txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(209, 237);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(165, 31);
            this.txtPrecio.TabIndex = 5;
            // 
            // rdoMacho
            // 
            this.rdoMacho.AutoSize = true;
            this.rdoMacho.Location = new System.Drawing.Point(209, 131);
            this.rdoMacho.Name = "rdoMacho";
            this.rdoMacho.Size = new System.Drawing.Size(108, 29);
            this.rdoMacho.TabIndex = 3;
            this.rdoMacho.TabStop = true;
            this.rdoMacho.Text = "Macho";
            this.rdoMacho.UseVisualStyleBackColor = true;
            // 
            // rdoHembra
            // 
            this.rdoHembra.AutoSize = true;
            this.rdoHembra.Location = new System.Drawing.Point(209, 182);
            this.rdoHembra.Name = "rdoHembra";
            this.rdoHembra.Size = new System.Drawing.Size(118, 29);
            this.rdoHembra.TabIndex = 4;
            this.rdoHembra.TabStop = true;
            this.rdoHembra.Text = "Hembra";
            this.rdoHembra.UseVisualStyleBackColor = true;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Ave"});
            this.cboTipo.Location = new System.Drawing.Point(209, 76);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(165, 33);
            this.cboTipo.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(237, 323);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(265, 90);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Perros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gatos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Aves";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Ventas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Promedio Hembras";
            // 
            // lblPerros
            // 
            this.lblPerros.AutoSize = true;
            this.lblPerros.Location = new System.Drawing.Point(709, 32);
            this.lblPerros.Name = "lblPerros";
            this.lblPerros.Size = new System.Drawing.Size(19, 25);
            this.lblPerros.TabIndex = 0;
            this.lblPerros.Text = "-";
            // 
            // lblGatos
            // 
            this.lblGatos.AutoSize = true;
            this.lblGatos.Location = new System.Drawing.Point(709, 84);
            this.lblGatos.Name = "lblGatos";
            this.lblGatos.Size = new System.Drawing.Size(19, 25);
            this.lblGatos.TabIndex = 0;
            this.lblGatos.Text = "-";
            // 
            // lblAves
            // 
            this.lblAves.AutoSize = true;
            this.lblAves.Location = new System.Drawing.Point(709, 138);
            this.lblAves.Name = "lblAves";
            this.lblAves.Size = new System.Drawing.Size(19, 25);
            this.lblAves.TabIndex = 0;
            this.lblAves.Text = "-";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Location = new System.Drawing.Point(709, 189);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(19, 25);
            this.lblTotalVentas.TabIndex = 0;
            this.lblTotalVentas.Text = "-";
            // 
            // lblPromedioHembras
            // 
            this.lblPromedioHembras.AutoSize = true;
            this.lblPromedioHembras.Location = new System.Drawing.Point(709, 245);
            this.lblPromedioHembras.Name = "lblPromedioHembras";
            this.lblPromedioHembras.Size = new System.Drawing.Size(19, 25);
            this.lblPromedioHembras.TabIndex = 0;
            this.lblPromedioHembras.Text = "-";
            // 
            // frmVeterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.rdoHembra);
            this.Controls.Add(this.rdoMacho);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPromedioHembras);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalVentas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAves);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGatos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPerros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "frmVeterinaria";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton rdoMacho;
        private System.Windows.Forms.RadioButton rdoHembra;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPerros;
        private System.Windows.Forms.Label lblGatos;
        private System.Windows.Forms.Label lblAves;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.Label lblPromedioHembras;
    }
}

