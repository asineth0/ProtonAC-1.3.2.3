using System.Runtime.InteropServices;

namespace GlibcInterop;

[StructLayout(LayoutKind.Explicit, Size = 1152)]
internal struct link_map_2_31_64
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
	private unsafe fixed byte l_info[616];

	[FieldOffset(680)]
	private unsafe fixed byte l_phdr[8];

	[FieldOffset(688)]
	private unsafe fixed byte l_entry[8];

	[FieldOffset(696)]
	private unsafe fixed byte l_phnum[2];

	[FieldOffset(698)]
	private unsafe fixed byte l_ldnum[2];

	[FieldOffset(704)]
	private unsafe fixed byte l_searchlist[16];

	[FieldOffset(720)]
	private unsafe fixed byte l_symbolic_searchlist[16];

	[FieldOffset(736)]
	private unsafe fixed byte l_loader[8];

	[FieldOffset(744)]
	private unsafe fixed byte l_versions[8];

	[FieldOffset(752)]
	private unsafe fixed byte l_nversions[4];

	[FieldOffset(756)]
	private unsafe fixed byte l_nbuckets[4];

	[FieldOffset(760)]
	private unsafe fixed byte l_gnu_bitmask_idxbits[4];

	[FieldOffset(764)]
	private unsafe fixed byte l_gnu_shift[4];

	[FieldOffset(768)]
	private unsafe fixed byte l_gnu_bitmask[8];

	[FieldOffset(776)]
	private unsafe fixed byte l_gnu_buckets[8];

	[FieldOffset(776)]
	private unsafe fixed byte l_chain[8];

	[FieldOffset(784)]
	private unsafe fixed byte l_gnu_chain_zero[8];

	[FieldOffset(784)]
	private unsafe fixed byte l_buckets[8];

	[FieldOffset(792)]
	private unsafe fixed byte l_direct_opencount[4];

	[FieldOffset(799)]
	private unsafe fixed byte l_nodelete_active[1];

	[FieldOffset(800)]
	private unsafe fixed byte l_nodelete_pending[1];

	[FieldOffset(808)]
	private unsafe fixed byte l_rpath_dirs[16];

	[FieldOffset(824)]
	private unsafe fixed byte l_reloc_result[8];

	[FieldOffset(832)]
	private unsafe fixed byte l_versyms[8];

	[FieldOffset(840)]
	private unsafe fixed byte l_origin[8];

	[FieldOffset(848)]
	private unsafe fixed byte l_map_start[8];

	[FieldOffset(856)]
	private unsafe fixed byte l_map_end[8];

	[FieldOffset(864)]
	private unsafe fixed byte l_text_end[8];

	[FieldOffset(872)]
	private unsafe fixed byte l_scope_mem[32];

	[FieldOffset(904)]
	private unsafe fixed byte l_scope_max[8];

	[FieldOffset(920)]
	private unsafe fixed byte l_local_scope[16];

	[FieldOffset(936)]
	private unsafe fixed byte l_file_id[16];

	[FieldOffset(952)]
	private unsafe fixed byte l_runpath_dirs[16];

	[FieldOffset(976)]
	private unsafe fixed byte l_reldeps[8];

	[FieldOffset(984)]
	private unsafe fixed byte l_reldepsmax[4];

	[FieldOffset(988)]
	private unsafe fixed byte l_used[4];

	[FieldOffset(992)]
	private unsafe fixed byte l_feature_1[4];

	[FieldOffset(996)]
	private unsafe fixed byte l_flags_1[4];

	[FieldOffset(1000)]
	private unsafe fixed byte l_flags[4];

	[FieldOffset(1004)]
	private unsafe fixed byte l_idx[4];

	[FieldOffset(1008)]
	private unsafe fixed byte l_mach[24];

	[FieldOffset(1032)]
	private unsafe fixed byte l_lookup_cache[32];

	[FieldOffset(1064)]
	private unsafe fixed byte l_tls_initimage[8];

	[FieldOffset(1072)]
	private unsafe fixed byte l_tls_initimage_size[8];

	[FieldOffset(1080)]
	private unsafe fixed byte l_tls_blocksize[8];

	[FieldOffset(1088)]
	private unsafe fixed byte l_tls_align[8];

	[FieldOffset(1096)]
	private unsafe fixed byte l_tls_firstbyte_offset[8];

	[FieldOffset(1104)]
	private unsafe fixed byte l_tls_offset[8];

	[FieldOffset(1112)]
	private unsafe fixed byte l_tls_modid[8];

	[FieldOffset(1120)]
	private unsafe fixed byte l_tls_dtor_count[8];

	[FieldOffset(1128)]
	private unsafe fixed byte l_relro_addr[8];

	[FieldOffset(1136)]
	private unsafe fixed byte l_relro_size[8];

	[FieldOffset(1144)]
	private unsafe fixed byte l_serial[8];
}
