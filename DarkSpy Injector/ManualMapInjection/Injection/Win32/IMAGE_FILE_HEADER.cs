using System;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000012 RID: 18
	public struct IMAGE_FILE_HEADER
	{
		// Token: 0x04000097 RID: 151
		public ushort Machine;

		// Token: 0x04000098 RID: 152
		public ushort NumberOfSections;

		// Token: 0x04000099 RID: 153
		public uint TimeDateStamp;

		// Token: 0x0400009A RID: 154
		public uint PointerToSymbolTable;

		// Token: 0x0400009B RID: 155
		public uint NumberOfSymbols;

		// Token: 0x0400009C RID: 156
		public ushort SizeOfOptionalHeader;

		// Token: 0x0400009D RID: 157
		public ushort Characteristics;
	}
}
