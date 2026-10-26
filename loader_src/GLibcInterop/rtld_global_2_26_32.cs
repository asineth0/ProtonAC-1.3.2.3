using System.Runtime.InteropServices;

namespace GlibcInterop;

[StructLayout(LayoutKind.Explicit, Size = 2100)]
internal struct rtld_global_2_26_32
{
	[FieldOffset(0)]
	private unsafe fixed byte _dl_ns[1216];

	[FieldOffset(1216)]
	private unsafe fixed byte _dl_nns[4];

	[FieldOffset(1220)]
	private unsafe fixed byte _dl_load_lock[24];

	[FieldOffset(1244)]
	private unsafe fixed byte _dl_load_write_lock[24];

	[FieldOffset(1268)]
	private unsafe fixed byte _dl_load_adds[8];

	[FieldOffset(1276)]
	private unsafe fixed byte _dl_initfirst[4];

	[FieldOffset(1280)]
	private unsafe fixed byte _dl_cpuclock_offset[8];

	[FieldOffset(1288)]
	private unsafe fixed byte _dl_profile_map[4];

	[FieldOffset(1292)]
	private unsafe fixed byte _dl_num_relocations[4];

	[FieldOffset(1296)]
	private unsafe fixed byte _dl_num_cache_relocations[4];

	[FieldOffset(1300)]
	private unsafe fixed byte _dl_all_dirs[4];

	[FieldOffset(1304)]
	private unsafe fixed byte _dl_rtld_map[604];

	[FieldOffset(2048)]
	private unsafe fixed byte _dl_stack_flags[4];

	[FieldOffset(2052)]
	private unsafe fixed byte _dl_tls_dtv_gaps[1];

	[FieldOffset(2056)]
	private unsafe fixed byte _dl_tls_max_dtv_idx[4];

	[FieldOffset(2060)]
	private unsafe fixed byte _dl_tls_dtv_slotinfo_list[4];

	[FieldOffset(2064)]
	private unsafe fixed byte _dl_tls_static_nelem[4];

	[FieldOffset(2068)]
	private unsafe fixed byte _dl_tls_static_size[4];

	[FieldOffset(2072)]
	private unsafe fixed byte _dl_tls_static_used[4];

	[FieldOffset(2076)]
	private unsafe fixed byte _dl_tls_static_align[4];

	[FieldOffset(2080)]
	private unsafe fixed byte _dl_initial_dtv[4];

	[FieldOffset(2084)]
	private unsafe fixed byte _dl_tls_generation[4];

	[FieldOffset(2096)]
	private unsafe fixed byte _dl_scope_free_list[4];
}
