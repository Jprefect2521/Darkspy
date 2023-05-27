using System;
using System.Text;

namespace sowy
{
	// Token: 0x02000008 RID: 8
	internal static class notgudprotectinlbkg
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00005B60 File Offset: 0x00005B60
		internal static string notgudprotectaqltgw(byte[] scqxve)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in scqxve)
			{
				bool flag = b == 0;
				if (flag)
				{
					IL_51:
					return stringBuilder.ToString();
				}
				stringBuilder.Append((char)b);
			}
			goto IL_51;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005BCC File Offset: 0x00005BCC
		internal static bool notgudprotectaqltgx(char[] scqxve, char[] scqxvf)
		{
			int num = Math.Min(scqxve.Length, scqxvf.Length);
			int i = 0;
			while (i < num)
			{
				bool flag = scqxve[i] != scqxvf[i];
				bool result;
				if (flag)
				{
					result = false;
				}
				else
				{
					bool flag2 = scqxve[i] == '\0';
					if (!flag2)
					{
						i++;
						continue;
					}
					IL_67:
					result = true;
				}
				return result;
			}
			goto IL_67;
		}
	}
}
