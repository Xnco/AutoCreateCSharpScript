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



public class guildNoticeModify : PackageBase
{
    
    public short ID = 73;
    
    public string notice;
    
    public int team;
    
    public override byte[] Create()
    {
        buf.Add((byte)(ID & (short)filter));
        buf.Add((byte)((ID>> 8) & (short)filter));

        int len = 0;
        byte[] noticeByteArray = Encoding.UTF8.GetBytes(notice);
        len +=  2 + noticeByteArray.Lenght +4 ;

        buf.Add((byte)(len & (short)filter));
        buf.Add((byte)((len >> 8) & (short)filter));

        buf.Add((byte)(noticeByteArray.Length & (short)filter));
        buf.Add((byte)((noticeByteArray.Length >> 8) & (short)filter));
		for (int i = 0; i < noticeByteArray.Length; i++) 
		{
           buf.Add(noticeByteArray[i]);
		}

        buf.Add((byte)(team & (short)filter));
        buf.Add((byte)((team >> 8) & (short)filter));
        buf.Add((byte)((team >> 16) & (short)filter));
        buf.Add((byte)((team >> 24) & (short)filter));

        return buf.ToArray();
    }
}