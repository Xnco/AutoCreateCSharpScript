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



public class guildReq : PackageBase
{
    
    public short ID = 63;
    
    public int guildid;
    
    public override byte[] Create()
    {
        buf.Add((byte)(ID & (short)filter));
        buf.Add((byte)((ID>> 8) & (short)filter));

        int len = 0;
        len += 4 ;

        buf.Add((byte)(len & (short)filter));
        buf.Add((byte)((len >> 8) & (short)filter));

        buf.Add((byte)(guildid & (short)filter));
        buf.Add((byte)((guildid >> 8) & (short)filter));
        buf.Add((byte)((guildid >> 16) & (short)filter));
        buf.Add((byte)((guildid >> 24) & (short)filter));

        return buf.ToArray();
    }
}
