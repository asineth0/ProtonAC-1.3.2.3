using System;
using System.Runtime.CompilerServices;
using HarmonyLib;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class _542A381FC1D44BA3 : Attribute
{
	[CompilerGenerated]
	private readonly Type F147E06B60B640AA;

	[CompilerGenerated]
	private readonly string ECE63F70C1E74D3B;

	[CompilerGenerated]
	private readonly _24AD03718EF64384 _48AC09FC138E4973;

	[CompilerGenerated]
	private readonly Type[] DB8798A5EC6F4C40;

	[CompilerGenerated]
	private readonly Type[] _592B5A5E8BF4404D;

	public Type _0FB47E4E20D24D2F
	{
		[CompilerGenerated]
		get
		{
			return F147E06B60B640AA;
		}
	}

	public string _37662C4CEEC14AA4
	{
		[CompilerGenerated]
		get
		{
			return ECE63F70C1E74D3B;
		}
	}

	public _24AD03718EF64384 E71F452CC443465C
	{
		[CompilerGenerated]
		get
		{
			return _48AC09FC138E4973;
		}
	}

	public Type[] _3458718780114A23
	{
		[CompilerGenerated]
		get
		{
			return DB8798A5EC6F4C40;
		}
	}

	public Type[] _2FBBDDB67E0648FE
	{
		[CompilerGenerated]
		get
		{
			return _592B5A5E8BF4404D;
		}
	}

	public _542A381FC1D44BA3(Type P_0, string P_1, _24AD03718EF64384 P_2, Type[] P_3, Type[] P_4)
	{
		F147E06B60B640AA = P_0;
		ECE63F70C1E74D3B = P_1;
	}

	public _542A381FC1D44BA3(Type P_0, string P_1, _24AD03718EF64384 P_2, Type[] P_3)
	{
	}

	public _542A381FC1D44BA3(Type P_0, string P_1, _24AD03718EF64384 P_2)
	{
	}

	public _542A381FC1D44BA3(string P_0, string P_1, _24AD03718EF64384 P_2)
		: this((Type)_1CBAB5A1DC144AD1(P_0), P_1, P_2, Array.Empty<Type>(), Array.Empty<Type>())
	{
	}

	static object _1CBAB5A1DC144AD1(string P_0)
	{
		return AccessTools.TypeByName(P_0);
	}
}
