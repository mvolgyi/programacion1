namespace TPnumero6
{
    partial class FormularioPrincipal
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
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonTope = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.listBoxAlumnos = new System.Windows.Forms.ListBox();
            this.textBoxCarga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFormulario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(40, 222);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(75, 23);
            this.buttonCargar.TabIndex = 0;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(299, 222);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 1;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonTope
            // 
            this.buttonTope.Location = new System.Drawing.Point(40, 314);
            this.buttonTope.Name = "buttonTope";
            this.buttonTope.Size = new System.Drawing.Size(75, 23);
            this.buttonTope.TabIndex = 2;
            this.buttonTope.Text = "Tope";
            this.buttonTope.UseVisualStyleBackColor = true;
            this.buttonTope.Click += new System.EventHandler(this.buttonTope_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(299, 314);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // listBoxAlumnos
            // 
            this.listBoxAlumnos.FormattingEnabled = true;
            this.listBoxAlumnos.Location = new System.Drawing.Point(40, 71);
            this.listBoxAlumnos.Name = "listBoxAlumnos";
            this.listBoxAlumnos.Size = new System.Drawing.Size(334, 121);
            this.listBoxAlumnos.TabIndex = 4;
            this.listBoxAlumnos.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // textBoxCarga
            // 
            this.textBoxCarga.Location = new System.Drawing.Point(190, 30);
            this.textBoxCarga.Name = "textBoxCarga";
            this.textBoxCarga.Size = new System.Drawing.Size(184, 20);
            this.textBoxCarga.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese un nombre";
            // 
            // buttonFormulario
            // 
            this.buttonFormulario.Location = new System.Drawing.Point(168, 262);
            this.buttonFormulario.Name = "buttonFormulario";
            this.buttonFormulario.Size = new System.Drawing.Size(75, 23);
            this.buttonFormulario.TabIndex = 7;
            this.buttonFormulario.Text = "Formulario";
            this.buttonFormulario.UseVisualStyleBackColor = true;
            this.buttonFormulario.Click += new System.EventHandler(this.buttonFormulario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 383);
            this.Controls.Add(this.buttonFormulario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCarga);
            this.Controls.Add(this.listBoxAlumnos);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonTope);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonTope;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.ListBox listBoxAlumnos;
        private System.Windows.Forms.TextBox textBoxCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFormulario;
    }
}

