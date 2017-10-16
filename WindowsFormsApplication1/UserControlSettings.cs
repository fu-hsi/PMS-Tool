using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class UserControlSettings : UserControl
    {
        public UserControlSettings()
        {
            InitializeComponent();
        }

        private void UserControlSettings_Load(object sender, EventArgs e)
        {
            buttonRefresh_Click(this, EventArgs.Empty);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((sender as LinkLabel).Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("devmgmt.msc");
        }

        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectButton.Enabled = comboBoxPorts.SelectedIndex > -1;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            comboBoxPorts.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                comboBoxPorts.Items.Add(s);
            }

            string storedCom = Properties.Settings.Default.COM;

            if (storedCom != String.Empty && comboBoxPorts.Items.Count > 0)
            {
                comboBoxPorts.SelectedItem = storedCom;
            }
        }
    }
}
