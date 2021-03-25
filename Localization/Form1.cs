using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Localization
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> availableLanguages;

        public Form1()
        {
            InitializeComponent();
            availableLanguages = GetLanguages();

            foreach (var language in availableLanguages)
            {
                ToolStripMenuItem languageItem = new ToolStripMenuItem(language.Key);
                languageItem.Click += LanguageItem_Click;
                customizeToolStripMenuItem.DropDownItems.Add(languageItem);
            }
        }

        private void LanguageItem_Click(object sender, EventArgs e)
        {
            var locale = availableLanguages[((ToolStripMenuItem)sender).Text];
            LoadLanguage(locale);
        }

        private static Dictionary<string, string> GetLanguages()
        {
            DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory + "//Languages");
            FileInfo[] rgFiles = di.GetFiles("*.xml");

            Dictionary<string, string> Languages = new Dictionary<string, string>();

            foreach (FileInfo fi in rgFiles)
            {
                XmlTextReader filereader = new XmlTextReader(fi.FullName);
                string languageType = "";
                while (filereader.ReadToFollowing("language"))
                {
                    languageType = filereader.GetAttribute("type");
                }

                Languages.Add(languageType, fi.Name.Replace(".xml", ""));
            }

            return Languages;
        }

        private void LoadLanguage(string locale)
        {
            var languageResource = $"{Environment.CurrentDirectory}\\Languages\\{locale}.xml";
            XmlTextReader languageReader = new XmlTextReader(languageResource);
            languageReader.MoveToContent();

            string elementName = "";

            if ((languageReader.NodeType == XmlNodeType.Element) && (languageReader.Name == "Locale"))
            {
                while (languageReader.Read())
                {
                    if (languageReader.NodeType == XmlNodeType.Element)
                    {
                        elementName = languageReader.Name;
                    }
                    else
                    {
                        if ((languageReader.NodeType == XmlNodeType.Text) && (languageReader.HasValue))
                        {
                            switch (elementName)
                            {
                                case "Title":
                                    this.Text = languageReader.Value;
                                    break;
                                case "File":
                                    this.fileToolStripMenuItem.Text = languageReader.Value;
                                    break;
                                case "Open":
                                    this.openToolStripMenuItem.Text = languageReader.Value;
                                    break;
                                case "Save":
                                    this.saveToolStripMenuItem.Text = languageReader.Value;
                                    break;
                                case "Edit":
                                    this.editToolStripMenuItem.Text = languageReader.Value;
                                    break;
                                case "Cut":
                                    this.cutToolStripMenuItem.Text = languageReader.Value;
                                    break;
                                case "Copy":
                                    this.copyToolStripMenuItem.Text = languageReader.Value;
                                    break;
                                case "Paste":
                                    this.pasteToolStripMenuItem.Text = languageReader.Value;
                                    break;
                                case "Options":
                                    this.toolsToolStripMenuItem.Text = languageReader.Value;
                                    break;
                                case "Language":
                                    this.customizeToolStripMenuItem.Text = languageReader.Value;
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
}
