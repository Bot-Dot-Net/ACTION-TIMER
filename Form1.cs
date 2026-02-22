namespace ACTION_TIMER

{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;

    public partial class Form1 : Form
    {
        bool warningShown = false;
        bool cancelPending = false;

        int timeLeft = 0;
        string selectedAction = "";
        DateTime targetTime;

        [DllImport("user32.dll")]
        public static extern void LockWorkStation();

        List<string> recentPrograms = new List<string>();
        string programToOpen = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void cmbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            string action = cmbAction.SelectedItem?.ToString();

            // Show textbox only if "Open Program" is selected
            txtProgramName.Visible = (action == "OPEN PROGRAM");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //if (int.TryParse(txtTime.Text, out int minutes))
            //{
            //    timeLeft = minutes * 60; // convert to seconds
            //    selectedAction = cmbAction.SelectedItem?.ToString();

            //    if (string.IsNullOrEmpty(selectedAction))
            //    {
            //        MessageBox.Show("Please select an action.");
            //        return;
            //    }

            //    timer1.Interval = 1000; // 1 second
            //    timer1.Start();
            //    lblCountdown.Text = $"Time left: {timeLeft} sec";
            //    btnStart.Enabled = false;
            //    txtTime.Enabled = false;
            //    cmbAction.Enabled = false;
            //}
            //else
            //{
            //    MessageBox.Show("Enter a valid time in minutes.");
            //}

            selectedAction = cmbAction.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedAction))
            {
                MessageBox.Show("Please select an action.");
                return;
            }

            if (rdoCountdown.Checked)
            {
                if (int.TryParse(txtTime.Text, out int minutes))
                {
                    timeLeft = minutes * 60; // seconds
                    timer1.Interval = 1000;
                    timer1.Start();
                    lblCountdown.Text = $"Time left: {timeLeft} sec";
                }
                else
                {
                    MessageBox.Show("Enter a valid number of minutes.");
                    return;
                }
            }
            else if (rdoClock.Checked)
            {
                targetTime = dtpClockTime.Value;
                if (targetTime < DateTime.Now)
                {
                    // if time already passed today, schedule for tomorrow
                    targetTime = targetTime.AddDays(1);
                }
                timer1.Interval = 1000;
                timer1.Start();
                lblCountdown.Text = $"Action scheduled for {targetTime.ToLongTimeString()}";
            }
            if (cmbAction.SelectedItem?.ToString() == "OPEN PROGRAM")
            {
                programToOpen = txtProgramName.Text.Trim();

                if (string.IsNullOrEmpty(programToOpen))
                {
                    MessageBox.Show("Please type a program name to open.");
                    return;
                }

                // Remember it for later (avoid duplicates)
                if (!recentPrograms.Contains(programToOpen))
                    recentPrograms.Add(programToOpen);
            }


            btnStart.Enabled = false;
            txtTime.Enabled = false;
            cmbAction.Enabled = false;
            rdoCountdown.Enabled = false;
            rdoClock.Enabled = false;
            dtpClockTime.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ////timeLeft--;
            ////lblCountdown.Text = $"Time left: {timeLeft} sec";

            ////if (timeLeft <= 0)
            ////{
            ////    timer1.Stop();
            ////    PerformAction();
            ////}


            if (rdoCountdown.Checked)
            {
                timeLeft--;
                lblCountdown.Text = $"Time left: {timeLeft} sec";

                if (timeLeft <= 0)
                {
                    timer1.Stop();
                    PerformAction();
                }
            }
            else if (rdoClock.Checked)
            {
                TimeSpan remaining = targetTime - DateTime.Now;
                lblCountdown.Text = $"Time left: {remaining.Hours:D2}:{remaining.Minutes:D2}:{remaining.Seconds:D2}";

                if (remaining.TotalSeconds <= 0)
                {
                    timer1.Stop();
                    PerformAction();
                }
            }



            //if (rdoCountdown.Checked)
            //{
            //    timeLeft--;
            //    lblCountdown.Text = $"Time left: {timeLeft} sec";

            //    // show 5-second warning (only once)
            //    if (timeLeft == 5 && !warningShown)
            //    {
            //        warningShown = true;
            //        ShowWarningPopup();
            //    }

            //    if (timeLeft <= 0)
            //    {
            //        timer1.Stop();
            //        if (!cancelPending)
            //            PerformAction();
            //    }
            //}
            //else if (rdoClock.Checked)
            //{
            //    TimeSpan remaining = targetTime - DateTime.Now;
            //    lblCountdown.Text = $"Time left: {remaining.Hours:D2}:{remaining.Minutes:D2}:{remaining.Seconds:D2}";

            //    if (remaining.TotalSeconds <= 10 && !warningShown)
            //    {
            //        warningShown = true;
            //        ShowWarningPopup();
            //    }

            //    if (remaining.TotalSeconds <= 0)
            //    {
            //        timer1.Stop();
            //        if (!cancelPending)
            //            PerformAction();
            //    }
        //}
        }

        //private async void ShowWarningPopup()
        //{
        //    // Use a separate task so it doesn’t freeze the countdown
        //    await Task.Run(() =>
        //    {
        //        MessageBox.Show("⚠️ Action will execute in 10 seconds!\nClick Cancel if you wish to stop.\ndo you want to STOP",
        //            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    });
        //}


        private void PerformAction()
        {
            switch (selectedAction)
            {
                case "SHUT DOWN":
                    Process.Start("shutdown", "/s /t 0");
                    break;
                case "RESTART":
                    Process.Start("shutdown", "/r /t 0");
                    break;
                case "SLEEP":
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                    break;
                case "LOG OFF":
                    Process.Start("shutdown", "/l");
                    break;
                case "LOCK SYSTEM":
                    LockWorkStation();
                    break;
                case "OPEN PROGRAM":
                    if (string.IsNullOrEmpty(programToOpen))
                    {
                        MessageBox.Show("No program specified.");
                        break;
                    }

                    try
                    {
                        // Try to start directly
                        Process.Start(programToOpen);
                    }
                    catch
                    {
                        try
                        {
                            // If not found by name, search via Windows Search (Shell execute)
                            Process.Start("explorer.exe", $"shell:appsFolder\\{programToOpen}");
                        }
                        catch
                        {
                            MessageBox.Show($"Could not open program: {programToOpen}");
                        }
                    }
                    break;
            }

            MessageBox.Show("Action executed!");
            btnStart.Enabled = true;
            txtTime.Enabled = true;
            cmbAction.Enabled = true;
            warningShown = false;
            cancelPending = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            //lblCountdown.Text = "Timer cancelled.";
            //btnStart.Enabled = true;
            //txtTime.Enabled = true;
            //cmbAction.Enabled = true;
            //rdoCountdown.Enabled = true;
            //rdoClock.Enabled = true;
            //dtpClockTime.Enabled = true;

            timer1.Stop();
            cancelPending = true;
            lblCountdown.Text = "Timer cancelled.";
            btnStart.Enabled = true;
            txtTime.Enabled = true;
            cmbAction.Enabled = true;
            rdoCountdown.Enabled = true;
            rdoClock.Enabled = true;
            dtpClockTime.Enabled = true;
            warningShown = false;
        }

        private void rdoCountdown_CheckedChanged(object sender, EventArgs e)
        {
            txtTime.Enabled = rdoCountdown.Checked;
            dtpClockTime.Enabled = !rdoCountdown.Checked;
        }

        private void rdoClock_CheckedChanged(object sender, EventArgs e)
        {
            txtTime.Enabled = !rdoClock.Checked;
            dtpClockTime.Enabled = rdoClock.Checked;
        }

        private void dtpClockTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveRecentPrograms()
        {
            System.IO.File.WriteAllLines("recentPrograms.txt", recentPrograms);
        }

        private void LoadRecentPrograms()
        {
            if (System.IO.File.Exists("recentPrograms.txt"))
                recentPrograms = System.IO.File.ReadAllLines("recentPrograms.txt").ToList();
        }

    }
}
