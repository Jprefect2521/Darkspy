using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000032 RID: 50
	public class PIMAGE_IMPORT_BY_NAME : ManagedPtr<IMAGE_IMPORT_BY_NAME>
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00008BB2 File Offset: 0x00008BB2
		public PIMAGE_IMPORT_BY_NAME(IntPtr address) : base(address)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00008BC7 File Offset: 0x00008BC7
		public PIMAGE_IMPORT_BY_NAME(object value) : base(value, true)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00008BE0 File Offset: 0x00008BE0
		public static PIMAGE_IMPORT_BY_NAME operator +(PIMAGE_IMPORT_BY_NAME c1, int c2)
		{
			return new PIMAGE_IMPORT_BY_NAME(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00008C10 File Offset: 0x00008C10
		public static PIMAGE_IMPORT_BY_NAME operator ++(PIMAGE_IMPORT_BY_NAME a)
		{
			DateTime d = default(DateTime);
			d = d.AddYears(139226405 + -139224385);
			d = d.AddMonths(~(-194088137) - 194088130);
			d = d.AddDays(25.1043634259259);
			if ((DateTime.Now - d).TotalDays > 0.0)
			{
				int num = (124755788 ^ 124755788) << 7;
				num = ((710396732 >> 1) - 355198365) / num;
			}
			return a + 1;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00008CC4 File Offset: 0x00008CC4
		public new static explicit operator PIMAGE_IMPORT_BY_NAME(IntPtr ptr)
		{
			DateTime d = new DateTime(572868550 ^ 572866595, (~16417615 >> 3) + 498864937 - 496812728, --295683679 + -295683654);
			if ((DateTime.Now - d).TotalDays > 0.0)
			{
				throw new ArgumentException();
			}
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_IMPORT_BY_NAME result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_IMPORT_BY_NAME(ptr);
			}
			return result;
		}
	}
}
