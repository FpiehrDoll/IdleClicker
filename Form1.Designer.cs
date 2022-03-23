namespace idle_clicker
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
            this.button1 = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.Label();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.buttonLevelTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "HIT ME!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(12, 9);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(62, 15);
            this.money.TabIndex = 1;
            this.money.Text = "Money: $0";
            // 
            // upgradeButton
            // 
            this.upgradeButton.Location = new System.Drawing.Point(31, 356);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(121, 41);
            this.upgradeButton.TabIndex = 2;
            this.upgradeButton.Text = "Upgrade  Button: $10";
            this.upgradeButton.UseVisualStyleBackColor = true;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // buttonLevelTextBox
            // 
            this.buttonLevelTextBox.AutoSize = true;
            this.buttonLevelTextBox.Location = new System.Drawing.Point(33, 335);
            this.buttonLevelTextBox.Name = "buttonLevelTextBox";
            this.buttonLevelTextBox.Size = new System.Drawing.Size(46, 15);
            this.buttonLevelTextBox.TabIndex = 3;
            this.buttonLevelTextBox.Text = "Level: 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLevelTextBox);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.money);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label money;
        private Button upgradeButton;
        private Label buttonLevelTextBox;
    }
}