namespace Roulette
{
    partial class Ricarica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ricarica));
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.text_ricarica = new System.Windows.Forms.TextBox();
            this.b_ricarica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quanto vuole ricaricare?";
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.Green;
            this.trackBar.Location = new System.Drawing.Point(52, 102);
            this.trackBar.Maximum = 100;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(251, 56);
            this.trackBar.TabIndex = 1;
            this.trackBar.TickFrequency = 10;
            this.trackBar.Value = 1;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // text_ricarica
            // 
            this.text_ricarica.Location = new System.Drawing.Point(127, 178);
            this.text_ricarica.Name = "text_ricarica";
            this.text_ricarica.Size = new System.Drawing.Size(100, 22);
            this.text_ricarica.TabIndex = 2;
            this.text_ricarica.Text = "1";
            this.text_ricarica.TextChanged += new System.EventHandler(this.text_ricarica_TextChanged);
            // 
            // b_ricarica
            // 
            this.b_ricarica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_ricarica.BackColor = System.Drawing.Color.Black;
            this.b_ricarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ricarica.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ricarica.ForeColor = System.Drawing.Color.Gold;
            this.b_ricarica.Location = new System.Drawing.Point(123, 229);
            this.b_ricarica.Margin = new System.Windows.Forms.Padding(4);
            this.b_ricarica.Name = "b_ricarica";
            this.b_ricarica.Size = new System.Drawing.Size(109, 33);
            this.b_ricarica.TabIndex = 10;
            this.b_ricarica.Text = "RICARICA";
            this.b_ricarica.UseVisualStyleBackColor = false;
            this.b_ricarica.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "€";
            // 
            // Ricarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(355, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_ricarica);
            this.Controls.Add(this.text_ricarica);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ricarica";
            this.Text = "Ricarica";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TextBox text_ricarica;
        private System.Windows.Forms.Button b_ricarica;
        private System.Windows.Forms.Label label2;
    }
}