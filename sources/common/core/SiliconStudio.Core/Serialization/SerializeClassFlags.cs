﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
using System;

namespace SiliconStudio.Core.Serialization
{
    /// <summary>
    /// Specifies flags used when serializing reference types.
    /// </summary>
    [Flags]
    public enum SerializeClassFlags
    {
        /// <summary>
        /// Default value.
        /// </summary>
        None = 0,
        /// <summary>
        /// Specifies that the object is null.
        /// </summary>
        IsNull = 1,
        /// <summary>
        /// Specifies that additional type info is necessary and is stored in the stream.
        /// </summary>
        IsTypeInfo = 2,
        /// <summary>
        /// Specifies that the object has already been serialized previously in the stream, and is only stored as an index.
        /// </summary>
        IsReference = 4,
    }
}