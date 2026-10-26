using System;
using System.Text;

public readonly struct _1A87FA40A3224FE4
{
	public readonly byte[] BFD9CAE3857542BA;

	public _1A87FA40A3224FE4(string P_0)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(P_0);
		byte[] array = new byte[bytes.Length + 3];
		array[0] = 34;
		Buffer.BlockCopy(bytes, 0, array, 1, bytes.Length);
		array[bytes.Length + 1] = 34;
		array[bytes.Length + 2] = 58;
		BFD9CAE3857542BA = array;
	}
}
