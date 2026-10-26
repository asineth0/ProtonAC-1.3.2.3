using System;
using System.Text;

public static class _1739BB42C5074828<_0001> where _0001 : struct, Enum
{
	private static readonly byte[] C84BA63604CA479D = Encoding.ASCII.GetBytes("\"?\"");

	private static readonly byte[][] _143FE4E250954DB1 = _89CC6617D6DC4236();

	public static byte[] _314F88BB1FD74F74(int P_0)
	{
		if ((uint)P_0 < (uint)_143FE4E250954DB1.Length)
		{
			byte[] array = _143FE4E250954DB1[P_0];
			if (array != null)
			{
				return array;
			}
		}
		return C84BA63604CA479D;
	}

	private static byte[][] _89CC6617D6DC4236()
	{
		_0001[] array = (_0001[])Enum.GetValues(typeof(_0001));
		string[] names = Enum.GetNames(typeof(_0001));
		int num = 0;
		for (int i = 0; i < array.Length; i++)
		{
			int num2 = Convert.ToInt32(array[i]);
			if (num2 < 0)
			{
				return Array.Empty<byte[]>();
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		byte[][] array2 = new byte[num + 1][];
		for (int j = 0; j < array.Length; j++)
		{
			array2[Convert.ToInt32(array[j])] = Encoding.UTF8.GetBytes("\"" + names[j] + "\"");
		}
		return array2;
	}
}
