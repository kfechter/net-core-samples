using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWatcher
{
    public partial class Form1 : Form
    {
        FileSystemWatcher fileWatcher;
        private delegate void SafeCallDelegate(string text);

        public Form1()
        {
            InitializeComponent();
            toolStripButton1.Click += ToolStripButton1_Click;
            fileWatcher = new FileSystemWatcher();
            fileWatcher.Changed += FileWatcher_Changed;
            fileWatcher.Created += FileWatcher_Created;
            fileWatcher.Deleted += FileWatcher_Deleted;
            fileWatcher.Renamed += FileWatcher_Renamed;
        }

        private void FileWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            AddItemThreadSafe(e.Name + " Renamed");
        }

        private void FileWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            AddItemThreadSafe(e.Name + " Deleted");
        }

        private void FileWatcher_Created(object sender, FileSystemEventArgs e)
        {
            AddItemThreadSafe(e.Name + " Created");
        }

        private void FileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            AddItemThreadSafe(e.Name + " Changed");
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                toolStripButton1.Text = folderBrowserDialog.SelectedPath;
                fileWatcher.Path = folderBrowserDialog.SelectedPath;
                fileWatcher.IncludeSubdirectories = true;
                fileWatcher.Filter = "*.*";
                fileWatcher.EnableRaisingEvents = true;
                lstChanges.Items.Clear();
            }
        }

        private void AddItemThreadSafe(string text)
        {
            if(lstChanges.InvokeRequired)
            {
                var d = new SafeCallDelegate(AddItemThreadSafe);
                lstChanges.Invoke(d, new object[] {  text });
            }
            else
            {
                lstChanges.Items.Add(text);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
