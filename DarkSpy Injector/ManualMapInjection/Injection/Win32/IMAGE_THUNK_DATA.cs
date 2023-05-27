using System;
using System.Runtime.InteropServices;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200001C RID: 28
	[StructLayout(LayoutKind.Explicit)]
	public struct IMAGE_THUNK_DATA
	{
		// Token: 0x0400011A RID: 282
		[FieldOffset(0)]
		public uint ForwarderString;

		// Token: 0x0400011B RID: 283
		[FieldOffset(0)]
		public uint Function;

		// Token: 0x0400011C RID: 284
		[FieldOffset(0)]
		public uint Ordinal;

		// Token: 0x0400011D RID: 285
		[FieldOffset(0)]
		public uint AddressOfData;
	}
}
