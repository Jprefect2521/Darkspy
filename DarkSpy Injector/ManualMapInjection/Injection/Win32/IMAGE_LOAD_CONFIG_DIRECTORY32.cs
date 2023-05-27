using System;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000021 RID: 33
	public struct IMAGE_LOAD_CONFIG_DIRECTORY32
	{
		// Token: 0x04000133 RID: 307
		public uint Size;

		// Token: 0x04000134 RID: 308
		public uint TimeDateStamp;

		// Token: 0x04000135 RID: 309
		public ushort MajorVersion;

		// Token: 0x04000136 RID: 310
		public ushort MinorVersion;

		// Token: 0x04000137 RID: 311
		public uint GlobalFlagsClear;

		// Token: 0x04000138 RID: 312
		public uint GlobalFlagsSet;

		// Token: 0x04000139 RID: 313
		public uint CriticalSectionDefaultTimeout;

		// Token: 0x0400013A RID: 314
		public uint DeCommitFreeBlockThreshold;

		// Token: 0x0400013B RID: 315
		public uint DeCommitTotalFreeThreshold;

		// Token: 0x0400013C RID: 316
		public uint LockPrefixTable;

		// Token: 0x0400013D RID: 317
		public uint MaximumAllocationSize;

		// Token: 0x0400013E RID: 318
		public uint VirtualMemoryThreshold;

		// Token: 0x0400013F RID: 319
		public uint ProcessHeapFlags;

		// Token: 0x04000140 RID: 320
		public uint ProcessAffinityMask;

		// Token: 0x04000141 RID: 321
		public ushort CSDVersion;

		// Token: 0x04000142 RID: 322
		public ushort Reserved1;

		// Token: 0x04000143 RID: 323
		public uint EditList;

		// Token: 0x04000144 RID: 324
		public uint SecurityCookie;

		// Token: 0x04000145 RID: 325
		public uint SEHandlerTable;

		// Token: 0x04000146 RID: 326
		public uint SEHandlerCount;

		// Token: 0x04000147 RID: 327
		public uint GuardCFCheckFunctionPointer;

		// Token: 0x04000148 RID: 328
		public uint Reserved2;

		// Token: 0x04000149 RID: 329
		public uint GuardCFFunctionTable;

		// Token: 0x0400014A RID: 330
		public uint GuardCFFunctionCount;

		// Token: 0x0400014B RID: 331
		public uint GuardFlags;
	}
}
