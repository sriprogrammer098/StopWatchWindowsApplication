namespace WinFormsApp1
{
    partial class StopWatch
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
            watchLabel = new Label();
            StartButton = new Button();
            StopButton = new Button();
            ResetButton = new Button();
            formTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // watchLabel
            // 
            watchLabel.Font = new Font("Segoe UI", 80F, FontStyle.Regular, GraphicsUnit.Point, 0);
            watchLabel.Location = new Point(25, 9);
            watchLabel.Name = "watchLabel";
            watchLabel.Size = new Size(614, 144);
            watchLabel.TabIndex = 0;
            watchLabel.Text = "00:00.00";
            watchLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.FromArgb(0, 192, 0);
            StartButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartButton.Location = new Point(12, 290);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(184, 54);
            StartButton.TabIndex = 1;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.BackColor = Color.FromArgb(192, 0, 0);
            StopButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StopButton.Location = new Point(226, 290);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(183, 54);
            StopButton.TabIndex = 2;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = false;
            StopButton.Click += StopButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.FromArgb(128, 128, 255);
            ResetButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetButton.Location = new Point(447, 290);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(183, 54);
            ResetButton.TabIndex = 3;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // formTimer
            // 
            formTimer.Interval = 10;
            formTimer.Tick += formTimer_Tick;
            // 
            // StopWatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(694, 450);
            Controls.Add(ResetButton);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Controls.Add(watchLabel);
            Name = "StopWatch";
            Text = "StopWatch";
            ResumeLayout(false);
        }

        #endregion

        private Label watchLabel;
        private Button StartButton;
        private Button StopButton;
        private Button ResetButton;
        private System.Windows.Forms.Timer formTimer;
    }
}
