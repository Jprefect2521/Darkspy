using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using sowy;

namespace ManualMapInjection.Injection.Types
{
	// Token: 0x02000038 RID: 56
	public class ManagedPtr<T> where T : struct
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00009266 File Offset: 0x00009266
		public IntPtr Address { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00009274 File Offset: 0x00009274
		public T Value
		{
			get
			{
				return this[0U];
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00009294 File Offset: 0x00009294
		public int StructSize
		{
			get
			{
				bool flag = this.notgudprotectsjfkbr == null;
				if (flag)
				{
					this.notgudprotectsjfkbr = new int?(Marshal.SizeOf(typeof(T)));
				}
				return this.notgudprotectsjfkbr.Value;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000092F0 File Offset: 0x000092F0
		private static T notgudprotectndvxef(IntPtr scqxve)
		{
			return (T)((object)Marshal.PtrToStructure(scqxve, typeof(T)));
		}

		// Token: 0x17000019 RID: 25
		public T this[uint index]
		{
			get
			{
				return ManagedPtr<T>.notgudprotectndvxef(this.Address + (int)(index * (uint)this.StructSize));
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000934C File Offset: 0x0000934C
		public static ManagedPtr<T>operator +(ManagedPtr<T> c1, int c2)
		{
			return new ManagedPtr<T>(c1.Address + c2 * c1.StructSize);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000937C File Offset: 0x0000937C
		public static ManagedPtr<T>operator ++(ManagedPtr<T> a)
		{
			return a + 1;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000939C File Offset: 0x0000939C
		public static ManagedPtr<T>operator -(ManagedPtr<T> c1, int c2)
		{
			return new ManagedPtr<T>(c1.Address - c2 * c1.StructSize);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000093CC File Offset: 0x000093CC
		public static ManagedPtr<T>operator --(ManagedPtr<T> a)
		{
			return a - 1;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000093EC File Offset: 0x000093EC
		public static explicit operator ManagedPtr<T>(IntPtr ptr)
		{
			bool flag = ptr == IntPtr.Zero;
			ManagedPtr<T> result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new ManagedPtr<T>(ptr);
			}
			return result;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00009424 File Offset: 0x00009424
		public static explicit operator IntPtr(ManagedPtr<T> ptr)
		{
			return ptr.Address;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00009440 File Offset: 0x00009440
		public ManagedPtr(IntPtr address)
		{
			this.notgudprotectsjfkbq = address;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000945C File Offset: 0x0000945C
		public ManagedPtr(object value, bool freeHandle = true)
		{
			bool flag = value == null;
			if (flag)
			{
				throw new InvalidOperationException(notgudprotectinlbkj.notgudprotectrjgqdn("", 58152));
			}
			try
			{
				this.notgudprotectsjfkbs = GCHandle.Alloc(value, GCHandleType.Pinned);
			}
			catch (Exception)
			{
				throw new InvalidOperationException(notgudprotectinlbkj.notgudprotectrjgqdn("", 60760) + value.GetType().Name);
			}
			this.notgudprotectsjfkbt = freeHandle;
			this.notgudprotectsjfkbq = this.notgudprotectsjfkbs.AddrOfPinnedObject();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000950C File Offset: 0x0000950C
		protected override void Finalize()
		{
			try
			{
				bool flag = this.notgudprotectsjfkbs.IsAllocated && this.notgudprotectsjfkbt;
				if (flag)
				{
					this.notgudprotectsjfkbs.Free();
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x04000175 RID: 373
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly IntPtr notgudprotectsjfkbq;

		// Token: 0x04000176 RID: 374
		private int? notgudprotectsjfkbr;

		// Token: 0x04000177 RID: 375
		private GCHandle notgudprotectsjfkbs;

		// Token: 0x04000178 RID: 376
		private bool notgudprotectsjfkbt;
	}
}
