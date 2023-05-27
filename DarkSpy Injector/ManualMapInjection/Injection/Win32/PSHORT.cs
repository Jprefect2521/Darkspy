using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000035 RID: 53
	public class PSHORT : ManagedPtr<short>
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00008FF2 File Offset: 0x00008FF2
		public PSHORT(IntPtr address) : base(address)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00009007 File Offset: 0x00009007
		public PSHORT(object value) : base(value, true)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00009020 File Offset: 0x00009020
		public static PSHORT operator +(PSHORT c1, int c2)
		{
			return new PSHORT(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00009050 File Offset: 0x00009050
		public static PSHORT operator ++(PSHORT a)
		{
			return a + 1;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00009070 File Offset: 0x00009070
		public new static explicit operator PSHORT(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PSHORT result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PSHORT(ptr);
			}
			return result;
		}
	}
}
