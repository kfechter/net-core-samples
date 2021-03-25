using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Windows.Forms.VisualStyles;
using System.DirectoryServices.ActiveDirectory;

namespace SystemInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtMachineName.Text = MachineName;
            txtDomainName.Text = DomainName;
            txtProcessor.Text = ProcessorInfo;
            txtOSVersion.Text = OSVersion;
            txtCLRVersion.Text = CLRVersion;
            txtSystemDirectory.Text = SystemDirectory;
            txtVisualStyle.Text = VisualStyle;
            txtStyleSupported.Text = VisualStylesSupported;
            uptimeClock.Enabled = true;

            foreach (DriveInfo driveInfo in SystemDrives)
            {
                TreeNode driveInfoNode = new TreeNode(driveInfo.Name);
                driveInfoNode.Nodes.Add(new TreeNode($"Drive Type: {driveInfo.DriveType}"));

                if(driveInfo.IsReady)
                {
                    driveInfoNode.Nodes.Add($"Volume Label: {driveInfo.VolumeLabel}");
                    driveInfoNode.Nodes.Add($"Drive Format: {driveInfo.DriveFormat}");
                    driveInfoNode.Nodes.Add($"Total Free Space (bytes): {driveInfo.TotalFreeSpace}");
                    driveInfoNode.Nodes.Add($"Total Size (bytes): {driveInfo.TotalSize}");
                }

                trDriveInfo.Nodes.Add(driveInfoNode);
            }
        }

        private string ProcessorInfo => $"CPU: {GetProcessorModel()} ({Environment.ProcessorCount})";

        private string MachineName => $"Computer Name: {Environment.MachineName}";

        private string OSVersion => $"OS Version: {Environment.OSVersion} {(Environment.Is64BitOperatingSystem ? "(64-Bit)" : "")}";

        private string CLRVersion => $"CLR Version: {Environment.Version}";

        private string DomainName => $"Domain: {(Environment.UserDomainName != Environment.MachineName ? Environment.UserDomainName : "Not Domain Joined")}";

        private string SystemDirectory => $"System Directory: {Environment.SystemDirectory}";

        private DriveInfo[] SystemDrives => DriveInfo.GetDrives();

        private string VisualStyle => $"Visual Style: {VisualStyleInformation.DisplayName}";

        private string VisualStylesSupported => $"Visual Styles Supported: {(VisualStyleRenderer.IsSupported ? "Yes" : "No")}";

        private string SystemUptime => $"System Uptime (milliseconds): {Environment.TickCount}";

        private string GetProcessorModel()
        {
            try
            {
                string ComputerName = "localhost";
                ManagementScope Scope;
                Scope = new ManagementScope(String.Format("\\\\{0}\\root\\CIMV2", ComputerName), null);
                Scope.Connect();
                ObjectQuery Query = new ObjectQuery("SELECT Name FROM Win32_Processor");
                ManagementObjectSearcher Searcher = new ManagementObjectSearcher(Scope, Query);

                foreach (ManagementObject WmiObject in Searcher.Get())
                {
                    return WmiObject["Name"].ToString();
                }

                return "No processor information found";
            }
            catch (Exception)
            {
                return "Error while getting processor name";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtSystemUptime.Text = SystemUptime;
        }
    }
}
