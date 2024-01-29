namespace POM_STUDY_2
{
    partial class Form1
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
            timerButton = new Button();
            relaxButton = new Button();
            studyLabelSeconds = new Label();
            relaxLabelSeconds = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            studyMinLabel = new Label();
            SuspendLayout();
            // 
            // timerButton
            // 
            timerButton.BackColor = Color.Lime;
            timerButton.Location = new Point(12, 12);
            timerButton.Name = "timerButton";
            timerButton.Size = new Size(776, 314);
            timerButton.TabIndex = 0;
            timerButton.Text = "START";
            timerButton.UseVisualStyleBackColor = false;
            timerButton.Click += timerButton_Click;
            // 
            // relaxButton
            // 
            relaxButton.Location = new Point(12, 332);
            relaxButton.Name = "relaxButton";
            relaxButton.Size = new Size(776, 106);
            relaxButton.TabIndex = 1;
            relaxButton.Text = "relax...";
            relaxButton.UseVisualStyleBackColor = true;
            // 
            // studyLabelSeconds
            // 
            studyLabelSeconds.AutoSize = true;
            studyLabelSeconds.BackColor = Color.White;
            studyLabelSeconds.Location = new Point(47, 25);
            studyLabelSeconds.Name = "studyLabelSeconds";
            studyLabelSeconds.Size = new Size(24, 15);
            studyLabelSeconds.TabIndex = 2;
            studyLabelSeconds.Text = "00s";
            studyLabelSeconds.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // relaxLabelSeconds
            // 
            relaxLabelSeconds.AutoSize = true;
            relaxLabelSeconds.BackColor = Color.White;
            relaxLabelSeconds.Location = new Point(47, 411);
            relaxLabelSeconds.Name = "relaxLabelSeconds";
            relaxLabelSeconds.Size = new Size(24, 15);
            relaxLabelSeconds.TabIndex = 3;
            relaxLabelSeconds.Text = "00s";
            relaxLabelSeconds.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // studyMinLabel
            // 
            studyMinLabel.AutoSize = true;
            studyMinLabel.BackColor = Color.White;
            studyMinLabel.Location = new Point(20, 25);
            studyMinLabel.Name = "studyMinLabel";
            studyMinLabel.Size = new Size(24, 15);
            studyMinLabel.TabIndex = 4;
            studyMinLabel.Text = "0m";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(studyMinLabel);
            Controls.Add(relaxLabelSeconds);
            Controls.Add(studyLabelSeconds);
            Controls.Add(relaxButton);
            Controls.Add(timerButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button timerButton;
        private Button relaxButton;
        private Label studyLabelSeconds;
        private Label relaxLabelSeconds;
        private System.Windows.Forms.Timer timer1;
        private Label studyMinLabel;
    }
}
