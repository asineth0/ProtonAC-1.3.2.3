using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

internal class _6487285FB41C4853
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _36CB4EE3CC6C48CE : IAsyncStateMachine
	{
		public int C7984810A4844DB9;

		public AsyncTaskMethodBuilder<bool> _7F6EE0AEB6134E2A;

		private HttpResponseMessage E194280DBF904BD2;

		private Stream CBEC1431F03F4D6D;

		private StreamReader _16997A03970F4E8B;

		private TaskAwaiter<HttpResponseMessage> _85DA7C8255494A0A;

		private TaskAwaiter<Stream> _45AF8AE6C188489F;

		private object _1BF957A5B3234DE2;

		private int _92AAB1FCF89D4C53;

		private bool D6478D73802B4095;

		private TaskAwaiter<string> _166839259CFE4071;

		private ValueTaskAwaiter _0C2DE04693284036;

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
			_7F6EE0AEB6134E2A.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static Task<HttpResponseMessage> _9633D28B72894C2B(object P_0, string P_1, HttpCompletionOption P_2)
		{
			return ((HttpClient)P_0).GetAsync(P_1, P_2);
		}

		static bool E094DF89E3784142(object P_0)
		{
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		static object _7BA68AD7CA2B4442(object P_0)
		{
			return ((HttpResponseMessage)P_0).Content;
		}

		static Task<Stream> DB4CC53065034A21(object P_0)
		{
			return ((HttpContent)P_0).ReadAsStreamAsync();
		}

		static object _53A99E5A747C441C(object P_0)
		{
			return new StreamReader((Stream)P_0);
		}

		static Task<string> _0760F0FDF58041DE(object P_0)
		{
			return ((TextReader)P_0).ReadLineAsync();
		}

		static string _3CCB9BB131684549(object P_0)
		{
			return ((string)P_0).Trim();
		}

		static bool B40A1107EC514DD7(string P_0, string P_1, StringComparison P_2)
		{
			return string.Equals(P_0, P_1, P_2);
		}

		static void C01D94B9EF1A4342(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		static ValueTask CF3C3CB83FC14A57(object P_0)
		{
			return ((Stream)P_0).DisposeAsync();
		}

		static object _05D5931AFF964D72(Exception P_0)
		{
			return ExceptionDispatchInfo.Capture(P_0);
		}

		static void _3B19AC9E12E447E6(object P_0)
		{
			((ExceptionDispatchInfo)P_0).Throw();
		}
	}

	private static readonly HttpClient F4F3315D845B450D = (HttpClient)_983FEE72DF904BAE();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_36CB4EE3CC6C48CE))]
	public static Task<bool> _46F5E45364394CBB()
	{
		return null;
	}

	static object _983FEE72DF904BAE()
	{
		return new HttpClient();
	}
}
