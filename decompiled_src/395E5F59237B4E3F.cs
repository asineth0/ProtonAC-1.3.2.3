using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using YamlDotNet.Helpers;
using YamlDotNet.RepresentationModel;

internal static class _395E5F59237B4E3F
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string? _4C3E983BB0114883()
	{
		F970B6ED9C744353();
		D513B85D8A594E3D((string?)null, (string?)null, (string?)null);
		_10B830F8CB504183(D513B85D8A594E3D((string?)null, (string?)null, (string?)null));
		D157BF3665364974();
		_3CD9AA53F5684245((object?)null);
		_3CD9AA53F5684245((object?)null);
		_847813CCD5A4489F((object?)0);
		A1631CDB06DD4A89((object?)0);
		CED97961F77D4E0B((string?)null);
		_00529551FC9B463C(D513B85D8A594E3D((string?)null, (string?)null, (string?)null));
		_43ACAEBC0BA64074((object?)null, (object?)null);
		_114DCE48BD924962((object?)null);
		E9A75BCCD8DE41A4((object?)null);
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string? _6712D9D04AD2481C()
	{
		F970B6ED9C744353();
		D513B85D8A594E3D((string?)null, (string?)null, (string?)null);
		_10B830F8CB504183(D513B85D8A594E3D((string?)null, (string?)null, (string?)null));
		D157BF3665364974();
		_3CD9AA53F5684245((object?)null);
		DB37E83FE96643F8(null, null);
		_847813CCD5A4489F((object?)0);
		_3CD9AA53F5684245((object?)null);
		_00529551FC9B463C(D513B85D8A594E3D((string?)null, (string?)null, (string?)null));
		_43ACAEBC0BA64074((object?)null, (object?)null);
		A1631CDB06DD4A89((object?)DB37E83FE96643F8(null, null));
		CED97961F77D4E0B((string?)null);
		_114DCE48BD924962((object?)null);
		E9A75BCCD8DE41A4((object?)null);
		return null;
	}

	private static YamlMappingNode? DB37E83FE96643F8(YamlMappingNode P_0, string P_1)
	{
		A1631CDB06DD4A89((object?)P_0);
		CED97961F77D4E0B(P_1);
		return null;
	}

	static string? F970B6ED9C744353()
	{
		return _52E00C0CB6ED438D._561BAC91D5264080();
	}

	static string? D513B85D8A594E3D(string? P_0, string? P_1, string? P_2)
	{
		return Path.Combine(P_0, P_1, P_2);
	}

	static bool _00529551FC9B463C(string? P_0)
	{
		return File.Exists(P_0);
	}

	static object? _10B830F8CB504183(string? P_0)
	{
		return new StreamReader(P_0);
	}

	static object? D157BF3665364974()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		return (object?)new YamlStream();
	}

	static void _43ACAEBC0BA64074(object? P_0, object? P_1)
	{
		((YamlStream)P_0).Load((TextReader)P_1);
	}

	static IList<YamlDocument?>? _3CD9AA53F5684245(object? P_0)
	{
		return ((YamlStream)P_0).Documents;
	}

	static object? _114DCE48BD924962(object? P_0)
	{
		return ((YamlDocument)P_0).RootNode;
	}

	static IOrderedDictionary<YamlNode?, YamlNode?>? A1631CDB06DD4A89(object? P_0)
	{
		return ((YamlMappingNode)P_0).Children;
	}

	static object? CED97961F77D4E0B(string? P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		return (object?)new YamlScalarNode(P_0);
	}

	static string? _847813CCD5A4489F(object? P_0)
	{
		return ((YamlScalarNode)P_0).Value;
	}

	static void E9A75BCCD8DE41A4(object? P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
