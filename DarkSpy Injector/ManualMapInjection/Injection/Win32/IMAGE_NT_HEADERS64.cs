using System;
using System.Runtime.InteropServices;
using sowy;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000017 RID: 23
	[StructLayout(LayoutKind.Explicit)]
	public struct IMAGE_NT_HEADERS64
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00007FC4 File Offset: 0x00007FC4
		private string notgudprotecthabtnj
		{
			get
			{
				return new string(this.Signature);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00007FE8 File Offset: 0x00007FE8
		public bool isValid
		{
			get
			{
				return this.notgudprotecthabtnj == notgudprotectinlbkj.notgudprotectrjgqdn("", 62244);
			}
		}

		// Token: 0x040000FE RID: 254
		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public char[] Signature;

		// Token: 0x040000FF RID: 255
		[FieldOffset(4)]
		public IMAGE_FILE_HEADER FileHeader;

		// Token: 0x04000100 RID: 256
		[FieldOffset(24)]
		public IMAGE_OPTIONAL_HEADER64 OptionalHeader;
	}
}
