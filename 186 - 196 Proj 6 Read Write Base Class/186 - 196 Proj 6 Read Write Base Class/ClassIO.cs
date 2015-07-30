using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassIO
{
    

    public class Reader : BaseIO
    {
        /// <summary>
        /// //create a reader to read a file.
        /// </summary>
        /// <param name="path">The path to the file to read.</param>
        public Reader(string path)
        {
            br = new BinaryReader(File.OpenRead(path));
            this.byteorder = ByteOrder.BigEndian;
        }
        /// <summary>
        /// //create a reader to read a file.
        /// </summary>
        /// <param name="path">The path to the file to read.</param>
        /// <param name="bo">The order of the bytes to read</param>
        public Reader(string path, ByteOrder bo)
        {
            br = new BinaryReader(File.OpenRead(path));
            this.byteorder = bo;
        }

        BinaryReader br;//use the constructor to pass

        public long Position
        {
            get { return br.BaseStream.Position; }
            set { br.BaseStream.Position = value; }
        }

        /// <summary>
        /// Advance reader
        /// </summary>
        /// <returns></returns>
        public byte ReadByte()
        {
            return br.ReadByte();
        }

        public sbyte ReadSByte()
        {
            return (sbyte)br.ReadByte();
        }

        public short ReadInt16()
        {
            short myShort = br.ReadInt16();//65 78 default little endian
            if (byteorder == ByteOrder.BigEndian)
            {
                byte[] buff = BitConverter.GetBytes(myShort);
                Array.Reverse(buff);
                myShort = BitConverter.ToInt16(buff, 0);//78 65 big endian
            }
            return myShort;
            }

        public ushort ReadUInt16()
        {
            ushort myuShort = br.ReadUInt16();//65 78 default little endian
            if (byteorder == ByteOrder.BigEndian)
            {
                byte[] buff = BitConverter.GetBytes(myuShort);
                Array.Reverse(buff);
                myuShort = BitConverter.ToUInt16(buff, 0);//78 65 big endian
            }
            return myuShort;
        }

        public int ReadInt32()
        {
            int myShort = br.ReadInt32();//65 78 default little endian
            if (byteorder == ByteOrder.BigEndian)
            {
                byte[] buff = BitConverter.GetBytes(myShort);
                Array.Reverse(buff);
                myShort = BitConverter.ToInt16(buff, 0);//78 65 big endian
            }
            return myShort;
        }

        public uint ReaduInt32()
        {
            uint myuShort = br.ReadUInt32();//65 78 default little endian
            if (byteorder == ByteOrder.BigEndian)
            {
                byte[] buff = BitConverter.GetBytes(myuShort);
                Array.Reverse(buff);
                myuShort = BitConverter.ToUInt32(buff, 0);//78 65 big endian
            }
            return myuShort;
        }

        public int ReadInt64()
        {
            long myLong = br.ReadInt64();//65 78 default little endian
            if (byteorder == ByteOrder.BigEndian)
            {
                byte[] buff = BitConverter.GetBytes(myLong);
                Array.Reverse(buff);
                myLong = BitConverter.ToInt64(buff, 0); //78 65 big endian
            }
            return myLong;
        }
            
    }

    public abstract class BaseIO
    {
        //can't inherite from any other than public
        public enum ByteOrder
        { 
            BigEndian,
            LittleEndian
        }

        //create variable, use in this class and derived.
        protected ByteOrder byteorder;

    }
}
