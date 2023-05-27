using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000037 RID: 55
	public class PIMAGE_LOAD_CONFIG_DIRECTORY32 : ManagedPtr<IMAGE_LOAD_CONFIG_DIRECTORY32>
	{
		// Token: 0x060000BD RID: 189 RVA: 0x000091B3 File Offset: 0x000091B3
		public PIMAGE_LOAD_CONFIG_DIRECTORY32(IntPtr address) : base(address)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000091C8 File Offset: 0x000091C8
		public PIMAGE_LOAD_CONFIG_DIRECTORY32(object value) : base(value, true)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000091E0 File Offset: 0x000091E0
		public static PIMAGE_LOAD_CONFIG_DIRECTORY32 operator +(PIMAGE_LOAD_CONFIG_DIRECTORY32 c1, int c2)
		{
			return new PIMAGE_LOAD_CONFIG_DIRECTORY32(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00009210 File Offset: 0x00009210
		public static PIMAGE_LOAD_CONFIG_DIRECTORY32 operator ++(PIMAGE_LOAD_CONFIG_DIRECTORY32 a)
		{
			return a + 1;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00009230 File Offset: 0x00009230
		public new static explicit operator PIMAGE_LOAD_CONFIG_DIRECTORY32(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_LOAD_CONFIG_DIRECTORY32 result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_LOAD_CONFIG_DIRECTORY32(ptr);
			}
			return result;
		}
	}
}
