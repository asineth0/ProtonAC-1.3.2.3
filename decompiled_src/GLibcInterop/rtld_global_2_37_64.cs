using System.Runtime.InteropServices;

namespace GlibcInterop;

[StructLayout(LayoutKind.Explicit, Size = 4328)]
internal struct rtld_global_2_37_64
{
	[FieldOffset(0)]
	private unsafe fixed byte _dl_ns[2560];

	[FieldOffset(2560)]
	private unsafe fixed byte _dl_nns[8];

	[FieldOffset(2568)]
	private unsafe fixed byte _dl_load_lock[40];

	[FieldOffset(2608)]
	private unsafe fixed byte _dl_load_write_lock[40];

	[FieldOffset(2648)]
	private unsafe fixed byte _dl_load_tls_lock[40];

	[FieldOffset(2688)]
	private unsafe fixed byte _dl_load_adds[8];

	[FieldOffset(2696)]
	private unsafe fixed byte _dl_initfirst[8];

	[FieldOffset(2704)]
	private unsafe fixed byte _dl_profile_map[8];

	[FieldOffset(2712)]
	private unsafe fixed byte _dl_num_relocations[8];

	[FieldOffset(2720)]
	private unsafe fixed byte _dl_num_cache_relocations[8];

	[FieldOffset(2728)]
	private unsafe fixed byte _dl_all_dirs[8];

	[FieldOffset(2736)]
	private unsafe fixed byte _dl_rtld_map[1184];

	[FieldOffset(3920)]
	private unsafe fixed byte _dl_rtld_auditstate[256];

	[FieldOffset(4176)]
	private unsafe fixed byte _dl_x86_feature_1[4];

	[FieldOffset(4180)]
	private unsafe fixed byte _dl_x86_feature_control[4];

	[FieldOffset(4184)]
	private unsafe fixed byte _dl_stack_flags[4];

	[FieldOffset(4188)]
	private unsafe fixed byte _dl_tls_dtv_gaps[1];

	[FieldOffset(4192)]
	private unsafe fixed byte _dl_tls_max_dtv_idx[8];

	[FieldOffset(4200)]
	private unsafe fixed byte _dl_tls_dtv_slotinfo_list[8];

	[FieldOffset(4208)]
	private unsafe fixed byte _dl_tls_static_nelem[8];

	[FieldOffset(4216)]
	private unsafe fixed byte _dl_tls_static_used[8];

	[FieldOffset(4224)]
	private unsafe fixed byte _dl_tls_static_optional[8];

	[FieldOffset(4232)]
	private unsafe fixed byte _dl_initial_dtv[8];

	[FieldOffset(4240)]
	private unsafe fixed byte _dl_tls_generation[8];

	[FieldOffset(4248)]
	private unsafe fixed byte _dl_scope_free_list[8];

	[FieldOffset(4256)]
	private unsafe fixed byte _dl_stack_used[16];

	[FieldOffset(4272)]
	private unsafe fixed byte _dl_stack_user[16];

	[FieldOffset(4288)]
	private unsafe fixed byte _dl_stack_cache[16];

	[FieldOffset(4304)]
	private unsafe fixed byte _dl_stack_cache_actsize[8];

	[FieldOffset(4312)]
	private unsafe fixed byte _dl_in_flight_stack[8];

	[FieldOffset(4320)]
	private unsafe fixed byte _dl_stack_cache_lock[4];
}
