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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.Label();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.buttonLevelTextBox = new System.Windows.Forms.Label();
            this.A1AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A1UpgradeAmmount = new System.Windows.Forms.Button();
            this.A1UpgradeInterval = new System.Windows.Forms.Button();
            this.A1Label = new System.Windows.Forms.Label();
            this.A1IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A1Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.A2Label = new System.Windows.Forms.Label();
            this.A2UpgradeAmmount = new System.Windows.Forms.Button();
            this.A2UpgradeInterval = new System.Windows.Forms.Button();
            this.A2AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A2IntervalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.A3IntervalTextBox = new System.Windows.Forms.TextBox();
            this.A3AmmountTextBox = new System.Windows.Forms.TextBox();
            this.A3UpgradeInterval = new System.Windows.Forms.Button();
            this.A3UpgradeAmmount = new System.Windows.Forms.Button();
            this.A3Label = new System.Windows.Forms.Label();
            this.A2Timer = new System.Windows.Forms.Timer(this.components);
            this.A3Timer = new System.Windows.Forms.Timer(this.components);
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
            // A1AmmountTextBox
            // 
            this.A1AmmountTextBox.Location = new System.Drawing.Point(592, 39);
            this.A1AmmountTextBox.Name = "A1AmmountTextBox";
            this.A1AmmountTextBox.ReadOnly = true;
            this.A1AmmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1AmmountTextBox.TabIndex = 4;
            this.A1AmmountTextBox.Text = "0";
            this.A1AmmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1UpgradeAmmount
            // 
            this.A1UpgradeAmmount.Location = new System.Drawing.Point(698, 31);
            this.A1UpgradeAmmount.Name = "A1UpgradeAmmount";
            this.A1UpgradeAmmount.Size = new System.Drawing.Size(90, 36);
            this.A1UpgradeAmmount.TabIndex = 5;
            this.A1UpgradeAmmount.Text = "Ulepsz ilość";
            this.A1UpgradeAmmount.UseVisualStyleBackColor = true;
            this.A1UpgradeAmmount.Click += new System.EventHandler(this.A1UpgradeAmmount_Click);
            // 
            // A1UpgradeInterval
            // 
            this.A1UpgradeInterval.Location = new System.Drawing.Point(698, 73);
            this.A1UpgradeInterval.Name = "A1UpgradeInterval";
            this.A1UpgradeInterval.Size = new System.Drawing.Size(90, 39);
            this.A1UpgradeInterval.TabIndex = 6;
            this.A1UpgradeInterval.Text = "Ulepsz częstotliwość";
            this.A1UpgradeInterval.UseVisualStyleBackColor = true;
            this.A1UpgradeInterval.Click += new System.EventHandler(this.A1UpgradeInterval_Click);
            // 
            // A1Label
            // 
            this.A1Label.AutoSize = true;
            this.A1Label.Location = new System.Drawing.Point(592, 21);
            this.A1Label.Name = "A1Label";
            this.A1Label.Size = new System.Drawing.Size(84, 15);
            this.A1Label.TabIndex = 7;
            this.A1Label.Text = "AutoUpgrade1";
            this.A1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // A1IntervalTextBox
            // 
            this.A1IntervalTextBox.Location = new System.Drawing.Point(592, 83);
            this.A1IntervalTextBox.Name = "A1IntervalTextBox";
            this.A1IntervalTextBox.ReadOnly = true;
            this.A1IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A1IntervalTextBox.TabIndex = 8;
            this.A1IntervalTextBox.Text = "0";
            this.A1IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A1Timer
            // 
            this.A1Timer.Tick += new System.EventHandler(this.A1Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "/min";
            // 
            // A2Label
            // 
            this.A2Label.AutoSize = true;
            this.A2Label.Location = new System.Drawing.Point(592, 152);
            this.A2Label.Name = "A2Label";
            this.A2Label.Size = new System.Drawing.Size(84, 15);
            this.A2Label.TabIndex = 10;
            this.A2Label.Text = "AutoUpgrade2";
            // 
            // A2UpgradeAmmount
            // 
            this.A2UpgradeAmmount.Location = new System.Drawing.Point(698, 155);
            this.A2UpgradeAmmount.Name = "A2UpgradeAmmount";
            this.A2UpgradeAmmount.Size = new System.Drawing.Size(90, 37);
            this.A2UpgradeAmmount.TabIndex = 11;
            this.A2UpgradeAmmount.Text = "Ulepsz ilość";
            this.A2UpgradeAmmount.UseVisualStyleBackColor = true;
            this.A2UpgradeAmmount.Click += new System.EventHandler(this.A2UpgradeAmmount_Click);
            // 
            // A2UpgradeInterval
            // 
            this.A2UpgradeInterval.Location = new System.Drawing.Point(698, 198);
            this.A2UpgradeInterval.Name = "A2UpgradeInterval";
            this.A2UpgradeInterval.Size = new System.Drawing.Size(90, 39);
            this.A2UpgradeInterval.TabIndex = 12;
            this.A2UpgradeInterval.Text = "Ulepsz częstotliwość";
            this.A2UpgradeInterval.UseVisualStyleBackColor = true;
            this.A2UpgradeInterval.Click += new System.EventHandler(this.A2UpgradeInterval_Click);
            // 
            // A2AmmountTextBox
            // 
            this.A2AmmountTextBox.Location = new System.Drawing.Point(592, 170);
            this.A2AmmountTextBox.Name = "A2AmmountTextBox";
            this.A2AmmountTextBox.ReadOnly = true;
            this.A2AmmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A2AmmountTextBox.TabIndex = 13;
            this.A2AmmountTextBox.Text = "0";
            this.A2AmmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A2IntervalTextBox
            // 
            this.A2IntervalTextBox.Location = new System.Drawing.Point(593, 214);
            this.A2IntervalTextBox.Name = "A2IntervalTextBox";
            this.A2IntervalTextBox.ReadOnly = true;
            this.A2IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A2IntervalTextBox.TabIndex = 14;
            this.A2IntervalTextBox.Text = "0";
            this.A2IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "/min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "/min";
            // 
            // A3IntervalTextBox
            // 
            this.A3IntervalTextBox.Location = new System.Drawing.Point(593, 335);
            this.A3IntervalTextBox.Name = "A3IntervalTextBox";
            this.A3IntervalTextBox.ReadOnly = true;
            this.A3IntervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.A3IntervalTextBox.TabIndex = 20;
            this.A3IntervalTextBox.Text = "0";
            this.A3IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.A3IntervalTextBox.TextChanged += new System.EventHandler(this.A3IntervalTextBox_TextChanged);
            // 
            // A3AmmountTextBox
            // 
            this.A3AmmountTextBox.Location = new System.Drawing.Point(592, 291);
            this.A3AmmountTextBox.Name = "A3AmmountTextBox";
            this.A3AmmountTextBox.ReadOnly = true;
            this.A3AmmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.A3AmmountTextBox.TabIndex = 19;
            this.A3AmmountTextBox.Text = "0";
            this.A3AmmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // A3UpgradeInterval
            // 
            this.A3UpgradeInterval.Location = new System.Drawing.Point(698, 319);
            this.A3UpgradeInterval.Name = "A3UpgradeInterval";
            this.A3UpgradeInterval.Size = new System.Drawing.Size(90, 39);
            this.A3UpgradeInterval.TabIndex = 18;
            this.A3UpgradeInterval.Text = "Ulepsz częstotliwość";
            this.A3UpgradeInterval.UseVisualStyleBackColor = true;
            this.A3UpgradeInterval.Click += new System.EventHandler(this.A3UpgradeInterval_Click);
            // 
            // A3UpgradeAmmount
            // 
            this.A3UpgradeAmmount.Location = new System.Drawing.Point(698, 276);
            this.A3UpgradeAmmount.Name = "A3UpgradeAmmount";
            this.A3UpgradeAmmount.Size = new System.Drawing.Size(90, 37);
            this.A3UpgradeAmmount.TabIndex = 17;
            this.A3UpgradeAmmount.Text = "Ulepsz ilość";
            this.A3UpgradeAmmount.UseVisualStyleBackColor = true;
            this.A3UpgradeAmmount.Click += new System.EventHandler(this.A3UpgradeAmmount_Click);
            // 
            // A3Label
            // 
            this.A3Label.AutoSize = true;
            this.A3Label.Location = new System.Drawing.Point(592, 273);
            this.A3Label.Name = "A3Label";
            this.A3Label.Size = new System.Drawing.Size(84, 15);
            this.A3Label.TabIndex = 16;
            this.A3Label.Text = "AutoUpgrade3";
            // 
            // A2Timer
            // 
            this.A2Timer.Tick += new System.EventHandler(this.A2Tick);
            // 
            // A3Timer
            // 
            this.A3Timer.Tick += new System.EventHandler(this.A3Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.A3IntervalTextBox);
            this.Controls.Add(this.A3AmmountTextBox);
            this.Controls.Add(this.A3UpgradeInterval);
            this.Controls.Add(this.A3UpgradeAmmount);
            this.Controls.Add(this.A3Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.A2IntervalTextBox);
            this.Controls.Add(this.A2AmmountTextBox);
            this.Controls.Add(this.A2UpgradeInterval);
            this.Controls.Add(this.A2UpgradeAmmount);
            this.Controls.Add(this.A2Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A1IntervalTextBox);
            this.Controls.Add(this.A1Label);
            this.Controls.Add(this.A1UpgradeInterval);
            this.Controls.Add(this.A1UpgradeAmmount);
            this.Controls.Add(this.A1AmmountTextBox);
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
        private TextBox A1AmmountTextBox;
        private Button A1UpgradeAmmount;
        private Button A1UpgradeInterval;
        private Label A1Label;
        private TextBox A1IntervalTextBox;
        private System.Windows.Forms.Timer A1Timer;
        private Label label1;
        private Label A2Label;
        private Button A2UpgradeAmmount;
        private Button A2UpgradeInterval;
        private TextBox A2AmmountTextBox;
        private TextBox A2IntervalTextBox;
        private Label label2;
        private Label label3;
        private TextBox A3IntervalTextBox;
        private TextBox A3AmmountTextBox;
        private Button A3UpgradeInterval;
        private Button A3UpgradeAmmount;
        private Label A3Label;
        private System.Windows.Forms.Timer A2Timer;
        private System.Windows.Forms.Timer A3Timer;
    }
}