
namespace WaterFowlHuntingGame
{
    partial class WaterFowlHuntingGame
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Kill = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBird1 = new System.Windows.Forms.PictureBox();
            this.picBird2 = new System.Windows.Forms.PictureBox();
            this.picBird3 = new System.Windows.Forms.PictureBox();
            this.lbl_missed = new System.Windows.Forms.Label();
            this.lbl_over = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBird1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Kill
            // 
            this.lbl_Kill.AutoSize = true;
            this.lbl_Kill.Font = new System.Drawing.Font("Baloo Da", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kill.ForeColor = System.Drawing.Color.Red;
            this.lbl_Kill.Location = new System.Drawing.Point(65, 9);
            this.lbl_Kill.Name = "lbl_Kill";
            this.lbl_Kill.Size = new System.Drawing.Size(128, 32);
            this.lbl_Kill.TabIndex = 0;
            this.lbl_Kill.Text = "Bird Killed : 0";
            this.lbl_Kill.Click += new System.EventHandler(this.lbl_Kill_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // picBird1
            // 
            this.picBird1.Image = global::WaterFowlHuntingGame.Properties.Resources.bird1;
            this.picBird1.Location = new System.Drawing.Point(56, 127);
            this.picBird1.Name = "picBird1";
            this.picBird1.Size = new System.Drawing.Size(190, 143);
            this.picBird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBird1.TabIndex = 1;
            this.picBird1.TabStop = false;
            this.picBird1.Click += new System.EventHandler(this.picBird1_Click);
            // 
            // picBird2
            // 
            this.picBird2.Image = global::WaterFowlHuntingGame.Properties.Resources.bird2;
            this.picBird2.Location = new System.Drawing.Point(520, 58);
            this.picBird2.Name = "picBird2";
            this.picBird2.Size = new System.Drawing.Size(150, 127);
            this.picBird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBird2.TabIndex = 2;
            this.picBird2.TabStop = false;
            this.picBird2.Click += new System.EventHandler(this.picBird2_Click);
            // 
            // picBird3
            // 
            this.picBird3.Image = global::WaterFowlHuntingGame.Properties.Resources.bird3;
            this.picBird3.Location = new System.Drawing.Point(364, 290);
            this.picBird3.Name = "picBird3";
            this.picBird3.Size = new System.Drawing.Size(150, 127);
            this.picBird3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBird3.TabIndex = 3;
            this.picBird3.TabStop = false;
            this.picBird3.Click += new System.EventHandler(this.picBird3_Click);
            // 
            // lbl_missed
            // 
            this.lbl_missed.AutoSize = true;
            this.lbl_missed.Font = new System.Drawing.Font("Baloo Da", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_missed.Location = new System.Drawing.Point(644, 9);
            this.lbl_missed.Name = "lbl_missed";
            this.lbl_missed.Size = new System.Drawing.Size(99, 32);
            this.lbl_missed.TabIndex = 4;
            this.lbl_missed.Text = "Missed : 0";
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.Font = new System.Drawing.Font("Baloo Da", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.Location = new System.Drawing.Point(252, 178);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(282, 81);
            this.lbl_over.TabIndex = 5;
            this.lbl_over.Text = "Game-Over";
            // 
            // WaterFowlHuntingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.lbl_missed);
            this.Controls.Add(this.picBird3);
            this.Controls.Add(this.picBird2);
            this.Controls.Add(this.picBird1);
            this.Controls.Add(this.lbl_Kill);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "WaterFowlHuntingGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaterFowlHuntingGame";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WaterFowlHuntingGame_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picBird1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Kill;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBird1;
        private System.Windows.Forms.PictureBox picBird2;
        private System.Windows.Forms.PictureBox picBird3;
        private System.Windows.Forms.Label lbl_missed;
        private System.Windows.Forms.Label lbl_over;
    }
}

