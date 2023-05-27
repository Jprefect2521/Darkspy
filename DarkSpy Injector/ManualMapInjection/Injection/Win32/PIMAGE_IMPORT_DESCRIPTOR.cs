using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002C RID: 44
	public class PIMAGE_IMPORT_DESCRIPTOR : ManagedPtr<IMAGE_IMPORT_DESCRIPTOR>
	{
		// Token: 0x06000088 RID: 136 RVA: 0x0000844E File Offset: 0x0000844E
		public PIMAGE_IMPORT_DESCRIPTOR(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00008463 File Offset: 0x00008463
		public PIMAGE_IMPORT_DESCRIPTOR(object value) : base(value, true)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000847C File Offset: 0x0000847C
		public static PIMAGE_IMPORT_DESCRIPTOR operator +(PIMAGE_IMPORT_DESCRIPTOR c1, int c2)
		{
			return new PIMAGE_IMPORT_DESCRIPTOR(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000084AC File Offset: 0x000084AC
		public static PIMAGE_IMPORT_DESCRIPTOR operator ++(PIMAGE_IMPORT_DESCRIPTOR a)
		{
			return a + 1;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000084CC File Offset: 0x000084CC
		public new static explicit operator PIMAGE_IMPORT_DESCRIPTOR(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_IMPORT_DESCRIPTOR result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_IMPORT_DESCRIPTOR(ptr);
			}
			return result;
		}
	}
}
