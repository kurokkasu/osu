﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System.Collections.Generic;
using osu.Game.Rulesets.Objects.Drawables;
using OpenTK;

namespace osu.Game.Rulesets.UI.Scrolling.Visualisers
{
    public interface ISpeedChangeVisualiser
    {
        /// <summary>
        /// Computes the states of <see cref="DrawableHitObject"/>s that remain constant while scrolling, such as lifetime and spatial length.
        /// This is invoked once whenever <paramref name="timeRange"/> or <paramref name="length"/> changes.
        /// </summary>
        /// <param name="hitObjects">The <see cref="DrawableHitObject"/>s whose states should be computed.</param>
        /// <param name="direction">The scrolling direction.</param>
        /// <param name="timeRange">The duration required to scroll through one length of the screen before any speed adjustments.</param>
        /// <param name="length">The length of the screen that is scrolled through.</param>
        void ComputeInitialStates(IEnumerable<DrawableHitObject> hitObjects, ScrollingDirection direction, double timeRange, Vector2 length);

        /// <summary>
        /// Updates the positions of <see cref="DrawableHitObject"/>s, depending on the current time. This is invoked once per frame.
        /// </summary>
        /// <param name="hitObjects">The <see cref="DrawableHitObject"/>s whose positions should be computed.</param>
        /// <param name="direction">The scrolling direction.</param>
        /// <param name="currentTime">The current time.</param>
        /// <param name="timeRange">The duration required to scroll through one length of the screen before any speed adjustments.</param>
        /// <param name="length">The length of the screen that is scrolled through.</param>
        void UpdatePositions(IEnumerable<DrawableHitObject> hitObjects, ScrollingDirection direction, double currentTime, double timeRange, Vector2 length);
    }
}
