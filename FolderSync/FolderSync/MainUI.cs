using System.Windows.Forms;

namespace FolderSync
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void btnBrowseSrc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbSource.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }

            if (tbSource.Text == tbReplica.Text && tbSource.Text != String.Empty)
            {
                tbSource.Text = String.Empty;
                MessageBox.Show("Source and replica folders must be diferent!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBrowseReplica_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbReplica.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }

            if (tbReplica.Text == tbSource.Text && tbReplica.Text != String.Empty)
            {
                tbReplica.Text = String.Empty;
                MessageBox.Show("Source and replica folders must be diferent!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lbLog.Items.Clear();
            lbLog.Items.Add("Sync started at " + DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"));
            lbLog.Items.Add("Source folder: " + tbSource.Text);
            lbLog.Items.Add("Replica folder: " + tbReplica.Text);
            lbLog.Items.Add("Sync interval: " + udInterval.Value.ToString()+" seconds.");
            tSync.Interval = Convert.ToInt32(udInterval.Value) * 1000;
            tSync.Start();
            btnStart.Enabled = false;
            btnBrowseSrc.Enabled = false;
            btnBrowseReplica.Enabled = false;
            btnStop.Enabled = true;
        }

        private void tSync_Tick(object sender, EventArgs e)
        {
            FileHandler fileHandler = new FileHandler(tbSource.Text, tbReplica.Text);

            fileHandler.EnumFiles();
            fileHandler.RemoveDeletedFiles(lbLog);

            fileHandler.EnumFiles();
            fileHandler.CopyMissingFiles(lbLog);

            fileHandler.EnumFiles();
            fileHandler.CheckRenamedFiles(lbLog);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tSync.Stop();
            lbLog.Items.Add("Sync stopped at " + DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt"));
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnBrowseSrc.Enabled = true;
            btnBrowseReplica.Enabled = true;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Text (*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in lbLog.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
            }
        }
    }
}
