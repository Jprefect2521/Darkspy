using System;
using System.Runtime.InteropServices;
using sowy;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000011 RID: 17
	public struct IMAGE_DOS_HEADER
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00007F1C File Offset: 0x00007F1C
		private string notgudprotectxuthck
		{
			get
			{
				return new string(this.e_magic);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00007F40 File Offset: 0x00007F40
		public bool isValid
		{
			get
			{
				return this.notgudprotectxuthck == notgudprotectinlbkj.notgudprotectrjgqdn("", 59233);
			}
		}

		// Token: 0x04000084 RID: 132
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public char[] e_magic;

		// Token: 0x04000085 RID: 133
		public ushort e_cblp;

		// Token: 0x04000086 RID: 134
		public ushort e_cp;

		// Token: 0x04000087 RID: 135
		public ushort e_crlc;

		// Token: 0x04000088 RID: 136
		public ushort e_cparhdr;

		// Token: 0x04000089 RID: 137
		public ushort e_minalloc;

		// Token: 0x0400008A RID: 138
		public ushort e_maxalloc;

		// Token: 0x0400008B RID: 139
		public ushort e_ss;

		// Token: 0x0400008C RID: 140
		public ushort e_sp;

		// Token: 0x0400008D RID: 141
		public ushort e_csum;

		// Token: 0x0400008E RID: 142
		public ushort e_ip;

		// Token: 0x0400008F RID: 143
		public ushort e_cs;

		// Token: 0x04000090 RID: 144
		public ushort e_lfarlc;

		// Token: 0x04000091 RID: 145
		public ushort e_ovno;

		// Token: 0x04000092 RID: 146
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public ushort[] e_res1;

		// Token: 0x04000093 RID: 147
		public ushort e_oemid;

		// Token: 0x04000094 RID: 148
		public ushort e_oeminfo;

		// Token: 0x04000095 RID: 149
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public ushort[] e_res2;

		// Token: 0x04000096 RID: 150
		public int e_lfanew;
	}
}
