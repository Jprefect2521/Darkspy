using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000036 RID: 54
	public class PIMAGE_TLS_DIRECTORY32 : ManagedPtr<IMAGE_TLS_DIRECTORY32>
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x000090A6 File Offset: 0x000090A6
		public PIMAGE_TLS_DIRECTORY32(IntPtr address) : base(address)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000090BB File Offset: 0x000090BB
		public PIMAGE_TLS_DIRECTORY32(object value) : base(value, true)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000090D4 File Offset: 0x000090D4
		public static PIMAGE_TLS_DIRECTORY32 operator +(PIMAGE_TLS_DIRECTORY32 c1, int c2)
		{
			return new PIMAGE_TLS_DIRECTORY32(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00009104 File Offset: 0x00009104
		public static PIMAGE_TLS_DIRECTORY32 operator ++(PIMAGE_TLS_DIRECTORY32 a)
		{
			return a + 1;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00009124 File Offset: 0x00009124
		public new static explicit operator PIMAGE_TLS_DIRECTORY32(IntPtr ptr)
		{
			DateTime t = new DateTime(--114775411 + -114773390, -(~(493016855 ^ -273264680) ^ -220948279), ~(-(-212294575 + 212294602)));
			if (t < DateTime.Now)
			{
				throw new ArgumentOutOfRangeException();
			}
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_TLS_DIRECTORY32 result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_TLS_DIRECTORY32(ptr);
			}
			return result;
		}
	}
}
