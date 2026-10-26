using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

internal class F131A7E07B2C4332(HttpClient? P_0 = null) : IDisposable
{
	private const string C4BD6C3D74FB48EC = "https://steamcommunity.com/profiles/";

	private const int _47D88A156DB04342 = 128;

	private const int _6A1194C5466240FC = 8192;

	private static readonly TimeSpan _3ADF4C03B7054152 = TimeSpan.FromSeconds(5.0);

	private static readonly Regex _2B3768AF474A4477 = new Regex("<span class=\"friendPlayerLevelNum\">(\\d+)</span>", RegexOptions.Compiled | RegexOptions.CultureInvariant);

	private static readonly HttpClient _06BAB51BFBBB4120 = _3B1C46D5180E457E();

	private readonly HttpClient _292205A32E294350 = P_0 ?? _06BAB51BFBBB4120;

	private static HttpClient _3B1C46D5180E457E()
	{
		HttpClientHandler httpClientHandler = new HttpClientHandler();
		if (httpClientHandler.SupportsAutomaticDecompression)
		{
			httpClientHandler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		}
		return new HttpClient(httpClientHandler)
		{
			Timeout = _3ADF4C03B7054152
		};
	}

	public async Task<FCE22BD5614B4582> EA827CA62FD14532(ulong P_0, CancellationToken P_1 = default(CancellationToken))
	{
		using HttpResponseMessage httpResponseMessage = await _292205A32E294350.GetAsync(string.Format("{0}{1}?xml=1", "https://steamcommunity.com/profiles/", P_0), P_1);
		httpResponseMessage.EnsureSuccessStatusCode();
		string text = await httpResponseMessage.Content.ReadAsStringAsync();
		XDocument xDocument;
		try
		{
			xDocument = XDocument.Parse(text);
		}
		catch (Exception ex)
		{
			throw new DF2AF08B4CEF4BE6($"Steam returned a malformed profile document for {P_0}: {ex.Message}");
		}
		return FCE22BD5614B4582.F5B75322E46F4EBD(xDocument);
	}

	public async Task<int?> AAC4F23C390A4550(ulong P_0, CancellationToken P_1 = default(CancellationToken))
	{
		using HttpResponseMessage httpResponseMessage = await _292205A32E294350.GetAsync(string.Format("{0}{1}", "https://steamcommunity.com/profiles/", P_0), HttpCompletionOption.ResponseHeadersRead, P_1);
		httpResponseMessage.EnsureSuccessStatusCode();
		using Stream stream = await httpResponseMessage.Content.ReadAsStreamAsync();
		using StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
		char[] array = new char[8192];
		StringBuilder stringBuilder = new StringBuilder(8320);
		int charCount;
		while ((charCount = await streamReader.ReadAsync(array, 0, array.Length)) > 0)
		{
			P_1.ThrowIfCancellationRequested();
			stringBuilder.Append(array, 0, charCount);
			string text = stringBuilder.ToString();
			Match match = _2B3768AF474A4477.Match(text);
			if (match.Success && int.TryParse(match.Groups[1].Value, NumberStyles.None, CultureInfo.InvariantCulture, out var result))
			{
				return result;
			}
			if (text.Length > 128)
			{
				stringBuilder.Remove(0, text.Length - 128);
			}
		}
		return null;
	}

	public void Dispose()
	{
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}
}
