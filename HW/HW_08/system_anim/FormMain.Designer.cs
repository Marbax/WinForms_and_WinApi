namespace system_anim
{
    partial class FormMain
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
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelPic = new System.Windows.Forms.Panel();
            this.pictureBoxSystem = new System.Windows.Forms.PictureBox();
            this.timerAnim = new System.Windows.Forms.Timer(this.components);
            this.labelPlanetsSpeed = new System.Windows.Forms.Label();
            this.numericUpDownPlanetsSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPlanetsSize = new System.Windows.Forms.NumericUpDown();
            this.labelPlanetsSize = new System.Windows.Forms.Label();
            this.panelControls.SuspendLayout();
            this.panelPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanetsSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanetsSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelControls.Controls.Add(this.numericUpDownPlanetsSize);
            this.panelControls.Controls.Add(this.labelPlanetsSize);
            this.panelControls.Controls.Add(this.numericUpDownPlanetsSpeed);
            this.panelControls.Controls.Add(this.labelPlanetsSpeed);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControls.Location = new System.Drawing.Point(0, 657);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1008, 24);
            this.panelControls.TabIndex = 0;
            // 
            // panelPic
            // 
            this.panelPic.Controls.Add(this.pictureBoxSystem);
            this.panelPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPic.Location = new System.Drawing.Point(0, 0);
            this.panelPic.Name = "panelPic";
            this.panelPic.Size = new System.Drawing.Size(1008, 657);
            this.panelPic.TabIndex = 1;
            // 
            // pictureBoxSystem
            // 
            this.pictureBoxSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSystem.Image = global::system_anim.Properties.Resources.space_bkg;
            this.pictureBoxSystem.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSystem.Name = "pictureBoxSystem";
            this.pictureBoxSystem.Size = new System.Drawing.Size(1008, 657);
            this.pictureBoxSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSystem.TabIndex = 0;
            this.pictureBoxSystem.TabStop = false;
            this.pictureBoxSystem.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSystem_Paint);
            // 
            // timerAnim
            // 
            this.timerAnim.Tick += new System.EventHandler(this.timerAnim_Tick);
            // 
            // labelPlanetsSpeed
            // 
            this.labelPlanetsSpeed.AutoSize = true;
            this.labelPlanetsSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlanetsSpeed.Location = new System.Drawing.Point(3, 1);
            this.labelPlanetsSpeed.Name = "labelPlanetsSpeed";
            this.labelPlanetsSpeed.Size = new System.Drawing.Size(113, 20);
            this.labelPlanetsSpeed.TabIndex = 0;
            this.labelPlanetsSpeed.Text = "Planets Speed";
            // 
            // numericUpDownPlanetsSpeed
            // 
            this.numericUpDownPlanetsSpeed.Location = new System.Drawing.Point(123, 0);
            this.numericUpDownPlanetsSpeed.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownPlanetsSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPlanetsSpeed.Name = "numericUpDownPlanetsSpeed";
            this.numericUpDownPlanetsSpeed.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownPlanetsSpeed.TabIndex = 1;
            this.numericUpDownPlanetsSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPlanetsSpeed.ValueChanged += new System.EventHandler(this.numericUpDownPlanetsSpeed_ValueChanged);
            // 
            // numericUpDownPlanetsSize
            // 
            this.numericUpDownPlanetsSize.Location = new System.Drawing.Point(318, 0);
            this.numericUpDownPlanetsSize.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownPlanetsSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPlanetsSize.Name = "numericUpDownPlanetsSize";
            this.numericUpDownPlanetsSize.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownPlanetsSize.TabIndex = 3;
            this.numericUpDownPlanetsSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPlanetsSize.ValueChanged += new System.EventHandler(this.numericUpDownPlanetsSize_ValueChanged);
            // 
            // labelPlanetsSize
            // 
            this.labelPlanetsSize.AutoSize = true;
            this.labelPlanetsSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlanetsSize.Location = new System.Drawing.Point(198, 1);
            this.labelPlanetsSize.Name = "labelPlanetsSize";
            this.labelPlanetsSize.Size = new System.Drawing.Size(97, 20);
            this.labelPlanetsSize.TabIndex = 2;
            this.labelPlanetsSize.Text = "Planets Size";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.panelPic);
            this.Controls.Add(this.panelControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Solar System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.panelPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanetsSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlanetsSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelPic;
        private System.Windows.Forms.PictureBox pictureBoxSystem;
        private System.Windows.Forms.Timer timerAnim;
        private System.Windows.Forms.NumericUpDown numericUpDownPlanetsSpeed;
        private System.Windows.Forms.Label labelPlanetsSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownPlanetsSize;
        private System.Windows.Forms.Label labelPlanetsSize;
    }
}

