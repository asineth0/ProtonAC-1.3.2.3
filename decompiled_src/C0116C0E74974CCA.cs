using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

internal static class C0116C0E74974CCA
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct B3B2A314445E4979 : IAsyncStateMachine
	{
		public int C6C882B472974A95;

		public AsyncTaskMethodBuilder<string> _550D16D11F8C4532;

		public string _2D82E063D21A48DE;

		public CancellationToken BDCEC5E5B07C4189;

		private SHA256 _9119499AB1BD425E;

		private byte[] _0473D44229224A40;

		private FileStream E453177D37F340F8;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter F0196C6280B54883;

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
			_550D16D11F8C4532.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object A659AB738A3443B6(string P_0)
		{
			return new ArgumentNullException(P_0);
		}

		static object AAA995D57A5B4D41()
		{
			return SHA256.Create();
		}

		static object FE96CCF7C21947FB(string P_0, FileMode P_1, FileAccess P_2, FileShare P_3, int P_4, bool P_5)
		{
			return null;
		}

		static int DFCBB7B34D9D4D9F(object P_0, byte[] P_1, int P_2, int P_3, byte[] P_4, int P_5)
		{
			return ((HashAlgorithm)P_0).TransformBlock(P_1, P_2, P_3, P_4, P_5);
		}

		static Task<int> E6A166C0397C45E0(object P_0, byte[] P_1, int P_2, int P_3, CancellationToken P_4)
		{
			return ((Stream)P_0).ReadAsync(P_1, P_2, P_3, P_4);
		}

		static byte[] _85FB7730B8BA4991(object P_0, byte[] P_1, int P_2, int P_3)
		{
			return ((HashAlgorithm)P_0).TransformFinalBlock(P_1, P_2, P_3);
		}

		static byte[] _950A0AE4BDDD4846(object P_0)
		{
			return ((HashAlgorithm)P_0).Hash;
		}

		static string _38ADEA32E3F94967(byte[] P_0)
		{
			return BitConverter.ToString(P_0);
		}

		static string _0DA3F7C438A049F7(object P_0, string P_1, string P_2)
		{
			return ((string)P_0).Replace(P_1, P_2);
		}

		static string F6E6345867324268(object P_0)
		{
			return ((string)P_0).ToLowerInvariant();
		}

		static void _408C166DE26D4DC2(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(B3B2A314445E4979))]
	public static Task<string> _580648BE2D68495A(string P_0, CancellationToken P_1 = default(CancellationToken))
	{
		uint num = 3u;
		while (true)
		{
			switch (num)
			{
			case 0u:
				num = 1u;
				break;
			case 1u:
				return null;
			case 3u:
				num = 0u;
				break;
			}
		}
	}
}
