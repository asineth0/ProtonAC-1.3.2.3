using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using LiteDB;
using UnityEngine;

internal class _22986AEA233A48AF : _05B7A84E8227463B
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _9CCD8C09EF3A4367
	{
		public static readonly _9CCD8C09EF3A4367 _003C_003E9 = (_9CCD8C09EF3A4367)_374E5D3A3A7A4A27();

		public static Func<_63B6905AA0884E5F, string> _003C_003E9__7_1;

		public static Func<_63B6905AA0884E5F, ulong> _003C_003E9__8_1;

		public static Func<_63B6905AA0884E5F, string> _003C_003E9__9_1;

		internal string _72D0BBD869A24CD3(_63B6905AA0884E5F P_0)
		{
			return _7C41D3362FDF46D9((object)P_0);
		}

		internal ulong _04A9B95A06704FE8(_63B6905AA0884E5F P_0)
		{
			return _82714028EAE346BF((object)P_0);
		}

		internal string _2053ED9D05F448C2(_63B6905AA0884E5F P_0)
		{
			return _7C41D3362FDF46D9((object)P_0);
		}

		static object _374E5D3A3A7A4A27()
		{
			return new _9CCD8C09EF3A4367();
		}

		static string _7C41D3362FDF46D9(object P_0)
		{
			return ((_63B6905AA0884E5F)P_0).HardwareID;
		}

		static ulong _82714028EAE346BF(object P_0)
		{
			return ((_63B6905AA0884E5F)P_0).SteamId;
		}
	}

	[CompilerGenerated]
	private sealed class C967E3B39EF54D33
	{
		public ulong steamId;
	}

	[CompilerGenerated]
	private sealed class _2FDDAF3D544845E8
	{
		public ulong steamId;
	}

	[CompilerGenerated]
	private sealed class _94F0AB9A8D404878
	{
		public string hwid;
	}

	[CompilerGenerated]
	private sealed class CBB801873316404B
	{
		public ulong steamId;

		public int hardwareIndex;

		public long minTimestamp;
	}

	private readonly object _59DC33CECAED4861;

	private readonly LiteDatabase? _71D2A701276D4313;

	private const string A9AB1F9BBDB94A08 = "hardwareIDHistory";

	private const string DF9C0952129A454C = "verifiedPlayers";

	public _22986AEA233A48AF(string P_0, string? P_1 = null)
	{
		object obj = null;
		LiteDatabase val = null;
		_59DC33CECAED4861 = obj;
		_1DB744298E9F4B09._0B1227EB3A824F28((object?)val);
		_71D2A701276D4313 = val;
	}

	private void InitializeIndexes()
	{
		_200C0FCD340543F6._8A8A6A3C81F4471D((Object)null, (Object)null);
		_148FC9FDA20643FB._8AF6331E943144F4._54AEFB29825643AD((IEnumerable<float>)null);
		_ = new ParameterExpression[1];
		_200C0FCD340543F6._8A8A6A3C81F4471D((Object)null, (Object)null);
		_ = new ParameterExpression[1];
		_200C0FCD340543F6._8A8A6A3C81F4471D((Object)null, (Object)null);
		_ = new ParameterExpression[1];
		_1DB744298E9F4B09._4AA0B6CB62334AA1((object?)_71D2A701276D4313);
		_200C0FCD340543F6._8A8A6A3C81F4471D((Object)null, (Object)null);
		_148FC9FDA20643FB._8AF6331E943144F4._54AEFB29825643AD((IEnumerable<float>)null);
		_ = new ParameterExpression[1];
		_1DB744298E9F4B09._4AA0B6CB62334AA1((object?)_71D2A701276D4313);
		throw new Exception();
	}

	public void _3C4CF1C18A274530(ulong P_0, int P_1, string P_2, long P_3)
	{
		if (_71D2A701276D4313 == null)
		{
			return;
		}
		lock (_59DC33CECAED4861)
		{
			_71D2A701276D4313.GetCollection<_63B6905AA0884E5F>("hardwareIDHistory", (BsonAutoId)10).Insert(new _63B6905AA0884E5F
			{
				SteamId = P_0,
				Timestamp = P_3,
				HardwareIndex = P_1,
				HardwareID = P_2
			});
		}
	}

	void _05B7A84E8227463B._1F53E315509B4C4A(ulong P_0, int P_1, string P_2, long P_3)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 3C4CF1C18A274530
		this._3C4CF1C18A274530(P_0, P_1, P_2, P_3);
	}

	public IEnumerable<string> GetHwids(ulong steamId)
	{
		if (_71D2A701276D4313 == null)
		{
			return Array.Empty<string>();
		}
		lock (_59DC33CECAED4861)
		{
			return (from P_0 in _71D2A701276D4313.GetCollection<_63B6905AA0884E5F>("hardwareIDHistory", (BsonAutoId)10).Find((Expression<Func<_63B6905AA0884E5F, bool>>)((_63B6905AA0884E5F x) => x.SteamId == steamId), 0, int.MaxValue)
				select _9CCD8C09EF3A4367._7C41D3362FDF46D9((object)P_0)).ToList();
		}
	}

	IEnumerable<string> _05B7A84E8227463B._0CE0C14392C04759(ulong steamId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetHwids
		return this.GetHwids(steamId);
	}

	public IEnumerable<ulong> GetDuplicateIDS(string hwid)
	{
		if (_71D2A701276D4313 == null)
		{
			return Array.Empty<ulong>();
		}
		lock (_59DC33CECAED4861)
		{
			return (from P_0 in _71D2A701276D4313.GetCollection<_63B6905AA0884E5F>("hardwareIDHistory", (BsonAutoId)10).Find((Expression<Func<_63B6905AA0884E5F, bool>>)((_63B6905AA0884E5F x) => x.HardwareID == hwid), 0, int.MaxValue)
				select _9CCD8C09EF3A4367._82714028EAE346BF((object)P_0)).Distinct().ToList();
		}
	}

	IEnumerable<ulong> _05B7A84E8227463B._62CB1B0C4D6B4440(string hwid)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetDuplicateIDS
		return this.GetDuplicateIDS(hwid);
	}

	public IEnumerable<string> GetUniqueHwids(ulong steamId, int hardwareIndex, long timestamp, long time)
	{
		if (_71D2A701276D4313 == null)
		{
			return Array.Empty<string>();
		}
		long minTimestamp = timestamp - time;
		lock (_59DC33CECAED4861)
		{
			return (from P_0 in _71D2A701276D4313.GetCollection<_63B6905AA0884E5F>("hardwareIDHistory", (BsonAutoId)10).Find((Expression<Func<_63B6905AA0884E5F, bool>>)((_63B6905AA0884E5F x) => x.SteamId == steamId && x.HardwareIndex == hardwareIndex && x.Timestamp >= minTimestamp), 0, int.MaxValue)
				select _9CCD8C09EF3A4367._7C41D3362FDF46D9((object)P_0)).Distinct().ToList();
		}
	}

	IEnumerable<string> _05B7A84E8227463B._725A098C42D04D27(ulong steamId, int hardwareIndex, long timestamp, long time)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetUniqueHwids
		return this.GetUniqueHwids(steamId, hardwareIndex, timestamp, time);
	}

	public void _655C809975114B35(ulong P_0)
	{
		if (_71D2A701276D4313 == null)
		{
			return;
		}
		lock (_59DC33CECAED4861)
		{
			ILiteCollection<F6F3837E2EA24490> collection = _71D2A701276D4313.GetCollection<F6F3837E2EA24490>("verifiedPlayers", (BsonAutoId)10);
			F6F3837E2EA24490 f6F3837E2EA = new F6F3837E2EA24490
			{
				SteamId = P_0
			};
			collection.Upsert(f6F3837E2EA);
		}
	}

	void _05B7A84E8227463B.F66ACEBD262741E3(ulong P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 655C809975114B35
		this._655C809975114B35(P_0);
	}

	public bool IsVerifiedPlayer(ulong steamId)
	{
		if (_71D2A701276D4313 == null)
		{
			return false;
		}
		lock (_59DC33CECAED4861)
		{
			return _71D2A701276D4313.GetCollection<F6F3837E2EA24490>("verifiedPlayers", (BsonAutoId)10).Exists((Expression<Func<F6F3837E2EA24490, bool>>)((F6F3837E2EA24490 x) => x.SteamId == steamId));
		}
	}

	bool _05B7A84E8227463B.EC834E7B0DC044F4(ulong steamId)
	{
		//ILSpy generated this explicit interface implementation from .override directive in IsVerifiedPlayer
		return this.IsVerifiedPlayer(steamId);
	}

	public void _4D8724EE8F794FF2()
	{
		LiteDatabase? val = _71D2A701276D4313;
		if (val != null)
		{
			val.Dispose();
		}
	}

	void _05B7A84E8227463B.E3A8BD6E89444F56()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 4D8724EE8F794FF2
		this._4D8724EE8F794FF2();
	}
}
