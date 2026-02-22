namespace ACTION_TIMER
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            dtpClockTime = new DateTimePicker();
            rdoClock = new RadioButton();
            rdoCountdown = new RadioButton();
            label4 = new Label();
            lblCountdown = new Label();
            txtTime = new TextBox();
            lblTime = new Label();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            btnStart = new Button();
            panel2 = new Panel();
            txtProgramName = new TextBox();
            cmbAction = new ComboBox();
            panel3 = new Panel();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dtpClockTime);
            panel1.Controls.Add(rdoClock);
            panel1.Controls.Add(rdoCountdown);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblCountdown);
            panel1.Controls.Add(txtTime);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 225);
            panel1.TabIndex = 0;
            // 
            // dtpClockTime
            // 
            dtpClockTime.Format = DateTimePickerFormat.Time;
            dtpClockTime.Location = new Point(13, 138);
            dtpClockTime.Name = "dtpClockTime";
            dtpClockTime.ShowUpDown = true;
            dtpClockTime.Size = new Size(127, 23);
            dtpClockTime.TabIndex = 11;
            dtpClockTime.ValueChanged += dtpClockTime_ValueChanged;
            // 
            // rdoClock
            // 
            rdoClock.AutoSize = true;
            rdoClock.Location = new Point(187, 145);
            rdoClock.Name = "rdoClock";
            rdoClock.Size = new Size(14, 13);
            rdoClock.TabIndex = 10;
            rdoClock.TabStop = true;
            rdoClock.UseVisualStyleBackColor = true;
            rdoClock.CheckedChanged += rdoClock_CheckedChanged;
            // 
            // rdoCountdown
            // 
            rdoCountdown.AutoSize = true;
            rdoCountdown.Location = new Point(187, 74);
            rdoCountdown.Name = "rdoCountdown";
            rdoCountdown.Size = new Size(14, 13);
            rdoCountdown.TabIndex = 0;
            rdoCountdown.TabStop = true;
            rdoCountdown.UseVisualStyleBackColor = true;
            rdoCountdown.CheckedChanged += rdoCountdown_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Aquamarine;
            label4.Location = new Point(13, 120);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 9;
            label4.Text = "Enter time (in Clock)";
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.BackColor = Color.Transparent;
            lblCountdown.ForeColor = Color.Aquamarine;
            lblCountdown.Location = new Point(13, 189);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(81, 15);
            lblCountdown.TabIndex = 8;
            lblCountdown.Text = "Time left  :  —";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(13, 70);
            txtTime.Name = "txtTime";
            txtTime.PlaceholderText = "(empty)";
            txtTime.Size = new Size(127, 23);
            txtTime.TabIndex = 3;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.ForeColor = Color.Aquamarine;
            lblTime.Location = new Point(12, 52);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(128, 15);
            lblTime.TabIndex = 2;
            lblTime.Text = "Enter time (in minutes)";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(26, 26, 26);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(238, 29);
            panel4.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Aquamarine;
            label3.Location = new Point(80, 5);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 1;
            label3.Text = "TIMER";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Aquamarine;
            label2.Location = new Point(257, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 0;
            label2.Text = "ACTIONS";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(204, 160);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "STOP";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(6, 160);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 6;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtProgramName);
            panel2.Controls.Add(cmbAction);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnStart);
            panel2.Controls.Add(btnCancel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(240, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 225);
            panel2.TabIndex = 1;
            // 
            // txtProgramName
            // 
            txtProgramName.Location = new Point(6, 110);
            txtProgramName.Name = "txtProgramName";
            txtProgramName.PlaceholderText = "program name exact";
            txtProgramName.Size = new Size(273, 23);
            txtProgramName.TabIndex = 8;
            txtProgramName.Visible = false;
            // 
            // cmbAction
            // 
            cmbAction.AutoCompleteCustomSource.AddRange(new string[] { "SHUT DOWN", "RESTART", "SLEEP", "LOG OFF", "PROGRAM", "CUSTOM" });
            cmbAction.FormattingEnabled = true;
            cmbAction.Items.AddRange(new object[] { "SHUT DOWN", "RESTART", "SLEEP", "LOG OFF", "LOCK SYSTEM", "OPEN PROGRAM" });
            cmbAction.Location = new Point(6, 71);
            cmbAction.Name = "cmbAction";
            cmbAction.Size = new Size(273, 23);
            cmbAction.TabIndex = 5;
            cmbAction.Text = "select action";
            cmbAction.SelectedIndexChanged += cmbAction_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 26, 26);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 30);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aquamarine;
            label1.Location = new Point(103, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 0;
            label1.Text = "ACTIONS";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(531, 225);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ACTION TIMER";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label lblTime;
        private TextBox txtTime;
        private ComboBox cmbAction;
        private Label lblCountdown;
        private Button btnCancel;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private RadioButton rdoCountdown;
        private RadioButton rdoClock;
        private DateTimePicker dtpClockTime;
        private TextBox txtProgramName;
    }
}
