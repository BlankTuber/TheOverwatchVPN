namespace TheOverwatchVPN
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            na_Btn = new CheckBox();
            sa_Btn = new CheckBox();
            eu_Btn = new CheckBox();
            asia_Btn = new CheckBox();
            oceania_Btn = new CheckBox();
            exit_Btn = new Button();
            infotext = new Label();
            githublink = new LinkLabel();
            SuspendLayout();
            // 
            // na_Btn
            // 
            na_Btn.Appearance = Appearance.Button;
            na_Btn.AutoSize = true;
            na_Btn.BackColor = Color.LimeGreen;
            na_Btn.CheckAlign = ContentAlignment.BottomCenter;
            na_Btn.Cursor = Cursors.Hand;
            na_Btn.FlatAppearance.CheckedBackColor = Color.Red;
            na_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            na_Btn.FlatAppearance.MouseOverBackColor = Color.Green;
            na_Btn.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold | FontStyle.Italic);
            na_Btn.ForeColor = Color.White;
            na_Btn.Location = new Point(15, 12);
            na_Btn.MaximumSize = new Size(200, 100);
            na_Btn.MinimumSize = new Size(200, 100);
            na_Btn.Name = "na_Btn";
            na_Btn.Size = new Size(200, 100);
            na_Btn.TabIndex = 0;
            na_Btn.Text = "North-America";
            na_Btn.TextAlign = ContentAlignment.MiddleCenter;
            na_Btn.UseVisualStyleBackColor = false;
            na_Btn.CheckedChanged += na_Btn_CheckedChanged;
            na_Btn.MouseEnter += hovereffect;
            na_Btn.MouseLeave += removehovereffect;
            // 
            // sa_Btn
            // 
            sa_Btn.Appearance = Appearance.Button;
            sa_Btn.AutoSize = true;
            sa_Btn.BackColor = Color.LimeGreen;
            sa_Btn.CheckAlign = ContentAlignment.BottomCenter;
            sa_Btn.Cursor = Cursors.Hand;
            sa_Btn.FlatAppearance.CheckedBackColor = Color.Red;
            sa_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            sa_Btn.FlatAppearance.MouseOverBackColor = Color.Green;
            sa_Btn.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold | FontStyle.Italic);
            sa_Btn.ForeColor = Color.White;
            sa_Btn.Location = new Point(251, 12);
            sa_Btn.MaximumSize = new Size(200, 100);
            sa_Btn.MinimumSize = new Size(200, 100);
            sa_Btn.Name = "sa_Btn";
            sa_Btn.Size = new Size(200, 100);
            sa_Btn.TabIndex = 1;
            sa_Btn.Text = "South-America";
            sa_Btn.TextAlign = ContentAlignment.MiddleCenter;
            sa_Btn.UseVisualStyleBackColor = false;
            sa_Btn.CheckedChanged += sa_Btn_CheckedChanged;
            sa_Btn.MouseEnter += hovereffect;
            sa_Btn.MouseLeave += removehovereffect;
            // 
            // eu_Btn
            // 
            eu_Btn.Appearance = Appearance.Button;
            eu_Btn.AutoSize = true;
            eu_Btn.BackColor = Color.LimeGreen;
            eu_Btn.CheckAlign = ContentAlignment.BottomCenter;
            eu_Btn.Cursor = Cursors.Hand;
            eu_Btn.FlatAppearance.CheckedBackColor = Color.Red;
            eu_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            eu_Btn.FlatAppearance.MouseOverBackColor = Color.Green;
            eu_Btn.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold | FontStyle.Italic);
            eu_Btn.ForeColor = Color.White;
            eu_Btn.Location = new Point(487, 12);
            eu_Btn.MaximumSize = new Size(200, 100);
            eu_Btn.MinimumSize = new Size(200, 100);
            eu_Btn.Name = "eu_Btn";
            eu_Btn.Size = new Size(200, 100);
            eu_Btn.TabIndex = 2;
            eu_Btn.Text = "Europe";
            eu_Btn.TextAlign = ContentAlignment.MiddleCenter;
            eu_Btn.UseVisualStyleBackColor = false;
            eu_Btn.CheckedChanged += eu_Btn_CheckedChanged;
            eu_Btn.MouseEnter += hovereffect;
            eu_Btn.MouseLeave += removehovereffect;
            // 
            // asia_Btn
            // 
            asia_Btn.Appearance = Appearance.Button;
            asia_Btn.AutoSize = true;
            asia_Btn.BackColor = Color.LimeGreen;
            asia_Btn.CheckAlign = ContentAlignment.BottomCenter;
            asia_Btn.Cursor = Cursors.Hand;
            asia_Btn.FlatAppearance.CheckedBackColor = Color.Red;
            asia_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            asia_Btn.FlatAppearance.MouseOverBackColor = Color.Green;
            asia_Btn.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold | FontStyle.Italic);
            asia_Btn.ForeColor = Color.White;
            asia_Btn.Location = new Point(723, 12);
            asia_Btn.MaximumSize = new Size(200, 100);
            asia_Btn.MinimumSize = new Size(200, 100);
            asia_Btn.Name = "asia_Btn";
            asia_Btn.Size = new Size(200, 100);
            asia_Btn.TabIndex = 3;
            asia_Btn.Text = "Asia";
            asia_Btn.TextAlign = ContentAlignment.MiddleCenter;
            asia_Btn.UseVisualStyleBackColor = false;
            asia_Btn.CheckedChanged += asia_Btn_CheckedChanged;
            asia_Btn.MouseEnter += hovereffect;
            asia_Btn.MouseLeave += removehovereffect;
            // 
            // oceania_Btn
            // 
            oceania_Btn.Appearance = Appearance.Button;
            oceania_Btn.AutoSize = true;
            oceania_Btn.BackColor = Color.LimeGreen;
            oceania_Btn.CheckAlign = ContentAlignment.BottomCenter;
            oceania_Btn.Cursor = Cursors.Hand;
            oceania_Btn.FlatAppearance.CheckedBackColor = Color.Red;
            oceania_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            oceania_Btn.FlatAppearance.MouseOverBackColor = Color.Green;
            oceania_Btn.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold | FontStyle.Italic);
            oceania_Btn.ForeColor = Color.White;
            oceania_Btn.Location = new Point(959, 12);
            oceania_Btn.MaximumSize = new Size(200, 100);
            oceania_Btn.MinimumSize = new Size(200, 100);
            oceania_Btn.Name = "oceania_Btn";
            oceania_Btn.Size = new Size(200, 100);
            oceania_Btn.TabIndex = 4;
            oceania_Btn.Text = "Oceania";
            oceania_Btn.TextAlign = ContentAlignment.MiddleCenter;
            oceania_Btn.UseVisualStyleBackColor = false;
            oceania_Btn.CheckedChanged += oceania_Btn_CheckedChanged;
            oceania_Btn.MouseEnter += hovereffect;
            oceania_Btn.MouseLeave += removehovereffect;
            // 
            // exit_Btn
            // 
            exit_Btn.BackColor = Color.DimGray;
            exit_Btn.Cursor = Cursors.Hand;
            exit_Btn.FlatAppearance.BorderColor = Color.Blue;
            exit_Btn.FlatAppearance.MouseDownBackColor = Color.Black;
            exit_Btn.FlatAppearance.MouseOverBackColor = Color.Gray;
            exit_Btn.Font = new Font("Microsoft Sans Serif", 30F);
            exit_Btn.ForeColor = SystemColors.ButtonHighlight;
            exit_Btn.Location = new Point(462, 276);
            exit_Btn.Name = "exit_Btn";
            exit_Btn.Size = new Size(250, 75);
            exit_Btn.TabIndex = 6;
            exit_Btn.Text = "Exit";
            exit_Btn.UseVisualStyleBackColor = false;
            exit_Btn.Click += exit_Btn_Click;
            exit_Btn.MouseEnter += grayHover;
            exit_Btn.MouseLeave += grayLeave;
            // 
            // infotext
            // 
            infotext.AutoSize = true;
            infotext.Location = new Point(412, 159);
            infotext.MaximumSize = new Size(350, 60);
            infotext.MinimumSize = new Size(350, 60);
            infotext.Name = "infotext";
            infotext.Size = new Size(350, 60);
            infotext.TabIndex = 7;
            infotext.Text = "Green means that the location is accessible.\r\nRed means it is disabled, and unaccessible.";
            infotext.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // githublink
            // 
            githublink.AutoSize = true;
            githublink.BackColor = SystemColors.InfoText;
            githublink.Cursor = Cursors.Hand;
            githublink.LinkColor = SystemColors.ActiveCaption;
            githublink.Location = new Point(1038, 345);
            githublink.MinimumSize = new Size(125, 25);
            githublink.Name = "githublink";
            githublink.Size = new Size(125, 25);
            githublink.TabIndex = 8;
            githublink.TabStop = true;
            githublink.Text = "To github page";
            githublink.TextAlign = ContentAlignment.MiddleCenter;
            githublink.VisitedLinkColor = Color.Fuchsia;
            githublink.LinkClicked += goToPage;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.dalledonwload;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1175, 379);
            Controls.Add(githublink);
            Controls.Add(infotext);
            Controls.Add(exit_Btn);
            Controls.Add(oceania_Btn);
            Controls.Add(asia_Btn);
            Controls.Add(eu_Btn);
            Controls.Add(sa_Btn);
            Controls.Add(na_Btn);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The Overwatch VPN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox na_Btn;
        private CheckBox sa_Btn;
        private CheckBox eu_Btn;
        private CheckBox asia_Btn;
        private CheckBox oceania_Btn;
        private Button exit_Btn;
        private Label infotext;
        private LinkLabel githublink;
    }
}
