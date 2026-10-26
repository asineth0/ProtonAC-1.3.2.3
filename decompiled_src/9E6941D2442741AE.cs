using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

public static class _9E6941D2442741AE
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IConfiguration DF274E6B0CD241BF(string P_0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		F40A54269E334090((string)null, (string)null);
		DF34DCCA33974DEC();
		_08B5C347E79C43A2(P_0);
		_75FF290933E74119((object)null);
		DCA4C86F47EC4593((object)null);
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void _41B34BCEE1A447D2(JsonElement P_0, string P_1, Dictionary<string, string?> P_2)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		ABCEA9B803CE46BB((string)null, (object)P_1, (object)num);
		E651E17AA2CA4BC8._7497D9F457FE469E._78D12C3B593C4A4D((object)P_0);
		E651E17AA2CA4BC8._1BA897AD7E174710();
		E651E17AA2CA4BC8._7497D9F457FE469E._7850E93C6DB34E61((object)P_0);
		E651E17AA2CA4BC8._7497D9F457FE469E.C0F33B48397C4DE5._19230E9F6DD14B37((object)null, (string)null, StringComparison.CurrentCulture);
		E651E17AA2CA4BC8._2031CC5701C34566._0549D438EB594BDD((object)null);
		B1C6751B9C684626(P_1);
		E651E17AA2CA4BC8._7497D9F457FE469E._93BB358F82C243E8((object)P_0);
		_41B34BCEE1A447D2(default, ABCEA9B803CE46BB((string)null, (object)P_1, (object)num), P_2);
		E651E17AA2CA4BC8._7497D9F457FE469E.C0F33B48397C4DE5.E8A421893BEC4147((object)null);
	}

	static bool _08B5C347E79C43A2(string P_0)
	{
		return string.IsNullOrWhiteSpace(P_0);
	}

	static object F40A54269E334090(string P_0, string P_1)
	{
		return new ArgumentException(P_0, P_1);
	}

	static object ECCB2EFCC2C94155(string P_0, JsonDocumentOptions P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return JsonDocument.Parse(P_0, P_1);
	}

	static JsonElement _75FF290933E74119(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((JsonDocument)P_0).RootElement;
	}

	static object DF34DCCA33974DEC()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		return (object)new ConfigurationBuilder();
	}

	static object DBF2C600A1CF4FBD(IConfigurationBuilder P_0, IEnumerable<KeyValuePair<string, string>> P_1)
	{
		return MemoryConfigurationBuilderExtensions.AddInMemoryCollection(P_0, P_1);
	}

	static object _667C00DEDEC74084(object P_0)
	{
		return ((IConfigurationBuilder)P_0).Build();
	}

	static void DCA4C86F47EC4593(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	static bool B1C6751B9C684626(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static string _5A756FB500F149A1(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static string ABCEA9B803CE46BB(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}
}
