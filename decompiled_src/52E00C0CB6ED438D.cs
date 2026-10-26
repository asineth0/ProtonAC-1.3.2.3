using System;
using System.Text;
using System.Text.RegularExpressions;

internal class _52E00C0CB6ED438D
{
	private static readonly Regex _964E2A5B938F438B;

	private static int _7782717D2D1642E9(string P_0, string P_1)
	{
		if (P_1.Length > P_0.Length)
		{
			string text = P_1;
			P_1 = P_0;
			P_0 = text;
		}
		int length = P_1.Length;
		int[] array = new int[length + 1];
		int[] array2 = new int[length + 1];
		for (int i = 0; i <= length; i++)
		{
			array[i] = i;
		}
		for (int j = 1; j <= P_0.Length; j++)
		{
			array2[0] = j;
			char c = P_0[j - 1];
			for (int k = 1; k <= length; k++)
			{
				int num = ((c != P_1[k - 1]) ? 1 : 0);
				array2[k] = Math.Min(Math.Min(array2[k - 1] + 1, array[k] + 1), array[k - 1] + num);
			}
			int[] array3 = array2;
			array2 = array;
			array = array3;
		}
		return array[length];
	}

	private static char DF7B797CF6FA4A3D(char P_0)
	{
		return P_0 switch
		{
			'0' => 'o', 
			'1' => 'i', 
			'2' => 'z', 
			'3' => 'e', 
			'4' => 'a', 
			'5' => 's', 
			'6' => 'g', 
			'7' => 't', 
			'8' => 'b', 
			'9' => 'q', 
			'@' => 'a', 
			'$' => 's', 
			'!' => 'i', 
			'*' => 'u', 
			'#' => 'h', 
			'%' => 'o', 
			_ => P_0, 
		};
	}

	public static string _57F3F3B600774394(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(P_0.Length);
		string text = P_0.ToLowerInvariant();
		for (int i = 0; i < text.Length; i++)
		{
			char c = DF7B797CF6FA4A3D(text[i]);
			if (!char.IsWhiteSpace(c) && !char.IsControl(c) && ((c >= 'a' && c <= 'z') || (c >= 'а' && c <= 'я') || c == 'ё' || c == 'і' || c == 'ї' || c == 'ґ'))
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	public static double _46ED1045DDD74BEB(string P_0, string P_1)
	{
		if (string.IsNullOrEmpty(P_0) && string.IsNullOrEmpty(P_1))
		{
			return 1.0;
		}
		if (string.IsNullOrEmpty(P_0) || string.IsNullOrEmpty(P_1))
		{
			return 0.0;
		}
		if (string.Equals(P_0, P_1, StringComparison.Ordinal))
		{
			return 1.0;
		}
		int num = _7782717D2D1642E9(P_0, P_1);
		int num2 = Math.Max(P_0.Length, P_1.Length);
		return 1.0 - (double)num / (double)num2;
	}

	public static bool _49D568CDF3784C4C(string P_0, string P_1, double P_2)
	{
		if (string.IsNullOrEmpty(P_0) || string.IsNullOrEmpty(P_1))
		{
			return _46ED1045DDD74BEB(P_0, P_1) * 100.0 >= P_2;
		}
		int num = Math.Max(P_0.Length, P_1.Length);
		if ((1.0 - (double)Math.Abs(P_0.Length - P_1.Length) / (double)num) * 100.0 < P_2)
		{
			return false;
		}
		return _46ED1045DDD74BEB(P_0, P_1) * 100.0 >= P_2;
	}

	public static bool _86EA9DA592ED421C(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return false;
		}
		return _964E2A5B938F438B.IsMatch(P_0);
	}

	public static string _561BAC91D5264080()
	{
		throw new Exception();
	}

	static _52E00C0CB6ED438D()
	{
		_052F586A77234595.D52BEF2278B4471D((object)null);
	}
}
