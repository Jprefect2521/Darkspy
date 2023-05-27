﻿using System;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200000E RID: 14
	public enum SubSystemType : ushort
	{
		// Token: 0x04000040 RID: 64
		IMAGE_SUBSYSTEM_UNKNOWN,
		// Token: 0x04000041 RID: 65
		IMAGE_SUBSYSTEM_NATIVE,
		// Token: 0x04000042 RID: 66
		IMAGE_SUBSYSTEM_WINDOWS_GUI,
		// Token: 0x04000043 RID: 67
		IMAGE_SUBSYSTEM_WINDOWS_CUI,
		// Token: 0x04000044 RID: 68
		IMAGE_SUBSYSTEM_POSIX_CUI = 7,
		// Token: 0x04000045 RID: 69
		IMAGE_SUBSYSTEM_WINDOWS_CE_GUI = 9,
		// Token: 0x04000046 RID: 70
		IMAGE_SUBSYSTEM_EFI_APPLICATION,
		// Token: 0x04000047 RID: 71
		IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER,
		// Token: 0x04000048 RID: 72
		IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER,
		// Token: 0x04000049 RID: 73
		IMAGE_SUBSYSTEM_EFI_ROM,
		// Token: 0x0400004A RID: 74
		IMAGE_SUBSYSTEM_XBOX
	}
}
