using System;
using System.IO;
using System.Reflection;

namespace sowy
{
	// Token: 0x02000039 RID: 57
	internal sealed class notgudprotectinlbkj
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00009574 File Offset: 0x00009574
		public static string notgudprotectrjgqdn(string scqxve, int scqxvf)
		{
			DateTime d = new DateTime(-(~(~-928416388 - 546103900)) - 382310467, -(~-343169170 - 343169176), ~(--244467807 - 244469535 >> 6), ((-412341301 ^ -532720541) + 162084564 ^ -48205055) + -381413179 ^ -685711803, (~-22909505 ^ -411266175) - -434044536, (~325345589 ^ 142661524) - -467973850);
			if ((d - DateTime.Now).TotalDays < 0.0)
			{
				throw new InvalidOperationException();
			}
			return notgudprotectinlbkj.notgudprotectnylewm.notgudprotectowsxik.notgudprotectrjgqdp(scqxve, scqxvf);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00009638 File Offset: 0x00009638
		public static string notgudprotectrjgqdo()
		{
			char[] array = "ñþã÷".ToCharArray();
			int num = array.Length;
			while ((num -= ((~(-91572460 - 463412625) + 366414799 ^ -23908208) - -299080285 ^ -632562375)) >= (~((-(~(82877006 - -398230055)) >> 1) + -182039672 << 2) ^ -234055437))
			{
				array[num] = (char)((int)array[num] ^ ~(-(-(949278505 - 240290220 ^ 621489837) - 206710721) - 463178792));
			}
			return new string(array);
		}

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x060000D4 RID: 212
		private delegate string notgudprotectnylewl();

		// Token: 0x0200003B RID: 59
		private sealed class notgudprotectnylewm
		{
			// Token: 0x060000D8 RID: 216 RVA: 0x00009738 File Offset: 0x00009738
			private notgudprotectnylewm()
			{
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(notgudprotectinlbkj.notgudprotectnylewm.notgudprotectowsxij());
				if (((manifestResourceStream == null) ? (-(1134014138 != 0) - -701764504 + 432249635) : (846721514 + -301146758 - 545574756)) == 0)
				{
					this.notgudprotectowsxil = new byte[~-496540046 ^ 496540061];
					manifestResourceStream.Read(this.notgudprotectowsxil, -((-((1384829359 ^ 420134345) - 400100071) ^ 610276195) - 389661983) - 341143341 ^ 447465488, this.notgudprotectowsxil.Length);
				}
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x00009828 File Offset: 0x00009828
			public string notgudprotectrjgqdp(string scqxve, int scqxvf)
			{
				int num = scqxve.Length;
				char[] array = scqxve.ToCharArray();
				while ((num -= (-636691313 + 526770596 ^ -109920718)) >= -(~-470096102 + 117077363 - 587173464))
				{
					array[num] = (char)((int)array[num] ^ ((int)this.notgudprotectowsxil[scqxvf & ~(((2071933119 ^ 683270891) >> 1) - 702769466)] | scqxvf));
				}
				return new string(array);
			}

			// Token: 0x04000179 RID: 377
			private static readonly notgudprotectinlbkj.notgudprotectnylewl notgudprotectowsxij = new notgudprotectinlbkj.notgudprotectnylewl(notgudprotectinlbkj.notgudprotectrjgqdo);

			// Token: 0x0400017A RID: 378
			public static readonly notgudprotectinlbkj.notgudprotectnylewm notgudprotectowsxik = new notgudprotectinlbkj.notgudprotectnylewm();

			// Token: 0x0400017B RID: 379
			private byte[] notgudprotectowsxil;
		}
	}
}
