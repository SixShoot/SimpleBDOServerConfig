using BDOServerRatesEditor.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BDOServerRatesEditor
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private Button button2;
    private Button button1;
    private PictureBox pictureBox1;
    private GroupBox groupBox1;
    private Label label1;

    public Form1()
    {
      this.InitializeComponent();
      this.Name = "Простая настройка сервера BDO";
      this.Text = "Простая настройка сервера BDO";
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      new Thread(new ThreadStart(this.ShowRates)).Start();
    }

    private void Button1_Click_1(object sender, EventArgs e)
    {
      new Thread(new ThreadStart(this.ShowNetwork)).Start();
    }

    private void ShowNetwork()
    {
      int num = (int) new Networks().ShowDialog();
    }

    private void ShowRates()
    {
      int num = (int) new Rates().ShowDialog();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.button2 = new Button();
      this.button1 = new Button();
      this.pictureBox1 = new PictureBox();
      this.groupBox1 = new GroupBox();
      this.label1 = new Label();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.button2.Location = new Point(543, 387);
      this.button2.Margin = new Padding(2);
      this.button2.Name = "button2";
      this.button2.Size = new Size(165, 103);
      this.button2.TabIndex = 30;
      this.button2.Text = "Настройки прокачки";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.Button2_Click);
      this.button1.Location = new Point(12, 387);
      this.button1.Margin = new Padding(2);
      this.button1.Name = "button1";
      this.button1.Size = new Size(165, 103);
      this.button1.TabIndex = 31;
      this.button1.Text = "Сервер и Сеть";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.Button1_Click_1);
      this.pictureBox1.Image = (Image) Resources.Black_Desert1;
      this.pictureBox1.Location = new Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(696, 344);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 32;
      this.pictureBox1.TabStop = false;
      this.groupBox1.Controls.Add((Control) this.label1);
      this.groupBox1.Location = new Point(197, 372);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(332, 135);
      this.groupBox1.TabIndex = 33;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Информация";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(6, 25);
      this.label1.Name = "label1";
      this.label1.Size = new Size(319, 91);
      this.label1.TabIndex = 0;
      this.label1.Text = componentResourceManager.GetString("label1.Text");
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(723, 519);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.button2);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Form1);
      this.Text = nameof (Form1);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
