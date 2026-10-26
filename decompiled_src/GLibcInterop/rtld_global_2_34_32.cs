using System.Runtime.InteropServices;

namespace GlibcInterop;

[StructLayout(LayoutKind.Explicit, Size = 2256)]
internal struct rtld_global_2_34_32
{
	[FieldOffset(0)]
	private unsafe fixed byte _dl_ns[1344];

	[FieldOffset(1344)]
	private unsafe fixed byte _dl_nns[4];

	[FieldOffset(1348)]
	private unsafe fixed byte _dl_load_lock[24];

	[FieldOffset(1372)]
	private unsafe fixed byte _dl_load_write_lock[24];

	[FieldOffset(1396)]
	private unsafe fixed byte _dl_load_adds[8];

	[FieldOffset(1404)]
	private unsafe fixed byte _dl_initfirst[4];

	[FieldOffset(1408)]
	private unsafe fixed byte _dl_profile_map[4];

	[FieldOffset(1412)]
	private unsafe fixed byte _dl_num_relocations[4];

	[FieldOffset(1416)]
	private unsafe fixed byte _dl_num_cache_relocations[4];

	[FieldOffset(1420)]
	private unsafe fixed byte _dl_all_dirs[4];

	[FieldOffset(1424)]
	private unsafe fixed byte _dl_rtld_map[620];

	[FieldOffset(2044)]
	private unsafe fixed byte _dl_rtld_auditstate[128];

	[FieldOffset(2172)]
	private unsafe fixed byte _dl_x86_feature_1[4];

	[FieldOffset(2176)]
	private unsafe fixed byte _dl_x86_feature_control[4];

	[FieldOffset(2180)]
	private unsafe fixed byte _dl_stack_flags[4];

	[FieldOffset(2184)]
	private unsafe fixed byte _dl_tls_dtv_gaps[1];

	[FieldOffset(2188)]
	private unsafe fixed byte _dl_tls_max_dtv_idx[4];

	[FieldOffset(2192)]
	private unsafe fixed byte _dl_tls_dtv_slotinfo_list[4];

	[FieldOffset(2196)]
	private unsafe fixed byte _dl_tls_static_nelem[4];

	[FieldOffset(2200)]
	private unsafe fixed byte _dl_tls_static_used[4];

	[FieldOffset(2204)]
	private unsafe fixed byte _dl_tls_static_optional[4];

	[FieldOffset(2208)]
	private unsafe fixed byte _dl_initial_dtv[4];

	[FieldOffset(2212)]
	private unsafe fixed byte _dl_tls_generation[4];

	[FieldOffset(2216)]
	private unsafe fixed byte _dl_scope_free_list[4];

	[FieldOffset(2220)]
	private unsafe fixed byte _dl_stack_used[8];

	[FieldOffset(2228)]
	private unsafe fixed byte _dl_stack_user[8];

	[FieldOffset(2236)]
	private unsafe fixed byte _dl_stack_cache[8];

	[FieldOffset(2244)]
	private unsafe fixed byte _dl_stack_cache_actsize[4];

	[FieldOffset(2248)]
	private unsafe fixed byte _dl_in_flight_stack[4];

	[FieldOffset(2252)]
	private unsafe fixed byte _dl_stack_cache_lock[4];
}
