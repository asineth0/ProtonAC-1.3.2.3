using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

internal sealed class _ni
{
	[CompilerGenerated]
	private ConcurrentDictionary<Guid, string> _Xi;

	[CompilerGenerated]
	private ConcurrentDictionary<string, _5M> _GB;

	[CompilerGenerated]
	private ConcurrentDictionary<string, TaskCompletionSource<bool>> _ol;

	internal DateTime _TL;

	[CompilerGenerated]
	private bool _sJ;

	[CompilerGenerated]
	private TaskCompletionSource<bool> _tg;

	internal ConcurrentDictionary<Guid, string> _2
	{
		[CompilerGenerated]
		get
		{
			return _Xi;
		}
		[CompilerGenerated]
		set
		{
			_Xi = xi;
		}
	}

	internal ConcurrentDictionary<string, _5M> _TJ
	{
		[CompilerGenerated]
		get
		{
			return _GB;
		}
		[CompilerGenerated]
		set
		{
			_GB = gB;
		}
	}

	internal ConcurrentDictionary<string, TaskCompletionSource<bool>> _JB
	{
		[CompilerGenerated]
		get
		{
			return _ol;
		}
		[CompilerGenerated]
		set
		{
			_ol = ol;
		}
	}

	internal bool _Zj
	{
		[CompilerGenerated]
		get
		{
			return _sJ;
		}
		[CompilerGenerated]
		set
		{
			_sJ = sJ;
		}
	}

	internal TaskCompletionSource<bool> _qd
	{
		[CompilerGenerated]
		get
		{
			return _tg;
		}
		[CompilerGenerated]
		set
		{
			_tg = tg;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _ni()
	{
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1605749840u);
		while (true)
		{
			int num = 1629483666;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(-(~((0xAEC77C3 ^ -1543743856) + (~(-1181488445 - 1608914162 - (472494725 - 1278980518)) - (0x4952144A ^ -868809149))) - 1622461903 * -610330425 - num - (~(430814944 - (--1195738843 - 273227272 * -571530295)) + (-50325217 - (0x11F52072 ^ --1036925080) + ~(-1320522115 - 1958588218 + (-96383133 ^ 0x60F294BF))) + -1186455703 * (-(0x57E4089B ^ -226841085) ^ 0x60AEA158))))) % 8)
				{
				case 7u:
					break;
				default:
					return;
				case 4u:
					_tg = new TaskCompletionSource<bool>((TaskCreationOptions)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x6757DFDF ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3750318570u))));
					num = (int)(num2 * 900629268) ^ -1864667277;
					continue;
				case 1u:
					_GB = (ConcurrentDictionary<string, _5M>)Activator.CreateInstance(typeof(ConcurrentDictionary<string, _5M>));
					num = ((int)num2 * -706702564) ^ -521913222;
					continue;
				case 2u:
					_Xi = (ConcurrentDictionary<Guid, string>)Activator.CreateInstance(typeof(ConcurrentDictionary<Guid, string>));
					num = ((int)num2 * -2060376209) ^ 0x6AF5512F;
					continue;
				case 6u:
					_ol = (ConcurrentDictionary<string, TaskCompletionSource<bool>>)Activator.CreateInstance(typeof(ConcurrentDictionary<string, TaskCompletionSource<bool>>));
					num = ((int)num2 * -122150705) ^ -1608537737;
					continue;
				case 5u:
					_TL = DateTime.UtcNow;
					num = (int)(num2 * 731301976) ^ -737196140;
					continue;
				case 3u:
					base._002Ector();
					num = ((int)num2 * -1278969257) ^ -1762764667;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}
}
