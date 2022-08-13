﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using Silk.NET.Core;
using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    public interface INativeGLSurface : ISurface
    {
        /// <summary>
        /// the GL Handle
        /// </summary>
        nint Handle { get; }
        /// <summary>
        /// Whether this is the currently running context on this thread
        /// </summary>
        bool IsContextCurrent { get; set; }
        /// <summary>
        /// Should the buffers swap immediately upon completion?
        /// </summary>
        bool ShouldSwapAutomatically { get; set; }
        
        /// <summary>
        /// Sets the number of vertical blanks to wait between calling <see cref="SwapBuffers" /> and presenting the image,
        /// a.k.a vertical synchronization (V-Sync). Set to <c>1</c> to enable V-Sync.
        /// </summary>
        /// <remarks>
        /// Due to platform restrictions, this value can only be set and not retrieved.
        /// </remarks>
        int SwapInterval { set; }

        /// <summary>
        /// Preferred depth buffer bits of the window's framebuffer.
        /// </summary>
        /// <remarks>
        /// Pass <c>null</c> or <c>-1</c> to use the system default. 
        /// </remarks>
        int? PreferredDepthBufferBits { get; set; }

        /// <summary>
        /// Preferred stencil buffer bits of the window's framebuffer.
        /// </summary>
        /// <remarks>
        /// Pass <c>null</c> or <c>-1</c> to use the system default. 
        /// </remarks>
        int? PreferredStencilBufferBits { get; set; }
        
        /// <summary>
        /// Preferred red, green, blue, and alpha bits of the window's framebuffer.
        /// </summary>
        /// <remarks>
        /// Pass <c>null</c> or <c>-1</c> for any of the channels to use the system default. 
        /// </remarks>
        Vector4D<int>? PreferredBitDepth { get; set; }
        
        /// <summary>
        /// The API version to use.
        /// </summary>
        Version32? ApiVersion { get; set; }

        nint? GetProcAddress(string proc);
        void SwapBuffers();
    }
}