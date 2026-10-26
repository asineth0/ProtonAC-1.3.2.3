using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal class _8162F8F545F5474A
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct D847CB6AB9214147 : IAsyncStateMachine
	{
		public int C6C01598EE5F4123;

		public AsyncTaskMethodBuilder<bool> DDC18242C06D4429;

		private _02C54685DE0E4B81 _952809FD20024B62;

		private TaskAwaiter F52B75DF490A4D30;

		private TaskAwaiter<bool> F27A5D071B4C4F56;

		private TaskAwaiter<string> _376085A5CFE24545;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			GC.KeepAlive(null);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			DDC18242C06D4429.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object BF976D3489524F87(object P_0, CancellationToken P_1)
		{
			return ((SemaphoreSlim)P_0).WaitAsync(P_1);
		}

		static TaskAwaiter C437267A5B424E3A(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static object _4EAD3D0EAD5D400A()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static string _0D78859E0FEC485C(object P_0)
		{
			return ((_1DB744298E9F4B09)P_0).EBFF406DCE4B4FB2;
		}

		static string E243DA7E07B24655(string P_0, string P_1)
		{
			return Path.Combine(P_0, P_1);
		}

		static bool _975824755FAC4C70(string P_0)
		{
			return File.Exists(P_0);
		}

		static object _02F1F6ED82FD4C17(Guid P_0, ushort P_1)
		{
			return new _23352941A2C442FB(P_0, P_1);
		}

		static Task<bool> B0C11BA67A5544C5(object P_0, object P_1, CancellationToken P_2)
		{
			return ((_02C54685DE0E4B81)P_0)._6E01EC7AE9294356((_652C34B1E6554F10)P_1, P_2);
		}

		static Task<string> _01701AC83A804EFB(string P_0, CancellationToken P_1)
		{
			return File.ReadAllTextAsync(P_0, P_1);
		}

		static string _18534523AF2F45F8(object P_0)
		{
			return ((string)P_0).Trim();
		}

		static byte[] AFE002B536684B61(string P_0)
		{
			return Convert.FromBase64String(P_0);
		}

		static object _3077A9009562463F(object P_0)
		{
			return ((_1DB744298E9F4B09)P_0)._83E23B43ACAC4FEA;
		}

		static void F1CA0916A3B94FD6(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}

		static int _5EE35F166AA84765(object P_0)
		{
			return ((SemaphoreSlim)P_0).Release();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _356AC1AB2B7D4344 : IAsyncStateMachine
	{
		public int FA9C8281082843FF;

		public AsyncTaskMethodBuilder<bool> C8B4C7AB4FEB4C47;

		public Guid C1C49604BE974C9C;

		private string _60EE526A63C74C81;

		private string _1617F32BA79B44CB;

		private string _8F26E4939C5742E3;

		private string _1AAFE1C9042947E3;

		private TaskAwaiter _2A7D0CC45D8A4819;

		private TaskAwaiter<string> _608E963776414D23;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			GC.KeepAlive(null);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			C8B4C7AB4FEB4C47.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object _251E909A6F02466E()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static string E7177445C00247DD(object P_0)
		{
			return ((_1DB744298E9F4B09)P_0).EBFF406DCE4B4FB2;
		}

		static string _5BF7E88B8D244588(string P_0, string P_1)
		{
			return Path.Combine(P_0, P_1);
		}

		static string C2F2EB2710DD4FFA(string P_0, string P_1, string P_2)
		{
			return Path.Combine(P_0, P_1, P_2);
		}

		static string _75A1BE8D09E0452F(byte[] P_0)
		{
			return Convert.ToBase64String(P_0);
		}

		static object D8E0D9DFE6F44804(object P_0, CancellationToken P_1)
		{
			return ((SemaphoreSlim)P_0).WaitAsync(P_1);
		}

		static TaskAwaiter _491C5DA9A4244B1E(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static object _5F54CFA822A449B2(string P_0)
		{
			return Directory.CreateDirectory(P_0);
		}

		static bool CD082EEB568A4E00(string P_0)
		{
			return File.Exists(P_0);
		}

		static Task<string> _5D16DDC5BD1D4712(string P_0, CancellationToken P_1)
		{
			return File.ReadAllTextAsync(P_0, P_1);
		}

		static bool F306AC516B814178(string P_0, string P_1)
		{
			return P_0 == P_1;
		}

		static string _320ED81552A54888(string P_0, object P_1, object P_2)
		{
			return string.Format(P_0, P_1, P_2);
		}

		static void _5A16C99D36424BD9(string P_0, string P_1, bool P_2)
		{
			File.Copy(P_0, P_1, P_2);
		}

		static object _9E7B97E01D6F44EB(object P_0)
		{
			return ((_1DB744298E9F4B09)P_0)._83E23B43ACAC4FEA;
		}

		static void _8CC9AC0FAD844E24(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}

		static object _2B6F32F437544561(string P_0, string P_1, CancellationToken P_2)
		{
			return File.WriteAllTextAsync(P_0, P_1, P_2);
		}

		static int A15C5A1623044B31(object P_0)
		{
			return ((SemaphoreSlim)P_0).Release();
		}
	}

	private static readonly CancellationToken _57AEC1BA18484D6B;

	private static readonly SemaphoreSlim _048909779F134E08;

	private static _02C54685DE0E4B81? D1D1A0003FA34607 => ((_1DB744298E9F4B09)_921DFC786DF5479E())._0D077240941749FA;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(D847CB6AB9214147))]
	public static Task<bool> _4D65BD4381F7417B()
	{
		uint num = 2u;
		while (true)
		{
			switch (num)
			{
			case 0u:
				num = 2u;
				break;
			case 2u:
				num = 0u;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_356AC1AB2B7D4344))]
	public static Task<bool> FF8CE9A823D04023(Guid P_0)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _8162F8F545F5474A()
	{
		_921DFC786DF5479E();
		_0B1BAE0D9C324FA5((object)null);
		_32D3D94265C645F8(0, 0);
	}

	static object _921DFC786DF5479E()
	{
		return _1DB744298E9F4B09._052FBC588F454484;
	}

	static CancellationToken _0B1BAE0D9C324FA5(object P_0)
	{
		return ((_1DB744298E9F4B09)P_0).A70B1408B5ED4F4E;
	}

	static object _32D3D94265C645F8(int P_0, int P_1)
	{
		return new SemaphoreSlim(P_0, P_1);
	}
}
