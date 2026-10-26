using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_06000019 {
    public unsafe static void M06000019(ref _Module_.LzmaDecoder __this, System.IO.Stream inStream, System.IO.Stream outStream, long inSize, long outSize) {
      var v1 = __this.LiteralDecoder.DecodeNormal(__this.RangeDecoder, 0, 0);
      var v2 = __this.OutWindow.GetByte(0);
      var v3 = __this.OutWindow.GetByte(0);
      var v4 = __this.OutWindow.GetByte(0);
      var v5 = _Module_.LzmaDecoder.GetLenToPosState(default);
      __this.Init(inStream, outStream);
      __this.OutWindow.PutByte((byte)(default));
      __this.OutWindow.PutByte((byte)(default));
      __this.OutWindow.PutByte(default);
      _Module_.BitTreeDecoder.ReverseDecode(__this.PosDecoders, (default), __this.RangeDecoder, (int)((default)));
      __this.RangeDecoder.DecodeDirectBits(((int)((default)) - 4));
      __this.Solid.ReverseDecode(__this.RangeDecoder);
      __this.OutWindow.CopyBlock(default, default);
      throw new System.Exception();
      throw new System.Exception();
      // call F802DDD56AAD418F::F05E99D5952142B7((? add 0xffffffffffffffc8))
      // call 8A0B3F4694D8411A::9385437DDFDE4D95(this.f10+(movsxd (0x0 shl 0x4))*4+20, this.f68)
      // call F802DDD56AAD418F::DF4C66DD7D7E4F9A((? add 0xffffffffffffffc8))
      // call 8A0B3F4694D8411A::9385437DDFDE4D95(this.f10+(movsxd ((0x0 shl 0x4) add (((a0 xor a0) shr 0x0) and this.f94)))*4+20, this.f68)
      // call F802DDD56AAD418F::5987B87C107C408B((? add 0xffffffffffffffc8))
      // call 4A7DB6E4806E4AE0::24916B1DB2C04FBB(this.f48, this.f68, ((a0 xor a0) shr 0x0), (movzx 386822932A254DF5::7F0F018E704241F8(this.f50, (this.f68 xor this.f68))))
      // call 4A7DB6E4806E4AE0::4001CF03F30D4B13(this.f48, this.f68, ((a0 xor a0) shr 0x0), (movzx 386822932A254DF5::7F0F018E704241F8(this.f50, (this.f68 xor this.f68))))
      // call F802DDD56AAD418F::DF4C66DD7D7E4F9A((? add 0xffffffffffffffc8))
      // call 8A0B3F4694D8411A::9385437DDFDE4D95(this.f20+(movsxd 0x0)*4+20, this.f68)
      // call 8A0B3F4694D8411A::9385437DDFDE4D95(this.f28+(movsxd 0x0)*4+20, this.f68)
      // call 8A0B3F4694D8411A::9385437DDFDE4D95(this.f18+(movsxd ((0x0 shl 0x4) add (((a0 xor a0) shr 0x0) and this.f94)))*4+20, this.f68)
      // call F802DDD56AAD418F::D78845C868574748((? add 0xffffffffffffffc8))
      // call 8A0B3F4694D8411A::9385437DDFDE4D95(this.f30+(movsxd 0x0)*4+20, this.f68)
      // call 8A0B3F4694D8411A::9385437DDFDE4D95(this.f38+(movsxd 0x0)*4+20, this.f68)
      // call 9B079DF67D3C4497::7258175EBFC64560(this.f70, this.f68, (((a0 xor a0) shr 0x0) and this.f94))
      // call F802DDD56AAD418F::812BA9180E8E48BF((? add 0xffffffffffffffc8))
      // call 9B079DF67D3C4497::7258175EBFC64560(this.f40, this.f68, (((a0 xor a0) shr 0x0) and this.f94))
      // call F802DDD56AAD418F::05DC7082FEF04055((? add 0xffffffffffffffc8))
      // call 5FE50471BBC64EF1::A9A16D03ACAE49E8(((this.f60 add ((movsxd EEC15067D7014D61::7D0E9FA074614AB3((9B079DF67D3C4497::7258175EBFC64560(this.f40, this.f68, (((a0 xor a0) shr 0x0) and this.f94)) add 0x2))) shl 0x4)) add 0x20), this.f68)
      // call 386822932A254DF5::D9FBF049DA9C4CF1(r14.f50)
      // call 386822932A254DF5::EE2DC035FE6D4792(r14.f50)
      // call EC1CFC21DD4E4A90::D949363E06D14437(r14.f68)
    }
  }
}