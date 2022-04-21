namespace DailySpecial
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
            this.dayBox = new System.Windows.Forms.TextBox();
            this.specialButton = new System.Windows.Forms.Button();
            this.intructionLabel = new System.Windows.Forms.Label();
            this.instructionExample = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(263, 235);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(200, 39);
            this.dayBox.TabIndex = 0;
            // 
            // specialButton
            // 
            this.specialButton.Location = new System.Drawing.Point(289, 311);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(150, 46);
            this.specialButton.TabIndex = 1;
            this.specialButton.Text = "Get special";
            this.specialButton.UseVisualStyleBackColor = true;
            this.specialButton.Click += new System.EventHandler(this.SpecialButton_Click);
            // 
            // intructionLabel
            // 
            this.intructionLabel.AutoSize = true;
            this.intructionLabel.Location = new System.Drawing.Point(164, 85);
            this.intructionLabel.Name = "intructionLabel";
            this.intructionLabel.Size = new System.Drawing.Size(418, 32);
            this.intructionLabel.TabIndex = 2;
            this.intructionLabel.Text = "Enter a day number to see our special";
            this.intructionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // instructionExample
            // 
            this.instructionExample.AutoSize = true;
            this.instructionExample.Location = new System.Drawing.Point(225, 156);
            this.instructionExample.Name = "instructionExample";
            this.instructionExample.Size = new System.Drawing.Size(279, 32);
            this.instructionExample.TabIndex = 3;
            this.instructionExample.Text = "For example, Sunday = 1";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(183, 372);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 32);
            this.outputLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.instructionExample);
            this.Controls.Add(this.intructionLabel);
            this.Controls.Add(this.specialButton);
            this.Controls.Add(this.dayBox);
            this.Name = "Form1";
            this.Text = "Chatterbox Dinner Daily Specials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox dayBox;
        private Button specialButton;
        private Label intructionLabel;
        private Label instructionExample;
        private Label outputLabel;
    }
}