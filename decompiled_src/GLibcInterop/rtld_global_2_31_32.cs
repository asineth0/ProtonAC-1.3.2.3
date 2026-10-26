using System.Runtime.InteropServices;

namespace GlibcInterop;

[StructLayout(LayoutKind.Explicit, Size = 2180)]
internal struct rtld_global_2_31_32
{
	[FieldOffset(0)]
	private unsafe fixed byte _dl_ns[1280];

	[FieldOffset(1280)]
	private unsafe fixed byte _dl_nns[4];

	[FieldOffset(1284)]
	private unsafe fixed byte _dl_load_lock[24];

	[FieldOffset(1308)]
	private unsafe fixed byte _dl_load_write_lock[24];

	[FieldOffset(1332)]
	private unsafe fixed byte _dl_load_adds[8];

	[FieldOffset(1340)]
	private unsafe fixed byte _dl_initfirst[4];

	[FieldOffset(1344)]
	private unsafe fixed byte _dl_profile_map[4];

	[FieldOffset(1348)]
	private unsafe fixed byte _dl_num_relocations[4];

	[FieldOffset(1352)]
	private unsafe fixed byte _dl_num_cache_relocations[4];

	[FieldOffset(1356)]
	private unsafe fixed byte _dl_all_dirs[4];

	[FieldOffset(1360)]
	private unsafe fixed byte _dl_rtld_map[612];

	[FieldOffset(1972)]
	private unsafe fixed byte _dl_rtld_auditstate[128];

	[FieldOffset(2108)]
	private unsafe fixed byte _dl_x86_feature_1[8];

	[FieldOffset(2116)]
	private unsafe fixed byte _dl_x86_legacy_bitmap[8];

	[FieldOffset(2128)]
	private unsafe fixed byte _dl_stack_flags[4];

	[FieldOffset(2132)]
	private unsafe fixed byte _dl_tls_dtv_gaps[1];

	[FieldOffset(2136)]
	private unsafe fixed byte _dl_tls_max_dtv_idx[4];

	[FieldOffset(2140)]
	private unsafe fixed byte _dl_tls_dtv_slotinfo_list[4];

	[FieldOffset(2144)]
	private unsafe fixed byte _dl_tls_static_nelem[4];

	[FieldOffset(2148)]
	private unsafe fixed byte _dl_tls_static_size[4];

	[FieldOffset(2152)]
	private unsafe fixed byte _dl_tls_static_used[4];

	[FieldOffset(2156)]
	private unsafe fixed byte _dl_tls_static_align[4];

	[FieldOffset(2160)]
	private unsafe fixed byte _dl_initial_dtv[4];

	[FieldOffset(2164)]
	private unsafe fixed byte _dl_tls_generation[4];

	[FieldOffset(2176)]
	private unsafe fixed byte _dl_scope_free_list[4];
}
