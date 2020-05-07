namespace ShowDialog
{
    partial class FrmPadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPadre));
            this.wmp_video = new AxWMPLib.AxWindowsMediaPlayer();
            this.lb_mensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_video)).BeginInit();
            this.SuspendLayout();
            // 
            // wmp_video
            // 
            this.wmp_video.Enabled = true;
            this.wmp_video.Location = new System.Drawing.Point(431, 12);
            this.wmp_video.Name = "wmp_video";
            this.wmp_video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_video.OcxState")));
            this.wmp_video.Size = new System.Drawing.Size(582, 351);
            this.wmp_video.TabIndex = 0;
            // 
            // lb_mensaje
            // 
            this.lb_mensaje.AutoSize = true;
            this.lb_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mensaje.Location = new System.Drawing.Point(536, 410);
            this.lb_mensaje.Name = "lb_mensaje";
            this.lb_mensaje.Size = new System.Drawing.Size(142, 24);
            this.lb_mensaje.TabIndex = 1;
            this.lb_mensaje.Text = "Mensaje default";
            // 
            // FrmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShowDialog.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 526);
            this.Controls.Add(this.lb_mensaje);
            this.Controls.Add(this.wmp_video);
            this.Name = "FrmPadre";
            this.Text = "FrmPadre";
            this.Load += new System.EventHandler(this.FrmPadre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmp_video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp_video;
        private System.Windows.Forms.Label lb_mensaje;
    }
}