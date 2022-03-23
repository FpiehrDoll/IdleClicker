namespace idle_clicker
{
    public partial class Form1 : Form
    {
        int cash;
        int buttonLevel;
        public Form1()
        {
            InitializeComponent();
            cash = 0;
            buttonLevel = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cash += (int)Math.Pow(10, buttonLevel-1);
            money.Text = "Money: $" + cash.ToString();
        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, buttonLevel);
            if(cash > upgradeCost)
            {
                buttonLevel++;
                buttonLevelTextBox.Text = buttonLevel.ToString();
                cash -= upgradeCost;
                money.Text = "Money: $" + cash.ToString();
                string nextUpgradeCost = "($" + Math.Pow(10, buttonLevel).ToString() + ")";
                upgradeButton.Text = "Upgrade\n" + nextUpgradeCost;
            }
        }
    }
}