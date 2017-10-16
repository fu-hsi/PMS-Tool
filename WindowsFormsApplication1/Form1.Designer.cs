namespace WindowsFormsApplication1
{
  partial class Form1
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.settingsToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.logToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
      this.label1 = new System.Windows.Forms.Label();
      this.panelContainer = new System.Windows.Forms.Panel();
      this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.BackColor = System.Drawing.Color.White;
      this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripButton,
            this.logToolStripButton,
            this.aboutToolStripButton,
            this.toolStripButton3});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.toolStrip1.Size = new System.Drawing.Size(624, 56);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
      // 
      // settingsToolStripButton
      // 
      this.settingsToolStripButton.AutoSize = false;
      this.settingsToolStripButton.Image = global::WindowsFormsApplication1.Properties.Resources.Network_connection;
      this.settingsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.settingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.settingsToolStripButton.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
      this.settingsToolStripButton.Name = "settingsToolStripButton";
      this.settingsToolStripButton.Padding = new System.Windows.Forms.Padding(5);
      this.settingsToolStripButton.Size = new System.Drawing.Size(100, 53);
      this.settingsToolStripButton.Tag = "1";
      this.settingsToolStripButton.Text = "Connecting";
      this.settingsToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.settingsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      // 
      // logToolStripButton
      // 
      this.logToolStripButton.AutoSize = false;
      this.logToolStripButton.Image = global::WindowsFormsApplication1.Properties.Resources.Stock_graph;
      this.logToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.logToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.logToolStripButton.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
      this.logToolStripButton.Name = "logToolStripButton";
      this.logToolStripButton.Padding = new System.Windows.Forms.Padding(5);
      this.logToolStripButton.Size = new System.Drawing.Size(100, 53);
      this.logToolStripButton.Tag = "2";
      this.logToolStripButton.Text = "Console";
      this.logToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.logToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      // 
      // aboutToolStripButton
      // 
      this.aboutToolStripButton.AutoSize = false;
      this.aboutToolStripButton.Image = global::WindowsFormsApplication1.Properties.Resources.About;
      this.aboutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.aboutToolStripButton.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
      this.aboutToolStripButton.Name = "aboutToolStripButton";
      this.aboutToolStripButton.Padding = new System.Windows.Forms.Padding(5);
      this.aboutToolStripButton.Size = new System.Drawing.Size(100, 53);
      this.aboutToolStripButton.Tag = "4";
      this.aboutToolStripButton.Text = "About";
      this.aboutToolStripButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.aboutToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      // 
      // toolStripButton3
      // 
      this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.toolStripButton3.AutoSize = false;
      this.toolStripButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.toolStripButton3.Image = global::WindowsFormsApplication1.Properties.Resources.Exit;
      this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton3.Name = "toolStripButton3";
      this.toolStripButton3.Size = new System.Drawing.Size(100, 53);
      this.toolStripButton3.Tag = "6";
      this.toolStripButton3.Text = "Exit";
      this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      // 
      // label1
      // 
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Location = new System.Drawing.Point(0, 56);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(624, 2);
      this.label1.TabIndex = 1;
      // 
      // panelContainer
      // 
      this.panelContainer.BackColor = System.Drawing.SystemColors.Control;
      this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelContainer.Location = new System.Drawing.Point(0, 58);
      this.panelContainer.Name = "panelContainer";
      this.panelContainer.Padding = new System.Windows.Forms.Padding(10);
      this.panelContainer.Size = new System.Drawing.Size(624, 383);
      this.panelContainer.TabIndex = 2;
      this.panelContainer.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelContainer_ControlAdded);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.DefaultExt = "osd";
      this.openFileDialog1.Filter = "OSD Settings|*.osd";
      // 
      // saveFileDialog1
      // 
      this.saveFileDialog1.DefaultExt = "osd";
      this.saveFileDialog1.Filter = "OSD Settings|*.osd";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(624, 441);
      this.Controls.Add(this.panelContainer);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.toolStrip1);
      this.MinimumSize = new System.Drawing.Size(640, 480);
      this.Name = "Form1";
      this.Text = "PMS Tool (1003/3003/5003/6003/7003)";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton logToolStripButton;
    private System.Windows.Forms.ToolStripButton settingsToolStripButton;
    private System.Windows.Forms.ToolStripButton aboutToolStripButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panelContainer;
    private System.IO.Ports.SerialPort serialPort1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.ToolStripButton toolStripButton3;
  }
}

