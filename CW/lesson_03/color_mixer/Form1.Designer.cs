namespace color_mixer
{
    partial class Form1
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
            this.pictureBoxMixerRes = new System.Windows.Forms.PictureBox();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.labelRed = new System.Windows.Forms.Label();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMixerRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMixerRes
            // 
            this.pictureBoxMixerRes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxMixerRes.Location = new System.Drawing.Point(235, 0);
            this.pictureBoxMixerRes.Name = "pictureBoxMixerRes";
            this.pictureBoxMixerRes.Size = new System.Drawing.Size(367, 325);
            this.pictureBoxMixerRes.TabIndex = 0;
            this.pictureBoxMixerRes.TabStop = false;
            // 
            // trackBarRed
            // 
            this.trackBarRed.LargeChange = 1;
            this.trackBarRed.Location = new System.Drawing.Point(29, 3);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRed.Size = new System.Drawing.Size(37, 292);
            this.trackBarRed.TabIndex = 1;
            this.trackBarRed.TickFrequency = 25;
            this.trackBarRed.Value = 150;
            this.trackBarRed.Scroll += new System.EventHandler(this.TrackBarRed_Scroll);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.trackBarBlue);
            this.panelBottom.Controls.Add(this.trackBarGreen);
            this.panelBottom.Controls.Add(this.trackBarRed);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 33);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(235, 292);
            this.panelBottom.TabIndex = 2;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(28, 9);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(42, 13);
            this.labelRed.TabIndex = 3;
            this.labelRed.Text = "R : 150";
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.LargeChange = 1;
            this.trackBarGreen.Location = new System.Drawing.Point(97, 3);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarGreen.Size = new System.Drawing.Size(37, 292);
            this.trackBarGreen.TabIndex = 2;
            this.trackBarGreen.TickFrequency = 25;
            this.trackBarGreen.Value = 150;
            this.trackBarGreen.Scroll += new System.EventHandler(this.TrackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.LargeChange = 1;
            this.trackBarBlue.Location = new System.Drawing.Point(169, 3);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarBlue.Size = new System.Drawing.Size(37, 289);
            this.trackBarBlue.TabIndex = 3;
            this.trackBarBlue.TickFrequency = 25;
            this.trackBarBlue.Value = 150;
            this.trackBarBlue.Scroll += new System.EventHandler(this.TrackBarBlue_Scroll);
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(94, 9);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(42, 13);
            this.labelGreen.TabIndex = 4;
            this.labelGreen.Text = "G : 150";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(167, 9);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(41, 13);
            this.labelBlue.TabIndex = 5;
            this.labelBlue.Text = "B : 150";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 325);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.pictureBoxMixerRes);
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMixerRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMixerRes;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
    }
}

