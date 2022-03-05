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
    public partial class frmSetupGlobal : Form
    {
        public frmSetupGlobal()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            this.txtSensorName.Text = null;
            this.numSensorValue.Value = 0;

            string[] names = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorNames;
            float[] values = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorValues;

            this.listKeys.Items.Clear();
            for (int i = 0; i < names.Length; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = names[i];
                lvi.Tag = i;
                lvi.SubItems.Add(values[i].ToString());

                this.listKeys.Items.Add(lvi);
            }

            if (this.listKeys.Items.Count > 0)
            {
                this.listKeys.Items[0].Selected = true;
            }
            else
            {
                this.txtSensorName.Enabled = false;
                this.numSensorValue.Enabled = false;
                this.btnValuesSet.Enabled = false;
            }
        }

        private void listKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listKeys.SelectedItems.Count > 0)
            {
                ListViewItem lvi = this.listKeys.SelectedItems[0];
                int index = (int)lvi.Tag;

                string[] names = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorNames;
                float[] values = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorValues;

                this.txtSensorName.Text = names[index];
                this.numSensorValue.Value = (decimal)values[index];

                this.txtSensorName.Enabled = true;
                this.numSensorValue.Enabled = true;
                this.btnValuesSet.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> names = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorNames.ToList();
            List<float> values = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorValues.ToList();

            names.Add("Sensor " + (names.Count - 1));
            values.Add(values.Count - 1);

            MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorNames = names.ToArray();
            MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorValues = values.ToArray();

            load();
            this.listKeys.Items[this.listKeys.Items.Count - 1].Selected = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.listKeys.SelectedItems.Count > 0)
            {
                int index = (int)this.listKeys.SelectedItems[0].Tag;

                List<string> names = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorNames.ToList();
                List<float> values = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorValues.ToList();

                names.RemoveAt(index);
                values.RemoveAt(index);

                MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorNames = names.ToArray();
                MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorValues = values.ToArray();

                load();
            }
        }

        private void btnValuesSet_Click(object sender, EventArgs e)
        {
            if (this.listKeys.SelectedItems.Count > 0)
            {
                int index = (int)this.listKeys.SelectedItems[0].Tag;

                List<string> names = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorNames.ToList();
                List<float> values = MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorValues.ToList();

                names[index] = this.txtSensorName.Text;
                values[index] = (float)this.numSensorValue.Value;

                MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorNames = names.ToArray();
                MSIAfterburner.Monitoring.Sample.Properties.Settings.Default.SensorValues = values.ToArray();

                load();
            }
        }
    }
}
