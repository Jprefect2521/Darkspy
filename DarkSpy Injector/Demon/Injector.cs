using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using sowy;

namespace Demon
{
	// Token: 0x02000004 RID: 4
	public partial class Injector : Form
	{
		// Token: 0x06000010 RID: 16 RVA: 0x0000237E File Offset: 0x0000237E
		public Injector()
		{
			this.notgudprotectevnrin();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023A6 File Offset: 0x000023A6
		private void notgudprotectevnric(object scqxve, EventArgs scqxvf)
		{
			Application.Exit();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000023B3 File Offset: 0x000023B3
		private void notgudprotectevnrid(object scqxve, EventArgs scqxvf)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000023C2 File Offset: 0x000023C2
		private void notgudprotectevnrie(object scqxve, EventArgs scqxvf)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000023CC File Offset: 0x000023CC
		private void notgudprotectevnrif(object scqxve, EventArgs scqxvf)
		{
			this.notgudprotectbksufw.Filter = notgudprotectinlbkj.notgudprotectrjgqdn("", 60402);
			this.notgudprotectbksufw.Title = notgudprotectinlbkj.notgudprotectrjgqdn("", 59652);
			this.notgudprotectbksufw.ShowDialog();
			this.notgudprotectbksuft.Text = this.notgudprotectbksufw.FileName;
			this.notgudprotectbksufv.Visible = false;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002458 File Offset: 0x00002458
		private void notgudprotectevnrig(object scqxve, EventArgs scqxvf)
		{
			bool flag = this.notgudprotectbksuft.Text == notgudprotectinlbkj.notgudprotectrjgqdn("", 60399);
			if (flag)
			{
				MessageBox.Show(notgudprotectinlbkj.notgudprotectrjgqdn("", 60399), notgudprotectinlbkj.notgudprotectrjgqdn("", 58162), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				notgudprotectinlbkh notgudprotectinlbkh = new notgudprotectinlbkh(Process.GetProcessesByName(this.notgudprotectbksufx.Text)[0]);
				notgudprotectinlbkh.notgudprotectewaqyo(this.notgudprotectbksuft.Text);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000024F0 File Offset: 0x000024F0
		private void notgudprotectevnrih(object scqxve, EventArgs scqxvf)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000024F8 File Offset: 0x000024F8
		private void notgudprotectevnrii(object scqxve, EventArgs scqxvf)
		{
			this.notgudprotectbksufx.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 58054);
			MessageBox.Show(notgudprotectinlbkj.notgudprotectrjgqdn("", 61430), notgudprotectinlbkj.notgudprotectrjgqdn("", 60177), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002554 File Offset: 0x00002554
		private void notgudprotectevnrij(object scqxve, EventArgs scqxvf)
		{
			this.notgudprotectbksufx.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 58970);
			MessageBox.Show(notgudprotectinlbkj.notgudprotectrjgqdn("", 60679), notgudprotectinlbkj.notgudprotectrjgqdn("", 57667), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000025B0 File Offset: 0x000025B0
		private void notgudprotectevnrik(object scqxve, EventArgs scqxvf)
		{
			Main main = new Main();
			main.Show();
			base.Hide();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000025DC File Offset: 0x000025DC
		private void notgudprotectevnril(object scqxve, EventArgs scqxvf)
		{
			bool flag = this.notgudprotectbksuft.Text == notgudprotectinlbkj.notgudprotectrjgqdn("", 62429);
			if (flag)
			{
				MessageBox.Show(notgudprotectinlbkj.notgudprotectrjgqdn("", 62429), notgudprotectinlbkj.notgudprotectrjgqdn("", 58097), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				notgudprotectinlbkh notgudprotectinlbkh = new notgudprotectinlbkh(Process.GetProcessesByName(this.notgudprotectbksufx.Text)[0]);
				notgudprotectinlbkh.notgudprotectewaqyp(this.notgudprotectbksuft.Text);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002674 File Offset: 0x00002674
		private void notgudprotectevnrim(object scqxve, PaintEventArgs scqxvf)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000026CC File Offset: 0x000026CC
		private void notgudprotectevnrin()
		{
			this.notgudprotectbksufn = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Injector));
			this.notgudprotectbksufo = new Guna2ShadowPanel();
			this.notgudprotectbksufp = new Label();
			this.notgudprotectbksufr = new Guna2Button();
			this.notgudprotectbksufs = new Guna2Button();
			this.notgudprotectbksuft = new Guna2TextBox();
			this.notgudprotectbksufv = new Label();
			this.notgudprotectbksufw = new OpenFileDialog();
			this.notgudprotectbksufx = new Guna2TextBox();
			this.notgudprotectbksufu = new Guna2ImageButton();
			this.notgudprotectbksufq = new PictureBox();
			this.notgudprotectbksufy = new Guna2BorderlessForm(this.notgudprotectbksufn);
			this.notgudprotectbksufz = new Guna2GradientButton();
			this.notgudprotectbksuga = new Guna2ImageButton();
			this.notgudprotectbksugb = new Guna2ImageButton();
			this.notgudprotectbksugd = new Guna2GradientButton();
			this.notgudprotectbksugc = new Guna2HtmlLabel();
			this.notgudprotectbksuge = new Guna2Button();
			this.notgudprotectbksugf = new Guna2DragControl(this.notgudprotectbksufn);
			this.notgudprotectbksufo.SuspendLayout();
			((ISupportInitialize)this.notgudprotectbksufq).BeginInit();
			base.SuspendLayout();
			this.notgudprotectbksufo.BackColor = Color.Transparent;
			this.notgudprotectbksufo.Controls.Add(this.notgudprotectbksuge);
			this.notgudprotectbksufo.Controls.Add(this.notgudprotectbksufp);
			this.notgudprotectbksufo.Controls.Add(this.notgudprotectbksufq);
			this.notgudprotectbksufo.Controls.Add(this.notgudprotectbksufr);
			this.notgudprotectbksufo.Controls.Add(this.notgudprotectbksufs);
			this.notgudprotectbksufo.FillColor = Color.FromArgb(0, 192, 192);
			this.notgudprotectbksufo.Location = new Point(-18, -20);
			this.notgudprotectbksufo.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 61271);
			this.notgudprotectbksufo.ShadowColor = Color.FromArgb(15, 15, 15);
			this.notgudprotectbksufo.Size = new Size(771, 55);
			this.notgudprotectbksufo.TabIndex = 5;
			this.notgudprotectbksufo.Paint += this.notgudprotectevnrim;
			this.notgudprotectbksufp.AutoSize = true;
			this.notgudprotectbksufp.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 61022), 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.notgudprotectbksufp.ForeColor = Color.White;
			this.notgudprotectbksufp.Location = new Point(52, 29);
			this.notgudprotectbksufp.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 62863);
			this.notgudprotectbksufp.Size = new Size(60, 15);
			this.notgudprotectbksufp.TabIndex = 23;
			this.notgudprotectbksufp.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 59146);
			this.notgudprotectbksufr.BorderRadius = 5;
			this.notgudprotectbksufr.CheckedState.Parent = this.notgudprotectbksufr;
			this.notgudprotectbksufr.CustomImages.Parent = this.notgudprotectbksufr;
			this.notgudprotectbksufr.FillColor = Color.FromArgb(0, 192, 192);
			this.notgudprotectbksufr.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 57860), 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.notgudprotectbksufr.ForeColor = Color.White;
			this.notgudprotectbksufr.HoverState.Parent = this.notgudprotectbksufr;
			this.notgudprotectbksufr.Location = new Point(609, 24);
			this.notgudprotectbksufr.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 59132);
			this.notgudprotectbksufr.PressedColor = Color.Teal;
			this.notgudprotectbksufr.ShadowDecoration.Parent = this.notgudprotectbksufr;
			this.notgudprotectbksufr.Size = new Size(29, 24);
			this.notgudprotectbksufr.TabIndex = 20;
			this.notgudprotectbksufr.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 59264);
			this.notgudprotectbksufr.Click += this.notgudprotectevnrid;
			this.notgudprotectbksufs.BorderRadius = 5;
			this.notgudprotectbksufs.CheckedState.Parent = this.notgudprotectbksufs;
			this.notgudprotectbksufs.CustomImages.Parent = this.notgudprotectbksufs;
			this.notgudprotectbksufs.FillColor = Color.FromArgb(0, 192, 192);
			this.notgudprotectbksufs.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 57860), 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.notgudprotectbksufs.ForeColor = Color.White;
			this.notgudprotectbksufs.HoverState.Parent = this.notgudprotectbksufs;
			this.notgudprotectbksufs.Location = new Point(641, 24);
			this.notgudprotectbksufs.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 63630);
			this.notgudprotectbksufs.PressedColor = Color.Teal;
			this.notgudprotectbksufs.ShadowDecoration.Parent = this.notgudprotectbksufs;
			this.notgudprotectbksufs.Size = new Size(29, 24);
			this.notgudprotectbksufs.TabIndex = 19;
			this.notgudprotectbksufs.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 60286);
			this.notgudprotectbksufs.Click += this.notgudprotectevnric;
			this.notgudprotectbksuft.BorderRadius = 4;
			this.notgudprotectbksuft.Cursor = Cursors.IBeam;
			this.notgudprotectbksuft.DefaultText = notgudprotectinlbkj.notgudprotectrjgqdn("", 61777);
			this.notgudprotectbksuft.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.notgudprotectbksuft.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.notgudprotectbksuft.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.notgudprotectbksuft.DisabledState.Parent = this.notgudprotectbksuft;
			this.notgudprotectbksuft.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.notgudprotectbksuft.Enabled = false;
			this.notgudprotectbksuft.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.notgudprotectbksuft.FocusedState.Parent = this.notgudprotectbksuft;
			this.notgudprotectbksuft.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 57860), 9f);
			this.notgudprotectbksuft.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
			this.notgudprotectbksuft.HoverState.Parent = this.notgudprotectbksuft;
			this.notgudprotectbksuft.Location = new Point(161, 49);
			this.notgudprotectbksuft.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 60465);
			this.notgudprotectbksuft.PasswordChar = '\0';
			this.notgudprotectbksuft.PlaceholderText = "";
			this.notgudprotectbksuft.SelectedText = "";
			this.notgudprotectbksuft.ShadowDecoration.Parent = this.notgudprotectbksuft;
			this.notgudprotectbksuft.Size = new Size(408, 22);
			this.notgudprotectbksuft.TabIndex = 6;
			this.notgudprotectbksuft.TextAlign = HorizontalAlignment.Center;
			this.notgudprotectbksufv.AutoSize = true;
			this.notgudprotectbksufv.BackColor = Color.FromArgb(224, 224, 224);
			this.notgudprotectbksufv.Enabled = false;
			this.notgudprotectbksufv.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 57860), 9f);
			this.notgudprotectbksufv.ForeColor = Color.FromArgb(125, 137, 149);
			this.notgudprotectbksufv.Location = new Point(541, 52);
			this.notgudprotectbksufv.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 58768);
			this.notgudprotectbksufv.Size = new Size(25, 15);
			this.notgudprotectbksufv.TabIndex = 24;
			this.notgudprotectbksufv.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 58928);
			this.notgudprotectbksufw.FileName = notgudprotectinlbkj.notgudprotectrjgqdn("", 62611);
			this.notgudprotectbksufx.BorderRadius = 4;
			this.notgudprotectbksufx.Cursor = Cursors.IBeam;
			this.notgudprotectbksufx.DefaultText = notgudprotectinlbkj.notgudprotectrjgqdn("", 62687);
			this.notgudprotectbksufx.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.notgudprotectbksufx.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.notgudprotectbksufx.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.notgudprotectbksufx.DisabledState.Parent = this.notgudprotectbksufx;
			this.notgudprotectbksufx.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.notgudprotectbksufx.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.notgudprotectbksufx.FocusedState.Parent = this.notgudprotectbksufx;
			this.notgudprotectbksufx.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 57860), 9f);
			this.notgudprotectbksufx.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
			this.notgudprotectbksufx.HoverState.Parent = this.notgudprotectbksufx;
			this.notgudprotectbksufx.Location = new Point(59, 49);
			this.notgudprotectbksufx.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 57401);
			this.notgudprotectbksufx.PasswordChar = '\0';
			this.notgudprotectbksufx.PlaceholderText = "";
			this.notgudprotectbksufx.SelectedText = "";
			this.notgudprotectbksufx.ShadowDecoration.Parent = this.notgudprotectbksufx;
			this.notgudprotectbksufx.Size = new Size(96, 22);
			this.notgudprotectbksufx.TabIndex = 25;
			this.notgudprotectbksufx.TextAlign = HorizontalAlignment.Center;
			this.notgudprotectbksufu.CheckedState.ImageSize = new Size(64, 64);
			this.notgudprotectbksufu.CheckedState.Parent = this.notgudprotectbksufu;
			this.notgudprotectbksufu.HoverState.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 60203));
			this.notgudprotectbksufu.HoverState.ImageSize = new Size(28, 28);
			this.notgudprotectbksufu.HoverState.Parent = this.notgudprotectbksufu;
			this.notgudprotectbksufu.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 59371));
			this.notgudprotectbksufu.ImageRotate = 0f;
			this.notgudprotectbksufu.ImageSize = new Size(30, 30);
			this.notgudprotectbksufu.Location = new Point(572, 49);
			this.notgudprotectbksufu.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 61070);
			this.notgudprotectbksufu.PressedState.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 57837));
			this.notgudprotectbksufu.PressedState.ImageSize = new Size(28, 28);
			this.notgudprotectbksufu.PressedState.Parent = this.notgudprotectbksufu;
			this.notgudprotectbksufu.Size = new Size(28, 22);
			this.notgudprotectbksufu.TabIndex = 7;
			this.notgudprotectbksufu.Click += this.notgudprotectevnrif;
			this.notgudprotectbksufq.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 63542));
			this.notgudprotectbksufq.Location = new Point(18, 20);
			this.notgudprotectbksufq.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 61958);
			this.notgudprotectbksufq.Size = new Size(34, 32);
			this.notgudprotectbksufq.SizeMode = PictureBoxSizeMode.StretchImage;
			this.notgudprotectbksufq.TabIndex = 22;
			this.notgudprotectbksufq.TabStop = false;
			this.notgudprotectbksufy.BorderRadius = 5;
			this.notgudprotectbksufy.ContainerControl = this;
			this.notgudprotectbksufy.DragForm = false;
			this.notgudprotectbksufz.Animated = true;
			this.notgudprotectbksufz.BorderRadius = 5;
			this.notgudprotectbksufz.CheckedState.Parent = this.notgudprotectbksufz;
			this.notgudprotectbksufz.CustomImages.Parent = this.notgudprotectbksufz;
			this.notgudprotectbksufz.FillColor = Color.FromArgb(35, 35, 35);
			this.notgudprotectbksufz.FillColor2 = Color.FromArgb(40, 40, 40);
			this.notgudprotectbksufz.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 59429), 10f, FontStyle.Bold);
			this.notgudprotectbksufz.ForeColor = Color.White;
			this.notgudprotectbksufz.HoverState.Parent = this.notgudprotectbksufz;
			this.notgudprotectbksufz.Location = new Point(161, 81);
			this.notgudprotectbksufz.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 59649);
			this.notgudprotectbksufz.ShadowDecoration.Parent = this.notgudprotectbksufz;
			this.notgudprotectbksufz.Size = new Size(106, 28);
			this.notgudprotectbksufz.TabIndex = 26;
			this.notgudprotectbksufz.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 61068);
			this.notgudprotectbksufz.Click += this.notgudprotectevnrig;
			this.notgudprotectbksuga.CheckedState.ImageSize = new Size(64, 64);
			this.notgudprotectbksuga.CheckedState.Parent = this.notgudprotectbksuga;
			this.notgudprotectbksuga.HoverState.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 62434));
			this.notgudprotectbksuga.HoverState.ImageSize = new Size(28, 28);
			this.notgudprotectbksuga.HoverState.Parent = this.notgudprotectbksuga;
			this.notgudprotectbksuga.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 61721));
			this.notgudprotectbksuga.ImageRotate = 0f;
			this.notgudprotectbksuga.ImageSize = new Size(30, 30);
			this.notgudprotectbksuga.Location = new Point(59, 77);
			this.notgudprotectbksuga.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 60194);
			this.notgudprotectbksuga.PressedState.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 59024));
			this.notgudprotectbksuga.PressedState.ImageSize = new Size(28, 28);
			this.notgudprotectbksuga.PressedState.Parent = this.notgudprotectbksuga;
			this.notgudprotectbksuga.Size = new Size(39, 32);
			this.notgudprotectbksuga.TabIndex = 27;
			this.notgudprotectbksuga.Click += this.notgudprotectevnrii;
			this.notgudprotectbksugb.CheckedState.ImageSize = new Size(64, 64);
			this.notgudprotectbksugb.CheckedState.Parent = this.notgudprotectbksugb;
			this.notgudprotectbksugb.HoverState.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 57356));
			this.notgudprotectbksugb.HoverState.ImageSize = new Size(28, 28);
			this.notgudprotectbksugb.HoverState.Parent = this.notgudprotectbksugb;
			this.notgudprotectbksugb.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 57929));
			this.notgudprotectbksugb.ImageRotate = 0f;
			this.notgudprotectbksugb.ImageSize = new Size(30, 30);
			this.notgudprotectbksugb.Location = new Point(116, 77);
			this.notgudprotectbksugb.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 58780);
			this.notgudprotectbksugb.PressedState.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 62013));
			this.notgudprotectbksugb.PressedState.ImageSize = new Size(28, 28);
			this.notgudprotectbksugb.PressedState.Parent = this.notgudprotectbksugb;
			this.notgudprotectbksugb.Size = new Size(39, 32);
			this.notgudprotectbksugb.TabIndex = 28;
			this.notgudprotectbksugb.Click += this.notgudprotectevnrij;
			this.notgudprotectbksugd.Animated = true;
			this.notgudprotectbksugd.BorderRadius = 5;
			this.notgudprotectbksugd.CheckedState.Parent = this.notgudprotectbksugd;
			this.notgudprotectbksugd.CustomImages.Parent = this.notgudprotectbksugd;
			this.notgudprotectbksugd.FillColor = Color.FromArgb(35, 35, 35);
			this.notgudprotectbksugd.FillColor2 = Color.FromArgb(40, 40, 40);
			this.notgudprotectbksugd.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 59429), 10f, FontStyle.Bold);
			this.notgudprotectbksugd.ForeColor = Color.White;
			this.notgudprotectbksugd.HoverState.Parent = this.notgudprotectbksugd;
			this.notgudprotectbksugd.Location = new Point(463, 81);
			this.notgudprotectbksugd.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 59281);
			this.notgudprotectbksugd.ShadowDecoration.Parent = this.notgudprotectbksugd;
			this.notgudprotectbksugd.Size = new Size(106, 28);
			this.notgudprotectbksugd.TabIndex = 29;
			this.notgudprotectbksugd.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 61735);
			this.notgudprotectbksugd.Click += this.notgudprotectevnril;
			this.notgudprotectbksugc.BackColor = Color.Transparent;
			this.notgudprotectbksugc.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 62053), 9f, FontStyle.Bold);
			this.notgudprotectbksugc.ForeColor = SystemColors.Control;
			this.notgudprotectbksugc.IsSelectionEnabled = false;
			this.notgudprotectbksugc.Location = new Point(282, 87);
			this.notgudprotectbksugc.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 63093);
			this.notgudprotectbksugc.Size = new Size(171, 17);
			this.notgudprotectbksugc.TabIndex = 30;
			this.notgudprotectbksugc.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 58402);
			this.notgudprotectbksuge.BorderRadius = 5;
			this.notgudprotectbksuge.CheckedState.Parent = this.notgudprotectbksuge;
			this.notgudprotectbksuge.CustomImages.Parent = this.notgudprotectbksuge;
			this.notgudprotectbksuge.FillColor = Color.FromArgb(0, 192, 192);
			this.notgudprotectbksuge.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 57860), 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.notgudprotectbksuge.ForeColor = Color.White;
			this.notgudprotectbksuge.HoverState.Parent = this.notgudprotectbksuge;
			this.notgudprotectbksuge.Location = new Point(576, 24);
			this.notgudprotectbksuge.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 57590);
			this.notgudprotectbksuge.PressedColor = Color.Teal;
			this.notgudprotectbksuge.ShadowDecoration.Parent = this.notgudprotectbksuge;
			this.notgudprotectbksuge.Size = new Size(29, 24);
			this.notgudprotectbksuge.TabIndex = 24;
			this.notgudprotectbksuge.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 61416);
			this.notgudprotectbksuge.Click += this.notgudprotectevnrik;
			this.notgudprotectbksugf.ContainerControl = this;
			this.notgudprotectbksugf.TargetControl = this.notgudprotectbksufo;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(26, 26, 26);
			base.ClientSize = new Size(655, 121);
			base.Controls.Add(this.notgudprotectbksugc);
			base.Controls.Add(this.notgudprotectbksugd);
			base.Controls.Add(this.notgudprotectbksugb);
			base.Controls.Add(this.notgudprotectbksuga);
			base.Controls.Add(this.notgudprotectbksufz);
			base.Controls.Add(this.notgudprotectbksufx);
			base.Controls.Add(this.notgudprotectbksufv);
			base.Controls.Add(this.notgudprotectbksufu);
			base.Controls.Add(this.notgudprotectbksuft);
			base.Controls.Add(this.notgudprotectbksufo);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 58589));
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 58037);
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 58037);
			base.Load += this.notgudprotectevnrie;
			this.notgudprotectbksufo.ResumeLayout(false);
			this.notgudprotectbksufo.PerformLayout();
			((ISupportInitialize)this.notgudprotectbksufq).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000005 RID: 5
		private Guna2ShadowPanel notgudprotectbksufo;

		// Token: 0x04000006 RID: 6
		private Label notgudprotectbksufp;

		// Token: 0x04000007 RID: 7
		private PictureBox notgudprotectbksufq;

		// Token: 0x04000008 RID: 8
		private Guna2Button notgudprotectbksufr;

		// Token: 0x04000009 RID: 9
		private Guna2Button notgudprotectbksufs;

		// Token: 0x0400000A RID: 10
		private Guna2TextBox notgudprotectbksuft;

		// Token: 0x0400000B RID: 11
		private Guna2ImageButton notgudprotectbksufu;

		// Token: 0x0400000C RID: 12
		private Label notgudprotectbksufv;

		// Token: 0x0400000D RID: 13
		private OpenFileDialog notgudprotectbksufw;

		// Token: 0x0400000E RID: 14
		private Guna2TextBox notgudprotectbksufx;

		// Token: 0x0400000F RID: 15
		private Guna2BorderlessForm notgudprotectbksufy;

		// Token: 0x04000010 RID: 16
		private Guna2GradientButton notgudprotectbksufz;

		// Token: 0x04000011 RID: 17
		private Guna2ImageButton notgudprotectbksuga;

		// Token: 0x04000012 RID: 18
		private Guna2ImageButton notgudprotectbksugb;

		// Token: 0x04000013 RID: 19
		private Guna2HtmlLabel notgudprotectbksugc;

		// Token: 0x04000014 RID: 20
		private Guna2GradientButton notgudprotectbksugd;

		// Token: 0x04000015 RID: 21
		private Guna2Button notgudprotectbksuge;

		// Token: 0x04000016 RID: 22
		private Guna2DragControl notgudprotectbksugf;
	}
}
