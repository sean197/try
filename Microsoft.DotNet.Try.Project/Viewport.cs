﻿using System;
using Microsoft.CodeAnalysis.Text;
using Microsoft.DotNet.Try.Protocol;

namespace Microsoft.DotNet.Try.Project
{
    public class Viewport
    {
        public Viewport(SourceFile destination, TextSpan region, TextSpan outerRegion, BufferId bufferId)
        {

            Region = region;
            BufferId = bufferId;
            OuterRegion = outerRegion;
            Destination = destination ?? throw new ArgumentNullException(nameof(destination));
        }

        public BufferId BufferId { get; }

        public TextSpan OuterRegion { get; }

        public TextSpan Region { get; }

        public SourceFile Destination { get; }

    }
}