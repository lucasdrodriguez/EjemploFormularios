namespace ShowDialog
{
    partial class FrmPrincipal
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
            this.gb_reutilizarForm = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_altaPeliculas = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_cargarNuevo = new System.Windows.Forms.Button();
            this.rtb_mostrarLista = new System.Windows.Forms.RichTextBox();
            this.gb_showDialog = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gb_reutilizarForm.SuspendLayout();
            this.gb_showDialog.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_reutilizarForm
            // 
            this.gb_reutilizarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_reutilizarForm.Controls.Add(this.richTextBox1);
            this.gb_reutilizarForm.Controls.Add(this.button2);
            this.gb_reutilizarForm.Controls.Add(this.bt_altaPeliculas);
            this.gb_reutilizarForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_reutilizarForm.Location = new System.Drawing.Point(3, 201);
            this.gb_reutilizarForm.Name = "gb_reutilizarForm";
            this.gb_reutilizarForm.Size = new System.Drawing.Size(447, 180);
            this.gb_reutilizarForm.TabIndex = 3;
            this.gb_reutilizarForm.TabStop = false;
            this.gb_reutilizarForm.Text = "2) Ejemplo Reutilizar Form";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modificar películas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_altaPeliculas
            // 
            this.bt_altaPeliculas.Location = new System.Drawing.Point(54, 47);
            this.bt_altaPeliculas.Name = "bt_altaPeliculas";
            this.bt_altaPeliculas.Size = new System.Drawing.Size(114, 23);
            this.bt_altaPeliculas.TabIndex = 0;
            this.bt_altaPeliculas.Text = "Alta Peliculas";
            this.bt_altaPeliculas.UseVisualStyleBackColor = true;
            this.bt_altaPeliculas.Click += new System.EventHandler(this.bt_altaPeliculas_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(191, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(250, 123);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // btn_cargarNuevo
            // 
            this.btn_cargarNuevo.Location = new System.Drawing.Point(66, 41);
            this.btn_cargarNuevo.Name = "btn_cargarNuevo";
            this.btn_cargarNuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_cargarNuevo.TabIndex = 0;
            this.btn_cargarNuevo.Text = "Agregar elemento";
            this.btn_cargarNuevo.UseVisualStyleBackColor = true;
            this.btn_cargarNuevo.Click += new System.EventHandler(this.btn_cargarNuevo_Click);
            // 
            // rtb_mostrarLista
            // 
            this.rtb_mostrarLista.Location = new System.Drawing.Point(191, 19);
            this.rtb_mostrarLista.Name = "rtb_mostrarLista";
            this.rtb_mostrarLista.Size = new System.Drawing.Size(250, 123);
            this.rtb_mostrarLista.TabIndex = 1;
            this.rtb_mostrarLista.Text = "";
            // 
            // gb_showDialog
            // 
            this.gb_showDialog.Controls.Add(this.rtb_mostrarLista);
            this.gb_showDialog.Controls.Add(this.btn_cargarNuevo);
            this.gb_showDialog.Location = new System.Drawing.Point(3, 12);
            this.gb_showDialog.Name = "gb_showDialog";
            this.gb_showDialog.Size = new System.Drawing.Size(447, 160);
            this.gb_showDialog.TabIndex = 2;
            this.gb_showDialog.TabStop = false;
            this.gb_showDialog.Text = "1) Ejemplo Show Dialog";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 184);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3) Ejemplo Heredar Form";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Form Padre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Form Hijo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_reutilizarForm);
            this.Controls.Add(this.gb_showDialog);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.gb_reutilizarForm.ResumeLayout(false);
            this.gb_showDialog.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_reutilizarForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_altaPeliculas;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_cargarNuevo;
        private System.Windows.Forms.RichTextBox rtb_mostrarLista;
        private System.Windows.Forms.GroupBox gb_showDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

