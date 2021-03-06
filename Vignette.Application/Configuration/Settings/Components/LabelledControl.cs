﻿// Copyright 2020 - 2021 Vignette Project
// Licensed under NPOSLv3. See LICENSE for details.

using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.UserInterface;
using osuTK;
using Vignette.Application.Graphics;
using Vignette.Application.Graphics.Sprites;
using Vignette.Application.Graphics.Themes;

namespace Vignette.Application.Configuration.Settings.Components
{
    public abstract class LabelledControl<T> : FillFlowContainer, IHasCurrentValue<T>
    {
        private VignetteSpriteText label;

        private IHasCurrentValue<T> controlWithCurrent => Control as IHasCurrentValue<T>;

        protected Drawable Control;

        public string Label
        {
            get => label?.Text ?? string.Empty;
            set
            {
                if (label == null)
                {
                    Insert(-1, label = new VignetteSpriteText
                    {
                        Font = VignetteFont.SemiBold.With(size: 12),
                        ThemeColour = ThemeColour.NeutralPrimary,
                    });
                }

                label.Text = value;
            }
        }

        public Bindable<T> Current
        {
            get => controlWithCurrent.Current;
            set => controlWithCurrent.Current = value;
        }

        public LabelledControl()
        {
            Width = 200;
            Spacing = new Vector2(0, 5);
            AutoSizeAxes = Axes.Y;
            InternalChild = Control = CreateControl().With(d =>
            {
                d.RelativeSizeAxes = Axes.X;
            });
        }

        protected abstract Drawable CreateControl();
    }
}
