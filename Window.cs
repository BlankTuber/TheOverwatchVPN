namespace TheOverwatchVPN
{
    public partial class Window : Form
    {
        private FireWallManager fireWallManager = new FireWallManager();
        public Window()
        {
            InitializeComponent();
        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!e.Cancel)  // Check if the closing process hasn't been canceled by other means.
            {
                // Prevent new operations from starting
                exit_Btn.Enabled = false;

                // Signal that the form should not close immediately
                e.Cancel = true;

                // Perform the cleanup operations asynchronously
                await DisableAllFirewallRulesAsync();

                // After cleanup, close the form for real
                e.Cancel = false;
            }
        }

        private async Task DisableAllFirewallRulesAsync()
        {
            // Asynchronously disable rules for all regions. This method needs to be defined in your FireWallManager.
            // Make sure this logic matches your needs and handles exceptions properly.
            await fireWallManager.DisableRegionRules("na");
            await fireWallManager.DisableRegionRules("sa");
            await fireWallManager.DisableRegionRules("europe");
            await fireWallManager.DisableRegionRules("asia");
            await fireWallManager.DisableRegionRules("oceania");
        }


        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
        }

        private async void na_Btn_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    await fireWallManager.EnableRegionRules("na");
                }
                else
                {
                    await fireWallManager.DisableRegionRules("na");
                }
            }
        }


        private async void sa_Btn_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    await fireWallManager.EnableRegionRules("sa");
                }
                else
                {
                    await fireWallManager.DisableRegionRules("sa");
                }
            }
        }

        private async void eu_Btn_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    await fireWallManager.EnableRegionRules("europe");
                }
                else
                {
                    await fireWallManager.DisableRegionRules("europe");
                }
            }
        }

        private async void asia_Btn_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    await fireWallManager.EnableRegionRules("asia");
                }
                else
                {
                    await fireWallManager.DisableRegionRules("asia");
                }
            }
        }

        private async void oceania_Btn_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    await fireWallManager.EnableRegionRules("oceania");
                }
                else
                {
                    await fireWallManager.DisableRegionRules("oceania");
                }
            }
        }

        private void exit_Btn_Click(object sender, EventArgs e)
        {
            // Optionally disable the exit button to prevent multiple clicks
            exit_Btn.Enabled = false;

            // Initiate closing the form.
            this.Close();
        }


    }
}
