using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using sowy;

namespace Demon
{
	// Token: 0x02000007 RID: 7
	public partial class Settings : Form
	{
		// Token: 0x0600002E RID: 46 RVA: 0x0000506F File Offset: 0x0000506F
		public Settings()
		{
			this.notgudprotectkotrpj();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005098 File Offset: 0x00005098
		private void notgudprotectkotrph(object scqxve, EventArgs scqxvf)
		{
			Main main = new Main();
			main.Show();
			base.Hide();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000050C4 File Offset: 0x000050C4
		private void notgudprotectkotrpi(object scqxve, EventArgs scqxvf)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005124 File Offset: 0x00005124
		private void notgudprotectkotrpj()
		{
			this.notgudprotectgrtsgt = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Settings));
			this.notgudprotectgrtsgu = new Guna2ShadowPanel();
			this.notgudprotectgrtsgv = new Label();
			this.notgudprotectgrtsgw = new PictureBox();
			this.notgudprotectgrtsgx = new Guna2Button();
			this.notgudprotectgrtsgy = new Guna2Button();
			this.notgudprotectgrtsgz = new Guna2Button();
			this.notgudprotectgrtsha = new Guna2Button();
			this.notgudprotectgrtshb = new Label();
			this.notgudprotectgrtshc = new Guna2DragControl(this.notgudprotectgrtsgt);
			this.notgudprotectgrtsgu.SuspendLayout();
			((ISupportInitialize)this.notgudprotectgrtsgw).BeginInit();
			base.SuspendLayout();
			this.notgudprotectgrtsgu.BackColor = Color.Transparent;
			this.notgudprotectgrtsgu.Controls.Add(this.notgudprotectgrtsgz);
			this.notgudprotectgrtsgu.Controls.Add(this.notgudprotectgrtsgv);
			this.notgudprotectgrtsgu.Controls.Add(this.notgudprotectgrtsha);
			this.notgudprotectgrtsgu.Controls.Add(this.notgudprotectgrtsgw);
			this.notgudprotectgrtsgu.Controls.Add(this.notgudprotectgrtsgx);
			this.notgudprotectgrtsgu.Controls.Add(this.notgudprotectgrtsgy);
			this.notgudprotectgrtsgu.FillColor = Color.FromArgb(0, 192, 192);
			this.notgudprotectgrtsgu.Location = new Point(-19, -20);
			this.notgudprotectgrtsgu.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 61124);
			this.notgudprotectgrtsgu.ShadowColor = Color.FromArgb(15, 15, 15);
			this.notgudprotectgrtsgu.Size = new Size(358, 55);
			this.notgudprotectgrtsgu.TabIndex = 5;
			this.notgudprotectgrtsgv.AutoSize = true;
			this.notgudprotectgrtsgv.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 62282), 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.notgudprotectgrtsgv.ForeColor = Color.White;
			this.notgudprotectgrtsgv.Location = new Point(49, 29);
			this.notgudprotectgrtsgv.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 59448);
			this.notgudprotectgrtsgv.Size = new Size(60, 15);
			this.notgudprotectgrtsgv.TabIndex = 23;
			this.notgudprotectgrtsgv.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 62253);
			this.notgudprotectgrtsgw.Image = (Image)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 62860));
			this.notgudprotectgrtsgw.Location = new Point(18, 20);
			this.notgudprotectgrtsgw.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 61005);
			this.notgudprotectgrtsgw.Size = new Size(34, 32);
			this.notgudprotectgrtsgw.SizeMode = PictureBoxSizeMode.StretchImage;
			this.notgudprotectgrtsgw.TabIndex = 22;
			this.notgudprotectgrtsgw.TabStop = false;
			this.notgudprotectgrtsgx.BorderRadius = 5;
			this.notgudprotectgrtsgx.CheckedState.Parent = this.notgudprotectgrtsgx;
			this.notgudprotectgrtsgx.CustomImages.Parent = this.notgudprotectgrtsgx;
			this.notgudprotectgrtsgx.FillColor = Color.FromArgb(0, 192, 192);
			this.notgudprotectgrtsgx.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 58030), 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.notgudprotectgrtsgx.ForeColor = Color.White;
			this.notgudprotectgrtsgx.HoverState.Parent = this.notgudprotectgrtsgx;
			this.notgudprotectgrtsgx.Location = new Point(544, 24);
			this.notgudprotectgrtsgx.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 57679);
			this.notgudprotectgrtsgx.PressedColor = Color.Teal;
			this.notgudprotectgrtsgx.ShadowDecoration.Parent = this.notgudprotectgrtsgx;
			this.notgudprotectgrtsgx.Size = new Size(29, 24);
			this.notgudprotectgrtsgx.TabIndex = 20;
			this.notgudprotectgrtsgx.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 62084);
			this.notgudprotectgrtsgy.BorderRadius = 5;
			this.notgudprotectgrtsgy.CheckedState.Parent = this.notgudprotectgrtsgy;
			this.notgudprotectgrtsgy.CustomImages.Parent = this.notgudprotectgrtsgy;
			this.notgudprotectgrtsgy.FillColor = Color.FromArgb(0, 192, 192);
			this.notgudprotectgrtsgy.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 58030), 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.notgudprotectgrtsgy.ForeColor = Color.White;
			this.notgudprotectgrtsgy.HoverState.Parent = this.notgudprotectgrtsgy;
			this.notgudprotectgrtsgy.Location = new Point(576, 24);
			this.notgudprotectgrtsgy.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 61502);
			this.notgudprotectgrtsgy.PressedColor = Color.Teal;
			this.notgudprotectgrtsgy.ShadowDecoration.Parent = this.notgudprotectgrtsgy;
			this.notgudprotectgrtsgy.Size = new Size(29, 24);
			this.notgudprotectgrtsgy.TabIndex = 19;
			this.notgudprotectgrtsgy.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 60193);
			this.notgudprotectgrtsgz.BorderRadius = 5;
			this.notgudprotectgrtsgz.CheckedState.Parent = this.notgudprotectgrtsgz;
			this.notgudprotectgrtsgz.CustomImages.Parent = this.notgudprotectgrtsgz;
			this.notgudprotectgrtsgz.FillColor = Color.FromArgb(0, 192, 192);
			this.notgudprotectgrtsgz.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 58030), 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.notgudprotectgrtsgz.ForeColor = Color.White;
			this.notgudprotectgrtsgz.HoverState.Parent = this.notgudprotectgrtsgz;
			this.notgudprotectgrtsgz.Location = new Point(249, 24);
			this.notgudprotectgrtsgz.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 58652);
			this.notgudprotectgrtsgz.PressedColor = Color.Teal;
			this.notgudprotectgrtsgz.ShadowDecoration.Parent = this.notgudprotectgrtsgz;
			this.notgudprotectgrtsgz.Size = new Size(29, 24);
			this.notgudprotectgrtsgz.TabIndex = 22;
			this.notgudprotectgrtsgz.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 62084);
			this.notgudprotectgrtsgz.Click += this.notgudprotectkotrpi;
			this.notgudprotectgrtsha.BorderRadius = 5;
			this.notgudprotectgrtsha.CheckedState.Parent = this.notgudprotectgrtsha;
			this.notgudprotectgrtsha.CustomImages.Parent = this.notgudprotectgrtsha;
			this.notgudprotectgrtsha.FillColor = Color.FromArgb(0, 192, 192);
			this.notgudprotectgrtsha.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 58030), 9f, FontStyle.Bold, GraphicsUnit.Point, 162);
			this.notgudprotectgrtsha.ForeColor = Color.White;
			this.notgudprotectgrtsha.HoverState.Parent = this.notgudprotectgrtsha;
			this.notgudprotectgrtsha.Location = new Point(284, 24);
			this.notgudprotectgrtsha.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 63388);
			this.notgudprotectgrtsha.PressedColor = Color.Teal;
			this.notgudprotectgrtsha.ShadowDecoration.Parent = this.notgudprotectgrtsha;
			this.notgudprotectgrtsha.Size = new Size(29, 24);
			this.notgudprotectgrtsha.TabIndex = 21;
			this.notgudprotectgrtsha.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 60193);
			this.notgudprotectgrtsha.Click += this.notgudprotectkotrph;
			this.notgudprotectgrtshb.AutoSize = true;
			this.notgudprotectgrtshb.Font = new Font(notgudprotectinlbkj.notgudprotectrjgqdn("", 62282), 25f, FontStyle.Bold);
			this.notgudprotectgrtshb.ForeColor = Color.White;
			this.notgudprotectgrtshb.Location = new Point(26, 50);
			this.notgudprotectgrtshb.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 61510);
			this.notgudprotectgrtshb.Size = new Size(235, 39);
			this.notgudprotectgrtshb.TabIndex = 24;
			this.notgudprotectgrtshb.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 59124);
			this.notgudprotectgrtshc.ContainerControl = this;
			this.notgudprotectgrtshc.TargetControl = this.notgudprotectgrtsgu;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(26, 26, 26);
			base.ClientSize = new Size(297, 106);
			base.Controls.Add(this.notgudprotectgrtshb);
			base.Controls.Add(this.notgudprotectgrtsgu);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject(notgudprotectinlbkj.notgudprotectrjgqdn("", 60638));
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = notgudprotectinlbkj.notgudprotectrjgqdn("", 59099);
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = notgudprotectinlbkj.notgudprotectrjgqdn("", 59099);
			this.notgudprotectgrtsgu.ResumeLayout(false);
			this.notgudprotectgrtsgu.PerformLayout();
			((ISupportInitialize)this.notgudprotectgrtsgw).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000026 RID: 38
		private Guna2ShadowPanel notgudprotectgrtsgu;

		// Token: 0x04000027 RID: 39
		private Label notgudprotectgrtsgv;

		// Token: 0x04000028 RID: 40
		private PictureBox notgudprotectgrtsgw;

		// Token: 0x04000029 RID: 41
		private Guna2Button notgudprotectgrtsgx;

		// Token: 0x0400002A RID: 42
		private Guna2Button notgudprotectgrtsgy;

		// Token: 0x0400002B RID: 43
		private Guna2Button notgudprotectgrtsgz;

		// Token: 0x0400002C RID: 44
		private Guna2Button notgudprotectgrtsha;

		// Token: 0x0400002D RID: 45
		private Label notgudprotectgrtshb;

		// Token: 0x0400002E RID: 46
		private Guna2DragControl notgudprotectgrtshc;
	}
}
