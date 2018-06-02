namespace MovingWindow
{
    partial class MovingWindow
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
            this.timerKeyUp = new System.Windows.Forms.Timer(this.components);
            this.timerKeyDown = new System.Windows.Forms.Timer(this.components);
            this.timerKeyLeft = new System.Windows.Forms.Timer(this.components);
            this.timerKeyRight = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerKeyUp
            // 
            this.timerKeyUp.Tick += new System.EventHandler(this.TimerKeyUp_Tick);
            // 
            // timerKeyDown
            // 
            this.timerKeyDown.Tick += new System.EventHandler(this.TimerKeyDown_Tick);
            // 
            // timerKeyLeft
            // 
            this.timerKeyLeft.Tick += new System.EventHandler(this.TimerKeyLeft_Tick);
            // 
            // timerKeyRight
            // 
            this.timerKeyRight.Tick += new System.EventHandler(this.TimerKeyRight_Tick);
            // 
            // MovingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovingWindow";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MovingWindow_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerKeyUp;
        private System.Windows.Forms.Timer timerKeyDown;
        private System.Windows.Forms.Timer timerKeyLeft;
        private System.Windows.Forms.Timer timerKeyRight;
    }
}

