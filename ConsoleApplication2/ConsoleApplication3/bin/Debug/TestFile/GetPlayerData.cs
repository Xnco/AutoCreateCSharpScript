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



public class GetPlayerData : PackageBase
{
    
    public short ID = 21;
    
    public int accountID			//玩家账号数据库唯一ID;
    
    public string name;
    
    public override byte[] Create()
    {
        buf.Add((byte)(ID & (short)filter));
        buf.Add((byte)((ID>> 8) & (short)filter));

        int len = 0;
        byte[] nameByteArray = Encoding.UTF8.GetBytes(name);
        len += 4 + 2 + nameByteArray.Lenght ;

        buf.Add((byte)(len & (short)filter));
        buf.Add((byte)((len >> 8) & (short)filter));

        buf.Add((byte)(accountID			//玩家账号数据库唯一ID & (short)filter));
        buf.Add((byte)((accountID			//玩家账号数据库唯一ID >> 8) & (short)filter));
        buf.Add((byte)((accountID			//玩家账号数据库唯一ID >> 16) & (short)filter));
        buf.Add((byte)((accountID			//玩家账号数据库唯一ID >> 24) & (short)filter));

        buf.Add((byte)(nameByteArray.Length & (short)filter));
        buf.Add((byte)((nameByteArray.Length >> 8) & (short)filter));
		for (int i = 0; i < nameByteArray.Length; i++) 
		{
           buf.Add(nameByteArray[i]);
		}

        return buf.ToArray();
    }
}
