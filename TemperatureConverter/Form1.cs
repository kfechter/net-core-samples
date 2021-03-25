using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class frmTempConversion : Form
    {
        public frmTempConversion()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTemperature.Text, out var temperature))
            {
                MessageBox.Show("The value provided was unabled to be converted, check input", "Conversion Failure");
            }
            else
            {
                double convertedTemperature = 0.0;
                string temperatureUnit = rdoCToF.Checked ? "F" : "C";
                if (rdoCToF.Checked)
                {
                    convertedTemperature = (temperature * 1.8) + 32;
                }
                else if (rdoFToC.Checked)
                {
                    convertedTemperature = (temperature - 32) * 0.55;
                }

                MessageBox.Show($"The Converted Temperature is {Math.Floor(convertedTemperature)}°{temperatureUnit}", "Temperature Converted");
            }
        }
    }
}
