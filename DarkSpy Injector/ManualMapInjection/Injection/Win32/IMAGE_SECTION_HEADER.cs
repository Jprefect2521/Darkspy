using System;
using System.Runtime.InteropServices;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000018 RID: 24
	[StructLayout(LayoutKind.Explicit)]
	public struct IMAGE_SECTION_HEADER
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00008018 File Offset: 0x00008018
		public string Section
		{
			get
			{
				return new string(this.Name);
			}
		}

		// Token: 0x04000101 RID: 257
		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public char[] Name;

		// Token: 0x04000102 RID: 258
		[FieldOffset(8)]
		public uint VirtualSize;

		// Token: 0x04000103 RID: 259
		[FieldOffset(12)]
		public uint VirtualAddress;

		// Token: 0x04000104 RID: 260
		[FieldOffset(16)]
		public uint SizeOfRawData;

		// Token: 0x04000105 RID: 261
		[FieldOffset(20)]
		public uint PointerToRawData;

		// Token: 0x04000106 RID: 262
		[FieldOffset(24)]
		public uint PointerToRelocations;

		// Token: 0x04000107 RID: 263
		[FieldOffset(28)]
		public uint PointerToLinenumbers;

		// Token: 0x04000108 RID: 264
		[FieldOffset(32)]
		public ushort NumberOfRelocations;

		// Token: 0x04000109 RID: 265
		[FieldOffset(34)]
		public ushort NumberOfLinenumbers;

		// Token: 0x0400010A RID: 266
		[FieldOffset(36)]
		public DataSectionFlags Characteristics;
	}
}
