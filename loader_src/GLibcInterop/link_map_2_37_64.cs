using System.Runtime.InteropServices;

namespace GlibcInterop;

[StructLayout(LayoutKind.Explicit, Size = 1184)]
internal struct link_map_2_37_64
{
	[FieldOffset(0)]
	private unsafe fixed byte l_addr[8];

	[FieldOffset(8)]
	private unsafe fixed byte l_name[8];

	[FieldOffset(16)]
	private unsafe fixed byte l_ld[8];

	[FieldOffset(24)]
	private unsafe fixed byte l_next[8];

	[FieldOffset(32)]
	private unsafe fixed byte l_prev[8];

	[FieldOffset(40)]
	private unsafe fixed byte l_real[8];

	[FieldOffset(48)]
	private unsafe fixed byte l_ns[8];

	[FieldOffset(56)]
	private unsafe fixed byte l_libname[8];

	[FieldOffset(64)]
	private unsafe fixed byte l_info[640];

	[FieldOffset(704)]
	private unsafe fixed byte l_phdr[8];

	[FieldOffset(712)]
	private unsafe fixed byte l_entry[8];

	[FieldOffset(720)]
	private unsafe fixed byte l_phnum[2];

	[FieldOffset(722)]
	private unsafe fixed byte l_ldnum[2];

	[FieldOffset(728)]
	private unsafe fixed byte l_searchlist[16];

	[FieldOffset(744)]
	private unsafe fixed byte l_symbolic_searchlist[16];

	[FieldOffset(760)]
	private unsafe fixed byte l_loader[8];

	[FieldOffset(768)]
	private unsafe fixed byte l_versions[8];

	[FieldOffset(776)]
	private unsafe fixed byte l_nversions[4];

	[FieldOffset(780)]
	private unsafe fixed byte l_nbuckets[4];

	[FieldOffset(784)]
	private unsafe fixed byte l_gnu_bitmask_idxbits[4];

	[FieldOffset(788)]
	private unsafe fixed byte l_gnu_shift[4];

	[FieldOffset(792)]
	private unsafe fixed byte l_gnu_bitmask[8];

	[FieldOffset(800)]
	private unsafe fixed byte l_gnu_buckets[8];

	[FieldOffset(800)]
	private unsafe fixed byte l_chain[8];

	[FieldOffset(808)]
	private unsafe fixed byte l_gnu_chain_zero[8];

	[FieldOffset(808)]
	private unsafe fixed byte l_buckets[8];

	[FieldOffset(816)]
	private unsafe fixed byte l_direct_opencount[4];

	[FieldOffset(823)]
	private unsafe fixed byte l_nodelete_active[1];

	[FieldOffset(824)]
	private unsafe fixed byte l_nodelete_pending[1];

	[FieldOffset(828)]
	private unsafe fixed byte l_x86_feature_1_and[4];

	[FieldOffset(832)]
	private unsafe fixed byte l_x86_isa_1_needed[4];

	[FieldOffset(836)]
	private unsafe fixed byte l_1_needed[4];

	[FieldOffset(840)]
	private unsafe fixed byte l_rpath_dirs[16];

	[FieldOffset(856)]
	private unsafe fixed byte l_reloc_result[8];

	[FieldOffset(864)]
	private unsafe fixed byte l_versyms[8];

	[FieldOffset(872)]
	private unsafe fixed byte l_origin[8];

	[FieldOffset(880)]
	private unsafe fixed byte l_map_start[8];

	[FieldOffset(888)]
	private unsafe fixed byte l_map_end[8];

	[FieldOffset(896)]
	private unsafe fixed byte l_text_end[8];

	[FieldOffset(904)]
	private unsafe fixed byte l_scope_mem[32];

	[FieldOffset(936)]
	private unsafe fixed byte l_scope_max[8];

	[FieldOffset(952)]
	private unsafe fixed byte l_local_scope[16];

	[FieldOffset(968)]
	private unsafe fixed byte l_file_id[16];

	[FieldOffset(984)]
	private unsafe fixed byte l_runpath_dirs[16];

	[FieldOffset(1008)]
	private unsafe fixed byte l_reldeps[8];

	[FieldOffset(1016)]
	private unsafe fixed byte l_reldepsmax[4];

	[FieldOffset(1020)]
	private unsafe fixed byte l_used[4];

	[FieldOffset(1024)]
	private unsafe fixed byte l_feature_1[4];

	[FieldOffset(1028)]
	private unsafe fixed byte l_flags_1[4];

	[FieldOffset(1032)]
	private unsafe fixed byte l_flags[4];

	[FieldOffset(1036)]
	private unsafe fixed byte l_idx[4];

	[FieldOffset(1040)]
	private unsafe fixed byte l_mach[24];

	[FieldOffset(1064)]
	private unsafe fixed byte l_lookup_cache[32];

	[FieldOffset(1096)]
	private unsafe fixed byte l_tls_initimage[8];

	[FieldOffset(1104)]
	private unsafe fixed byte l_tls_initimage_size[8];

	[FieldOffset(1112)]
	private unsafe fixed byte l_tls_blocksize[8];

	[FieldOffset(1120)]
	private unsafe fixed byte l_tls_align[8];

	[FieldOffset(1128)]
	private unsafe fixed byte l_tls_firstbyte_offset[8];

	[FieldOffset(1136)]
	private unsafe fixed byte l_tls_offset[8];

	[FieldOffset(1144)]
	private unsafe fixed byte l_tls_modid[8];

	[FieldOffset(1152)]
	private unsafe fixed byte l_tls_dtor_count[8];

	[FieldOffset(1160)]
	private unsafe fixed byte l_relro_addr[8];

	[FieldOffset(1168)]
	private unsafe fixed byte l_relro_size[8];

	[FieldOffset(1176)]
	private unsafe fixed byte l_serial[8];
}
