namespace WindowsFormsApplication1
{
  partial class UserControlSettings
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.buttonRefresh = new System.Windows.Forms.Button();
      this.ConnectButton = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.comboBoxPorts = new System.Windows.Forms.ComboBox();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox2
      // 
      this.groupBox2.AutoSize = true;
      this.groupBox2.Controls.Add(this.buttonRefresh);
      this.groupBox2.Controls.Add(this.ConnectButton);
      this.groupBox2.Controls.Add(this.button1);
      this.groupBox2.Controls.Add(this.label1);
      this.groupBox2.Controls.Add(this.comboBoxPorts);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
      this.groupBox2.Size = new System.Drawing.Size(728, 99);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Serial port";
      // 
      // buttonRefresh
      // 
      this.buttonRefresh.Location = new System.Drawing.Point(140, 24);
      this.buttonRefresh.Name = "buttonRefresh";
      this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
      this.buttonRefresh.TabIndex = 7;
      this.buttonRefresh.Text = "Refresh";
      this.buttonRefresh.UseVisualStyleBackColor = true;
      this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
      // 
      // ConnectButton
      // 
      this.ConnectButton.Enabled = false;
      this.ConnectButton.Location = new System.Drawing.Point(221, 24);
      this.ConnectButton.Name = "ConnectButton";
      this.ConnectButton.Size = new System.Drawing.Size(75, 23);
      this.ConnectButton.TabIndex = 5;
      this.ConnectButton.Text = "Open";
      this.ConnectButton.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.AutoSize = true;
      this.button1.Location = new System.Drawing.Point(605, 24);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(110, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Device Manager";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 63);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(401, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "BaudRate = 9600, Parity = None, DataBits = 8, StopBits = One, Handshake = None";
      // 
      // comboBoxPorts
      // 
      this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxPorts.FormattingEnabled = true;
      this.comboBoxPorts.Location = new System.Drawing.Point(13, 26);
      this.comboBoxPorts.Name = "comboBoxPorts";
      this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
      this.comboBoxPorts.TabIndex = 2;
      this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
      // 
      // UserControlSettings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox2);
      this.Name = "UserControlSettings";
      this.Size = new System.Drawing.Size(728, 360);
      this.Load += new System.EventHandler(this.UserControlSettings_Load);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    public System.Windows.Forms.ComboBox comboBoxPorts;
    public System.Windows.Forms.Button ConnectButton;
    private System.Windows.Forms.Button buttonRefresh;
  }
}
