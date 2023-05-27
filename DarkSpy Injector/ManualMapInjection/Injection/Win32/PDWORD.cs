using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000031 RID: 49
	public class PDWORD : ManagedPtr<uint>
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00008B01 File Offset: 0x00008B01
		public PDWORD(IntPtr address) : base(address)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00008B16 File Offset: 0x00008B16
		public PDWORD(object value) : base(value, true)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00008B2C File Offset: 0x00008B2C
		public static PDWORD operator +(PDWORD c1, int c2)
		{
			return new PDWORD(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00008B5C File Offset: 0x00008B5C
		public static PDWORD operator ++(PDWORD a)
		{
			return a + 1;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00008B7C File Offset: 0x00008B7C
		public new static explicit operator PDWORD(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PDWORD result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PDWORD(ptr);
			}
			return result;
		}
	}
}
