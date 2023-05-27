using System;
using System.Runtime.InteropServices;
using sowy;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000016 RID: 22
	[StructLayout(LayoutKind.Explicit)]
	public struct IMAGE_NT_HEADERS32
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00007F70 File Offset: 0x00007F70
		private string notgudprotectvjwacc
		{
			get
			{
				return new string(this.Signature);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00007F94 File Offset: 0x00007F94
		public bool isValid
		{
			get
			{
				return this.notgudprotectvjwacc == notgudprotectinlbkj.notgudprotectrjgqdn("", 59126);
			}
		}

		// Token: 0x040000FB RID: 251
		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public char[] Signature;

		// Token: 0x040000FC RID: 252
		[FieldOffset(4)]
		public IMAGE_FILE_HEADER FileHeader;

		// Token: 0x040000FD RID: 253
		[FieldOffset(24)]
		public IMAGE_OPTIONAL_HEADER32 OptionalHeader;
	}
}
