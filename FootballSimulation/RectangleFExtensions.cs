﻿using System.Diagnostics.Contracts;
using System.Drawing;
using System.Numerics;

namespace FootballSimulation
{
    /// <summary>
    ///     Provides extension methods for the <see cref="RectangleF" /> structure.
    /// </summary>
    public static class RectangleFExtensions
    {
        /// <summary>
        ///     Determines if the specified point is contained within this <see cref="RectangleF" /> structure.
        /// </summary>
        /// <param name="rectangle">The <see cref="RectangleF" /> to test.</param>
        /// <param name="vector">The <see cref="Vector2" /> to test.</param>
        /// <returns>
        ///     This method returns <c>true</c> if the point is contained within this <see cref="RectangleF" /> structure;
        ///     otherwise <c>false</c>.
        /// </returns>
        [Pure]
        public static bool Contains(this RectangleF rectangle, Vector2 vector)
            => rectangle.Contains(vector.X, vector.Y);

        /// <summary>
        ///     Determines if the specified rectangle either intersects or borders this <see cref="RectangleF" /> structure.
        /// </summary>
        /// <param name="rectangle">The <see cref="RectangleF" /> to test.</param>
        /// <param name="other">The other <see cref="RectangleF" /> to test.</param>
        /// <returns>
        ///     This method returns <c>true</c> if the rectangles intersect or border each other; otherwise <c>false</c>.
        /// </returns>
        [Pure]
        public static bool IntersectsOrBorders(this RectangleF rectangle, RectangleF other)
            => other.Left <= rectangle.Right && rectangle.Left <= other.Right &&
               other.Top <= rectangle.Bottom && rectangle.Top <= other.Bottom;
    }
}