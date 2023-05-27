using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000029 RID: 41
	public class PIMAGE_NT_HEADERS32 : ManagedPtr<IMAGE_NT_HEADERS32>
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00008286 File Offset: 0x00008286
		public PIMAGE_NT_HEADERS32(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000829B File Offset: 0x0000829B
		public PIMAGE_NT_HEADERS32(object value) : base(value, true)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000082B4 File Offset: 0x000082B4
		public new static explicit operator PIMAGE_NT_HEADERS32(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_NT_HEADERS32 result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_NT_HEADERS32(ptr);
			}
			return result;
		}
	}
}
