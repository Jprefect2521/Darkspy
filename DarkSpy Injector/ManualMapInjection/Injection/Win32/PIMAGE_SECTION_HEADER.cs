using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002D RID: 45
	public class PIMAGE_SECTION_HEADER : ManagedPtr<IMAGE_SECTION_HEADER>
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00008502 File Offset: 0x00008502
		public PIMAGE_SECTION_HEADER(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00008517 File Offset: 0x00008517
		public PIMAGE_SECTION_HEADER(object value) : base(value, true)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00008530 File Offset: 0x00008530
		public new static explicit operator PIMAGE_SECTION_HEADER(IntPtr ptr)
		{
			DateTime d = default(DateTime);
			d = d.AddYears(((626422489 ^ -109399432) - -296307941 ^ -304729434) >> 5 << 2);
			d = d.AddMonths(-251150142 + 389017606 - 137867458);
			d = d.AddDays(24.7559143518519);
			if ((d - DateTime.Now).TotalDays < 0.0)
			{
				throw new ArgumentException();
			}
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_SECTION_HEADER result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_SECTION_HEADER(ptr);
			}
			return result;
		}
	}
}
