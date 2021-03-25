using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HandleResult(DialogResult result, string title, string message = "")
        {
            if (result != DialogResult.OK || message == "")
            {
                MessageBox.Show($"You Clicked {result}", title);
            }
            else
            {
                MessageBox.Show(message, title);
            }
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            var simpleMessage = "This is an Example of a MessageBox";
            var simpleTitle = "Example MessageBox";
            var messageBoxIcon = MessageBoxIcon.Information;
            var messageBoxButtons = MessageBoxButtons.YesNoCancel;
            var messageBoxDefaultButton = MessageBoxDefaultButton.Button1;
            var result = MessageBox.Show(simpleMessage, simpleTitle, messageBoxButtons, messageBoxIcon, messageBoxDefaultButton);
            var title = "MessageBox";
            HandleResult(result, title);
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogExample = new ColorDialog();
            colorDialogExample.AllowFullOpen = true;
            var result = colorDialogExample.ShowDialog();
            var message = $"Color Selected : {colorDialogExample.Color.R}R {colorDialogExample.Color.G}G {colorDialogExample.Color.B}B";
            var title = "Color Dialog";
            HandleResult(result, title, message);
        }

        private void btnFolderBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserExample = new FolderBrowserDialog();
            folderBrowserExample.Description = "Example of Folder browser dialog";
            var result = folderBrowserExample.ShowDialog();
            var message = $"You Chose: {folderBrowserExample.SelectedPath}";
            var title = "Folder Browser";
            HandleResult(result, title, message);
        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fontDialogExample = new FontDialog();
            fontDialogExample.ShowEffects = true;
            fontDialogExample.ShowColor = true;
            var result = fontDialogExample.ShowDialog();
            var message = $"Font Selected: {fontDialogExample.Font}, Font Color: {fontDialogExample.Color}";
            var title = "Font Dialog";
            HandleResult(result, title, message);
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogExample = new OpenFileDialog();
            openFileDialogExample.Filter = "All files (*.*)|*.*";
            openFileDialogExample.Title = "Open File Dialog";
            openFileDialogExample.Multiselect = false;
            var result = openFileDialogExample.ShowDialog();
            var message = $"You selected {openFileDialogExample.FileName}";
            var title = "Open File Dialog";
            HandleResult(result, title, message);
        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialogExample = new SaveFileDialog();
            saveFileDialogExample.Filter = "All files (*.*)|*.*";
            var result = saveFileDialogExample.ShowDialog();
            var message = $"You Selected {saveFileDialogExample.FileName}";
            var title = "Save File Dialog";
            HandleResult(result, title, message);
        }
    }
}
