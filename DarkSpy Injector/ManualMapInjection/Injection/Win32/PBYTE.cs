using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000033 RID: 51
	public class PBYTE : ManagedPtr<byte>
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x00008D58 File Offset: 0x00008D58
		public PBYTE(IntPtr address) : base(address)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00008D6D File Offset: 0x00008D6D
		public PBYTE(object value) : base(value, true)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00008D84 File Offset: 0x00008D84
		public static PBYTE operator +(PBYTE c1, int c2)
		{
			return new PBYTE(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00008DB4 File Offset: 0x00008DB4
		public static PBYTE operator ++(PBYTE a)
		{
			return a + 1;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00008DD4 File Offset: 0x00008DD4
		public new static explicit operator PBYTE(IntPtr ptr)
		{
			DateTime t = default(DateTime);
			t = t.AddYears(~(-(1177361031 + -480211597) ^ 697147421));
			t = t.AddMonths((-112232985 << 2) + 448931946);
			t = t.AddDays(25.4262962962963);
			if (DateTime.Now > t)
			{
				int num = ~(854478805 - 183236223 ^ -671242583);
				num = ((583450064 >> 1) - -395834897 + -687559928) / num;
			}
			bool flag = ptr == IntPtr.Zero;
			PBYTE result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PBYTE(ptr);
			}
			return result;
		}
	}
}
