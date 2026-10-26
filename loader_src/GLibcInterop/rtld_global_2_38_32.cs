using System.Runtime.InteropServices;

namespace GlibcInterop;

[StructLayout(LayoutKind.Explicit, Size = 2360)]
internal struct rtld_global_2_38_32
{
	[FieldOffset(0)]
	private unsafe fixed byte _dl_ns[1408];

	[FieldOffset(1408)]
	private unsafe fixed byte _dl_nns[4];

	[FieldOffset(1412)]
	private unsafe fixed byte _dl_load_lock[24];

	[FieldOffset(1436)]
	private unsafe fixed byte _dl_load_write_lock[24];

	[FieldOffset(1460)]
	private unsafe fixed byte _dl_load_tls_lock[24];

	[FieldOffset(1484)]
	private unsafe fixed byte _dl_load_adds[8];

	[FieldOffset(1492)]
	private unsafe fixed byte _dl_initfirst[4];

	[FieldOffset(1496)]
	private unsafe fixed byte _dl_profile_map[4];

	[FieldOffset(1500)]
	private unsafe fixed byte _dl_num_relocations[4];

	[FieldOffset(1504)]
	private unsafe fixed byte _dl_num_cache_relocations[4];

	[FieldOffset(1508)]
	private unsafe fixed byte _dl_all_dirs[4];

	[FieldOffset(1512)]
	private unsafe fixed byte _dl_rtld_map[636];

	[FieldOffset(2148)]
	private unsafe fixed byte _dl_rtld_auditstate[128];

	[FieldOffset(2276)]
	private unsafe fixed byte _dl_x86_feature_1[4];

	[FieldOffset(2280)]
	private unsafe fixed byte _dl_x86_feature_control[4];

	[FieldOffset(2284)]
	private unsafe fixed byte _dl_stack_flags[4];

	[FieldOffset(2288)]
	private unsafe fixed byte _dl_tls_dtv_gaps[1];

	[FieldOffset(2292)]
	private unsafe fixed byte _dl_tls_max_dtv_idx[4];

	[FieldOffset(2296)]
	private unsafe fixed byte _dl_tls_dtv_slotinfo_list[4];

	[FieldOffset(2300)]
	private unsafe fixed byte _dl_tls_static_nelem[4];

	[FieldOffset(2304)]
	private unsafe fixed byte _dl_tls_static_used[4];

	[FieldOffset(2308)]
	private unsafe fixed byte _dl_tls_static_optional[4];

	[FieldOffset(2312)]
	private unsafe fixed byte _dl_initial_dtv[4];

	[FieldOffset(2316)]
	private unsafe fixed byte _dl_tls_generation[4];

	[FieldOffset(2320)]
	private unsafe fixed byte _dl_scope_free_list[4];

	[FieldOffset(2324)]
	private unsafe fixed byte _dl_stack_used[8];

	[FieldOffset(2332)]
	private unsafe fixed byte _dl_stack_user[8];

	[FieldOffset(2340)]
	private unsafe fixed byte _dl_stack_cache[8];

	[FieldOffset(2348)]
	private unsafe fixed byte _dl_stack_cache_actsize[4];

	[FieldOffset(2352)]
	private unsafe fixed byte _dl_in_flight_stack[4];

	[FieldOffset(2356)]
	private unsafe fixed byte _dl_stack_cache_lock[4];
}
