namespace idle_clicker
{
    public partial class Form1 : Form
    {
        private int cash;
        public int Cash
        {
            set
            {
                cash = value;
                money.Text = "Cash: $" + value.ToString();
            }
            get
            {
                return cash;
            }
        }
        int buttonLevel;
        int A1Ammount;
        int A1Interval;  // iloœæ cykli na minutê
        int A2Ammount;
        int A2Interval;
        int A3Ammount;
        int A3Interval;
        public Form1()
        {
            InitializeComponent();
            Cash = 0;
            buttonLevel = 1;

            A1Ammount = 10;
            A1Interval = 0;
            A1AmmountTextBox.Text = A1Ammount.ToString();
            A1IntervalTextBox.Text = A1Interval.ToString();

            A2Ammount = 10;
            A2Interval = 0;
            A2AmmountTextBox.Text = A2Ammount.ToString();
            A2IntervalTextBox.Text = A2Interval.ToString();

            A3Ammount = 10;
            A3Interval = 0;
            A3AmmountTextBox.Text = A3Ammount.ToString();
            A3IntervalTextBox.Text = A3Interval.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cash += (int)Math.Pow(10, buttonLevel - 1);
            //money.Text = "Money: $" + cash.ToString();
        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, buttonLevel);
            if (Cash > upgradeCost)
            {
                buttonLevel++;
                buttonLevelTextBox.Text = buttonLevel.ToString();
                Cash -= upgradeCost;
                //money.Text = "Money: $" + cash.ToString();
                string nextUpgradeCost = "($" + Math.Pow(10, buttonLevel).ToString() + ")";
                upgradeButton.Text = "Upgrade\n" + nextUpgradeCost;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void A1UpgradeInterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = A1Interval * 100;
            if (Cash >= upgradeCost) {
                A1Interval++;
                A1IntervalTextBox.Text = A1Interval.ToString();
                A1Timer.Interval = (60 / A1Interval) + 100;
                if (!A1Timer.Enabled)
                    A1Timer.Enabled = true;
                Cash -= upgradeCost;
                //money.Text = "Money: $" + cash.ToString();
            }
        }

        private void A1Tick(object sender, EventArgs e)
        {
            Cash += A1Ammount;
            //money.Text = "Money: $" + cash.ToString();
        }

        private void A1UpgradeAmmount_Click(object sender, EventArgs e)
        {
            A1Ammount += 10;
            A1AmmountTextBox.Text = A1Ammount.ToString();
        }

        private void A2Tick(object sender, EventArgs e)
        {
            Cash += A2Ammount;
        }

        private void A3Tick(object sender, EventArgs e)
        {
            Cash += A3Ammount;
        }

        private void A2UpgradeAmmount_Click(object sender, EventArgs e)
        {
            A2Ammount += 10;
            A2AmmountTextBox.Text = A2Ammount.ToString();
        }

        private void A2UpgradeInterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = A2Interval * 100;
            if (Cash >= upgradeCost)
            {
                A2Interval++;
                A2IntervalTextBox.Text = A2Interval.ToString();
                A2Timer.Interval = (60 / A2Interval) + 100;
                if (!A2Timer.Enabled)
                    A2Timer.Enabled = true;
                Cash -= upgradeCost;
            }
        }

        private void A3UpgradeAmmount_Click(object sender, EventArgs e)
        {
            A3Ammount += 10;
            A3AmmountTextBox.Text = A3Ammount.ToString();
        }

        private void A3UpgradeInterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = A3Interval * 100;
            if (Cash >= upgradeCost)
            {
                A3Interval++;
                A3IntervalTextBox.Text = A3Interval.ToString();
                A3Timer.Interval = (60 / A3Interval) + 100;
                if (!A3Timer.Enabled)
                    A3Timer.Enabled = true;
                Cash -= upgradeCost;
            }
        }

        private void A3IntervalTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}