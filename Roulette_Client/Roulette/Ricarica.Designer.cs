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
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.b_ricarica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_ricarica = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_ricarica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quanto vuole ricaricare?";
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.Green;
            this.trackBar.Location = new System.Drawing.Point(39, 83);
            this.trackBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar.Maximum = 500;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(188, 45);
            this.trackBar.TabIndex = 1;
            this.trackBar.TickFrequency = 50;
            this.trackBar.Value = 1;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // b_ricarica
            // 
            this.b_ricarica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_ricarica.BackColor = System.Drawing.Color.Black;
            this.b_ricarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ricarica.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ricarica.ForeColor = System.Drawing.Color.Gold;
            this.b_ricarica.Location = new System.Drawing.Point(92, 186);
            this.b_ricarica.Name = "b_ricarica";
            this.b_ricarica.Size = new System.Drawing.Size(82, 27);
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
            this.label2.Location = new System.Drawing.Point(152, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "€";
            // 
            // text_ricarica
            // 
            this.text_ricarica.Location = new System.Drawing.Point(92, 145);
            this.text_ricarica.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.text_ricarica.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.text_ricarica.Name = "text_ricarica";
            this.text_ricarica.Size = new System.Drawing.Size(56, 20);
            this.text_ricarica.TabIndex = 12;
            this.text_ricarica.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.text_ricarica.ValueChanged += new System.EventHandler(this.text_ricarica_ValueChanged);
            // 
            // Ricarica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(266, 241);
            this.Controls.Add(this.text_ricarica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_ricarica);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ricarica";
            this.Text = "Ricarica";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_ricarica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button b_ricarica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown text_ricarica;
    }
}