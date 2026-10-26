using System.Runtime.InteropServices;

namespace GlibcInterop;

[StructLayout(LayoutKind.Explicit, Size = 636)]
internal struct link_map_2_37_32
{
	[FieldOffset(0)]
	private unsafe fixed byte l_addr[4];

	[FieldOffset(4)]
	private unsafe fixed byte l_name[4];

	[FieldOffset(8)]
	private unsafe fixed byte l_ld[4];

	[FieldOffset(12)]
	private unsafe fixed byte l_next[4];

	[FieldOffset(16)]
	private unsafe fixed byte l_prev[4];

	[FieldOffset(20)]
	private unsafe fixed byte l_real[4];

	[FieldOffset(24)]
	private unsafe fixed byte l_ns[4];

	[FieldOffset(28)]
	private unsafe fixed byte l_libname[4];

	[FieldOffset(32)]
	private unsafe fixed byte l_info[320];

	[FieldOffset(352)]
	private unsafe fixed byte l_phdr[4];

	[FieldOffset(356)]
	private unsafe fixed byte l_entry[4];

	[FieldOffset(360)]
	private unsafe fixed byte l_phnum[2];

	[FieldOffset(362)]
	private unsafe fixed byte l_ldnum[2];

	[FieldOffset(364)]
	private unsafe fixed byte l_searchlist[8];

	[FieldOffset(372)]
	private unsafe fixed byte l_symbolic_searchlist[8];

	[FieldOffset(380)]
	private unsafe fixed byte l_loader[4];

	[FieldOffset(384)]
	private unsafe fixed byte l_versions[4];

	[FieldOffset(388)]
	private unsafe fixed byte l_nversions[4];

	[FieldOffset(392)]
	private unsafe fixed byte l_nbuckets[4];

	[FieldOffset(396)]
	private unsafe fixed byte l_gnu_bitmask_idxbits[4];

	[FieldOffset(400)]
	private unsafe fixed byte l_gnu_shift[4];

	[FieldOffset(404)]
	private unsafe fixed byte l_gnu_bitmask[4];

	[FieldOffset(408)]
	private unsafe fixed byte l_gnu_buckets[4];

	[FieldOffset(408)]
	private unsafe fixed byte l_chain[4];

	[FieldOffset(412)]
	private unsafe fixed byte l_gnu_chain_zero[4];

	[FieldOffset(412)]
	private unsafe fixed byte l_buckets[4];

	[FieldOffset(416)]
	private unsafe fixed byte l_direct_opencount[4];

	[FieldOffset(423)]
	private unsafe fixed byte l_nodelete_active[1];

	[FieldOffset(424)]
	private unsafe fixed byte l_nodelete_pending[1];

	[FieldOffset(428)]
	private unsafe fixed byte l_x86_feature_1_and[4];

	[FieldOffset(432)]
	private unsafe fixed byte l_x86_isa_1_needed[4];

	[FieldOffset(436)]
	private unsafe fixed byte l_1_needed[4];

	[FieldOffset(440)]
	private unsafe fixed byte l_rpath_dirs[8];

	[FieldOffset(448)]
	private unsafe fixed byte l_reloc_result[4];

	[FieldOffset(452)]
	private unsafe fixed byte l_versyms[4];

	[FieldOffset(456)]
	private unsafe fixed byte l_origin[4];

	[FieldOffset(460)]
	private unsafe fixed byte l_map_start[4];

	[FieldOffset(464)]
	private unsafe fixed byte l_map_end[4];

	[FieldOffset(468)]
	private unsafe fixed byte l_text_end[4];

	[FieldOffset(472)]
	private unsafe fixed byte l_scope_mem[16];

	[FieldOffset(488)]
	private unsafe fixed byte l_scope_max[4];

	[FieldOffset(496)]
	private unsafe fixed byte l_local_scope[8];

	[FieldOffset(504)]
	private unsafe fixed byte l_file_id[16];

	[FieldOffset(520)]
	private unsafe fixed byte l_runpath_dirs[8];

	[FieldOffset(532)]
	private unsafe fixed byte l_reldeps[4];

	[FieldOffset(536)]
	private unsafe fixed byte l_reldepsmax[4];

	[FieldOffset(540)]
	private unsafe fixed byte l_used[4];

	[FieldOffset(544)]
	private unsafe fixed byte l_feature_1[4];

	[FieldOffset(548)]
	private unsafe fixed byte l_flags_1[4];

	[FieldOffset(552)]
	private unsafe fixed byte l_flags[4];

	[FieldOffset(556)]
	private unsafe fixed byte l_idx[4];

	[FieldOffset(560)]
	private unsafe fixed byte l_mach[12];

	[FieldOffset(572)]
	private unsafe fixed byte l_lookup_cache[16];

	[FieldOffset(588)]
	private unsafe fixed byte l_tls_initimage[4];

	[FieldOffset(592)]
	private unsafe fixed byte l_tls_initimage_size[4];

	[FieldOffset(596)]
	private unsafe fixed byte l_tls_blocksize[4];

	[FieldOffset(600)]
	private unsafe fixed byte l_tls_align[4];

	[FieldOffset(604)]
	private unsafe fixed byte l_tls_firstbyte_offset[4];

	[FieldOffset(608)]
	private unsafe fixed byte l_tls_offset[4];

	[FieldOffset(612)]
	private unsafe fixed byte l_tls_modid[4];

	[FieldOffset(616)]
	private unsafe fixed byte l_tls_dtor_count[4];

	[FieldOffset(620)]
	private unsafe fixed byte l_relro_addr[4];

	[FieldOffset(624)]
	private unsafe fixed byte l_relro_size[4];

	[FieldOffset(628)]
	private unsafe fixed byte l_serial[8];
}
