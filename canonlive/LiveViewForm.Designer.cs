namespace canonlive
{
    partial class LiveViewForm
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
            this.LiveBox1 = new System.Windows.Forms.PictureBox();
            this.LiveRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.KeepAliveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LiveBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LiveBox1
            // 
            this.LiveBox1.BackColor = System.Drawing.Color.Lime;
            this.LiveBox1.Location = new System.Drawing.Point(0, 0);
            this.LiveBox1.Margin = new System.Windows.Forms.Padding(0);
            this.LiveBox1.Name = "LiveBox1";
            this.LiveBox1.Size = new System.Drawing.Size(960, 640);
            this.LiveBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LiveBox1.TabIndex = 0;
            this.LiveBox1.TabStop = false;
            this.LiveBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LiveBox1_MouseClick);
            // 
            // LiveRefreshTimer
            // 
            this.LiveRefreshTimer.Interval = 50;
            this.LiveRefreshTimer.Tick += new System.EventHandler(this.LiveRefreshTimer_Tick);
            // 
            // KeepAliveTimer
            // 
            this.KeepAliveTimer.Enabled = true;
            this.KeepAliveTimer.Interval = 300000;
            this.KeepAliveTimer.Tick += new System.EventHandler(this.KeepAliveTimer_Tick);
            // 
            // LiveViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.Controls.Add(this.LiveBox1);
            this.Name = "LiveViewForm";
            this.Text = "canonlive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LiveViewForm_FormClosing);
            this.Load += new System.EventHandler(this.LiveViewForm_Load);
            this.ResizeEnd += new System.EventHandler(this.LiveViewForm_Resize);
            this.Resize += new System.EventHandler(this.LiveViewForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.LiveBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LiveBox1;
        private System.Windows.Forms.Timer LiveRefreshTimer;
        private System.Windows.Forms.Timer KeepAliveTimer;
    }
}