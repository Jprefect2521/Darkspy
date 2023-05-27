using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002B RID: 43
	public class PPROCESS_BASIC_INFORMATION : ManagedPtr<PROCESS_BASIC_INFORMATION>
	{
		// Token: 0x06000085 RID: 133 RVA: 0x000083EA File Offset: 0x000083EA
		public PPROCESS_BASIC_INFORMATION(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000083FF File Offset: 0x000083FF
		public PPROCESS_BASIC_INFORMATION(object value) : base(value, true)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00008418 File Offset: 0x00008418
		public new static explicit operator PPROCESS_BASIC_INFORMATION(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			PPROCESS_BASIC_INFORMATION result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PPROCESS_BASIC_INFORMATION(ptr);
			}
			return result;
		}
	}
}
