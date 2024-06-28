namespace Cluster5
{
    partial class Menu
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
            label1 = new Label();
            playButton = new Button();
            alltimeButton = new Button();
            todayScoreButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 34);
            label1.Name = "label1";
            label1.Size = new Size(248, 65);
            label1.TabIndex = 0;
            label1.Text = "Math Quiz";
            // 
            // playButton
            // 
            playButton.Font = new Font("Segoe UI", 15.75F);
            playButton.Location = new Point(225, 116);
            playButton.Name = "playButton";
            playButton.Size = new Size(333, 61);
            playButton.TabIndex = 1;
            playButton.Text = "Play Quiz";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // alltimeButton
            // 
            alltimeButton.Font = new Font("Segoe UI", 15.75F);
            alltimeButton.Location = new Point(225, 183);
            alltimeButton.Name = "alltimeButton";
            alltimeButton.Size = new Size(333, 61);
            alltimeButton.TabIndex = 2;
            alltimeButton.Text = "All Time High Scores";
            alltimeButton.UseVisualStyleBackColor = true;
            alltimeButton.Click += alltimeButton_Click;
            // 
            // todayScoreButton
            // 
            todayScoreButton.Font = new Font("Segoe UI", 15.75F);
            todayScoreButton.Location = new Point(225, 250);
            todayScoreButton.Name = "todayScoreButton";
            todayScoreButton.Size = new Size(333, 61);
            todayScoreButton.TabIndex = 3;
            todayScoreButton.Text = "Todays High Scores";
            todayScoreButton.UseVisualStyleBackColor = true;
            todayScoreButton.Click += todayScoreButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Red;
            exitButton.Font = new Font("Segoe UI", 15.75F);
            exitButton.Location = new Point(225, 317);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(333, 61);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(todayScoreButton);
            Controls.Add(alltimeButton);
            Controls.Add(playButton);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button playButton;
        private Button alltimeButton;
        private Button todayScoreButton;
        private Button exitButton;
    }
}
