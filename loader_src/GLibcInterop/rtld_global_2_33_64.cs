using System.Runtime.InteropServices;

namespace GlibcInterop;

[StructLayout(LayoutKind.Explicit, Size = 4152)]
internal struct rtld_global_2_33_64
{
	[FieldOffset(0)]
	private unsafe fixed byte _dl_ns[2432];

	[FieldOffset(2432)]
	private unsafe fixed byte _dl_nns[8];

	[FieldOffset(2440)]
	private unsafe fixed byte _dl_load_lock[40];

	[FieldOffset(2480)]
	private unsafe fixed byte _dl_load_write_lock[40];

	[FieldOffset(2520)]
	private unsafe fixed byte _dl_load_adds[8];

	[FieldOffset(2528)]
	private unsafe fixed byte _dl_initfirst[8];

	[FieldOffset(2536)]
	private unsafe fixed byte _dl_profile_map[8];

	[FieldOffset(2544)]
	private unsafe fixed byte _dl_num_relocations[8];

	[FieldOffset(2552)]
	private unsafe fixed byte _dl_num_cache_relocations[8];

	[FieldOffset(2560)]
	private unsafe fixed byte _dl_all_dirs[8];

	[FieldOffset(2568)]
	private unsafe fixed byte _dl_rtld_map[1160];

	[FieldOffset(3728)]
	private unsafe fixed byte _dl_rtld_auditstate[256];

	[FieldOffset(4000)]
	private unsafe fixed byte _dl_x86_feature_1[4];

	[FieldOffset(4004)]
	private unsafe fixed byte _dl_x86_feature_control[4];

	[FieldOffset(4016)]
	private unsafe fixed byte _dl_stack_flags[4];

	[FieldOffset(4020)]
	private unsafe fixed byte _dl_tls_dtv_gaps[1];

	[FieldOffset(4024)]
	private unsafe fixed byte _dl_tls_max_dtv_idx[8];

	[FieldOffset(4032)]
	private unsafe fixed byte _dl_tls_dtv_slotinfo_list[8];

	[FieldOffset(4040)]
	private unsafe fixed byte _dl_tls_static_nelem[8];

	[FieldOffset(4048)]
	private unsafe fixed byte _dl_tls_static_size[8];

	[FieldOffset(4056)]
	private unsafe fixed byte _dl_tls_static_used[8];

	[FieldOffset(4064)]
	private unsafe fixed byte _dl_tls_static_align[8];

	[FieldOffset(4072)]
	private unsafe fixed byte _dl_tls_static_optional[8];

	[FieldOffset(4080)]
	private unsafe fixed byte _dl_initial_dtv[8];

	[FieldOffset(4088)]
	private unsafe fixed byte _dl_tls_generation[8];

	[FieldOffset(4104)]
	private unsafe fixed byte _dl_scope_free_list[8];

	[FieldOffset(4112)]
	private unsafe fixed byte _dl_stack_used[16];

	[FieldOffset(4128)]
	private unsafe fixed byte _dl_stack_user[16];

	[FieldOffset(4144)]
	private unsafe fixed byte _dl_stack_cache_lock[4];
}
