﻿using System;
using MonoSync.Utils;

namespace MonoSync.Serializers
{
    public class SingleSerializer : Serializer<float>
    {
        public override void Write(float value, ExtendedBinaryWriter writer)
        {
            writer.Write(value);
        }

        public override void Read(ExtendedBinaryReader reader, Action<float> synchronizationCallback)
        {
            synchronizationCallback(reader.ReadSingle());
        }

        public override float Interpolate(float source, float target, float factor)
        {
            return source + (target - source) * factor;
        }
    }
}