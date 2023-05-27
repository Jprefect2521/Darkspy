using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000034 RID: 52
	public class PIMAGE_BASE_RELOCATION : ManagedPtr<IMAGE_BASE_RELOCATION>
	{
		// Token: 0x060000AE RID: 174 RVA: 0x00008EB3 File Offset: 0x00008EB3
		public PIMAGE_BASE_RELOCATION(IntPtr address) : base(address)
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00008EC8 File Offset: 0x00008EC8
		public PIMAGE_BASE_RELOCATION(object value) : base(value, true)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00008EE0 File Offset: 0x00008EE0
		public static PIMAGE_BASE_RELOCATION operator +(PIMAGE_BASE_RELOCATION c1, int c2)
		{
			DateTime t = default(DateTime);
			t = t.AddYears(-(129314069 ^ -129313527));
			t = t.AddMonths(~(-(256 >> 6)) << 1);
			t = t.AddDays(24.8661226851852);
			if (t < DateTime.Now)
			{
				int num = ~(-1);
				num = -(~(-1223194949 + 248061938 ^ 615363204) + -515042263) / num;
			}
			return new PIMAGE_BASE_RELOCATION(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00008F9C File Offset: 0x00008F9C
		public static PIMAGE_BASE_RELOCATION operator ++(PIMAGE_BASE_RELOCATION a)
		{
			return a + 1;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00008FBC File Offset: 0x00008FBC
		public new static explicit operator PIMAGE_BASE_RELOCATION(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_BASE_RELOCATION result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_BASE_RELOCATION(ptr);
			}
			return result;
		}
	}
}
