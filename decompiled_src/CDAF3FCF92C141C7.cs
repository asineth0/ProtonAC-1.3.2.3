using SDG.Unturned;

internal class CDAF3FCF92C141C7
{
	[_542A381FC1D44BA3(typeof(CommandWindow), "onInputCommitted", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool DFFBCFEC3A75404D(string input)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (input.StartsWith("/"))
		{
			input.Substring(1);
		}
		return !_148FC9FDA20643FB._12E92B7AED794992(input, _200C0FCD340543F6._7C49F3F609634A1E(Provider.server));
	}
}
