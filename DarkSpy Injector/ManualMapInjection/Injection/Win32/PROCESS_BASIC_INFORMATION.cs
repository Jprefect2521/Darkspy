using System;
using System.Runtime.InteropServices;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200001A RID: 26
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct PROCESS_BASIC_INFORMATION
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000803C File Offset: 0x0000803C
		public int Size
		{
			get
			{
				return Marshal.SizeOf(typeof(PROCESS_BASIC_INFORMATION));
			}
		}

		// Token: 0x04000111 RID: 273
		public IntPtr ExitStatus;

		// Token: 0x04000112 RID: 274
		public IntPtr PebBaseAddress;

		// Token: 0x04000113 RID: 275
		public IntPtr AffinityMask;

		// Token: 0x04000114 RID: 276
		public IntPtr BasePriority;

		// Token: 0x04000115 RID: 277
		public UIntPtr UniqueProcessId;

		// Token: 0x04000116 RID: 278
		public IntPtr InheritedFromUniqueProcessId;
	}
}
