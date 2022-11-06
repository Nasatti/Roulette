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
            this.timer_velocità = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_palla
            // 
            this.timer_palla.Enabled = true;
            this.timer_palla.Interval = 50;
            this.timer_palla.Tick += new System.EventHandler(this.timer_palla_Tick);
            // 
            // timer_velocità
            // 
            this.timer_velocità.Enabled = true;
            this.timer_velocità.Interval = 3000;
            this.timer_velocità.Tick += new System.EventHandler(this.timer_velocità_Tick);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 628);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(675, 675);
            this.MinimumSize = new System.Drawing.Size(675, 675);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Server_Paint);
            this.Resize += new System.EventHandler(this.Server_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_palla;
        private System.Windows.Forms.Timer timer_velocità;
    }
}

