using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using ManualMapInjection.Injection.Win32;

namespace sowy
{
	// Token: 0x02000023 RID: 35
	[SuppressUnmanagedCodeSecurity]
	internal static class notgudprotectinlbki
	{
		// Token: 0x0600005F RID: 95
		[DllImport("kernel32.dll", EntryPoint = "VirtualAllocEx", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr notgudprotectnxhjlm(IntPtr scqxve, UIntPtr scqxvf, IntPtr scqxvg, notgudprotectinlbki.notgudprotectclmtxu scqxvh, notgudprotectinlbki.notgudprotectclmtxv scqxvi);

		// Token: 0x06000060 RID: 96
		[DllImport("kernel32.dll", EntryPoint = "VirtualAlloc", SetLastError = true)]
		public static extern IntPtr notgudprotectnxhjln(IntPtr scqxve, UIntPtr scqxvf, notgudprotectinlbki.notgudprotectclmtxu scqxvg, notgudprotectinlbki.notgudprotectclmtxv scqxvh);

		// Token: 0x06000061 RID: 97
		[DllImport("kernel32.dll", EntryPoint = "OpenProcess", SetLastError = true)]
		public static extern IntPtr notgudprotectnxhjlo(notgudprotectinlbki.notgudprotectclmtxw scqxve, bool scqxvf, int scqxvg);

		// Token: 0x06000062 RID: 98
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool notgudprotectnxhjlp(IntPtr scqxve);

		// Token: 0x06000063 RID: 99
		[DllImport("Dbghelp.dll", EntryPoint = "ImageRvaToVa")]
		public static extern IntPtr notgudprotectnxhjlq(IntPtr scqxve, IntPtr scqxvf, UIntPtr scqxvg, [Optional] IntPtr scqxvh);

		// Token: 0x06000064 RID: 100
		[DllImport("kernel32.dll", EntryPoint = "GetProcessHeap", SetLastError = true)]
		public static extern IntPtr notgudprotectnxhjlr();

		// Token: 0x06000065 RID: 101
		[DllImport("kernel32.dll", EntryPoint = "HeapAlloc")]
		public static extern IntPtr notgudprotectnxhjls(IntPtr scqxve, uint scqxvf, UIntPtr scqxvg);

		// Token: 0x06000066 RID: 102
		[DllImport("kernel32.dll", EntryPoint = "HeapFree", SetLastError = true)]
		public static extern bool notgudprotectnxhjlt(IntPtr scqxve, uint scqxvf, IntPtr scqxvg);

		// Token: 0x06000067 RID: 103
		[DllImport("NTDLL.DLL", EntryPoint = "NtQueryInformationProcess", SetLastError = true)]
		public static extern int notgudprotectnxhjlu(IntPtr scqxve, int scqxvf, IntPtr scqxvg, uint scqxvh, out uint scqxvi);

		// Token: 0x06000068 RID: 104
		[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
		public static extern bool notgudprotectnxhjlv(IntPtr scqxve, IntPtr scqxvf, IntPtr scqxvg, int scqxvh, out UIntPtr scqxvi);

		// Token: 0x06000069 RID: 105
		[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
		public static extern bool notgudprotectnxhjlw(IntPtr scqxve, IntPtr scqxvf, byte[] scqxvg, int scqxvh, out UIntPtr scqxvi);

		// Token: 0x0600006A RID: 106
		[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
		public static extern bool notgudprotectnxhjlx(IntPtr scqxve, IntPtr scqxvf, IntPtr scqxvg, IntPtr scqxvh, out UIntPtr scqxvi);

		// Token: 0x0600006B RID: 107
		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr notgudprotectnxhjly(IntPtr scqxve, string scqxvf);

		// Token: 0x0600006C RID: 108
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetModuleHandle")]
		public static extern IntPtr notgudprotectnxhjlz(string scqxve);

		// Token: 0x0600006D RID: 109
		[DllImport("kernel32.dll", EntryPoint = "CreateRemoteThread")]
		public static extern IntPtr notgudprotectnxhjma(IntPtr scqxve, IntPtr scqxvf, uint scqxvg, IntPtr scqxvh, IntPtr scqxvi, uint scqxvj, IntPtr scqxvk);

		// Token: 0x0600006E RID: 110
		[DllImport("kernel32.dll", EntryPoint = "WaitForSingleObject", SetLastError = true)]
		public static extern uint notgudprotectnxhjmb(IntPtr scqxve, uint scqxvf);

		// Token: 0x0600006F RID: 111
		[DllImport("kernel32.dll", EntryPoint = "VirtualFreeEx", ExactSpelling = true, SetLastError = true)]
		public static extern bool notgudprotectnxhjmc(IntPtr scqxve, IntPtr scqxvf, int scqxvg, notgudprotectinlbki.notgudprotectclmtxx scqxvh);

		// Token: 0x06000070 RID: 112
		[DllImport("kernel32.dll", EntryPoint = "VirtualFree", SetLastError = true)]
		public static extern bool notgudprotectnxhjmd(IntPtr scqxve, int scqxvf, notgudprotectinlbki.notgudprotectclmtxx scqxvg);

		// Token: 0x06000071 RID: 113
		[DllImport("kernel32.dll", EntryPoint = "VirtualProtectEx")]
		public static extern bool notgudprotectnxhjme(IntPtr scqxve, IntPtr scqxvf, UIntPtr scqxvg, uint scqxvh, out uint scqxvi);

		// Token: 0x06000072 RID: 114
		[DllImport("kernel32.dll", EntryPoint = "GetSystemTimeAsFileTime")]
		public static extern void notgudprotectnxhjmf(out ManualMapInjection.Injection.Win32.FILETIME scqxve);

		// Token: 0x06000073 RID: 115
		[DllImport("kernel32.dll", EntryPoint = "QueryPerformanceCounter", SetLastError = true)]
		public static extern bool notgudprotectnxhjmg(out long scqxve);

		// Token: 0x06000074 RID: 116 RVA: 0x00008064 File Offset: 0x00008064
		public static bool notgudprotectnxhjmh(IntPtr scqxve, IntPtr scqxvf, byte[] scqxvg, out UIntPtr scqxvh)
		{
			GCHandle gchandle = GCHandle.Alloc(scqxvg, GCHandleType.Pinned);
			bool result = notgudprotectinlbki.notgudprotectnxhjlv(scqxve, scqxvf, gchandle.AddrOfPinnedObject(), scqxvg.Length, out scqxvh);
			gchandle.Free();
			return result;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000080AC File Offset: 0x000080AC
		public static bool notgudprotectnxhjmi(IntPtr scqxve, IntPtr scqxvf, out uint scqxvg, out UIntPtr scqxvh)
		{
			byte[] array = new byte[4];
			bool result = notgudprotectinlbki.notgudprotectnxhjmh(scqxve, scqxvf, array, out scqxvh);
			scqxvg = BitConverter.ToUInt32(array, 0);
			return result;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000080E4 File Offset: 0x000080E4
		public static bool notgudprotectnxhjmj<a>(IntPtr scqxve, IntPtr scqxvf, out a scqxvg, out UIntPtr scqxvh) where a : struct
		{
			byte[] array = new byte[Marshal.SizeOf(typeof(a))];
			bool result = notgudprotectinlbki.notgudprotectnxhjmh(scqxve, scqxvf, array, out scqxvh);
			GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			scqxvg = Marshal.PtrToStructure<a>(gchandle.AddrOfPinnedObject());
			gchandle.Free();
			return result;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00008150 File Offset: 0x00008150
		public static IntPtr notgudprotectnxhjmk(Process scqxve, notgudprotectinlbki.notgudprotectclmtxw scqxvf)
		{
			return notgudprotectinlbki.notgudprotectnxhjlo(scqxvf, false, scqxve.Id);
		}

		// Token: 0x02000024 RID: 36
		[Flags]
		public enum notgudprotectclmtxu
		{
			// Token: 0x0400014F RID: 335
			notgudprotectjmdcuf = 4096,
			// Token: 0x04000150 RID: 336
			notgudprotectjmdcug = 8192,
			// Token: 0x04000151 RID: 337
			notgudprotectjmdcuh = 16384,
			// Token: 0x04000152 RID: 338
			notgudprotectjmdcui = 32768,
			// Token: 0x04000153 RID: 339
			notgudprotectjmdcuj = 524288,
			// Token: 0x04000154 RID: 340
			notgudprotectjmdcuk = 4194304,
			// Token: 0x04000155 RID: 341
			notgudprotectjmdcul = 1048576,
			// Token: 0x04000156 RID: 342
			notgudprotectjmdcum = 2097152,
			// Token: 0x04000157 RID: 343
			notgudprotectjmdcun = 536870912
		}

		// Token: 0x02000025 RID: 37
		[Flags]
		public enum notgudprotectclmtxv
		{
			// Token: 0x04000159 RID: 345
			notgudprotecttrkeir = 16,
			// Token: 0x0400015A RID: 346
			notgudprotecttrkeis = 32,
			// Token: 0x0400015B RID: 347
			notgudprotecttrkeit = 64,
			// Token: 0x0400015C RID: 348
			notgudprotecttrkeiu = 128,
			// Token: 0x0400015D RID: 349
			notgudprotecttrkeiv = 1,
			// Token: 0x0400015E RID: 350
			notgudprotecttrkeiw = 2,
			// Token: 0x0400015F RID: 351
			notgudprotecttrkeix = 4,
			// Token: 0x04000160 RID: 352
			notgudprotecttrkeiy = 8,
			// Token: 0x04000161 RID: 353
			notgudprotecttrkeiz = 256,
			// Token: 0x04000162 RID: 354
			notgudprotecttrkeja = 512,
			// Token: 0x04000163 RID: 355
			notgudprotecttrkejb = 1024
		}

		// Token: 0x02000026 RID: 38
		[Flags]
		public enum notgudprotectclmtxw : uint
		{
			// Token: 0x04000165 RID: 357
			notgudprotectiyifez = 2035711U,
			// Token: 0x04000166 RID: 358
			notgudprotectiyiffa = 1U,
			// Token: 0x04000167 RID: 359
			notgudprotectiyiffb = 2U,
			// Token: 0x04000168 RID: 360
			notgudprotectiyiffc = 8U,
			// Token: 0x04000169 RID: 361
			notgudprotectiyiffd = 16U,
			// Token: 0x0400016A RID: 362
			notgudprotectiyiffe = 32U,
			// Token: 0x0400016B RID: 363
			notgudprotectiyifff = 64U,
			// Token: 0x0400016C RID: 364
			notgudprotectiyiffg = 128U,
			// Token: 0x0400016D RID: 365
			notgudprotectiyiffh = 256U,
			// Token: 0x0400016E RID: 366
			notgudprotectiyiffi = 512U,
			// Token: 0x0400016F RID: 367
			notgudprotectiyiffj = 1024U,
			// Token: 0x04000170 RID: 368
			notgudprotectiyiffk = 4096U,
			// Token: 0x04000171 RID: 369
			notgudprotectiyiffl = 1048576U
		}

		// Token: 0x02000027 RID: 39
		[Flags]
		public enum notgudprotectclmtxx
		{
			// Token: 0x04000173 RID: 371
			notgudprotectdufdmo = 16384,
			// Token: 0x04000174 RID: 372
			notgudprotectdufdmp = 32768
		}
	}
}
