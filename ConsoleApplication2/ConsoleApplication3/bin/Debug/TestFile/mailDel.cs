//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;



public class mailDel : PackageBase
{
    
    public short ID = 45;
    
    public int mailIndex;
    
    public int checkCount;
    
    public override byte[] Create()
    {
        buf.Add((byte)(ID & (short)filter));
        buf.Add((byte)((ID>> 8) & (short)filter));

        int len = 0;
        len += 4 +4 ;

        buf.Add((byte)(len & (short)filter));
        buf.Add((byte)((len >> 8) & (short)filter));

        buf.Add((byte)(mailIndex & (short)filter));
        buf.Add((byte)((mailIndex >> 8) & (short)filter));
        buf.Add((byte)((mailIndex >> 16) & (short)filter));
        buf.Add((byte)((mailIndex >> 24) & (short)filter));

        buf.Add((byte)(checkCount & (short)filter));
        buf.Add((byte)((checkCount >> 8) & (short)filter));
        buf.Add((byte)((checkCount >> 16) & (short)filter));
        buf.Add((byte)((checkCount >> 24) & (short)filter));

        return buf.ToArray();
    }
}
