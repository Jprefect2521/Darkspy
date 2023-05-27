using System;
using System.Runtime.InteropServices;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000019 RID: 25
	[StructLayout(LayoutKind.Explicit)]
	public struct IMAGE_IMPORT_DESCRIPTOR
	{
		// Token: 0x0400010B RID: 267
		[FieldOffset(0)]
		public uint Characteristics;

		// Token: 0x0400010C RID: 268
		[FieldOffset(0)]
		public uint OriginalFirstThunk;

		// Token: 0x0400010D RID: 269
		[FieldOffset(4)]
		public uint TimeDateStamp;

		// Token: 0x0400010E RID: 270
		[FieldOffset(8)]
		public uint ForwarderChain;

		// Token: 0x0400010F RID: 271
		[FieldOffset(12)]
		public uint Name;

		// Token: 0x04000110 RID: 272
		[FieldOffset(16)]
		public uint FirstThunk;
	}
}
