// ============================================================
// token 0x06000857   7FE330C6E84D4C74::21B8A9D9572346C4
// native code: 0x28d970d3ac0  (387 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '21B8A9D9572346C4' () cil managed
//   
// native-calls: 06001068
// native-strings: 
// ============================================================

public  void 21B8A9D9572346C4()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 8 call(s):
    //   0x28d970d3b08  ALLOC_OBJECT(0x28d9665d778)
    //   0x28d970d3b30  WBARRIER((ALLOC_OBJECT(0x28d9665d778) add 0x20), ?)
    //   0x28d970d3b80  Combine(0x28cc768cce8.f0, ALLOC_OBJECT(0x28d9665d778), 0x28d9665d848.f28, ?)
    //   0x28d970d3bd0  WBARRIER(0x28cc768cce8, ALLOC_OBJECT(0x28d9665d778))
    //   0x28d970d3be8  760EF57D5259421C::A599C828530B4E69(this)
    //   0x28d970d3c10  THROW(0x14b, 0x71)
    //   0x28d970d3c28  THROW(0x162, 0x11a)
    //   0x28d970d3c40  THROW(0xf3, 0x15c)
    // 7 store(s):
    //   0x28d970d3b17  ALLOC_OBJECT(0x28d9665d778) <- this
    //   0x28d970d3b45  ALLOC_OBJECT(0x28d9665d778) <- 0x28d96653778
    //   0x28d970d3b53  ALLOC_OBJECT(0x28d9665d778) <- 0x28d9665d840
    //   0x28d970d3b65  ALLOC_OBJECT(0x28d9665d778) <- 0x28d9665d848.f28
    //   0x28d970d3b6d  ALLOC_OBJECT(0x28d9665d778) <- 0x28d9665d848.f20
    //   0x28d970d3b71  ALLOC_OBJECT(0x28d9665d778) <- 0x0
    //   0x28d970d3bb5  0x28cc768cce8 <- Combine(0x28cc768cce8.f0, ALLOC_OBJECT(0x28d9665d778), 0x28d9665d848.f28, ?)
    // returns: 760EF57D5259421C::A599C828530B4E69(this)
}
