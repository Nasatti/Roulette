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
            this.btn_avvia = new System.Windows.Forms.Button();
            this.label_t = new System.Windows.Forms.Label();
            this.label_timer = new System.Windows.Forms.Label();
            this.panel_nestratto = new System.Windows.Forms.Panel();
            this.label_n = new System.Windows.Forms.Label();
            this.label_nestratto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p_number)).BeginInit();
            this.panel_nestratto.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_palla
            // 
            this.timer_palla.Interval = 50;
            this.timer_palla.Tick += new System.EventHandler(this.timer_palla_Tick);
            // 
            // timer_avvio
            // 
            this.timer_avvio.Interval = 1000;
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
            this.p_number.Location = new System.Drawing.Point(179, 164);
            this.p_number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // btn_avvia
            // 
            this.btn_avvia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_avvia.BackColor = System.Drawing.Color.Black;
            this.btn_avvia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_avvia.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_avvia.ForeColor = System.Drawing.Color.Gold;
            this.btn_avvia.Location = new System.Drawing.Point(527, 578);
            this.btn_avvia.Margin = new System.Windows.Forms.Padding(4);
            this.btn_avvia.Name = "btn_avvia";
            this.btn_avvia.Size = new System.Drawing.Size(116, 34);
            this.btn_avvia.TabIndex = 10;
            this.btn_avvia.Text = "AVVIA";
            this.btn_avvia.UseVisualStyleBackColor = false;
            this.btn_avvia.Click += new System.EventHandler(this.btn_avvia_Click);
            // 
            // label_t
            // 
            this.label_t.AutoSize = true;
            this.label_t.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_t.ForeColor = System.Drawing.Color.White;
            this.label_t.Location = new System.Drawing.Point(13, 9);
            this.label_t.Name = "label_t";
            this.label_t.Size = new System.Drawing.Size(128, 20);
            this.label_t.TabIndex = 11;
            this.label_t.Text = "Prossimo turno:";
            this.label_t.Visible = false;
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.ForeColor = System.Drawing.Color.White;
            this.label_timer.Location = new System.Drawing.Point(13, 34);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(90, 20);
            this.label_timer.TabIndex = 12;
            this.label_timer.Text = "20 secondi";
            this.label_timer.Visible = false;
            // 
            // panel_nestratto
            // 
            this.panel_nestratto.Controls.Add(this.label_n);
            this.panel_nestratto.Location = new System.Drawing.Point(573, 27);
            this.panel_nestratto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_nestratto.Name = "panel_nestratto";
            this.panel_nestratto.Size = new System.Drawing.Size(71, 63);
            this.panel_nestratto.TabIndex = 13;
            this.panel_nestratto.Visible = false;
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.BackColor = System.Drawing.Color.Transparent;
            this.label_n.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_n.ForeColor = System.Drawing.Color.White;
            this.label_n.Location = new System.Drawing.Point(11, 15);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(42, 31);
            this.label_n.TabIndex = 15;
            this.label_n.Text = "11";
            // 
            // label_nestratto
            // 
            this.label_nestratto.AutoSize = true;
            this.label_nestratto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nestratto.ForeColor = System.Drawing.Color.White;
            this.label_nestratto.Location = new System.Drawing.Point(459, 5);
            this.label_nestratto.Name = "label_nestratto";
            this.label_nestratto.Size = new System.Drawing.Size(185, 20);
            this.label_nestratto.TabIndex = 14;
            this.label_nestratto.Text = "Ultimo numero estratto:";
            this.label_nestratto.Visible = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 624);
            this.Controls.Add(this.label_nestratto);
            this.Controls.Add(this.panel_nestratto);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.label_t);
            this.Controls.Add(this.btn_avvia);
            this.Controls.Add(this.num);
            this.Controls.Add(this.p_number);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(674, 671);
            this.MinimumSize = new System.Drawing.Size(674, 671);
            this.Name = "Server";
            this.Text = "Server";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Server_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Server_Paint);
            this.Resize += new System.EventHandler(this.Server_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.p_number)).EndInit();
            this.panel_nestratto.ResumeLayout(false);
            this.panel_nestratto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_palla;
        private System.Windows.Forms.Timer timer_avvio;
        private System.Windows.Forms.Label num;
        private System.Windows.Forms.PictureBox p_number;
        private System.Windows.Forms.ImageList color;
        private System.Windows.Forms.Button btn_avvia;
        private System.Windows.Forms.Label label_t;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Panel panel_nestratto;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.Label label_nestratto;
    }
}

