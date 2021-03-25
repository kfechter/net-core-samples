using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace ScreenBrightness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var brightness = int.Parse(GetBrightness().ToString());
            trkBrightness.Value = brightness;
            label1.Text = $"Screen Brightness: {brightness}";
        }


        static byte GetBrightness()
        {
            //define scope (namespace)
            ManagementScope s = new ManagementScope("root\\WMI");

            //define query
            SelectQuery q = new SelectQuery("WmiMonitorBrightness");

            //output current brightness
            ManagementObjectSearcher mos = new ManagementObjectSearcher(s, q);

            ManagementObjectCollection moc = mos.Get();

            //store result
            byte curBrightness = 0;

            foreach (ManagementObject o in moc)
            {
                curBrightness = (byte)o.GetPropertyValue("CurrentBrightness");
                break; //only work on the first object
            }

            moc.Dispose();
            mos.Dispose();

            return curBrightness;
        }

        static void SetBrightness(byte targetBrightness)
        {
            //define scope (namespace)
            ManagementScope s = new ManagementScope("root\\WMI");

            //define query
            SelectQuery q = new SelectQuery("WmiMonitorBrightnessMethods");

            //output current brightness
            ManagementObjectSearcher mos = new ManagementObjectSearcher(s, q);

            ManagementObjectCollection moc = mos.Get();

            foreach (ManagementObject o in moc)
            {
                o.InvokeMethod("WmiSetBrightness", new object[] { uint.MaxValue, targetBrightness }); //note the reversed order - won't work otherwise!
                break; //only work on the first object
            }

            moc.Dispose();
            mos.Dispose();
        }

        private void trkBrightness_Scroll(object sender, EventArgs e)
        {
            SetBrightness(byte.Parse(trkBrightness.Value.ToString()));
            label1.Text = $"Screen Brightness: {trkBrightness.Value}";
        }
    }
}
