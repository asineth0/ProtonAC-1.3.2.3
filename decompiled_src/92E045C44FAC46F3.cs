using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

internal class _92E045C44FAC46F3
{
	[CompilerGenerated]
	private readonly MemoryStream _910E038396D444DB;

	[CompilerGenerated]
	private readonly SemaphoreSlim _3F7A15B7D25B4CBC;

	[CompilerGenerated]
	private readonly SortedDictionary<long, byte[]> _80A886D7B6BF406D;

	[CompilerGenerated]
	private long F8B3198A71E14173;

	[CompilerGenerated]
	private long? CCF445FA93AB4F97;

	[CompilerGenerated]
	private readonly TaskCompletionSource<bool> _89F1745EC0FE40C1;

	public MemoryStream _626F75DE2391436C
	{
		[CompilerGenerated]
		get
		{
			return _910E038396D444DB;
		}
	}

	public SemaphoreSlim _309BAE722CA94271
	{
		[CompilerGenerated]
		get
		{
			return _3F7A15B7D25B4CBC;
		}
	}

	public SortedDictionary<long, byte[]> _61E39332C26842D0
	{
		[CompilerGenerated]
		get
		{
			return _80A886D7B6BF406D;
		}
	}

	public long _292FBC325CEE4318
	{
		[CompilerGenerated]
		get
		{
			return F8B3198A71E14173;
		}
		[CompilerGenerated]
		set
		{
			F8B3198A71E14173 = f8B3198A71E;
		}
	}

	public long? _1A55046179A347E1
	{
		[CompilerGenerated]
		get
		{
			return CCF445FA93AB4F97;
		}
		[CompilerGenerated]
		set
		{
			CCF445FA93AB4F97 = cCF445FA93AB4F;
		}
	}

	public TaskCompletionSource<bool> _7A4FE2B7C2A945FA
	{
		[CompilerGenerated]
		get
		{
			return _89F1745EC0FE40C1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _92E045C44FAC46F3()
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1222889473u);
		while (true)
		{
			int num = 864849932;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)(-(~(-(~(-num)) - -(~(--1327691105)) * -2001559369)) + -549159156 - 1358475949)) % 6)
				{
				case 0u:
					break;
				case 5u:
					_910E038396D444DB = (MemoryStream)_14497C984C494966();
					num = ((int)num2 * -1493843695) ^ 0x35F7BC5B;
					continue;
				case 4u:
					_80A886D7B6BF406D = new SortedDictionary<long, byte[]>();
					num = (int)(num2 * 397887071) ^ -1639113057;
					continue;
				case 2u:
					_89F1745EC0FE40C1 = new TaskCompletionSource<bool>((TaskCreationOptions)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x1B281A41 ^ obj._184044A093C04AF2(6, 2955892382u))));
					num = (int)((num2 * 1311580144) ^ 0x65C7B3CE);
					continue;
				case 1u:
					_3F7A15B7D25B4CBC = (SemaphoreSlim)_5F7C8B3B1C4046C9(_003CModule_003E._8B9C7B12B1AE4949<int>(-1249706763 ^ (int)obj._184044A093C04AF2(9, 86245854u)), _003CModule_003E.F84FA79ABE6944BB<int>((int)(0x1BC1DE85 ^ obj._184044A093C04AF2(2, 1233797177u))));
					num = (int)((num2 * 2137153898) ^ 0x1F5E7FD1);
					continue;
				default:
					base._002Ector();
					return;
				}
				break;
			}
		}
	}

	static object _14497C984C494966()
	{
		return new MemoryStream();
	}

	static object _5F7C8B3B1C4046C9(int P_0, int P_1)
	{
		return new SemaphoreSlim(P_0, P_1);
	}
}
