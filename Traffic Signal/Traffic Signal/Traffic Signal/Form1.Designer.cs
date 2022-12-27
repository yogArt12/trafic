namespace Traffic_Signal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RedStopLight = new System.Windows.Forms.PictureBox();
            this.YellowStopLight = new System.Windows.Forms.PictureBox();
            this.GreenStopLight = new System.Windows.Forms.PictureBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RedStopLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowStopLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenStopLight)).BeginInit();
            this.SuspendLayout();
            // 
            // RedStopLight
            // 
            this.RedStopLight.Image = ((System.Drawing.Image)(resources.GetObject("RedStopLight.Image")));
            this.RedStopLight.Location = new System.Drawing.Point(143, 25);
            this.RedStopLight.Name = "RedStopLight";
            this.RedStopLight.Size = new System.Drawing.Size(136, 377);
            this.RedStopLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RedStopLight.TabIndex = 0;
            this.RedStopLight.TabStop = false;
            // 
            // YellowStopLight
            // 
            this.YellowStopLight.Image = ((System.Drawing.Image)(resources.GetObject("YellowStopLight.Image")));
            this.YellowStopLight.Location = new System.Drawing.Point(141, 26);
            this.YellowStopLight.Name = "YellowStopLight";
            this.YellowStopLight.Size = new System.Drawing.Size(138, 373);
            this.YellowStopLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.YellowStopLight.TabIndex = 1;
            this.YellowStopLight.TabStop = false;
            // 
            // GreenStopLight
            // 
            this.GreenStopLight.Image = ((System.Drawing.Image)(resources.GetObject("GreenStopLight.Image")));
            this.GreenStopLight.Location = new System.Drawing.Point(141, 27);
            this.GreenStopLight.Name = "GreenStopLight";
            this.GreenStopLight.Size = new System.Drawing.Size(142, 378);
            this.GreenStopLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GreenStopLight.TabIndex = 2;
            this.GreenStopLight.TabStop = false;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(389, 91);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 3;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(389, 180);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 23);
            this.btnstop.TabIndex = 4;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 460);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.GreenStopLight);
            this.Controls.Add(this.YellowStopLight);
            this.Controls.Add(this.RedStopLight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedStopLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowStopLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenStopLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RedStopLight;
        private System.Windows.Forms.PictureBox YellowStopLight;
        private System.Windows.Forms.PictureBox GreenStopLight;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Timer timer1;
    }
}

