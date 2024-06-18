namespace FolderSync
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            gbFolders = new GroupBox();
            lblReplica = new Label();
            lblSrc = new Label();
            btnBrowseReplica = new Button();
            btnBrowseSrc = new Button();
            tbReplica = new TextBox();
            tbSource = new TextBox();
            gbControls = new GroupBox();
            lblSeconds = new Label();
            udInterval = new NumericUpDown();
            lblSyncInterval = new Label();
            btnLog = new Button();
            btnStop = new Button();
            btnStart = new Button();
            gbLog = new GroupBox();
            lbLog = new ListBox();
            tSync = new System.Windows.Forms.Timer(components);
            gbFolders.SuspendLayout();
            gbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udInterval).BeginInit();
            gbLog.SuspendLayout();
            SuspendLayout();
            // 
            // gbFolders
            // 
            gbFolders.Controls.Add(lblReplica);
            gbFolders.Controls.Add(lblSrc);
            gbFolders.Controls.Add(btnBrowseReplica);
            gbFolders.Controls.Add(btnBrowseSrc);
            gbFolders.Controls.Add(tbReplica);
            gbFolders.Controls.Add(tbSource);
            gbFolders.Location = new Point(13, 17);
            gbFolders.Name = "gbFolders";
            gbFolders.Size = new Size(655, 127);
            gbFolders.TabIndex = 0;
            gbFolders.TabStop = false;
            gbFolders.Text = "Folders";
            // 
            // lblReplica
            // 
            lblReplica.AutoSize = true;
            lblReplica.Location = new Point(6, 80);
            lblReplica.Name = "lblReplica";
            lblReplica.Size = new Size(84, 15);
            lblReplica.TabIndex = 5;
            lblReplica.Text = "Replica Folder:";
            // 
            // lblSrc
            // 
            lblSrc.AutoSize = true;
            lblSrc.Location = new Point(6, 24);
            lblSrc.Name = "lblSrc";
            lblSrc.Size = new Size(82, 15);
            lblSrc.TabIndex = 4;
            lblSrc.Text = "Source Folder:";
            // 
            // btnBrowseReplica
            // 
            btnBrowseReplica.Location = new Point(574, 98);
            btnBrowseReplica.Name = "btnBrowseReplica";
            btnBrowseReplica.Size = new Size(75, 23);
            btnBrowseReplica.TabIndex = 3;
            btnBrowseReplica.Text = "Browse";
            btnBrowseReplica.UseVisualStyleBackColor = true;
            btnBrowseReplica.Click += btnBrowseReplica_Click;
            // 
            // btnBrowseSrc
            // 
            btnBrowseSrc.Location = new Point(574, 42);
            btnBrowseSrc.Name = "btnBrowseSrc";
            btnBrowseSrc.Size = new Size(75, 23);
            btnBrowseSrc.TabIndex = 2;
            btnBrowseSrc.Text = "Browse";
            btnBrowseSrc.UseVisualStyleBackColor = true;
            btnBrowseSrc.Click += btnBrowseSrc_Click;
            // 
            // tbReplica
            // 
            tbReplica.Location = new Point(6, 98);
            tbReplica.Name = "tbReplica";
            tbReplica.ReadOnly = true;
            tbReplica.Size = new Size(545, 23);
            tbReplica.TabIndex = 1;
            // 
            // tbSource
            // 
            tbSource.Location = new Point(6, 42);
            tbSource.Name = "tbSource";
            tbSource.ReadOnly = true;
            tbSource.Size = new Size(545, 23);
            tbSource.TabIndex = 0;
            // 
            // gbControls
            // 
            gbControls.Controls.Add(lblSeconds);
            gbControls.Controls.Add(udInterval);
            gbControls.Controls.Add(lblSyncInterval);
            gbControls.Controls.Add(btnLog);
            gbControls.Controls.Add(btnStop);
            gbControls.Controls.Add(btnStart);
            gbControls.Location = new Point(13, 150);
            gbControls.Name = "gbControls";
            gbControls.Size = new Size(655, 100);
            gbControls.TabIndex = 1;
            gbControls.TabStop = false;
            gbControls.Text = "Controls";
            // 
            // lblSeconds
            // 
            lblSeconds.AutoSize = true;
            lblSeconds.Location = new Point(149, 35);
            lblSeconds.Name = "lblSeconds";
            lblSeconds.Size = new Size(50, 15);
            lblSeconds.TabIndex = 8;
            lblSeconds.Text = "seconds";
            // 
            // udInterval
            // 
            udInterval.Location = new Point(92, 33);
            udInterval.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            udInterval.Name = "udInterval";
            udInterval.Size = new Size(51, 23);
            udInterval.TabIndex = 7;
            udInterval.TextAlign = HorizontalAlignment.Center;
            udInterval.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblSyncInterval
            // 
            lblSyncInterval.AutoSize = true;
            lblSyncInterval.Location = new Point(6, 35);
            lblSyncInterval.Name = "lblSyncInterval";
            lblSyncInterval.Size = new Size(80, 15);
            lblSyncInterval.TabIndex = 6;
            lblSyncInterval.Text = "Sync Interval: ";
            // 
            // btnLog
            // 
            btnLog.Location = new Point(211, 71);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(75, 23);
            btnLog.TabIndex = 5;
            btnLog.Text = "Save Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(107, 71);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop Sync";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(6, 71);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start Sync";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // gbLog
            // 
            gbLog.Controls.Add(lbLog);
            gbLog.Location = new Point(13, 256);
            gbLog.Name = "gbLog";
            gbLog.Size = new Size(655, 192);
            gbLog.TabIndex = 2;
            gbLog.TabStop = false;
            gbLog.Text = "Log";
            // 
            // lbLog
            // 
            lbLog.FormattingEnabled = true;
            lbLog.ItemHeight = 15;
            lbLog.Location = new Point(6, 22);
            lbLog.Name = "lbLog";
            lbLog.Size = new Size(643, 154);
            lbLog.TabIndex = 0;
            // 
            // tSync
            // 
            tSync.Tick += tSync_Tick;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 460);
            Controls.Add(gbLog);
            Controls.Add(gbControls);
            Controls.Add(gbFolders);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainUI";
            Text = "FolderSync";
            gbFolders.ResumeLayout(false);
            gbFolders.PerformLayout();
            gbControls.ResumeLayout(false);
            gbControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udInterval).EndInit();
            gbLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbFolders;
        private Label lblReplica;
        private Label lblSrc;
        private Button btnBrowseReplica;
        private Button btnBrowseSrc;
        private TextBox tbReplica;
        private TextBox tbSource;
        private GroupBox gbControls;
        private Button btnLog;
        private Button btnStop;
        private Button btnStart;
        private Label lblSeconds;
        private NumericUpDown udInterval;
        private Label lblSyncInterval;
        private GroupBox gbLog;
        private ListBox lbLog;
        private System.Windows.Forms.Timer tSync;
    }
}
