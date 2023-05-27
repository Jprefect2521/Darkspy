using System;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000020 RID: 32
	public struct IMAGE_TLS_DIRECTORY32
	{
		// Token: 0x0400012D RID: 301
		public uint StartAddressOfRawData;

		// Token: 0x0400012E RID: 302
		public uint EndAddressOfRawData;

		// Token: 0x0400012F RID: 303
		public uint AddressOfIndex;

		// Token: 0x04000130 RID: 304
		public uint AddressOfCallBacks;

		// Token: 0x04000131 RID: 305
		public uint SizeOfZeroFill;

		// Token: 0x04000132 RID: 306
		public uint Characteristics;
	}
}
