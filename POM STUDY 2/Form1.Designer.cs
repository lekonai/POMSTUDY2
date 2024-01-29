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
            timerTextLabel = new Label();
            relaxLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
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
            // timerTextLabel
            // 
            timerTextLabel.AutoSize = true;
            timerTextLabel.BackColor = Color.White;
            timerTextLabel.Location = new Point(21, 23);
            timerTextLabel.Name = "timerTextLabel";
            timerTextLabel.Size = new Size(34, 15);
            timerTextLabel.TabIndex = 2;
            timerTextLabel.Text = "00:00";
            timerTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // relaxLabel
            // 
            relaxLabel.AutoSize = true;
            relaxLabel.BackColor = Color.White;
            relaxLabel.Location = new Point(21, 411);
            relaxLabel.Name = "relaxLabel";
            relaxLabel.Size = new Size(34, 15);
            relaxLabel.TabIndex = 3;
            relaxLabel.Text = "00:00";
            relaxLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(relaxLabel);
            Controls.Add(timerTextLabel);
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
        private Label timerTextLabel;
        private Label relaxLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
