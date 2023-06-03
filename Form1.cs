using System.Diagnostics; // for Process

namespace tftpc
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select file or output directory";
            fileDialog.CheckFileExists = false;
            fileDialog.CheckPathExists = true;
            fileDialog.Multiselect = false;
            fileDialog.ReadOnlyChecked = false;
            fileDialog.ValidateNames = false;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                local_textbox.Text = fileDialog.FileName;
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            string server = server_textbox.Text;
            string remote = remote_textbox.Text;
            string local = local_textbox.Text;
            string operation = operation_combo.Text;

            if (server == "")
            {
                MessageBox.Show("Please enter a server address");
                return;
            }
            if (remote == "")
            {
                MessageBox.Show("Please enter a remote filename");
                return;
            }
            if (local == "")
            {
                MessageBox.Show("Please enter a local filename");
                return;
            }
            if (operation == "")
            {
                MessageBox.Show("Please select an operation");
                return;
            }

            if (operation == "Download")
            {
                // run tftpc-cli.exe with the arguments: tftpc-cli.exe <server> <get> <remote> <local>
                Process process = new Process();
                process.StartInfo.FileName = "tftpc-cli.exe";
                process.StartInfo.Arguments = server + " get " + remote + " " + local;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                MessageBox.Show(process.StartInfo.Arguments);
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                MessageBox.Show(output);
            }
            else if (operation == "Upload")
            {
                // run tftpc-cli.exe with the arguments: tftpc-cli.exe <server> <put> <remote> <local>
                Process process = new Process();
                process.StartInfo.FileName = "tftpc-cli.exe";
                process.StartInfo.Arguments = server + " put " + remote + " " + local;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                // show whole command:
                MessageBox.Show(process.StartInfo.FileName + " " + process.StartInfo.Arguments);
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                MessageBox.Show(output);
            }
            else
            {
                MessageBox.Show("Invalid operation");
            }
        }
    }
}