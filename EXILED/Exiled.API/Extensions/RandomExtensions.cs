// -----------------------------------------------------------------------
// <copyright file="RandomExtensions.cs" company="ExMod Team">
// Copyright (c) ExMod Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Extensions
{
    using System;

    /// <summary>
    /// A set of extensions for <see cref="Random"/>.
    /// </summary>
    public static class RandomExtensions
    {
        /// <summary>
        /// Generate a random float.
        /// </summary>
        /// <param name="rnd"><see cref="Random"/> object.</param>
        /// <param name="min">Minimum value.</param>
        /// <param name="max">Maximum value.</param>
        /// <returns>Random value between minimum and maximum.</returns>
        public static float NextFloat(this Random rnd, float min, float max)
        {
            return (float)((rnd.NextDouble() * (max - min)) + min);
        }

        /// <summary>
        /// Generate a random float.
        /// </summary>
        /// <param name="rnd"><see cref="Random"/> object.</param>
        /// <param name="min">Minimum value.</param>
        /// <param name="max">Maximum value.</param>
        /// <returns>Random value between minimum and maximum.</returns>
        public static float NextFloat(this Random rnd, double min, float max)
        {
            return (float)((rnd.NextDouble() * (max - min)) + min);
        }

        /// <summary>
        /// Generate a random float.
        /// </summary>
        /// <param name="rnd"><see cref="Random"/> object.</param>
        /// <param name="min">Minimum value.</param>
        /// <param name="max">Maximum value.</param>
        /// <returns>Random value between minimum and maximum.</returns>
        public static float NextFloat(this Random rnd, float min, double max)
        {
            return (float)((rnd.NextDouble() * (max - min)) + min);
        }

        /// <summary>
        /// Generate a random float.
        /// </summary>
        /// <param name="rnd"><see cref="Random"/> object.</param>
        /// <param name="min">Minimum value.</param>
        /// <param name="max">Maximum value.</param>
        /// <returns>Random value between minimum and maximum.</returns>
        public static float NextFloat(this Random rnd, double min, double max)
        {
            return (float)((rnd.NextDouble() * (max - min)) + min);
        }

        /// <summary>
        /// Generate a random bool.
        /// </summary>
        /// <param name="rnd"><see cref="Random"/> object.</param>
        /// <returns>Random boolean value.</returns>
        public static bool NextBool(this Random rnd)
        {
            return (rnd.Next() & 1) == 0;
        }
    }
}
