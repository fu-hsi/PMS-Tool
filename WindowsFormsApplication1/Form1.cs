using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        UserControlSettings _panelSettings;
        UserControlLog _panelLog;
        UserControlAbout _panelAbout;

        public Form1()
        {
            InitializeComponent();

            _panelLog = new UserControlLog(serialPort1);
            panelContainer.Controls.Add(_panelLog);

            _panelSettings = new UserControlSettings();
            panelContainer.Controls.Add(_panelSettings);
            _panelSettings.ConnectButton.Click += new EventHandler(ConnectButton_Click);

            _panelAbout = new UserControlAbout();
            panelContainer.Controls.Add(_panelAbout);

            toolStrip1_ItemClicked(this, new ToolStripItemClickedEventArgs(settingsToolStripButton));

            if (string.IsNullOrEmpty(this.Text))
            {
                this.Text = Application.ProductName + " v" + Application.ProductVersion.Substring(0, Application.ProductVersion.Length - 2);
            }
            else
            {
                this.Text += " v" + Application.ProductVersion.Substring(0, Application.ProductVersion.Length - 2);
            }
        }

        void ConnectButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = _panelSettings.comboBoxPorts.SelectedItem.ToString();
                    serialPort1.Open();
                    toolStrip1_ItemClicked(this, new ToolStripItemClickedEventArgs(logToolStripButton));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                serialPort1.Close();
            }

            _panelSettings.ConnectButton.Text = serialPort1.IsOpen ? "Close" : "Open";
            _panelSettings.comboBoxPorts.Enabled = !serialPort1.IsOpen;
        }

        void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem is ToolStripButton)
            {
                ToolStripButton b = e.ClickedItem as ToolStripButton;

                foreach (ToolStripButton i in toolStrip1.Items.OfType<ToolStripButton>())
                {
                    if (e.ClickedItem != i)
                    {
                        i.Checked = false;
                    }
                }

                b.Checked = true;

                int menuIndex = Convert.ToInt32(b.Tag);

                switch (menuIndex)
                {
                    case 1:
                        ActivatePanel(_panelSettings);
                        break;
                    case 2:
                        ActivatePanel(_panelLog);
                        break;
                    case 4:
                        ActivatePanel(_panelAbout);
                        break;
                    case 6:
                        Application.Exit();
                        break;
                    default:
                        ActivatePanel(_panelSettings);
                        break;
                }
            }
        }

        private void ActivatePanel(Control panel)
        {
            foreach (Control c in panelContainer.Controls)
            {
                c.Visible = false;
            }

            panel.Visible = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

            if (_panelSettings.comboBoxPorts.SelectedIndex > -1)
            {
                Properties.Settings.Default.COM = _panelSettings.comboBoxPorts.SelectedItem.ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void logToolStripButton_Click(object sender, EventArgs e)
        {
            ActivatePanel(_panelLog);
        }

        private void panelContainer_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.Dock = DockStyle.Fill;
            e.Control.Visible = false;
        }
    }
}
