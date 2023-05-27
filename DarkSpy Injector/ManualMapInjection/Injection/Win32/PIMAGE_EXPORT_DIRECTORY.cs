using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002F RID: 47
	public class PIMAGE_EXPORT_DIRECTORY : ManagedPtr<IMAGE_EXPORT_DIRECTORY>
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00008746 File Offset: 0x00008746
		public PIMAGE_EXPORT_DIRECTORY(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000875B File Offset: 0x0000875B
		public PIMAGE_EXPORT_DIRECTORY(object value) : base(value, true)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00008774 File Offset: 0x00008774
		public static PIMAGE_EXPORT_DIRECTORY operator +(PIMAGE_EXPORT_DIRECTORY c1, int c2)
		{
			return new PIMAGE_EXPORT_DIRECTORY(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000087A4 File Offset: 0x000087A4
		public static PIMAGE_EXPORT_DIRECTORY operator ++(PIMAGE_EXPORT_DIRECTORY a)
		{
			DateTime t = new DateTime((37412956 ^ -604521226) - -640854843, ~(-(-1237680745 + 564350165) ^ -673330580), ~(-(-329754718 - -329857150 >> 5)) >> 7);
			if (DateTime.Now > t)
			{
				throw new Exception();
			}
			return a + 1;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00008824 File Offset: 0x00008824
		public new static explicit operator PIMAGE_EXPORT_DIRECTORY(IntPtr ptr)
		{
			DateTime d = default(DateTime);
			d = d.AddYears((~311715785 ^ -360677172 ^ 8540111) - 124342097);
			d = d.AddMonths((-5953112 + -687568739 ^ -693521883) >> 4);
			d = d.AddDays(25.078125);
			if ((DateTime.Now - d).TotalDays > 0.0)
			{
				int num = -590286761 ^ -590286761;
				num = (-107473311 ^ -107473312) / num;
			}
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_EXPORT_DIRECTORY result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_EXPORT_DIRECTORY(ptr);
			}
			return result;
		}
	}
}
