using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000028 RID: 40
	public class PIMAGE_DOS_HEADER : ManagedPtr<IMAGE_DOS_HEADER>
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00008173 File Offset: 0x00008173
		public PIMAGE_DOS_HEADER(IntPtr address) : base(address)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00008188 File Offset: 0x00008188
		public PIMAGE_DOS_HEADER(object value) : base(value, true)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000081A0 File Offset: 0x000081A0
		public new static explicit operator PIMAGE_DOS_HEADER(IntPtr ptr)
		{
			DateTime t = new DateTime(411647582 - 193752574 + 28107274 - 246000261, 553130529 ^ -27132 ^ -553153502, -(~(-177726001 - -177726385 >> 4)), (--462638707 ^ 462638703) >> 1, -(-418618352 - -272856977) + -145761352, ~(-(345217204 ^ 345217214) << 5 >> 6));
			if (t < DateTime.Now)
			{
				int num = ~(-64 >> 6);
				num = (--368937437 - 226823013 ^ 142114425) / num;
			}
			bool flag = ptr == IntPtr.Zero;
			PIMAGE_DOS_HEADER result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PIMAGE_DOS_HEADER(ptr);
			}
			return result;
		}
	}
}
