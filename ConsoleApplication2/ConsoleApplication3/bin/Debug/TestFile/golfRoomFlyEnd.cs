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



public class golfRoomFlyEnd : PackageBase
{
    
    public short ID = 307;
    
    public float x;
    
    public float y;
    
    public float z;
    
    public override byte[] Create()
    {
        buf.Add((byte)(ID & (short)filter));
        buf.Add((byte)((ID>> 8) & (short)filter));

        int len = 0;
        len +=  4 + 4 + 4 ;

        buf.Add((byte)(len & (short)filter));
        buf.Add((byte)((len >> 8) & (short)filter));

        byte[] byx = BitConverter.GetBytes(x);
		for (int m = 0; m < byx.Length; m++) 
		{
           buf.Add(byx[m]);
		}

        byte[] byy = BitConverter.GetBytes(y);
		for (int m = 0; m < byy.Length; m++) 
		{
           buf.Add(byy[m]);
		}

        byte[] byz = BitConverter.GetBytes(z);
		for (int m = 0; m < byz.Length; m++) 
		{
           buf.Add(byz[m]);
		}

        return buf.ToArray();
    }
}
