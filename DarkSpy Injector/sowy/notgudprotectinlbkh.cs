using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using ManualMapInjection.Injection.Win32;

namespace sowy
{
	// Token: 0x02000009 RID: 9
	internal class notgudprotectinlbkh
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00005C45 File Offset: 0x00005C45
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00005C51 File Offset: 0x00005C51
		public bool notgudprotectukfiqz { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00005C5E File Offset: 0x00005C5E
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00005C6A File Offset: 0x00005C6A
		public uint notgudprotectukfira { get; set; }

		// Token: 0x06000039 RID: 57 RVA: 0x00005C78 File Offset: 0x00005C78
		private PIMAGE_DOS_HEADER notgudprotectewaqxq(IntPtr scqxve)
		{
			PIMAGE_DOS_HEADER pimage_DOS_HEADER = (PIMAGE_DOS_HEADER)scqxve;
			bool flag = !pimage_DOS_HEADER.Value.isValid;
			PIMAGE_DOS_HEADER result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = pimage_DOS_HEADER;
			}
			return result;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005CC0 File Offset: 0x00005CC0
		private PIMAGE_NT_HEADERS32 notgudprotectewaqxr(IntPtr scqxve)
		{
			PIMAGE_DOS_HEADER pimage_DOS_HEADER = this.notgudprotectewaqxq(scqxve);
			bool flag = pimage_DOS_HEADER == null;
			PIMAGE_NT_HEADERS32 result;
			if (flag)
			{
				result = null;
			}
			else
			{
				PIMAGE_NT_HEADERS32 pimage_NT_HEADERS = (PIMAGE_NT_HEADERS32)(scqxve + pimage_DOS_HEADER.Value.e_lfanew);
				bool flag2 = !pimage_NT_HEADERS.Value.isValid;
				if (flag2)
				{
					result = null;
				}
				else
				{
					result = pimage_NT_HEADERS;
				}
			}
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005D3C File Offset: 0x00005D3C
		private IntPtr notgudprotectewaqxs(uint scqxve)
		{
			return notgudprotectinlbki.notgudprotectnxhjlm(this.notgudprotectpvesut, UIntPtr.Zero, new IntPtr((long)((ulong)scqxve)), notgudprotectinlbki.notgudprotectclmtxu.notgudprotectjmdcuf | notgudprotectinlbki.notgudprotectclmtxu.notgudprotectjmdcug, notgudprotectinlbki.notgudprotectclmtxv.notgudprotecttrkeit);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005D70 File Offset: 0x00005D70
		private IntPtr notgudprotectewaqxt(uint scqxve)
		{
			return notgudprotectinlbki.notgudprotectnxhjln(IntPtr.Zero, new UIntPtr(scqxve), notgudprotectinlbki.notgudprotectclmtxu.notgudprotectjmdcuf | notgudprotectinlbki.notgudprotectclmtxu.notgudprotectjmdcug, notgudprotectinlbki.notgudprotectclmtxv.notgudprotecttrkeit);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005DA0 File Offset: 0x00005DA0
		private IntPtr notgudprotectewaqxu(uint scqxve, IntPtr scqxvf)
		{
			PIMAGE_NT_HEADERS32 pimage_NT_HEADERS = this.notgudprotectewaqxr(scqxvf);
			bool flag = pimage_NT_HEADERS == null;
			IntPtr result;
			if (flag)
			{
				result = IntPtr.Zero;
			}
			else
			{
				result = notgudprotectinlbki.notgudprotectnxhjlq(pimage_NT_HEADERS.Address, scqxvf, new UIntPtr(scqxve), IntPtr.Zero);
			}
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005DF4 File Offset: 0x00005DF4
		private bool notgudprotectewaqxv(string scqxve)
		{
			IntPtr intPtr = notgudprotectinlbki.notgudprotectnxhjly(notgudprotectinlbki.notgudprotectnxhjlz(notgudprotectinlbkj.notgudprotectrjgqdn("", 61520)), notgudprotectinlbkj.notgudprotectrjgqdn("", 59354));
			bool flag = intPtr == IntPtr.Zero;
			bool result;
			if (flag)
			{
				Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 62521));
				result = false;
			}
			else
			{
				IntPtr intPtr2 = this.notgudprotectewaqxs((uint)scqxve.Length);
				bool flag2 = intPtr2 == IntPtr.Zero;
				if (flag2)
				{
					Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 62995));
					result = false;
				}
				else
				{
					byte[] bytes = Encoding.ASCII.GetBytes(scqxve);
					UIntPtr uintPtr;
					bool flag3 = notgudprotectinlbki.notgudprotectnxhjlw(this.notgudprotectpvesut, intPtr2, bytes, bytes.Length, out uintPtr);
					bool flag4 = flag3;
					if (flag4)
					{
						IntPtr scqxve2 = notgudprotectinlbki.notgudprotectnxhjma(this.notgudprotectpvesut, IntPtr.Zero, 0U, intPtr, intPtr2, 0U, IntPtr.Zero);
						bool flag5 = notgudprotectinlbki.notgudprotectnxhjmb(scqxve2, this.notgudprotectukfira) > 0U;
						if (flag5)
						{
							Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 61486));
							return false;
						}
					}
					else
					{
						Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 60098));
					}
					notgudprotectinlbki.notgudprotectnxhjmc(this.notgudprotectpvesut, intPtr2, 0, notgudprotectinlbki.notgudprotectclmtxx.notgudprotectdufdmp);
					result = flag3;
				}
			}
			return result;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00005F84 File Offset: 0x00005F84
		private IntPtr notgudprotectewaqxw(string scqxve)
		{
			IntPtr zero = IntPtr.Zero;
			IntPtr scqxve2 = notgudprotectinlbki.notgudprotectnxhjlr();
			uint num = (uint)Marshal.SizeOf(typeof(PROCESS_BASIC_INFORMATION));
			PPROCESS_BASIC_INFORMATION pprocess_BASIC_INFORMATION = (PPROCESS_BASIC_INFORMATION)notgudprotectinlbki.notgudprotectnxhjls(scqxve2, 8U, new UIntPtr(num));
			uint num3;
			int num2 = notgudprotectinlbki.notgudprotectnxhjlu(this.notgudprotectpvesut, 0, pprocess_BASIC_INFORMATION.Address, num, out num3);
			bool flag = num2 >= 0 && num < num3;
			if (flag)
			{
				bool flag2 = pprocess_BASIC_INFORMATION != null;
				if (flag2)
				{
					notgudprotectinlbki.notgudprotectnxhjlt(scqxve2, 0U, pprocess_BASIC_INFORMATION.Address);
				}
				pprocess_BASIC_INFORMATION = (PPROCESS_BASIC_INFORMATION)notgudprotectinlbki.notgudprotectnxhjls(scqxve2, 8U, new UIntPtr(num));
				bool flag3 = pprocess_BASIC_INFORMATION == null;
				if (flag3)
				{
					Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 61209));
					return IntPtr.Zero;
				}
				num2 = notgudprotectinlbki.notgudprotectnxhjlu(this.notgudprotectpvesut, 0, pprocess_BASIC_INFORMATION.Address, num3, out num3);
			}
			bool flag4 = num2 >= 0;
			if (flag4)
			{
				bool flag5 = pprocess_BASIC_INFORMATION.Value.PebBaseAddress != IntPtr.Zero;
				if (flag5)
				{
					uint num4;
					UIntPtr uintPtr;
					bool flag6 = notgudprotectinlbki.notgudprotectnxhjmi(this.notgudprotectpvesut, pprocess_BASIC_INFORMATION.Value.PebBaseAddress + 12, out num4, out uintPtr);
					if (flag6)
					{
						uint num5 = num4 + 12U;
						uint num6 = num4 + 12U;
						uint num8;
						for (;;)
						{
							uint num7;
							bool flag7 = !notgudprotectinlbki.notgudprotectnxhjmi(this.notgudprotectpvesut, new IntPtr((long)((ulong)num6)), out num7, out uintPtr);
							if (flag7)
							{
								notgudprotectinlbki.notgudprotectnxhjlt(scqxve2, 0U, pprocess_BASIC_INFORMATION.Address);
							}
							num6 = num7;
							UNICODE_STRING unicode_STRING;
							notgudprotectinlbki.notgudprotectnxhjmj<UNICODE_STRING>(this.notgudprotectpvesut, new IntPtr((long)((ulong)num7)) + 44, out unicode_STRING, out uintPtr);
							string a = string.Empty;
							bool flag8 = unicode_STRING.Length > 0;
							if (flag8)
							{
								byte[] array = new byte[(int)unicode_STRING.Length];
								notgudprotectinlbki.notgudprotectnxhjmh(this.notgudprotectpvesut, unicode_STRING.Buffer, array, out uintPtr);
								a = Encoding.Unicode.GetString(array);
							}
							notgudprotectinlbki.notgudprotectnxhjmi(this.notgudprotectpvesut, new IntPtr((long)((ulong)num7)) + 24, out num8, out uintPtr);
							uint num9;
							notgudprotectinlbki.notgudprotectnxhjmi(this.notgudprotectpvesut, new IntPtr((long)((ulong)num7)) + 32, out num9, out uintPtr);
							bool flag9 = num8 != 0U && num9 > 0U;
							if (flag9)
							{
								bool flag10 = string.Equals(a, scqxve, StringComparison.OrdinalIgnoreCase);
								if (flag10)
								{
									break;
								}
							}
							if (num5 == num6)
							{
								goto IL_26F;
							}
						}
						zero = new IntPtr((long)((ulong)num8));
						IL_26F:;
					}
				}
			}
			bool flag11 = pprocess_BASIC_INFORMATION != null;
			if (flag11)
			{
				notgudprotectinlbki.notgudprotectnxhjlt(scqxve2, 0U, pprocess_BASIC_INFORMATION.Address);
			}
			return zero;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006250 File Offset: 0x00006250
		private IntPtr notgudprotectewaqxx(IntPtr scqxve, PCHAR scqxvf)
		{
			IntPtr intPtr = IntPtr.Zero;
			IMAGE_DOS_HEADER image_DOS_HEADER;
			UIntPtr uintPtr;
			notgudprotectinlbki.notgudprotectnxhjmj<IMAGE_DOS_HEADER>(this.notgudprotectpvesut, scqxve, out image_DOS_HEADER, out uintPtr);
			bool flag = !image_DOS_HEADER.isValid;
			IntPtr result;
			if (flag)
			{
				result = IntPtr.Zero;
			}
			else
			{
				IMAGE_NT_HEADERS32 image_NT_HEADERS;
				notgudprotectinlbki.notgudprotectnxhjmj<IMAGE_NT_HEADERS32>(this.notgudprotectpvesut, scqxve + image_DOS_HEADER.e_lfanew, out image_NT_HEADERS, out uintPtr);
				bool flag2 = !image_NT_HEADERS.isValid;
				if (flag2)
				{
					result = IntPtr.Zero;
				}
				else
				{
					uint virtualAddress = image_NT_HEADERS.OptionalHeader.ExportTable.VirtualAddress;
					bool flag3 = virtualAddress > 0U;
					if (flag3)
					{
						uint size = image_NT_HEADERS.OptionalHeader.ExportTable.Size;
						PIMAGE_EXPORT_DIRECTORY pimage_EXPORT_DIRECTORY = (PIMAGE_EXPORT_DIRECTORY)this.notgudprotectewaqxt(size);
						notgudprotectinlbki.notgudprotectnxhjlv(this.notgudprotectpvesut, scqxve + (int)virtualAddress, pimage_EXPORT_DIRECTORY.Address, (int)size, out uintPtr);
						PWORD pword = (PWORD)(pimage_EXPORT_DIRECTORY.Address + (int)pimage_EXPORT_DIRECTORY.Value.AddressOfNameOrdinals - (int)virtualAddress);
						PDWORD pdword = (PDWORD)(pimage_EXPORT_DIRECTORY.Address + (int)pimage_EXPORT_DIRECTORY.Value.AddressOfNames - (int)virtualAddress);
						PDWORD pdword2 = (PDWORD)(pimage_EXPORT_DIRECTORY.Address + (int)pimage_EXPORT_DIRECTORY.Value.AddressOfFunctions - (int)virtualAddress);
						for (uint num = 0U; num < pimage_EXPORT_DIRECTORY.Value.NumberOfFunctions; num += 1U)
						{
							PCHAR pchar = null;
							bool flag4 = new PDWORD(scqxvf.Address).Value <= 65535U;
							ushort num2;
							if (flag4)
							{
								num2 = (ushort)num;
							}
							else
							{
								bool flag5 = new PDWORD(scqxvf.Address).Value > 65535U && num < pimage_EXPORT_DIRECTORY.Value.NumberOfNames;
								if (!flag5)
								{
									return IntPtr.Zero;
								}
								pchar = (PCHAR)new IntPtr((long)((ulong)pdword[num] + (ulong)((long)pimage_EXPORT_DIRECTORY.Address.ToInt32()) - (ulong)virtualAddress));
								num2 = pword[num];
							}
							bool flag6 = (new PDWORD(scqxvf.Address).Value <= 65535U && new PDWORD(scqxvf.Address).Value == (uint)num2 + pimage_EXPORT_DIRECTORY.Value.Base) || (new PDWORD(scqxvf.Address).Value > 65535U && pchar.ToString() == scqxvf.ToString());
							if (flag6)
							{
								intPtr = scqxve + (int)pdword2[(uint)num2];
								bool flag7 = intPtr.ToInt64() >= (scqxve + (int)virtualAddress).ToInt64() && intPtr.ToInt64() <= (scqxve + (int)virtualAddress + (int)size).ToInt64();
								if (flag7)
								{
									byte[] array = new byte[255];
									notgudprotectinlbki.notgudprotectnxhjmh(this.notgudprotectpvesut, intPtr, array, out uintPtr);
									string text = notgudprotectinlbkg.notgudprotectaqltgw(array);
									string scqxve2 = text.Substring(0, text.IndexOf(notgudprotectinlbkj.notgudprotectrjgqdn("", 63184))) + notgudprotectinlbkj.notgudprotectrjgqdn("", 58721);
									string text2 = text.Substring(text.IndexOf(notgudprotectinlbkj.notgudprotectrjgqdn("", 63184)) + 1);
									IntPtr intPtr2 = this.notgudprotectewaqxw(scqxve2);
									bool flag8 = intPtr2 == IntPtr.Zero;
									if (flag8)
									{
										this.notgudprotectewaqxv(scqxve2);
									}
									bool flag9 = text2.StartsWith(notgudprotectinlbkj.notgudprotectrjgqdn("", 58418));
									if (flag9)
									{
										intPtr = this.notgudprotectewaqxx(intPtr2, new PCHAR(text2) + 1);
									}
									else
									{
										intPtr = this.notgudprotectewaqxx(intPtr2, new PCHAR(text2));
									}
								}
								IL_3FF:
								notgudprotectinlbki.notgudprotectnxhjmd(pimage_EXPORT_DIRECTORY.Address, 0, notgudprotectinlbki.notgudprotectclmtxx.notgudprotectdufdmp);
								goto IL_423;
							}
						}
						goto IL_3FF;
					}
					IL_423:
					result = intPtr;
				}
			}
			return result;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006688 File Offset: 0x00006688
		private bool notgudprotectewaqxy(IntPtr scqxve)
		{
			PIMAGE_NT_HEADERS32 pimage_NT_HEADERS = this.notgudprotectewaqxr(scqxve);
			bool flag = pimage_NT_HEADERS == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = pimage_NT_HEADERS.Value.OptionalHeader.ImportTable.Size > 0U;
				if (flag2)
				{
					PIMAGE_IMPORT_DESCRIPTOR pimage_IMPORT_DESCRIPTOR = (PIMAGE_IMPORT_DESCRIPTOR)this.notgudprotectewaqxu(pimage_NT_HEADERS.Value.OptionalHeader.ImportTable.VirtualAddress, scqxve);
					bool flag3 = pimage_IMPORT_DESCRIPTOR != null;
					if (flag3)
					{
						while (pimage_IMPORT_DESCRIPTOR.Value.Name > 0U)
						{
							PCHAR pchar = (PCHAR)this.notgudprotectewaqxu(pimage_IMPORT_DESCRIPTOR.Value.Name, scqxve);
							bool flag4 = pchar == null;
							if (!flag4)
							{
								bool flag5 = pchar.ToString().Contains(notgudprotectinlbkj.notgudprotectrjgqdn("", 62148));
								if (flag5)
								{
									pchar = new PCHAR(notgudprotectinlbkj.notgudprotectrjgqdn("", 58064));
								}
								IntPtr intPtr = this.notgudprotectewaqxw(pchar.ToString());
								bool flag6 = intPtr == IntPtr.Zero;
								if (flag6)
								{
									this.notgudprotectewaqxv(pchar.ToString());
									intPtr = this.notgudprotectewaqxw(pchar.ToString());
									bool flag7 = intPtr == IntPtr.Zero;
									if (flag7)
									{
										Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 63232));
										goto IL_2C2;
									}
								}
								bool flag8 = pimage_IMPORT_DESCRIPTOR.Value.OriginalFirstThunk > 0U;
								PIMAGE_THUNK_DATA pimage_THUNK_DATA;
								PIMAGE_THUNK_DATA pimage_THUNK_DATA2;
								if (flag8)
								{
									pimage_THUNK_DATA = (PIMAGE_THUNK_DATA)this.notgudprotectewaqxu(pimage_IMPORT_DESCRIPTOR.Value.OriginalFirstThunk, scqxve);
									pimage_THUNK_DATA2 = (PIMAGE_THUNK_DATA)this.notgudprotectewaqxu(pimage_IMPORT_DESCRIPTOR.Value.FirstThunk, scqxve);
								}
								else
								{
									pimage_THUNK_DATA = (PIMAGE_THUNK_DATA)this.notgudprotectewaqxu(pimage_IMPORT_DESCRIPTOR.Value.FirstThunk, scqxve);
									pimage_THUNK_DATA2 = (PIMAGE_THUNK_DATA)this.notgudprotectewaqxu(pimage_IMPORT_DESCRIPTOR.Value.FirstThunk, scqxve);
								}
								while (pimage_THUNK_DATA.Value.AddressOfData > 0U)
								{
									bool flag9 = (pimage_THUNK_DATA.Value.Ordinal & 2147483648U) > 0U;
									bool flag10 = flag9;
									IntPtr value;
									if (flag10)
									{
										short num = (short)(pimage_THUNK_DATA.Value.Ordinal & 65535U);
										value = this.notgudprotectewaqxx(intPtr, new PCHAR(num));
										bool flag11 = value == IntPtr.Zero;
										if (flag11)
										{
											return false;
										}
									}
									else
									{
										PIMAGE_IMPORT_BY_NAME pimage_IMPORT_BY_NAME = (PIMAGE_IMPORT_BY_NAME)this.notgudprotectewaqxu(pimage_THUNK_DATA2.Value.Ordinal, scqxve);
										PCHAR scqxvf = (PCHAR)pimage_IMPORT_BY_NAME.Address + 2;
										value = this.notgudprotectewaqxx(intPtr, scqxvf);
									}
									Marshal.WriteInt32(pimage_THUNK_DATA2.Address, value.ToInt32());
									pimage_THUNK_DATA = ++pimage_THUNK_DATA;
									pimage_THUNK_DATA2 = ++pimage_THUNK_DATA2;
								}
							}
							IL_2C2:
							pimage_IMPORT_DESCRIPTOR = ++pimage_IMPORT_DESCRIPTOR;
						}
						result = true;
					}
					else
					{
						Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 62791));
						result = false;
					}
				}
				else
				{
					Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 58178));
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000069E0 File Offset: 0x000069E0
		private bool notgudprotectewaqxz(IntPtr scqxve, IntPtr scqxvf)
		{
			PIMAGE_NT_HEADERS32 pimage_NT_HEADERS = this.notgudprotectewaqxr(scqxve);
			bool flag = pimage_NT_HEADERS == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = pimage_NT_HEADERS.Value.OptionalHeader.DelayImportDescriptor.Size > 0U;
				if (flag2)
				{
					PIMAGE_IMPORT_DESCRIPTOR pimage_IMPORT_DESCRIPTOR = (PIMAGE_IMPORT_DESCRIPTOR)this.notgudprotectewaqxu(pimage_NT_HEADERS.Value.OptionalHeader.DelayImportDescriptor.VirtualAddress, scqxve);
					bool flag3 = pimage_IMPORT_DESCRIPTOR != null;
					if (flag3)
					{
						while (pimage_IMPORT_DESCRIPTOR.Value.Name > 0U)
						{
							PCHAR pchar = (PCHAR)this.notgudprotectewaqxu(pimage_IMPORT_DESCRIPTOR.Value.Name, scqxve);
							bool flag4 = pchar == null;
							if (!flag4)
							{
								IntPtr intPtr = this.notgudprotectewaqxw(pchar.ToString());
								bool flag5 = intPtr == IntPtr.Zero;
								if (flag5)
								{
									this.notgudprotectewaqxv(pchar.ToString());
									intPtr = this.notgudprotectewaqxw(pchar.ToString());
									bool flag6 = intPtr == IntPtr.Zero;
									if (flag6)
									{
										Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 58911));
										goto IL_28F;
									}
								}
								bool flag7 = pimage_IMPORT_DESCRIPTOR.Value.OriginalFirstThunk > 0U;
								PIMAGE_THUNK_DATA pimage_THUNK_DATA;
								PIMAGE_THUNK_DATA pimage_THUNK_DATA2;
								if (flag7)
								{
									pimage_THUNK_DATA = (PIMAGE_THUNK_DATA)this.notgudprotectewaqxu(pimage_IMPORT_DESCRIPTOR.Value.OriginalFirstThunk, scqxve);
									pimage_THUNK_DATA2 = (PIMAGE_THUNK_DATA)this.notgudprotectewaqxu(pimage_IMPORT_DESCRIPTOR.Value.FirstThunk, scqxve);
								}
								else
								{
									pimage_THUNK_DATA = (PIMAGE_THUNK_DATA)this.notgudprotectewaqxu(pimage_IMPORT_DESCRIPTOR.Value.FirstThunk, scqxve);
									pimage_THUNK_DATA2 = (PIMAGE_THUNK_DATA)this.notgudprotectewaqxu(pimage_IMPORT_DESCRIPTOR.Value.FirstThunk, scqxve);
								}
								while (pimage_THUNK_DATA.Value.AddressOfData > 0U)
								{
									bool flag8 = (pimage_THUNK_DATA.Value.Ordinal & 2147483648U) > 0U;
									bool flag9 = flag8;
									IntPtr value;
									if (flag9)
									{
										short num = (short)(pimage_THUNK_DATA.Value.Ordinal & 65535U);
										value = this.notgudprotectewaqxx(intPtr, new PCHAR(num));
										bool flag10 = value == IntPtr.Zero;
										if (flag10)
										{
											return false;
										}
									}
									else
									{
										PIMAGE_IMPORT_BY_NAME pimage_IMPORT_BY_NAME = (PIMAGE_IMPORT_BY_NAME)this.notgudprotectewaqxu(pimage_THUNK_DATA2.Value.Ordinal, scqxve);
										PCHAR scqxvf2 = (PCHAR)pimage_IMPORT_BY_NAME.Address + 2;
										value = this.notgudprotectewaqxx(intPtr, scqxvf2);
									}
									Marshal.WriteInt32(pimage_THUNK_DATA2.Address, value.ToInt32());
									pimage_THUNK_DATA = ++pimage_THUNK_DATA;
									pimage_THUNK_DATA2 = ++pimage_THUNK_DATA2;
								}
							}
							IL_28F:
							pimage_IMPORT_DESCRIPTOR = ++pimage_IMPORT_DESCRIPTOR;
						}
						result = true;
					}
					else
					{
						Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 60898));
						result = false;
					}
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006CF0 File Offset: 0x00006CF0
		private bool notgudprotectewaqya(uint scqxve, ushort scqxvf, PBYTE scqxvg)
		{
			bool result = true;
			switch (scqxvf >> 12 & 15)
			{
			case 0:
				return result;
			case 1:
			{
				PSHORT pshort = (PSHORT)(scqxvg + (int)(scqxvf & 4095)).Address;
				Marshal.WriteInt16(pshort.Address, (short)((long)pshort.Value + (long)((ulong)((ushort)(scqxve >> 16 & 65535U)))));
				return result;
			}
			case 2:
			{
				PSHORT pshort = (PSHORT)(scqxvg + (int)(scqxvf & 4095)).Address;
				Marshal.WriteInt16(pshort.Address, (short)((long)pshort.Value + (long)((ulong)((ushort)(scqxve & 65535U)))));
				return result;
			}
			case 3:
			{
				PDWORD pdword = (PDWORD)(scqxvg + (int)(scqxvf & 4095)).Address;
				Marshal.WriteInt32(pdword.Address, (int)(pdword.Value + scqxve));
				return result;
			}
			case 4:
				return result;
			case 10:
			{
				PDWORD pdword = (PDWORD)(scqxvg + (int)(scqxvf & 4095)).Address;
				Marshal.WriteInt32(pdword.Address, (int)(pdword.Value + scqxve));
				return result;
			}
			}
			result = false;
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006E64 File Offset: 0x00006E64
		private bool notgudprotectewaqyb(IntPtr scqxve, IntPtr scqxvf)
		{
			PIMAGE_NT_HEADERS32 pimage_NT_HEADERS = this.notgudprotectewaqxr(scqxve);
			bool flag = pimage_NT_HEADERS == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = (pimage_NT_HEADERS.Value.FileHeader.Characteristics & 1) > 0;
				if (flag2)
				{
					result = true;
				}
				else
				{
					uint scqxve2 = (uint)((long)scqxvf.ToInt32() - (long)((ulong)pimage_NT_HEADERS.Value.OptionalHeader.ImageBase));
					uint size = pimage_NT_HEADERS.Value.OptionalHeader.BaseRelocationTable.Size;
					bool flag3 = size > 0U;
					if (flag3)
					{
						PIMAGE_BASE_RELOCATION pimage_BASE_RELOCATION = (PIMAGE_BASE_RELOCATION)this.notgudprotectewaqxu(pimage_NT_HEADERS.Value.OptionalHeader.BaseRelocationTable.VirtualAddress, scqxve);
						bool flag4 = pimage_BASE_RELOCATION != null;
						if (!flag4)
						{
							return false;
						}
						PBYTE pbyte = (PBYTE)pimage_BASE_RELOCATION.Address + (int)size;
						while (pimage_BASE_RELOCATION.Address.ToInt64() < pbyte.Address.ToInt64())
						{
							PBYTE scqxvg = (PBYTE)this.notgudprotectewaqxu(pimage_BASE_RELOCATION.Value.VirtualAddress, scqxve);
							uint num = pimage_BASE_RELOCATION.Value.SizeOfBlock - 8U >> 1;
							PWORD pword = (PWORD)(pimage_BASE_RELOCATION + 1).Address;
							uint num2 = 0U;
							while (num2 < num)
							{
								this.notgudprotectewaqya(scqxve2, pword.Value, scqxvg);
								num2 += 1U;
								pword = ++pword;
							}
							pimage_BASE_RELOCATION = (PIMAGE_BASE_RELOCATION)pword.Address;
						}
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00007044 File Offset: 0x00007044
		private uint notgudprotectewaqyc(DataSectionFlags scqxve)
		{
			uint num = 0U;
			bool flag = scqxve.HasFlag(DataSectionFlags.MemoryNotCached);
			if (flag)
			{
				num |= 512U;
			}
			bool flag2 = scqxve.HasFlag(DataSectionFlags.MemoryExecute);
			if (flag2)
			{
				bool flag3 = scqxve.HasFlag(DataSectionFlags.MemoryRead);
				if (flag3)
				{
					bool flag4 = scqxve.HasFlag((DataSectionFlags)2147483648U);
					if (flag4)
					{
						num |= 64U;
					}
					else
					{
						num |= 32U;
					}
				}
				else
				{
					bool flag5 = scqxve.HasFlag((DataSectionFlags)2147483648U);
					if (flag5)
					{
						num |= 128U;
					}
					else
					{
						num |= 16U;
					}
				}
			}
			else
			{
				bool flag6 = scqxve.HasFlag(DataSectionFlags.MemoryRead);
				if (flag6)
				{
					bool flag7 = scqxve.HasFlag((DataSectionFlags)2147483648U);
					if (flag7)
					{
						num |= 4U;
					}
					else
					{
						num |= 2U;
					}
				}
				else
				{
					bool flag8 = scqxve.HasFlag((DataSectionFlags)2147483648U);
					if (flag8)
					{
						num |= 8U;
					}
					else
					{
						num |= 1U;
					}
				}
			}
			return num;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000071C0 File Offset: 0x000071C0
		private bool notgudprotectewaqyd(char[] scqxve, IntPtr scqxvf, IntPtr scqxvg, ulong scqxvh, ulong scqxvi, ulong scqxvj, ulong scqxvk, uint scqxvl)
		{
			UIntPtr uintPtr;
			bool flag = !notgudprotectinlbki.notgudprotectnxhjlx(this.notgudprotectpvesut, new IntPtr(scqxvg.ToInt64() + (long)scqxvi), new IntPtr(scqxvf.ToInt64() + (long)scqxvh), new IntPtr((long)scqxvj), out uintPtr);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				uint num;
				bool flag2 = !notgudprotectinlbki.notgudprotectnxhjme(this.notgudprotectpvesut, new IntPtr(scqxvg.ToInt64() + (long)scqxvi), new UIntPtr(scqxvk), scqxvl, out num);
				result = !flag2;
			}
			return result;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00007258 File Offset: 0x00007258
		private bool notgudprotectewaqye(IntPtr scqxve, IntPtr scqxvf)
		{
			PIMAGE_NT_HEADERS32 pimage_NT_HEADERS = this.notgudprotectewaqxr(scqxve);
			bool flag = pimage_NT_HEADERS == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				PIMAGE_SECTION_HEADER pimage_SECTION_HEADER = (PIMAGE_SECTION_HEADER)(pimage_NT_HEADERS.Address + 24 + (int)pimage_NT_HEADERS.Value.FileHeader.SizeOfOptionalHeader);
				for (ushort num = 0; num < pimage_NT_HEADERS.Value.FileHeader.NumberOfSections; num += 1)
				{
					bool flag2 = notgudprotectinlbkg.notgudprotectaqltgx(notgudprotectinlbkj.notgudprotectrjgqdn("", 57613).ToCharArray(), pimage_SECTION_HEADER[(uint)num].Name);
					if (!flag2)
					{
						DataSectionFlags characteristics = pimage_SECTION_HEADER[(uint)num].Characteristics;
						bool flag3 = characteristics.HasFlag(DataSectionFlags.MemoryRead) || characteristics.HasFlag((DataSectionFlags)2147483648U) || characteristics.HasFlag(DataSectionFlags.MemoryExecute);
						if (flag3)
						{
							uint scqxvl = this.notgudprotectewaqyc(pimage_SECTION_HEADER[(uint)num].Characteristics);
							this.notgudprotectewaqyd(pimage_SECTION_HEADER[(uint)num].Name, scqxve, scqxvf, (ulong)pimage_SECTION_HEADER[(uint)num].PointerToRawData, (ulong)pimage_SECTION_HEADER[(uint)num].VirtualAddress, (ulong)pimage_SECTION_HEADER[(uint)num].SizeOfRawData, (ulong)pimage_SECTION_HEADER[(uint)num].VirtualSize, scqxvl);
						}
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00007418 File Offset: 0x00007418
		private bool notgudprotectewaqyf(byte[] scqxve, bool scqxvf)
		{
			notgudprotectinlbkh.notgudprotectdfekpp notgudprotectdfekpp = new notgudprotectinlbkh.notgudprotectdfekpp();
			notgudprotectdfekpp.notgudprotectntclfz = this;
			notgudprotectdfekpp.notgudprotectntclga = this.notgudprotectewaqxs((uint)scqxve.Length);
			bool flag = notgudprotectdfekpp.notgudprotectntclga == IntPtr.Zero;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				UIntPtr uintPtr;
				bool flag2 = notgudprotectinlbki.notgudprotectnxhjlw(this.notgudprotectpvesut, notgudprotectdfekpp.notgudprotectntclga, scqxve, scqxve.Length, out uintPtr);
				bool flag3 = flag2;
				if (flag3)
				{
					notgudprotectinlbkh.notgudprotectdfekpq notgudprotectdfekpq = new notgudprotectinlbkh.notgudprotectdfekpq();
					notgudprotectdfekpq.notgudprotectermcso = notgudprotectdfekpp;
					notgudprotectdfekpq.notgudprotectermcsn = notgudprotectinlbki.notgudprotectnxhjma(this.notgudprotectpvesut, IntPtr.Zero, 0U, notgudprotectdfekpq.notgudprotectermcso.notgudprotectntclga, IntPtr.Zero, 0U, IntPtr.Zero);
					if (scqxvf)
					{
						Thread thread = new Thread(new ThreadStart(notgudprotectdfekpq.notgudprotectcnnpun))
						{
							IsBackground = true
						};
						thread.Start();
					}
					else
					{
						notgudprotectinlbki.notgudprotectnxhjmb(notgudprotectdfekpq.notgudprotectermcsn, 4000U);
						notgudprotectinlbki.notgudprotectnxhjmc(this.notgudprotectpvesut, notgudprotectdfekpq.notgudprotectermcso.notgudprotectntclga, 0, notgudprotectinlbki.notgudprotectclmtxx.notgudprotectdufdmp);
					}
				}
				result = flag2;
			}
			return result;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00007568 File Offset: 0x00007568
		private bool notgudprotectewaqyg(IntPtr scqxve, uint scqxvf, bool scqxvg)
		{
			List<byte> list = new List<byte>();
			list.Add(104);
			list.AddRange(BitConverter.GetBytes(scqxve.ToInt32()));
			list.Add(104);
			list.AddRange(BitConverter.GetBytes(1));
			list.Add(104);
			list.AddRange(BitConverter.GetBytes(0));
			list.Add(184);
			list.AddRange(BitConverter.GetBytes(scqxvf));
			list.Add(byte.MaxValue);
			list.Add(208);
			list.Add(51);
			list.Add(192);
			list.Add(194);
			list.Add(4);
			list.Add(0);
			return this.notgudprotectewaqyf(list.ToArray(), scqxvg);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00007674 File Offset: 0x00007674
		private bool notgudprotectewaqyh(IntPtr scqxve, IntPtr scqxvf)
		{
			PIMAGE_NT_HEADERS32 pimage_NT_HEADERS = this.notgudprotectewaqxr(scqxve);
			bool flag = pimage_NT_HEADERS == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = pimage_NT_HEADERS.Value.OptionalHeader.TLSTable.Size == 0U;
				if (flag2)
				{
					result = true;
				}
				else
				{
					PIMAGE_TLS_DIRECTORY32 pimage_TLS_DIRECTORY = (PIMAGE_TLS_DIRECTORY32)this.notgudprotectewaqxu(pimage_NT_HEADERS.Value.OptionalHeader.TLSTable.VirtualAddress, scqxve);
					bool flag3 = pimage_TLS_DIRECTORY == null;
					if (flag3)
					{
						result = true;
					}
					else
					{
						bool flag4 = pimage_TLS_DIRECTORY.Value.AddressOfCallBacks == 0U;
						if (flag4)
						{
							result = true;
						}
						else
						{
							byte[] array = new byte[1020];
							UIntPtr uintPtr;
							bool flag5 = !notgudprotectinlbki.notgudprotectnxhjmh(this.notgudprotectpvesut, new IntPtr((long)((ulong)pimage_TLS_DIRECTORY.Value.AddressOfCallBacks)), array, out uintPtr);
							if (!flag5)
							{
								PDWORD pdword = new PDWORD(array);
								bool flag6 = true;
								uint num = 0U;
								while (pdword[num] > 0U)
								{
									flag6 = this.notgudprotectewaqyg(scqxvf, pdword[num], false);
									bool flag7 = !flag6;
									if (flag7)
									{
										IL_166:
										return flag6;
									}
									num += 1U;
								}
								goto IL_166;
							}
							result = false;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000077F0 File Offset: 0x000077F0
		private IntPtr notgudprotectewaqyi(IntPtr scqxve)
		{
			PIMAGE_NT_HEADERS32 pimage_NT_HEADERS = this.notgudprotectewaqxr(scqxve);
			bool flag = pimage_NT_HEADERS == null;
			IntPtr result;
			if (flag)
			{
				Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 63466));
				result = IntPtr.Zero;
			}
			else
			{
				bool flag2 = pimage_NT_HEADERS.Value.FileHeader.NumberOfSections == 0;
				if (flag2)
				{
					Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 59198));
					result = IntPtr.Zero;
				}
				else
				{
					uint num = uint.MaxValue;
					uint num2 = 0U;
					PIMAGE_SECTION_HEADER pimage_SECTION_HEADER = (PIMAGE_SECTION_HEADER)(pimage_NT_HEADERS.Address + 24 + (int)pimage_NT_HEADERS.Value.FileHeader.SizeOfOptionalHeader);
					for (uint num3 = 0U; num3 < (uint)pimage_NT_HEADERS.Value.FileHeader.NumberOfSections; num3 += 1U)
					{
						bool flag3 = pimage_SECTION_HEADER[num3].VirtualSize == 0U;
						if (!flag3)
						{
							bool flag4 = pimage_SECTION_HEADER[num3].VirtualAddress < num;
							if (flag4)
							{
								num = pimage_SECTION_HEADER[num3].VirtualAddress;
							}
							bool flag5 = pimage_SECTION_HEADER[num3].VirtualAddress + pimage_SECTION_HEADER[num3].VirtualSize > num2;
							if (flag5)
							{
								num2 = pimage_SECTION_HEADER[num3].VirtualAddress + pimage_SECTION_HEADER[num3].VirtualSize;
							}
						}
					}
					uint scqxve2 = num2 - num;
					bool flag6 = pimage_NT_HEADERS.Value.OptionalHeader.ImageBase % 4096U > 0U;
					if (flag6)
					{
						Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 59008));
						result = IntPtr.Zero;
					}
					else
					{
						bool flag7 = pimage_NT_HEADERS.Value.OptionalHeader.DelayImportDescriptor.Size > 0U;
						if (flag7)
						{
							Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 62095));
							result = IntPtr.Zero;
						}
						else
						{
							IntPtr intPtr = this.notgudprotectewaqxs(scqxve2);
							bool flag8 = intPtr == IntPtr.Zero;
							if (flag8)
							{
								Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 59100));
								result = IntPtr.Zero;
							}
							else
							{
								bool flag9 = !this.notgudprotectewaqxy(scqxve);
								if (flag9)
								{
									Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 60401));
									result = IntPtr.Zero;
								}
								else
								{
									bool flag10 = !this.notgudprotectewaqxz(scqxve, intPtr);
									if (flag10)
									{
										Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 60276));
										result = IntPtr.Zero;
									}
									else
									{
										bool flag11 = !this.notgudprotectewaqyb(scqxve, intPtr);
										if (flag11)
										{
											Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 63071));
											result = IntPtr.Zero;
										}
										else
										{
											bool flag12 = !this.notgudprotectewaqye(scqxve, intPtr);
											if (flag12)
											{
												Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 58945));
												result = IntPtr.Zero;
											}
											else
											{
												bool flag13 = !this.notgudprotectewaqyh(scqxve, intPtr);
												if (flag13)
												{
													Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 59360));
													result = IntPtr.Zero;
												}
												else
												{
													bool flag14 = pimage_NT_HEADERS.Value.OptionalHeader.AddressOfEntryPoint > 0U;
													if (flag14)
													{
														int scqxvf = intPtr.ToInt32() + (int)pimage_NT_HEADERS.Value.OptionalHeader.AddressOfEntryPoint;
														bool flag15 = !this.notgudprotectewaqyg(intPtr, (uint)scqxvf, this.notgudprotectukfiqz);
														if (flag15)
														{
															Debug.WriteLine(notgudprotectinlbkj.notgudprotectrjgqdn("", 60502));
															return IntPtr.Zero;
														}
													}
													result = intPtr;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00007BCC File Offset: 0x00007BCC
		private GCHandle notgudprotectewaqyj(byte[] scqxve)
		{
			return GCHandle.Alloc(scqxve, GCHandleType.Pinned);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00007BEC File Offset: 0x00007BEC
		private void notgudprotectewaqyk(GCHandle scqxve)
		{
			bool isAllocated = scqxve.IsAllocated;
			if (isAllocated)
			{
				scqxve.Free();
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00007C20 File Offset: 0x00007C20
		private void notgudprotectewaqyl()
		{
			this.notgudprotectpvesut = notgudprotectinlbki.notgudprotectnxhjmk(this.notgudprotectpvesus, notgudprotectinlbki.notgudprotectclmtxw.notgudprotectiyifez);
			bool flag = this.notgudprotectpvesut == IntPtr.Zero;
			if (flag)
			{
				throw new Exception(string.Format(notgudprotectinlbkj.notgudprotectrjgqdn("", 58965), Marshal.GetLastWin32Error()));
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00007C90 File Offset: 0x00007C90
		private void notgudprotectewaqym()
		{
			bool flag = this.notgudprotectpvesut != IntPtr.Zero;
			if (flag)
			{
				notgudprotectinlbki.notgudprotectnxhjlp(this.notgudprotectpvesut);
				this.notgudprotectpvesut = IntPtr.Zero;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007CDC File Offset: 0x00007CDC
		public IntPtr notgudprotectewaqyn(byte[] scqxve)
		{
			GCHandle scqxve2 = default(GCHandle);
			scqxve = scqxve.ToArray<byte>();
			IntPtr result = IntPtr.Zero;
			try
			{
				bool flag = this.notgudprotectpvesus == null || this.notgudprotectpvesus.HasExited;
				if (flag)
				{
					return result;
				}
				scqxve2 = this.notgudprotectewaqyj(scqxve);
				this.notgudprotectewaqyl();
				result = this.notgudprotectewaqyi(scqxve2.AddrOfPinnedObject());
			}
			catch (Exception arg)
			{
				Debug.WriteLine(string.Format(notgudprotectinlbkj.notgudprotectrjgqdn("", 58002), arg));
			}
			finally
			{
				this.notgudprotectewaqyk(scqxve2);
				this.notgudprotectewaqym();
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007DA4 File Offset: 0x00007DA4
		public IntPtr notgudprotectewaqyo(string scqxve)
		{
			return this.notgudprotectewaqyn(File.ReadAllBytes(scqxve));
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00007DC8 File Offset: 0x00007DC8
		public void notgudprotectewaqyp(string scqxve)
		{
			IntPtr scqxve2 = notgudprotectinlbki.notgudprotectnxhjmk(this.notgudprotectpvesus, notgudprotectinlbki.notgudprotectclmtxw.notgudprotectiyifez);
			IntPtr scqxvh = notgudprotectinlbki.notgudprotectnxhjly(notgudprotectinlbki.notgudprotectnxhjlz(notgudprotectinlbkj.notgudprotectrjgqdn("", 60036)), notgudprotectinlbkj.notgudprotectrjgqdn("", 58230));
			IntPtr intPtr = notgudprotectinlbki.notgudprotectnxhjlm(scqxve2, UIntPtr.Zero, (IntPtr)((scqxve.Length + 1) * Marshal.SizeOf(typeof(char))), notgudprotectinlbki.notgudprotectclmtxu.notgudprotectjmdcuf | notgudprotectinlbki.notgudprotectclmtxu.notgudprotectjmdcug, notgudprotectinlbki.notgudprotectclmtxv.notgudprotecttrkeit);
			UIntPtr uintPtr;
			notgudprotectinlbki.notgudprotectnxhjlw(scqxve2, intPtr, Encoding.ASCII.GetBytes(scqxve), Encoding.ASCII.GetBytes(scqxve).Length, out uintPtr);
			notgudprotectinlbki.notgudprotectnxhjma(scqxve2, IntPtr.Zero, 0U, scqxvh, intPtr, 0U, IntPtr.Zero);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00007E8D File Offset: 0x00007E8D
		public notgudprotectinlbkh(Process scqxve)
		{
			this.notgudprotectpvesus = scqxve;
		}

		// Token: 0x0400002F RID: 47
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool notgudprotectpvesuq = false;

		// Token: 0x04000030 RID: 48
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private uint notgudprotectpvesur = 5000U;

		// Token: 0x04000031 RID: 49
		private readonly Process notgudprotectpvesus;

		// Token: 0x04000032 RID: 50
		private IntPtr notgudprotectpvesut;

		// Token: 0x0200000A RID: 10
		[CompilerGenerated]
		private sealed class notgudprotectdfekpp
		{
			// Token: 0x04000033 RID: 51
			public notgudprotectinlbkh notgudprotectntclfz;

			// Token: 0x04000034 RID: 52
			public IntPtr notgudprotectntclga;
		}

		// Token: 0x0200000B RID: 11
		[CompilerGenerated]
		private sealed class notgudprotectdfekpq
		{
			// Token: 0x06000056 RID: 86 RVA: 0x00007EDA File Offset: 0x00007EDA
			internal void notgudprotectcnnpun()
			{
				notgudprotectinlbki.notgudprotectnxhjmb(this.notgudprotectermcsn, 5000U);
				notgudprotectinlbki.notgudprotectnxhjmc(this.notgudprotectermcso.notgudprotectntclfz.notgudprotectpvesut, this.notgudprotectermcso.notgudprotectntclga, 0, notgudprotectinlbki.notgudprotectclmtxx.notgudprotectdufdmp);
			}

			// Token: 0x04000035 RID: 53
			public IntPtr notgudprotectermcsn;

			// Token: 0x04000036 RID: 54
			public notgudprotectinlbkh.notgudprotectdfekpp notgudprotectermcso;
		}
	}
}
