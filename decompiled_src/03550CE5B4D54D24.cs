using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

public class _03550CE5B4D54D24 : C179263454B44BF6
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _296BF0DC0B134F89 : IAsyncStateMachine
	{
		public int _703179B664AE41B1;

		public AsyncTaskMethodBuilder<bool> _29F1E881B3844242;

		public _03550CE5B4D54D24 AE472DE5319C475E;

		public Stream _270D58EC47A54DB8;

		public Guid _8E0D12F8FA784753;

		public int C7AE841E95354A19;

		public object DC8FC97B96AE4253;

		public ulong _09588E70514D4374;

		private TaskAwaiter<bool> _02F2C0E311B5433F;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = _703179B664AE41B1;
			_03550CE5B4D54D24 obj = AE472DE5319C475E;
			bool result;
			try
			{
				if ((uint)num > (uint)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884))
				{
					while (true)
					{
						int num2 = 1864484556;
						while (true)
						{
							int num3 = num2;
							uint num4;
							switch ((num4 = (uint)(-(((-(-num3 - --832637774) * -418021407) ^ -1280810542) - -(-1428954938 ^ -2076399619) - (-1440135890 + -390964942)))) % 4)
							{
							case 0u:
								break;
							case 1u:
							{
								int num5;
								int num6;
								if (obj._5D0FD0E81BC54045 == null)
								{
									num5 = -431493280;
									num6 = num5;
								}
								else
								{
									num5 = 1467200885;
									num6 = num5;
								}
								num2 = num5 ^ ((int)num4 * -2122547894);
								continue;
							}
							case 3u:
								result = (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
								goto end_IL_000e;
							default:
								goto end_IL_0020;
							}
							break;
						}
						continue;
						end_IL_0020:
						break;
					}
				}
				try
				{
					if (num != 0)
					{
						goto IL_00bf;
					}
					goto IL_014d;
					IL_00bf:
					int num7 = 718310107;
					goto IL_00c4;
					IL_00c4:
					TaskAwaiter<bool> awaiter = default;
					bool flag = default;
					while (true)
					{
						int num3 = num7;
						uint num4;
						switch ((num4 = (uint)(-(((-(-num3 - --832637774) * -418021407) ^ -1280810542) - -(-1428954938 ^ -2076399619) - (-1440135890 + -390964942)))) % 16)
						{
						case 0u:
							break;
						case 3u:
							goto IL_014d;
						case 13u:
							_02F2C0E311B5433F = default;
							num = (_703179B664AE41B1 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num7 = 1223746090;
							continue;
						case 5u:
							_02F2C0E311B5433F = awaiter;
							num7 = ((int)num4 * -1214583613) ^ -1859532820;
							continue;
						case 12u:
							flag = awaiter.GetResult();
							num7 = 843421800;
							continue;
						case 8u:
							flag = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
							num7 = 964732982;
							continue;
						case 6u:
							return;
						case 15u:
						{
							int num8;
							int num9;
							if (_270D58EC47A54DB8 != null)
							{
								num8 = -1969639390;
								num9 = num8;
							}
							else
							{
								num8 = -1780789036;
								num9 = num8;
							}
							num7 = num8 ^ (int)(num4 * 1292316804);
							continue;
						}
						case 9u:
							num = (_703179B664AE41B1 = _003CModule_003E._3F57E81A62734AC2<int>(1017304263));
							num7 = 16215684;
							continue;
						case 7u:
							goto IL_0248;
						case 4u:
							awaiter = _02F2C0E311B5433F;
							num7 = 1375002844;
							continue;
						case 10u:
							goto IL_02b7;
						case 2u:
							_29F1E881B3844242.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 14u:
							num = (_703179B664AE41B1 = _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563));
							_02F2C0E311B5433F = awaiter;
							_29F1E881B3844242.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num7 = 1987194959;
							continue;
						case 1u:
							goto IL_0334;
						default:
							result = awaiter.GetResult();
							goto end_IL_00b9;
						}
						break;
						IL_0334:
						awaiter = B3ECAC8F49C44074((object)obj._5D0FD0E81BC54045, _4B4E2EA6FFDB4984(C7AE841E95354A19, _32D2426FAE4F4C89(DC8FC97B96AE4253), _8E0D12F8FA784753, flag, _09588E70514D4374), obj._845C251299804986).GetAwaiter();
						int num10;
						if (awaiter.IsCompleted)
						{
							num7 = 1223746090;
							num10 = num7;
						}
						else
						{
							num7 = 1197557312;
							num10 = num7;
						}
						continue;
						IL_02b7:
						int num11;
						if (num == _003CModule_003E.F84FA79ABE6944BB<int>(1741630884))
						{
							num7 = 525910021;
							num11 = num7;
						}
						else
						{
							num7 = 994978177;
							num11 = num7;
						}
						continue;
						IL_0248:
						awaiter = A78BA586B9014AB8((object)obj._5D0FD0E81BC54045, (object)_270D58EC47A54DB8, (B79532442FF34B1B)_003CModule_003E._58ECCB512F2A43AC<int>(-1977557483), C059B027F5254098((object)_270D58EC47A54DB8), _8E0D12F8FA784753.ToString()).GetAwaiter();
						int num12;
						if (!awaiter.IsCompleted)
						{
							num7 = 748581079;
							num12 = num7;
						}
						else
						{
							num7 = -1216095507;
							num12 = num7;
						}
					}
					goto IL_00bf;
					IL_014d:
					awaiter = _02F2C0E311B5433F;
					_02F2C0E311B5433F = default;
					num = (_703179B664AE41B1 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
					num7 = -1216095507;
					goto IL_00c4;
					end_IL_00b9:;
				}
				catch (Exception ex)
				{
					ILogger val = C179263454B44BF6._54DF173DA5E74DC3;
					string text = _003CModule_003E._58ECCB512F2A43AC<string>(647787870);
					object[] array = new object[_003CModule_003E._390073C602714496<int>(-250964212)];
					array[_003CModule_003E._3F57E81A62734AC2<int>(-1803194042)] = C7AE841E95354A19;
					_5A5F99B3A16A4CF1(val, ex, text, array);
					result = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_703179B664AE41B1 = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
				_29F1E881B3844242.SetException(exception);
				return;
			}
			_703179B664AE41B1 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
			_29F1E881B3844242.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_29F1E881B3844242.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static long C059B027F5254098(object P_0)
		{
			return ((Stream)P_0).Length;
		}

		static Task<bool> A78BA586B9014AB8(object P_0, object P_1, B79532442FF34B1B P_2, long P_3, string P_4)
		{
			return ((_02C54685DE0E4B81)P_0)._3787CDA13EC74733((Stream)P_1, P_2, P_3, P_4);
		}

		static string _32D2426FAE4F4C89(object P_0)
		{
			return JsonConvert.SerializeObject(P_0);
		}

		static object _4B4E2EA6FFDB4984(int P_0, string P_1, Guid P_2, bool P_3, ulong P_4)
		{
			return new _74813FBB45A64ADC(P_0, P_1, P_2, P_3, P_4);
		}

		static Task<bool> B3ECAC8F49C44074(object P_0, object P_1, CancellationToken P_2)
		{
			return ((_02C54685DE0E4B81)P_0)._6E01EC7AE9294356((_652C34B1E6554F10)P_1, P_2);
		}

		static void _5A5F99B3A16A4CF1(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}
	}

	private readonly CancellationToken _845C251299804986;

	private _02C54685DE0E4B81? _5D0FD0E81BC54045 => ((_1DB744298E9F4B09)_6D3D1833382F43E9())._0D077240941749FA;

	public Task<bool> C269E25CA8FC4AF2(int P_0, object P_1, ulong P_2, Guid P_3, byte[]? P_4 = null)
	{
		return _82C60D50A24F4361((object)this, P_0, P_1, P_2, P_3, (P_4 != null) ? DAE929692CB645A8(P_4) : null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_296BF0DC0B134F89))]
	public Task<bool> DB064864A7A9401A(int P_0, object P_1, ulong P_2, Guid P_3, Stream? P_4 = null)
	{
		_296BF0DC0B134F89 stateMachine = default;
		stateMachine._29F1E881B3844242 = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine.AE472DE5319C475E = this;
		while (true)
		{
			int num = 1160162235;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~((num2 ^ -(-(-(-1507629449 * --807563879) + -1410446218) + (unchecked(~569817883 - (-924221118 ^ -1546083021)) + -(438526941 + 1419672985) - -(~(-235567868 ^ -1743064110)) - (-(-1640017647 ^ 0x7383FB1D) + (-unchecked(9463663 * 1144620140) + ~unchecked(992916035 * -1388471817))))) ^ -797722834 ^ 0x5384032C ^ 0xF6E9036 ^ 0x6A271EBE) - (-1108984438 ^ -1666685395)) ^ 0x68E3632B)) % 6)
				{
				case 0u:
					break;
				case 3u:
					stateMachine.C7AE841E95354A19 = P_0;
					num = ((int)num3 * -304425291) ^ 0x8E361C4;
					continue;
				case 5u:
					stateMachine.DC8FC97B96AE4253 = P_1;
					num = (int)((num3 * 396755486) ^ 0x59BB87CB);
					continue;
				case 1u:
					stateMachine._09588E70514D4374 = P_2;
					num = ((int)num3 * -1797661450) ^ 0x2CA5F69C;
					continue;
				case 4u:
					stateMachine._8E0D12F8FA784753 = P_3;
					stateMachine._270D58EC47A54DB8 = P_4;
					stateMachine._703179B664AE41B1 = _003CModule_003E._390073C602714496<int>(-736908096);
					stateMachine._29F1E881B3844242.Start(ref stateMachine);
					num = -1893220924;
					continue;
				default:
					return stateMachine._29F1E881B3844242.Task;
				}
				break;
			}
		}
	}

	public _03550CE5B4D54D24()
	{
		_6D3D1833382F43E9();
		BEA87FDFA6284013((object)null);
		_845C251299804986 = BEA87FDFA6284013((object)null);
		throw new Exception();
	}

	static object _6D3D1833382F43E9()
	{
		return _1DB744298E9F4B09._052FBC588F454484;
	}

	static object DAE929692CB645A8(byte[] P_0)
	{
		return new MemoryStream(P_0);
	}

	static Task<bool> _82C60D50A24F4361(object P_0, int P_1, object P_2, ulong P_3, Guid P_4, object P_5)
	{
		return ((_03550CE5B4D54D24)P_0).DB064864A7A9401A(P_1, P_2, P_3, P_4, (Stream?)P_5);
	}

	static CancellationToken BEA87FDFA6284013(object P_0)
	{
		return ((_1DB744298E9F4B09)P_0).A70B1408B5ED4F4E;
	}
}
