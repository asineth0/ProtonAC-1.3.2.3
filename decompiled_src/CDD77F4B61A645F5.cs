using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

internal sealed class CDD77F4B61A645F5
{
	[CompilerGenerated]
	private sealed class _3BA94C0092FF4C7A<_0001> where _0001 : notnull, _652C34B1E6554F10
	{
		public global::_94E3D906D3E34B5F<_0001> _7D7A084C885E4C5A;

		internal Task _6B6448D76B4D4F64(_02C54685DE0E4B81 P_0, _652C34B1E6554F10 P_1, CancellationToken P_2)
		{
			return _7D7A084C885E4C5A._61C062AE41194B7D(P_0, (_0001)P_1, P_2);
		}
	}

	[CompilerGenerated]
	private sealed class _74B9570B4A074DA6<_0001> where _0001 : notnull, _652C34B1E6554F10
	{
		public Func<_02C54685DE0E4B81, _0001, CancellationToken, Task> D08ED89016354111;

		internal Task E0F2F57BB5984808(_02C54685DE0E4B81 P_0, _652C34B1E6554F10 P_1, CancellationToken P_2)
		{
			return D08ED89016354111(P_0, (_0001)P_1, P_2);
		}
	}

	private readonly ConcurrentDictionary<Type, Func<_02C54685DE0E4B81, _652C34B1E6554F10, CancellationToken, Task>> _8B04CA50BCDB4228;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CF59166FC77F4F69<_0001>(global::_94E3D906D3E34B5F<_0001> P_0) where _0001 : _652C34B1E6554F10
	{
		global::_94E3D906D3E34B5F<_0001> obj = default;
		while (true)
		{
			int num = 515074860;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~((num2 ^ (1862078377 * (1835099375 - ~(-((-829202375 ^ -2140206910) - 65856999))) * -379804997)) * 1438930505 * 341343955 * 1957648883 - unchecked(1847311477 * (882840590 - 1220353006))) ^ 0x38D50E9B))) % 6)
				{
				case 5u:
					break;
				default:
					return;
				case 4u:
					obj = P_0;
					num = ((int)num3 * -59733750) ^ 0x146B56BF;
					continue;
				case 2u:
					throw _3219F8BD54214BBF(_003CModule_003E._3F57E81A62734AC2<string>(-503620398));
				case 3u:
					_8B04CA50BCDB4228[(Type)CEB16D650A6D4233(typeof(_0001).TypeHandle)] = (_02C54685DE0E4B81 obj2, _652C34B1E6554F10 obj3, CancellationToken cancellationToken) => obj._61C062AE41194B7D(obj2, (_0001)obj3, cancellationToken);
					num = 572806640;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (obj == null)
					{
						num4 = -826513545;
						num5 = num4;
					}
					else
					{
						num4 = 561657250;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1243316299);
					continue;
				}
				case 0u:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void F02833DF63EE4D55<_0001>(Func<_02C54685DE0E4B81, _0001, CancellationToken, Task> P_0) where _0001 : _652C34B1E6554F10
	{
		if (P_0 == null)
		{
			while (true)
			{
				int num = -2096485959;
				uint num2;
				switch ((num2 = (uint)(~(-(-(-(-num)))))) % 3)
				{
				case 0u:
					continue;
				case 2u:
					throw _3219F8BD54214BBF(_003CModule_003E._390073C602714496<string>(-396812262));
				}
				break;
			}
		}
		_8B04CA50BCDB4228[(Type)CEB16D650A6D4233(typeof(_0001).TypeHandle)] = (_02C54685DE0E4B81 arg, _652C34B1E6554F10 obj, CancellationToken arg2) => P_0(arg, (_0001)obj, arg2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task _1144E21C9FA84988(_02C54685DE0E4B81 P_0, _652C34B1E6554F10 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		FF65E1E221E948A3((object)P_1);
		FA1A8878DB7E4FFE((object)0);
		_3219F8BD54214BBF((string)null);
		CEB16D650A6D4233(default(RuntimeTypeHandle));
		_3219F8BD54214BBF((string)null);
		_96D1E507C55A436C();
		FA1A8878DB7E4FFE((object)null);
		return null;
	}

	public CDD77F4B61A645F5()
	{
		ConcurrentDictionary<Type, Func<_02C54685DE0E4B81, _652C34B1E6554F10, CancellationToken, Task>> concurrentDictionary = null;
		_8B04CA50BCDB4228 = concurrentDictionary;
	}

	static object _3219F8BD54214BBF(string P_0)
	{
		return new ArgumentNullException(P_0);
	}

	static object CEB16D650A6D4233(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static object FF65E1E221E948A3(object P_0)
	{
		return P_0.GetType();
	}

	static object FA1A8878DB7E4FFE(object P_0)
	{
		return ((Type)P_0).BaseType;
	}

	static bool FB3CC6B25CE742B5(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	static object _96D1E507C55A436C()
	{
		return Task.CompletedTask;
	}
}
