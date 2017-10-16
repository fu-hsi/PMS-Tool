namespace WindowsFormsApplication1
{
  partial class UserControlLog
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLog));
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.textBoxLog = new System.Windows.Forms.TextBox();
      this.buttonRead = new System.Windows.Forms.Button();
      this.checkBoxActiveMode = new System.Windows.Forms.CheckBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label7 = new System.Windows.Forms.Label();
      this.textBox10_0 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox2_5 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBox1_0 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textBoxCF_10_0 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxCF_2_5 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxCF_1_0 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.checkBoxSleepMode = new System.Windows.Forms.CheckBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label8 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "0.png");
      this.imageList1.Images.SetKeyName(1, "1.png");
      this.imageList1.Images.SetKeyName(2, "2.png");
      this.imageList1.Images.SetKeyName(3, "3.png");
      this.imageList1.Images.SetKeyName(4, "4.png");
      this.imageList1.Images.SetKeyName(5, "5.png");
      this.imageList1.Images.SetKeyName(6, "6.png");
      this.imageList1.Images.SetKeyName(7, "7.png");
      this.imageList1.Images.SetKeyName(8, "8.png");
      this.imageList1.Images.SetKeyName(9, "9.png");
      // 
      // textBoxLog
      // 
      this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.textBoxLog.Location = new System.Drawing.Point(0, 0);
      this.textBoxLog.Multiline = true;
      this.textBoxLog.Name = "textBoxLog";
      this.textBoxLog.ReadOnly = true;
      this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBoxLog.Size = new System.Drawing.Size(544, 196);
      this.textBoxLog.TabIndex = 0;
      // 
      // buttonRead
      // 
      this.buttonRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonRead.Enabled = false;
      this.buttonRead.Location = new System.Drawing.Point(463, 23);
      this.buttonRead.Name = "buttonRead";
      this.buttonRead.Size = new System.Drawing.Size(75, 23);
      this.buttonRead.TabIndex = 0;
      this.buttonRead.Text = "Read";
      this.buttonRead.UseVisualStyleBackColor = true;
      this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
      // 
      // checkBoxActiveMode
      // 
      this.checkBoxActiveMode.AutoSize = true;
      this.checkBoxActiveMode.Checked = true;
      this.checkBoxActiveMode.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxActiveMode.Location = new System.Drawing.Point(13, 27);
      this.checkBoxActiveMode.Name = "checkBoxActiveMode";
      this.checkBoxActiveMode.Size = new System.Drawing.Size(205, 17);
      this.checkBoxActiveMode.TabIndex = 1;
      this.checkBoxActiveMode.Text = "Active Mode (Default when power up)";
      this.checkBoxActiveMode.UseVisualStyleBackColor = true;
      this.checkBoxActiveMode.CheckedChanged += new System.EventHandler(this.checkBoxActiveMode_CheckedChanged);
      // 
      // groupBox1
      // 
      this.groupBox1.AutoSize = true;
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Controls.Add(this.textBox10_0);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.textBox2_5);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.textBox1_0);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.textBoxCF_10_0);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.textBoxCF_2_5);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.textBoxCF_1_0);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.groupBox1.Location = new System.Drawing.Point(0, 196);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(544, 185);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Data";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(10, 156);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(264, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Note: CF=1 should be used in the factory environment.";
      // 
      // textBox10_0
      // 
      this.textBox10_0.Location = new System.Drawing.Point(228, 119);
      this.textBox10_0.Name = "textBox10_0";
      this.textBox10_0.ReadOnly = true;
      this.textBox10_0.Size = new System.Drawing.Size(100, 20);
      this.textBox10_0.TabIndex = 11;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(225, 103);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(69, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "PM 10 μg/m³";
      // 
      // textBox2_5
      // 
      this.textBox2_5.Location = new System.Drawing.Point(228, 80);
      this.textBox2_5.Name = "textBox2_5";
      this.textBox2_5.ReadOnly = true;
      this.textBox2_5.Size = new System.Drawing.Size(100, 20);
      this.textBox2_5.TabIndex = 9;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(225, 64);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(72, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "PM 2.5 μg/m³";
      // 
      // textBox1_0
      // 
      this.textBox1_0.Location = new System.Drawing.Point(228, 41);
      this.textBox1_0.Name = "textBox1_0";
      this.textBox1_0.ReadOnly = true;
      this.textBox1_0.Size = new System.Drawing.Size(100, 20);
      this.textBox1_0.TabIndex = 7;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(225, 25);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(72, 13);
      this.label6.TabIndex = 6;
      this.label6.Text = "PM 1.0 μg/m³";
      // 
      // textBoxCF_10_0
      // 
      this.textBoxCF_10_0.Location = new System.Drawing.Point(13, 119);
      this.textBoxCF_10_0.Name = "textBoxCF_10_0";
      this.textBoxCF_10_0.ReadOnly = true;
      this.textBoxCF_10_0.Size = new System.Drawing.Size(100, 20);
      this.textBoxCF_10_0.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(10, 103);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(103, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "PM 10 μg/m³ (CF=1)";
      // 
      // textBoxCF_2_5
      // 
      this.textBoxCF_2_5.Location = new System.Drawing.Point(13, 80);
      this.textBoxCF_2_5.Name = "textBoxCF_2_5";
      this.textBoxCF_2_5.ReadOnly = true;
      this.textBoxCF_2_5.Size = new System.Drawing.Size(100, 20);
      this.textBoxCF_2_5.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(10, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(106, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "PM 2.5 μg/m³ (CF=1)";
      // 
      // textBoxCF_1_0
      // 
      this.textBoxCF_1_0.Location = new System.Drawing.Point(13, 41);
      this.textBoxCF_1_0.Name = "textBoxCF_1_0";
      this.textBoxCF_1_0.ReadOnly = true;
      this.textBoxCF_1_0.Size = new System.Drawing.Size(100, 20);
      this.textBoxCF_1_0.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(106, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "PM 1.0 μg/m³ (CF=1)";
      // 
      // checkBoxSleepMode
      // 
      this.checkBoxSleepMode.AutoSize = true;
      this.checkBoxSleepMode.Location = new System.Drawing.Point(13, 50);
      this.checkBoxSleepMode.Name = "checkBoxSleepMode";
      this.checkBoxSleepMode.Size = new System.Drawing.Size(83, 17);
      this.checkBoxSleepMode.TabIndex = 2;
      this.checkBoxSleepMode.Text = "Sleep Mode";
      this.checkBoxSleepMode.UseVisualStyleBackColor = true;
      this.checkBoxSleepMode.CheckedChanged += new System.EventHandler(this.checkBoxSleepMode_CheckedChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.AutoSize = true;
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.checkBoxSleepMode);
      this.groupBox2.Controls.Add(this.buttonRead);
      this.groupBox2.Controls.Add(this.checkBoxActiveMode);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.groupBox2.Location = new System.Drawing.Point(0, 381);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(544, 108);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Modes";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(10, 79);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(230, 13);
      this.label8.TabIndex = 13;
      this.label8.Text = "Not all sensors can support the above features.";
      // 
      // UserControlLog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.textBoxLog);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox2);
      this.Name = "UserControlLog";
      this.Size = new System.Drawing.Size(544, 489);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.TextBox textBoxLog;
    private System.Windows.Forms.Button buttonRead;
    private System.Windows.Forms.CheckBox checkBoxActiveMode;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBox10_0;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox2_5;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox1_0;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBoxCF_10_0;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxCF_2_5;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxCF_1_0;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.CheckBox checkBoxSleepMode;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label8;
  }
}
