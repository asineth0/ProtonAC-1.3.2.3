namespace GLibcInterop;

internal struct r_search_path_struct
{
	public unsafe void** dirs;

	public int malloced;
}
