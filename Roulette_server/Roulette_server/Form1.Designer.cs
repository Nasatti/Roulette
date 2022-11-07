namespace Roulette_server
{
    partial class Server
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.timer_palla = new System.Windows.Forms.Timer(this.components);
            this.timer_avvio = new System.Windows.Forms.Timer(this.components);
            this.num = new System.Windows.Forms.Label();
            this.p_number = new System.Windows.Forms.PictureBox();
            this.color = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.p_number)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_palla
            // 
            this.timer_palla.Enabled = true;
            this.timer_palla.Interval = 50;
            this.timer_palla.Tick += new System.EventHandler(this.timer_palla_Tick);
            // 
            // timer_avvio
            // 
            this.timer_avvio.Interval = 3000;
            this.timer_avvio.Tick += new System.EventHandler(this.timer_velocità_Tick);
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.BackColor = System.Drawing.Color.Transparent;
            this.num.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.ForeColor = System.Drawing.Color.White;
            this.num.Location = new System.Drawing.Point(311, 278);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(42, 31);
            this.num.TabIndex = 0;
            this.num.Text = "11";
            this.num.Visible = false;
            // 
            // p_number
            // 
            this.p_number.BackColor = System.Drawing.Color.Transparent;
            this.p_number.Location = new System.Drawing.Point(178, 164);
            this.p_number.Name = "p_number";
            this.p_number.Size = new System.Drawing.Size(300, 300);
            this.p_number.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_number.TabIndex = 1;
            this.p_number.TabStop = false;
            this.p_number.Visible = false;
            // 
            // color
            // 
            this.color.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("color.ImageStream")));
            this.color.TransparentColor = System.Drawing.Color.Transparent;
            this.color.Images.SetKeyName(0, "red.png");
            this.color.Images.SetKeyName(1, "black1.png");
            this.color.Images.SetKeyName(2, "green.png");
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 628);
            this.Controls.Add(this.num);
            this.Controls.Add(this.p_number);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(675, 675);
            this.MinimumSize = new System.Drawing.Size(675, 675);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Server_Paint);
            this.Resize += new System.EventHandler(this.Server_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.p_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_palla;
        private System.Windows.Forms.Timer timer_avvio;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.PictureBox p_number;
        private System.Windows.Forms.ImageList color;
    }
}

