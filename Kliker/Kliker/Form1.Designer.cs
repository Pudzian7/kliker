namespace Kliker
{
    partial class Form1
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
            this.pktmax = new System.Windows.Forms.Label();
            this.bestscore = new System.Windows.Forms.Label();
            this.klik = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Label();
            this.kliki = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pktmax
            // 
            this.pktmax.AutoSize = true;
            this.pktmax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pktmax.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pktmax.ForeColor = System.Drawing.Color.Black;
            this.pktmax.Location = new System.Drawing.Point(86, 189);
            this.pktmax.Name = "pktmax";
            this.pktmax.Size = new System.Drawing.Size(132, 21);
            this.pktmax.TabIndex = 28;
            this.pktmax.Text = "Suma punktów:";
            this.pktmax.Click += new System.EventHandler(this.pktmax_Click);
            // 
            // bestscore
            // 
            this.bestscore.AutoSize = true;
            this.bestscore.BackColor = System.Drawing.Color.LawnGreen;
            this.bestscore.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bestscore.ForeColor = System.Drawing.Color.Black;
            this.bestscore.Location = new System.Drawing.Point(86, 244);
            this.bestscore.Name = "bestscore";
            this.bestscore.Size = new System.Drawing.Size(142, 21);
            this.bestscore.TabIndex = 27;
            this.bestscore.Text = "Najlepszy Wynik:";
            this.bestscore.Click += new System.EventHandler(this.najLbl_Click);
            // 
            // klik
            // 
            this.klik.Location = new System.Drawing.Point(206, 122);
            this.klik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klik.Name = "klik";
            this.klik.Size = new System.Drawing.Size(82, 39);
            this.klik.TabIndex = 26;
            this.klik.Text = "Klik";
            this.klik.UseVisualStyleBackColor = true;
            this.klik.Click += new System.EventHandler(this.clickerBtn_Click);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.BackColor = System.Drawing.Color.Red;
            this.timer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timer.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timer.ForeColor = System.Drawing.Color.Black;
            this.timer.Location = new System.Drawing.Point(330, 73);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(53, 23);
            this.timer.TabIndex = 25;
            this.timer.Text = "Czas:";
            this.timer.Click += new System.EventHandler(this.timerLbl_Click);
            // 
            // kliki
            // 
            this.kliki.AutoSize = true;
            this.kliki.BackColor = System.Drawing.SystemColors.HotTrack;
            this.kliki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kliki.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kliki.ForeColor = System.Drawing.Color.Black;
            this.kliki.Location = new System.Drawing.Point(47, 73);
            this.kliki.Name = "kliki";
            this.kliki.Size = new System.Drawing.Size(119, 23);
            this.kliki.TabIndex = 24;
            this.kliki.Text = "Ilość kliknięć:";
            this.kliki.Click += new System.EventHandler(this.clicksLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pktmax);
            this.Controls.Add(this.bestscore);
            this.Controls.Add(this.klik);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.kliki);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label pktmax;
        private Label bestscore;
        private Button klik;
        private Label timer;
        private Label kliki;
    }
}