using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace canonlive
{
    public partial class LiveViewForm : Form
    {

        IntPtr cameraListRef = new IntPtr();
        IntPtr[] camera = new IntPtr[1];
        int cameraCount;
        int KeepAliveCounter = 0;

        public LiveViewForm()
        {
            InitializeComponent();
        }       

        private void LiveViewForm_Load(object sender, EventArgs e)
        {
            cameraControl.InitCamera();
            cameraListRef = cameraControl.GetCameras(out cameraCount);
            camera = cameraControl.OpenCameras(cameraListRef, cameraCount);
            for (int i = 0; i < cameraCount; i++)
            {
                cameraControl.LiveView(camera[i]);
            }
            LiveRefreshTimer.Start();
            this.Text = "canon live | v0.1 | dev:camenduru | " + LiveBox1.Width + "x" + LiveBox1.Height;
        }

        private void LiveRefreshTimer_Tick(object sender, EventArgs e)
        {
            LiveBox1.Image = cameraControl.DownloadEvf(camera[0]);
        }

        private void LiveViewForm_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            LiveBox1.Width = control.Size.Width;
            LiveBox1.Height = ((2 * LiveBox1.Width) / 3);
            this.Text = "canon live | v0.1 | dev:camenduru | " + LiveBox1.Width + "x" + LiveBox1.Height;
        }

        private void LiveViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cameraControl.CloseCameras(camera, cameraCount);
        }

        private void LiveBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Text = "canon live | v0.1 | dev:camenduru | " + LiveBox1.Width + "x" + LiveBox1.Height + " | Focus Far";
                cameraControl.FocusOFF(camera, cameraCount);
                cameraControl.FocusFar3(camera, cameraCount);
            }
            else if (e.Button == MouseButtons.Left)
            {
                this.Text = "canon live | v0.1 | dev:camenduru | " + LiveBox1.Width + "x" + LiveBox1.Height + " | Focus Near";
                cameraControl.FocusOFF(camera, cameraCount);
                cameraControl.FocusNear3(camera, cameraCount);
            }
            else if (e.Button == MouseButtons.Middle)
            {
                this.Text = "canon live | v0.1 | dev:camenduru | " + LiveBox1.Width + "x" + LiveBox1.Height + " | Focus AF";
                cameraControl.FocusOFF(camera, cameraCount);
                cameraControl.FocusON(camera, cameraCount);
            }
        }

        private void KeepAliveTimer_Tick(object sender, EventArgs e)
        {  
            this.Text = "canon live | v0.1 | dev:camenduru | " + LiveBox1.Width + "x" + LiveBox1.Height + " | Keep Alive " + KeepAliveCounter++;
            cameraControl.KeepAlive(camera, cameraCount);
        }
    }
}
