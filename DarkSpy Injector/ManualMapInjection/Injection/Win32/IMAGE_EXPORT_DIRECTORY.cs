using System;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200001D RID: 29
	public struct IMAGE_EXPORT_DIRECTORY
	{
		// Token: 0x0400011E RID: 286
		public uint Characteristics;

		// Token: 0x0400011F RID: 287
		public uint TimeDateStamp;

		// Token: 0x04000120 RID: 288
		public ushort MajorVersion;

		// Token: 0x04000121 RID: 289
		public ushort MinorVersion;

		// Token: 0x04000122 RID: 290
		public uint Name;

		// Token: 0x04000123 RID: 291
		public uint Base;

		// Token: 0x04000124 RID: 292
		public uint NumberOfFunctions;

		// Token: 0x04000125 RID: 293
		public uint NumberOfNames;

		// Token: 0x04000126 RID: 294
		public uint AddressOfFunctions;

		// Token: 0x04000127 RID: 295
		public uint AddressOfNames;

		// Token: 0x04000128 RID: 296
		public uint AddressOfNameOrdinals;
	}
}
