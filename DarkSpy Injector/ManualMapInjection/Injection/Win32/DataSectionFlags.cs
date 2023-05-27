using System;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000010 RID: 16
	[Flags]
	public enum DataSectionFlags : uint
	{
		// Token: 0x0400005A RID: 90
		TypeReg = 0U,
		// Token: 0x0400005B RID: 91
		TypeDsect = 1U,
		// Token: 0x0400005C RID: 92
		TypeNoLoad = 2U,
		// Token: 0x0400005D RID: 93
		TypeGroup = 4U,
		// Token: 0x0400005E RID: 94
		TypeNoPadded = 8U,
		// Token: 0x0400005F RID: 95
		TypeCopy = 16U,
		// Token: 0x04000060 RID: 96
		ContentCode = 32U,
		// Token: 0x04000061 RID: 97
		ContentInitializedData = 64U,
		// Token: 0x04000062 RID: 98
		ContentUninitializedData = 128U,
		// Token: 0x04000063 RID: 99
		LinkOther = 256U,
		// Token: 0x04000064 RID: 100
		LinkInfo = 512U,
		// Token: 0x04000065 RID: 101
		TypeOver = 1024U,
		// Token: 0x04000066 RID: 102
		LinkRemove = 2048U,
		// Token: 0x04000067 RID: 103
		LinkComDat = 4096U,
		// Token: 0x04000068 RID: 104
		NoDeferSpecExceptions = 16384U,
		// Token: 0x04000069 RID: 105
		RelativeGP = 32768U,
		// Token: 0x0400006A RID: 106
		MemPurgeable = 131072U,
		// Token: 0x0400006B RID: 107
		Memory16Bit = 131072U,
		// Token: 0x0400006C RID: 108
		MemoryLocked = 262144U,
		// Token: 0x0400006D RID: 109
		MemoryPreload = 524288U,
		// Token: 0x0400006E RID: 110
		Align1Bytes = 1048576U,
		// Token: 0x0400006F RID: 111
		Align2Bytes = 2097152U,
		// Token: 0x04000070 RID: 112
		Align4Bytes = 3145728U,
		// Token: 0x04000071 RID: 113
		Align8Bytes = 4194304U,
		// Token: 0x04000072 RID: 114
		Align16Bytes = 5242880U,
		// Token: 0x04000073 RID: 115
		Align32Bytes = 6291456U,
		// Token: 0x04000074 RID: 116
		Align64Bytes = 7340032U,
		// Token: 0x04000075 RID: 117
		Align128Bytes = 8388608U,
		// Token: 0x04000076 RID: 118
		Align256Bytes = 9437184U,
		// Token: 0x04000077 RID: 119
		Align512Bytes = 10485760U,
		// Token: 0x04000078 RID: 120
		Align1024Bytes = 11534336U,
		// Token: 0x04000079 RID: 121
		Align2048Bytes = 12582912U,
		// Token: 0x0400007A RID: 122
		Align4096Bytes = 13631488U,
		// Token: 0x0400007B RID: 123
		Align8192Bytes = 14680064U,
		// Token: 0x0400007C RID: 124
		LinkExtendedRelocationOverflow = 16777216U,
		// Token: 0x0400007D RID: 125
		MemoryDiscardable = 33554432U,
		// Token: 0x0400007E RID: 126
		MemoryNotCached = 67108864U,
		// Token: 0x0400007F RID: 127
		MemoryNotPaged = 134217728U,
		// Token: 0x04000080 RID: 128
		MemoryShared = 268435456U,
		// Token: 0x04000081 RID: 129
		MemoryExecute = 536870912U,
		// Token: 0x04000082 RID: 130
		MemoryRead = 1073741824U,
		// Token: 0x04000083 RID: 131
		MemoryWrite = 2147483648U
	}
}
