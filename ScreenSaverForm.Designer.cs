﻿namespace JunyaSaver
{
    partial class ScreenSaverForm
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
            SuspendLayout();
            // 
            // ScreenSaverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(484, 461);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScreenSaverForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += ScreenSaverForm_Load;
            KeyPress += ScreenSaverForm_KeyPress;
            MouseClick += ScreenSaverForm_MouseClick;
            MouseMove += ScreenSaverForm_MouseMove;
            ResumeLayout(false);
        }

        #endregion
    }
}
