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



public class shopGift : PackageBase
{
    
    public short ID = 101;
    
    public int charid;
    
    public string theme;
    
    public string content;
    
    public int giftType;
    
    public int num;
    
    public override byte[] Create()
    {
        buf.Add((byte)(ID & (short)filter));
        buf.Add((byte)((ID>> 8) & (short)filter));

        int len = 0;
        byte[] themeByteArray = Encoding.UTF8.GetBytes(theme);
        byte[] contentByteArray = Encoding.UTF8.GetBytes(content);
        len += 4 + 2 + themeByteArray.Lenght + 2 + contentByteArray.Lenght +4 +4 ;

        buf.Add((byte)(len & (short)filter));
        buf.Add((byte)((len >> 8) & (short)filter));

        buf.Add((byte)(charid & (short)filter));
        buf.Add((byte)((charid >> 8) & (short)filter));
        buf.Add((byte)((charid >> 16) & (short)filter));
        buf.Add((byte)((charid >> 24) & (short)filter));

        buf.Add((byte)(themeByteArray.Length & (short)filter));
        buf.Add((byte)((themeByteArray.Length >> 8) & (short)filter));
		for (int i = 0; i < themeByteArray.Length; i++) 
		{
           buf.Add(themeByteArray[i]);
		}

        buf.Add((byte)(contentByteArray.Length & (short)filter));
        buf.Add((byte)((contentByteArray.Length >> 8) & (short)filter));
		for (int i = 0; i < contentByteArray.Length; i++) 
		{
           buf.Add(contentByteArray[i]);
		}

        buf.Add((byte)(giftType & (short)filter));
        buf.Add((byte)((giftType >> 8) & (short)filter));
        buf.Add((byte)((giftType >> 16) & (short)filter));
        buf.Add((byte)((giftType >> 24) & (short)filter));

        buf.Add((byte)(num & (short)filter));
        buf.Add((byte)((num >> 8) & (short)filter));
        buf.Add((byte)((num >> 16) & (short)filter));
        buf.Add((byte)((num >> 24) & (short)filter));

        return buf.ToArray();
    }
}
