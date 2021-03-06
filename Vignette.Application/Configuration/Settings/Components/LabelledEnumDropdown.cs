﻿// Copyright 2020 - 2021 Vignette Project
// Licensed under NPOSLv3. See LICENSE for details.

using System;
using osu.Framework.Graphics;
using Vignette.Application.Graphics.Interface;

namespace Vignette.Application.Configuration.Settings.Components
{
    public class LabelledEnumDropdown<T> : LabelledDropdown<T>
        where T : struct, Enum
    {
        protected override Drawable CreateControl() => new VignetteEnumDropdown<T>();
    }
}
