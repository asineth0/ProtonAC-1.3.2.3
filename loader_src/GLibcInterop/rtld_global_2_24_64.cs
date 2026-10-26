using System.Runtime.InteropServices;

namespace GlibcInterop;

[StructLayout(LayoutKind.Explicit, Size = 3968)]
internal struct rtld_global_2_24_64
{
	[FieldOffset(0)]
	private unsafe fixed byte _dl_ns[2304];

	[FieldOffset(2304)]
	private unsafe fixed byte _dl_nns[8];

	[FieldOffset(2312)]
	private unsafe fixed byte _dl_load_lock[40];

	[FieldOffset(2352)]
	private unsafe fixed byte _dl_load_write_lock[40];

	[FieldOffset(2392)]
	private unsafe fixed byte _dl_load_adds[8];

	[FieldOffset(2400)]
	private unsafe fixed byte _dl_initfirst[8];

	[FieldOffset(2408)]
	private unsafe fixed byte _dl_cpuclock_offset[8];

	[FieldOffset(2416)]
	private unsafe fixed byte _dl_profile_map[8];

	[FieldOffset(2424)]
	private unsafe fixed byte _dl_num_relocations[8];

	[FieldOffset(2432)]
	private unsafe fixed byte _dl_num_cache_relocations[8];

	[FieldOffset(2440)]
	private unsafe fixed byte _dl_all_dirs[8];

	[FieldOffset(2456)]
	private unsafe fixed byte _dl_rtld_map[1136];

	[FieldOffset(3872)]
	private unsafe fixed byte _dl_stack_flags[4];

	[FieldOffset(3876)]
	private unsafe fixed byte _dl_tls_dtv_gaps[1];

	[FieldOffset(3880)]
	private unsafe fixed byte _dl_tls_max_dtv_idx[8];

	[FieldOffset(3888)]
	private unsafe fixed byte _dl_tls_dtv_slotinfo_list[8];

	[FieldOffset(3896)]
	private unsafe fixed byte _dl_tls_static_nelem[8];

	[FieldOffset(3904)]
	private unsafe fixed byte _dl_tls_static_size[8];

	[FieldOffset(3912)]
	private unsafe fixed byte _dl_tls_static_used[8];

	[FieldOffset(3920)]
	private unsafe fixed byte _dl_tls_static_align[8];

	[FieldOffset(3928)]
	private unsafe fixed byte _dl_initial_dtv[8];

	[FieldOffset(3936)]
	private unsafe fixed byte _dl_tls_generation[8];

	[FieldOffset(3960)]
	private unsafe fixed byte _dl_scope_free_list[8];
}
