using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSIAfterburner.Monitoring.Sample.Forms
{
    public partial class frmSetupSpecific : Form
    {
        int index;

        public frmSetupSpecific(int index)
        {
            this.index = index;
            InitializeComponent();
            load();
        }

        private void load()
        {
            string[] names = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorNames;
            float[] values = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorValues;

            this.txtSensorName.Text = names[this.index];
            this.numSensorValue.Value = (decimal)values[this.index];
        }

        private void btnValuesSet_Click(object sender, EventArgs e)
        {
            List<string> names = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorNames.ToList();
            List<float> values = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorValues.ToList();

            names[this.index] = this.txtSensorName.Text;
            values[this.index] = (float)this.numSensorValue.Value;

            MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorNames = names.ToArray();
            MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorValues = values.ToArray();

            load();
        }
    }
}
