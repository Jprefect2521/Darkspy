using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x0200002E RID: 46
	public class PIMAGE_THUNK_DATA : ManagedPtr<IMAGE_THUNK_DATA>
	{
		// Token: 0x06000090 RID: 144 RVA: 0x000085FB File Offset: 0x000085FB
		public PIMAGE_THUNK_DATA(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00008610 File Offset: 0x00008610
		public PIMAGE_THUNK_DATA(object value) : base(value, true)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00008628 File Offset: 0x00008628
		public static PIMAGE_THUNK_DATA operator +(PIMAGE_THUNK_DATA c1, int c2)
		{
			return new PIMAGE_THUNK_DATA(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00008658 File Offset: 0x00008658
		public static PIMAGE_THUNK_DATA operator ++(PIMAGE_THUNK_DATA a)
		{
			return a + 1;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00008678 File Offset: 0x00008678
		public new static explicit operator PIMAGE_THUNK_DATA(IntPtr ptr)
		{
			DateTime t = new DateTime(443897838 - -177626849 + -621522666, -(-(278525839 - 321201643) - 300073133) + -257397322, -(-104 >> 2), (1480904672 - 472266789 ^ -650219844) + 450823941, (-650855405 ^ 130780128) + 388249098 ^ -165450249, (209680016 << 2 >> 2) + -209679963);
			if (t < DateTime.Now)
			{
				throw new InvalidOperationException();
			}
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_THUNK_DATA result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_THUNK_DATA(ptr);
			}
			return result;
		}
	}
}
