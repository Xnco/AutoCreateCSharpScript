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



public class wxqq : PackageBase
{
    
    public short ID = 2;
    
    public string wx		;
    
    public string qq;
    
    public override byte[] Create()
    {
        buf.Add((byte)(ID & (short)filter));
        buf.Add((byte)((ID>> 8) & (short)filter));

        int len = 0;
        byte[] wx		ByteArray = Encoding.UTF8.GetBytes(wx		);
        byte[] qqByteArray = Encoding.UTF8.GetBytes(qq);
        len +=  2 + wx		ByteArray.Lenght + 2 + qqByteArray.Lenght ;

        buf.Add((byte)(len & (short)filter));
        buf.Add((byte)((len >> 8) & (short)filter));

        buf.Add((byte)(wx		ByteArray.Length & (short)filter));
        buf.Add((byte)((wx		ByteArray.Length >> 8) & (short)filter));
		for (int i = 0; i < wx		ByteArray.Length; i++) 
		{
           buf.Add(wx		ByteArray[i]);
		}

        buf.Add((byte)(qqByteArray.Length & (short)filter));
        buf.Add((byte)((qqByteArray.Length >> 8) & (short)filter));
		for (int i = 0; i < qqByteArray.Length; i++) 
		{
           buf.Add(qqByteArray[i]);
		}

        return buf.ToArray();
    }
}
