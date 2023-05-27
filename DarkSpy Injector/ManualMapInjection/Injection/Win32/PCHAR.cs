using System;
using System.Runtime.InteropServices;
using System.Text;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002A RID: 42
	public class PCHAR : ManagedPtr<char>
	{
		// Token: 0x0600007E RID: 126 RVA: 0x000082EA File Offset: 0x000082EA
		public PCHAR(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000082FF File Offset: 0x000082FF
		public PCHAR(object value) : base(value, true)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00008315 File Offset: 0x00008315
		public PCHAR(string value) : base(Encoding.UTF8.GetBytes(value), true)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00008338 File Offset: 0x00008338
		public static PCHAR operator +(PCHAR c1, int c2)
		{
			return new PCHAR(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00008368 File Offset: 0x00008368
		public static PCHAR operator ++(PCHAR a)
		{
			return a + 1;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00008388 File Offset: 0x00008388
		public new static explicit operator PCHAR(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PCHAR result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PCHAR(ptr);
			}
			return result;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000083C0 File Offset: 0x000083C0
		public override string ToString()
		{
			return Marshal.PtrToStringAnsi(base.Address) ?? string.Empty;
		}
	}
}
