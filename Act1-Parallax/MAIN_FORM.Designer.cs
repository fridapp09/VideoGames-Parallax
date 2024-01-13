namespace Act1_Parallax
{
    partial class MAIN_FORM
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
            components = new System.ComponentModel.Container();
            TIMER = new System.Windows.Forms.Timer(components);
            PLAYER = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PLAYER).BeginInit();
            SuspendLayout();
            // 
            // TIMER
            // 
            TIMER.Enabled = true;
            TIMER.Interval = 10;
            TIMER.Tick += TIMER_Tick;
            // 
            // PLAYER
            // 
            PLAYER.BackColor = Color.Transparent;
            PLAYER.Location = new Point(285, 190);
            PLAYER.Name = "PLAYER";
            PLAYER.Size = new Size(80, 100);
            PLAYER.SizeMode = PictureBoxSizeMode.Zoom;
            PLAYER.TabIndex = 0;
            PLAYER.TabStop = false;
            PLAYER.Click += pictureBox1_Click;
            // 
            // MAIN_FORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 311);
            Controls.Add(PLAYER);
            DoubleBuffered = true;
            Name = "MAIN_FORM";
            Text = "PARALLAX";
            Load += MAIN_FORM_Load;
            Paint += MAIN_FORM_Paint;
            KeyDown += MAIN_FORM_KeyDown;
            KeyUp += MAIN_FORM_KeyUp;
            ((System.ComponentModel.ISupportInitialize)PLAYER).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer TIMER;
        private PictureBox PLAYER;
    }
}
