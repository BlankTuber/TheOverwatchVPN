using System.Diagnostics;

namespace TheOverwatchVPN
{
    public partial class Window : Form
    {
        private FireWallManager fireWallManager = new FireWallManager();
        public Window()
        {
            InitializeComponent();
        }

        private bool cleanupInitiated = false;

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!e.Cancel && !cleanupInitiated)
            {
                // Signal that cleanup has started
                cleanupInitiated = true;

                // Prevent new operations from starting
                exit_Btn.Enabled = false;

                // Minimize the form to give visual feedback that the close process has started
                this.WindowState = FormWindowState.Minimized;

                // Signal that the form should not close immediately
                e.Cancel = true;

                // Perform the cleanup operations asynchronously
                await DisableAllFirewallRulesAsync();

                // Cleanup is done, allow the form to close
                e.Cancel = false;
                this.Close(); // This call will now only happen once after cleanup
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
                    checkBox.BackColor = Color.Red;
                }
                else
                {
                    await fireWallManager.DisableRegionRules("na");
                    checkBox.BackColor = Color.LimeGreen;
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
                    checkBox.BackColor = Color.Red;
                }
                else
                {
                    await fireWallManager.DisableRegionRules("sa");
                    checkBox.BackColor = Color.LimeGreen;
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
                    checkBox.BackColor = Color.Red;
                }
                else
                {
                    await fireWallManager.DisableRegionRules("europe");
                    checkBox.BackColor = Color.LimeGreen;
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
                    checkBox.BackColor = Color.Red;
                }
                else
                {
                    await fireWallManager.DisableRegionRules("asia");
                    checkBox.BackColor = Color.LimeGreen;
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
                    checkBox.BackColor = Color.Red;
                }
                else
                {
                    await fireWallManager.DisableRegionRules("oceania");
                    checkBox.BackColor = Color.LimeGreen;
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

        private void hovereffect(object sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;

            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    checkBox.BackColor = Color.DarkRed;
                }
                else
                {
                    checkBox.BackColor = Color.Green;
                }
            }
        }

        private void removehovereffect(object sender, EventArgs e)
        {
            CheckBox? checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    checkBox.BackColor = Color.Red;
                }
                else
                {
                    checkBox.BackColor = Color.LimeGreen;
                }
            }
        }

        private void grayHover(object sender, EventArgs e)
        {
            exit_Btn.BackColor = Color.Black;
        }

        private void grayLeave(object sender, EventArgs e)
        {
            exit_Btn.BackColor = Color.Gray;

        }

        private void goToPage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Use ProcessStartInfo to set up the web link opening
                var psi = new ProcessStartInfo
                {
                    FileName = "https://github.com/BlankTuber/TheOverwatchVPN",
                    UseShellExecute = true // This is required to specify that an external process, like a browser, should be used
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // If an error occurs, catch it and display or log it
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
