using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32
{
	// Token: 0x02000030 RID: 48
	public class PWORD : ManagedPtr<ushort>
	{
		// Token: 0x0600009A RID: 154 RVA: 0x0000891A File Offset: 0x0000891A
		public PWORD(IntPtr address) : base(address)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000892F File Offset: 0x0000892F
		public PWORD(object value) : base(value, true)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008948 File Offset: 0x00008948
		public static PWORD operator +(PWORD c1, int c2)
		{
			return new PWORD(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00008978 File Offset: 0x00008978
		public static PWORD operator ++(PWORD a)
		{
			DateTime d = new DateTime((-341948762 ^ -341919226) >> 5, -(-650463912 + 650463905), -(-553917558 + 553917454 >> 2), ~(544195158 ^ -538775794) - 7524679 >> 5, ~(-(-370107332 + 370107369)), -(~567585505 - -567585459));
			if ((DateTime.Now - d).TotalDays > 0.0)
			{
				int num = --646670333 ^ 646670333;
				num = -(-2 >> 1) / num;
			}
			return a + 1;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00008A38 File Offset: 0x00008A38
		public new static explicit operator PWORD(IntPtr ptr)
		{
			DateTime d = new DateTime((644969103 ^ 644910031) >> 6, (-185812457 ^ 184788432) - 426276912 ^ -427382896, --612141756 + -612141731, 1181244896 >> 2 ^ 295311223, 492141753 + -492141745, ~(1341544303 - 589576337 + -162718059) ^ -589249903);
			if ((d - DateTime.Now).TotalDays < 0.0)
			{
				throw new Exception();
			}
			bool flag = ptr == IntPtr.Zero;
			PWORD result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new PWORD(ptr);
			}
			return result;
		}
	}
}
