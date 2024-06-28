namespace Cluster5
{
    partial class PlayScreen
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
            questionLabel = new Label();
            answerInput = new TextBox();
            submitButton = new Button();
            userScore = new Label();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionLabel.Location = new Point(240, 182);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(94, 30);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "5 x 10 = ";
            // 
            // answerInput
            // 
            answerInput.Location = new Point(325, 189);
            answerInput.Name = "answerInput";
            answerInput.Size = new Size(100, 23);
            answerInput.TabIndex = 1;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(259, 229);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(166, 38);
            submitButton.TabIndex = 2;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // userScore
            // 
            userScore.AutoSize = true;
            userScore.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userScore.Location = new Point(12, 416);
            userScore.Name = "userScore";
            userScore.Size = new Size(147, 25);
            userScore.TabIndex = 3;
            userScore.Text = "Current Score: 0";
            // 
            // PlayScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userScore);
            Controls.Add(submitButton);
            Controls.Add(answerInput);
            Controls.Add(questionLabel);
            Name = "PlayScreen";
            Text = "PlayScreen";
            Load += PlayScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionLabel;
        private TextBox answerInput;
        private Button submitButton;
        private Label userScore;
    }
}