namespace WindowsFormsApp1_geponAuto_20200415
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.histogram1 = new AForge.Controls.Histogram();
            this.sliderControl1 = new AForge.Controls.SliderControl();
            this.pictureBox1 = new AForge.Controls.PictureBox();
            this.manipulatorControl1 = new AForge.Controls.ManipulatorControl();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // histogram1
            // 
            this.histogram1.Location = new System.Drawing.Point(311, 97);
            this.histogram1.Name = "histogram1";
            this.histogram1.Size = new System.Drawing.Size(75, 23);
            this.histogram1.TabIndex = 0;
            this.histogram1.Text = "histogram1";
            this.histogram1.Values = null;
            // 
            // sliderControl1
            // 
            this.sliderControl1.Location = new System.Drawing.Point(466, 57);
            this.sliderControl1.ManipulatorPosition = 0F;
            this.sliderControl1.Name = "sliderControl1";
            this.sliderControl1.Size = new System.Drawing.Size(75, 23);
            this.sliderControl1.TabIndex = 2;
            this.sliderControl1.Text = "sliderControl1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(414, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // manipulatorControl1
            // 
            this.manipulatorControl1.Location = new System.Drawing.Point(558, 231);
            this.manipulatorControl1.ManipulatorPosition = ((System.Drawing.PointF)(resources.GetObject("manipulatorControl1.ManipulatorPosition")));
            this.manipulatorControl1.Name = "manipulatorControl1";
            this.manipulatorControl1.Size = new System.Drawing.Size(199, 179);
            this.manipulatorControl1.TabIndex = 4;
            this.manipulatorControl1.Text = "manipulatorControl1";
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.Location = new System.Drawing.Point(201, 148);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(169, 58);
            this.videoSourcePlayer2.TabIndex = 5;
            this.videoSourcePlayer2.Text = "videoSourcePlayer2";
            this.videoSourcePlayer2.VideoSource = null;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videoSourcePlayer2);
            this.Controls.Add(this.manipulatorControl1);
            this.Controls.Add(this.sliderControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.histogram1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.Histogram histogram1;
        private AForge.Controls.PictureBox pictureBox1;
        private AForge.Controls.SliderControl sliderControl1;
        private AForge.Controls.ManipulatorControl manipulatorControl1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
    }
}