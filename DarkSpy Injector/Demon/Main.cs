using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using sowy;

namespace Demon
{
	// Token: 0x02000005 RID: 5
	public partial class Main : Form
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00003E29 File Offset: 0x00003E29
		public Main()
		{
			this.notgudprotectqcljft();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003E51 File Offset: 0x00003E51
		private void notgudprotectqcljfh(object scqxve, PaintEventArgs scqxvf)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003E58 File Offset: 0x00003E58
		private void notgudprotectqcljfi(object scqxve, EventArgs scqxvf)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003E5F File Offset: 0x00003E5F
		private void notgudprotectqcljfj(object scqxve, EventArgs scqxvf)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003E66 File Offset: 0x00003E66
		private void notgudprotectqcljfk(object scqxve, EventArgs scqxvf)
		{
			Application.Exit();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003E73 File Offset: 0x00003E73
		private void notgudprotectqcljfl(object scqxve, EventArgs scqxvf)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003E84 File Offset: 0x00003E84
		private void notgudprotectqcljfm(object scqxve, EventArgs scqxvf)
		{
			Injector injector = new Injector();
			injector.Show();
			base.Hide();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003EB0 File Offset: 0x00003EB0
		private void notgudprotectqcljfn(object scqxve, EventArgs scqxvf)
		{
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			WebClient webClient = new WebClient();
			string value = webClient.DownloadString(notgudprotectinlbkj.notgudprotectrjgqdn("", 60700));
			bool flag = this.notgudprotectngxlyi.Text.Contains(value);
			if (!flag)
			{
				MessageBox.Show(notgudprotectinlbkj.notgudprotectrjgqdn("", 57590), notgudprotectinlbkj.notgudprotectrjgqdn("", 63049), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Process.Start(notgudprotectinlbkj.notgudprotectrjgqdn("", 60300));
				Environment.Exit(1);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003F78 File Offset: 0x00003F78
		private void notgudprotectqcljfo(object scqxve, EventArgs scqxvf)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003F80 File Offset: 0x00003F80
		private void notgudprotectqcljfp(object scqxve, EventArgs scqxvf)
		{
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			WebClient webClient = new WebClient();
			Directory.CreateDirectory(notgudprotectinlbkj.notgudprotectrjgqdn("", 61552));
			string address = notgudprotectinlbkj.notgudprotectrjgqdn("", 59160);
			string text = notgudprotectinlbkj.notgudprotectrjgqdn("", 57910);
			bool flag = !File.Exists(text);
			if (flag)
			{
				webClient.DownloadFile(address, text);
			}
			Process.Start(text);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000402B File Offset: 0x0000402B
		private void notgudprotectqcljfq(object scqxve, EventArgs scqxvf)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004032 File Offset: 0x00004032
		private void notgudprotectqcljfr(object scqxve, CancelEventArgs scqxvf)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000403C File Offset: 0x0000403C
		private void notgudprotectqcljfs(object scqxve, EventArgs scqxvf)
		{
			Settings settings = new Settings();
			settings.Show();
			base.Hide();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000040B8 File Offset: 0x000040B8
		private void notgudprotectqcljft()
		{
			this.notgudprotectngxlxv = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
			this.notgudprotectngxlxw = new Guna2ShadowPanel();
			this.notgudprotectngxlyi = new TextBox();
			this.notgudprotectngxlyf = new Label();
			this.notgudprotectngxlyd = new PictureBox();
			this.notgudprotectngxlxy = new Guna2Button();
			this.notgudprotectngxlxx = new Guna2Button();
			this.notgudprotectngxlxz = new Guna2BorderlessForm(this.notgudprotectngxlxv);
			this.notgudprotectngxlya = new Guna2Button();
			this.notgudprotectngxlyb = new Guna2Button();
			this.notgudprotectngxlyc = new Guna2Button();
			this.notgudprotectngxlye = new Guna2Button();
			this.notgudprotectngxlyg = new OpenFileDialog();
			this.notgudprotectngxlyh = new Guna2DragControl(this.notgudprotectngxlxv);
			this.notgudprotectngxlxw.SuspendLayout();
			((ISupportInitialize)this.notgudprotectngxlyd).BeginInit();
			base.SuspendLayout();
			this.notgudprotectngxlxw.BackColor = Color.Transparent;
			this.notgudprotectngxlxw.Controls.Add(this.notgudprotectngxlyi);
			this.notgudprotectngxlxw.Controls.Add(this.notgudprotectngxlyf);
			this.notgudprotectngxlxw.Controls.Add(this.notgudprotectngxlyd);
			this.notgudprotectngxlxw.Controls.Add(this.notgudprotectngxlxy);
			this.notgudprotectngxlxw.Controls.Add(this.notgudprotectngxlxx);
			this.notgudprotectngxlxw.FillColor = Color.FromArgb(0, 192, 192);
			this.notgudprotectngxlxw.Location = new Point(-19, -20);
			this.notgudprotectngxlxw.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 63382);
			this.notgudprotectngxlxw.ShadowColor = Color.FromArgb(15, 15, 15);
			this.notgudprotectngxlxw.Size = new Size(771, 55);
			this.notgudprotectngxlxw.TabIndex = 4;
			this.notgudprotectngxlxw.Paint += this.notgudprotectqcljfh;
			this.notgudprotectngxlyi.Location = new Point(495, 28);
			this.notgudprotectngxlyi.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 58593);
			this.notgudprotectngxlyi.Size = new Size(32, 20);
			this.notgudprotectngxlyi.TabIndex = 8;
			this.notgudprotectngxlyi.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 60339);
			this.notgudprotectngxlyi.Visible = false;
			this.notgudprotectngxlyf.AutoSize = true;
			this.notgudprotectngxlyf.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 61988), 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.notgudprotectngxlyf.ForeColor = Color.White;
			this.notgudprotectngxlyf.Location = new Point(49, 29);
			this.notgudprotectngxlyf.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 59726);
			this.notgudprotectngxlyf.Size = new Size(60, 15);
			this.notgudprotectngxlyf.TabIndex = 23;
			this.notgudprotectngxlyf.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 57911);
			this.notgudprotectngxlyf.Click += this.notgudprotectqcljfq;
			this.notgudprotectngxlyd.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 57388));
			this.notgudprotectngxlyd.Location = new Point(18, 20);
			this.notgudprotectngxlyd.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 60777);
			this.notgudprotectngxlyd.Size = new Size(34, 32);
			this.notgudprotectngxlyd.SizeMode = PictureBoxSizeMode.StretchImage;
			this.notgudprotectngxlyd.TabIndex = 22;
			this.notgudprotectngxlyd.TabStop = false;
			this.notgudprotectngxlyd.Click += this.notgudprotectqcljfo;
			this.notgudprotectngxlxy.BorderRadius = 5;
			this.notgudprotectngxlxy.CheckedState.Parent = this.notgudprotectngxlxy;
			this.notgudprotectngxlxy.CustomImages.Parent = this.notgudprotectngxlxy;
			this.notgudprotectngxlxy.FillColor = Color.FromArgb(0, 192, 192);
			this.notgudprotectngxlxy.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 60121), 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.notgudprotectngxlxy.ForeColor = Color.White;
			this.notgudprotectngxlxy.HoverState.Parent = this.notgudprotectngxlxy;
			this.notgudprotectngxlxy.Location = new Point(544, 24);
			this.notgudprotectngxlxy.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 61730);
			this.notgudprotectngxlxy.PressedColor = Color.Teal;
			this.notgudprotectngxlxy.ShadowDecoration.Parent = this.notgudprotectngxlxy;
			this.notgudprotectngxlxy.Size = new Size(29, 24);
			this.notgudprotectngxlxy.TabIndex = 20;
			this.notgudprotectngxlxy.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 57456);
			this.notgudprotectngxlxy.Click += this.notgudprotectqcljfl;
			this.notgudprotectngxlxx.BorderRadius = 5;
			this.notgudprotectngxlxx.CheckedState.Parent = this.notgudprotectngxlxx;
			this.notgudprotectngxlxx.CustomImages.Parent = this.notgudprotectngxlxx;
			this.notgudprotectngxlxx.FillColor = Color.FromArgb(0, 192, 192);
			this.notgudprotectngxlxx.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 60121), 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.notgudprotectngxlxx.ForeColor = Color.White;
			this.notgudprotectngxlxx.HoverState.Parent = this.notgudprotectngxlxx;
			this.notgudprotectngxlxx.Location = new Point(576, 24);
			this.notgudprotectngxlxx.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 60177);
			this.notgudprotectngxlxx.PressedColor = Color.Teal;
			this.notgudprotectngxlxx.ShadowDecoration.Parent = this.notgudprotectngxlxx;
			this.notgudprotectngxlxx.Size = new Size(29, 24);
			this.notgudprotectngxlxx.TabIndex = 19;
			this.notgudprotectngxlxx.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 58548);
			this.notgudprotectngxlxx.Click += this.notgudprotectqcljfk;
			this.notgudprotectngxlxz.BorderRadius = 5;
			this.notgudprotectngxlxz.ContainerControl = this;
			this.notgudprotectngxlxz.DragForm = false;
			this.notgudprotectngxlya.BorderRadius = 10;
			this.notgudprotectngxlya.CheckedState.Parent = this.notgudprotectngxlya;
			this.notgudprotectngxlya.Cursor = Cursors.Hand;
			this.notgudprotectngxlya.CustomImages.Parent = this.notgudprotectngxlya;
			this.notgudprotectngxlya.FillColor = Color.FromArgb(30, 30, 30);
			this.notgudprotectngxlya.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 58903), 10f, FontStyle.Bold);
			this.notgudprotectngxlya.ForeColor = Color.White;
			this.notgudprotectngxlya.HoverState.Parent = this.notgudprotectngxlya;
			this.notgudprotectngxlya.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 61983));
			this.notgudprotectngxlya.ImageOffset = new Point(14, -13);
			this.notgudprotectngxlya.ImageSize = new Size(85, 85);
			this.notgudprotectngxlya.Location = new Point(395, 42);
			this.notgudprotectngxlya.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 62270);
			this.notgudprotectngxlya.ShadowDecoration.Parent = this.notgudprotectngxlya;
			this.notgudprotectngxlya.Size = new Size(168, 137);
			this.notgudprotectngxlya.TabIndex = 7;
			this.notgudprotectngxlya.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 62442);
			this.notgudprotectngxlya.TextOffset = new Point(-21, 50);
			this.notgudprotectngxlya.Click += this.notgudprotectqcljfs;
			this.notgudprotectngxlyb.BorderRadius = 10;
			this.notgudprotectngxlyb.CheckedState.Parent = this.notgudprotectngxlyb;
			this.notgudprotectngxlyb.Cursor = Cursors.Hand;
			this.notgudprotectngxlyb.CustomImages.Parent = this.notgudprotectngxlyb;
			this.notgudprotectngxlyb.FillColor = Color.FromArgb(30, 30, 30);
			this.notgudprotectngxlyb.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 58903), 10f, FontStyle.Bold);
			this.notgudprotectngxlyb.ForeColor = Color.White;
			this.notgudprotectngxlyb.HoverState.Parent = this.notgudprotectngxlyb;
			this.notgudprotectngxlyb.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 60672));
			this.notgudprotectngxlyb.ImageOffset = new Point(18, -13);
			this.notgudprotectngxlyb.ImageSize = new Size(85, 85);
			this.notgudprotectngxlyb.Location = new Point(212, 42);
			this.notgudprotectngxlyb.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 60264);
			this.notgudprotectngxlyb.ShadowDecoration.Parent = this.notgudprotectngxlyb;
			this.notgudprotectngxlyb.Size = new Size(168, 137);
			this.notgudprotectngxlyb.TabIndex = 6;
			this.notgudprotectngxlyb.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 62347);
			this.notgudprotectngxlyb.TextOffset = new Point(-21, 50);
			this.notgudprotectngxlyb.Click += this.notgudprotectqcljfp;
			this.notgudprotectngxlyc.BorderRadius = 10;
			this.notgudprotectngxlyc.CheckedState.Parent = this.notgudprotectngxlyc;
			this.notgudprotectngxlyc.Cursor = Cursors.Hand;
			this.notgudprotectngxlyc.CustomImages.Parent = this.notgudprotectngxlyc;
			this.notgudprotectngxlyc.FillColor = Color.FromArgb(30, 30, 30);
			this.notgudprotectngxlyc.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 58903), 10f, FontStyle.Bold);
			this.notgudprotectngxlyc.ForeColor = Color.White;
			this.notgudprotectngxlyc.HoverState.Parent = this.notgudprotectngxlyc;
			this.notgudprotectngxlyc.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 63683));
			this.notgudprotectngxlyc.ImageOffset = new Point(15, -13);
			this.notgudprotectngxlyc.ImageSize = new Size(85, 85);
			this.notgudprotectngxlyc.Location = new Point(28, 42);
			this.notgudprotectngxlyc.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 62604);
			this.notgudprotectngxlyc.ShadowDecoration.Parent = this.notgudprotectngxlyc;
			this.notgudprotectngxlyc.Size = new Size(168, 137);
			this.notgudprotectngxlyc.TabIndex = 5;
			this.notgudprotectngxlyc.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 59816);
			this.notgudprotectngxlyc.TextOffset = new Point(-21, 50);
			this.notgudprotectngxlyc.Click += this.notgudprotectqcljfm;
			this.notgudprotectngxlye.BorderRadius = 10;
			this.notgudprotectngxlye.CheckedState.Parent = this.notgudprotectngxlye;
			this.notgudprotectngxlye.Cursor = Cursors.Hand;
			this.notgudprotectngxlye.CustomImages.Parent = this.notgudprotectngxlye;
			this.notgudprotectngxlye.FillColor = Color.FromArgb(30, 30, 30);
			this.notgudprotectngxlye.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 58903), 10f, FontStyle.Bold);
			this.notgudprotectngxlye.ForeColor = Color.White;
			this.notgudprotectngxlye.HoverState.Parent = this.notgudprotectngxlye;
			this.notgudprotectngxlye.ImageOffset = new Point(18, -13);
			this.notgudprotectngxlye.ImageSize = new Size(85, 85);
			this.notgudprotectngxlye.Location = new Point(212, 42);
			this.notgudprotectngxlye.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 62063);
			this.notgudprotectngxlye.ShadowDecoration.Parent = this.notgudprotectngxlye;
			this.notgudprotectngxlye.Size = new Size(168, 137);
			this.notgudprotectngxlye.TabIndex = 6;
			this.notgudprotectngxlye.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 62347);
			this.notgudprotectngxlye.TextOffset = new Point(-21, 50);
			this.notgudprotectngxlye.Click += this.notgudprotectqcljfp;
			this.notgudprotectngxlyg.FileName = notgudprotectinlbkj.notgudprotectrjgqdn("", 60807);
			this.notgudprotectngxlyg.FileOk += this.notgudprotectqcljfr;
			this.notgudprotectngxlyh.ContainerControl = this;
			this.notgudprotectngxlyh.TargetControl = this.notgudprotectngxlxw;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(26, 26, 26);
			base.ClientSize = new Size(589, 190);
			base.Controls.Add(this.notgudprotectngxlya);
			base.Controls.Add(this.notgudprotectngxlyb);
			base.Controls.Add(this.notgudprotectngxlyc);
			base.Controls.Add(this.notgudprotectngxlxw);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 60688));
			base.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 59663);
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 59663);
			base.Load += this.notgudprotectqcljfn;
			this.notgudprotectngxlxw.ResumeLayout(false);
			this.notgudprotectngxlxw.PerformLayout();
			((ISupportInitialize)this.notgudprotectngxlyd).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000018 RID: 24
		private Guna2ShadowPanel notgudprotectngxlxw;

		// Token: 0x04000019 RID: 25
		private Guna2Button notgudprotectngxlxx;

		// Token: 0x0400001A RID: 26
		private Guna2Button notgudprotectngxlxy;

		// Token: 0x0400001B RID: 27
		private Guna2BorderlessForm notgudprotectngxlxz;

		// Token: 0x0400001C RID: 28
		private Guna2Button notgudprotectngxlya;

		// Token: 0x0400001D RID: 29
		private Guna2Button notgudprotectngxlyb;

		// Token: 0x0400001E RID: 30
		private Guna2Button notgudprotectngxlyc;

		// Token: 0x0400001F RID: 31
		private PictureBox notgudprotectngxlyd;

		// Token: 0x04000020 RID: 32
		private Guna2Button notgudprotectngxlye;

		// Token: 0x04000021 RID: 33
		private Label notgudprotectngxlyf;

		// Token: 0x04000022 RID: 34
		private OpenFileDialog notgudprotectngxlyg;

		// Token: 0x04000023 RID: 35
		private Guna2DragControl notgudprotectngxlyh;

		// Token: 0x04000024 RID: 36
		private TextBox notgudprotectngxlyi;
	}
}
