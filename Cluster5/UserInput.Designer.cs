namespace Cluster5
{
    partial class UserInput
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
            label1 = new Label();
            userName = new TextBox();
            endButton = new Button();
            finalLabel = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 5;
            // 
            // userName
            // 
            userName.Location = new Point(330, 205);
            userName.Name = "userName";
            userName.Size = new Size(155, 23);
            userName.TabIndex = 4;
            // 
            // endButton
            // 
            endButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endButton.Location = new Point(258, 282);
            endButton.Name = "endButton";
            endButton.Size = new Size(227, 51);
            endButton.TabIndex = 2;
            endButton.Text = "End Quiz";
            endButton.UseVisualStyleBackColor = true;
            endButton.Click += endButton_Click;
            // 
            // finalLabel
            // 
            finalLabel.AutoSize = true;
            finalLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finalLabel.Location = new Point(264, 100);
            finalLabel.Name = "finalLabel";
            finalLabel.Size = new Size(221, 50);
            finalLabel.TabIndex = 3;
            finalLabel.Text = "You complete the quiz. \r\nYour final score was 0/10";
            finalLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(258, 205);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 6;
            label3.Text = "Name:";
            // 
            // UserInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(finalLabel);
            Controls.Add(endButton);
            Controls.Add(userName);
            Controls.Add(label1);
            Name = "UserInput";
            Text = "UserInput";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userName;
        private Button endButton;
        private Label finalLabel;
        private Label label3;
    }
}