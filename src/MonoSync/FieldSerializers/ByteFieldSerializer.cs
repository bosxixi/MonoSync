﻿using System;
using MonoSync.Utils;

namespace MonoSync.FieldSerializers
{
    public class ByteFieldSerializer : FieldSerializer<byte>
    {
        public override void Write(byte value, ExtendedBinaryWriter writer)
        {
            writer.Write(value);
        }

        public override void Read(ExtendedBinaryReader reader, Action<byte> synchronizationCallback)
        {
            synchronizationCallback(reader.ReadByte());
        }

        public override byte Interpolate(byte source, byte target, float factor)
        {
            return (byte) (source + (target - source) * factor);
        }
    }
}