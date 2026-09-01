// -----------------------------------------------------------------------
// <copyright file="TimeSpanExtensions.cs" company="ExMod Team">
// Copyright (c) ExMod Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Extensions
{
    using System;

    /// <summary>
    /// A set of extensions for <see cref="TimeSpan"/>.
    /// </summary>
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// Converts a TimeSpan object to a human-readable format.
        /// </summary>
        /// <param name="timeSpan"><see cref="TimeSpan"/> object.</param>
        /// <returns>A <see cref="TimeSpan"/> object in string representation.</returns>
        public static string ToHumanReadable(this TimeSpan timeSpan)
        {
            if (timeSpan.TotalHours < 1)
                return timeSpan.ToString(@"mm\:ss");

            if (timeSpan.TotalDays < 1)
                return timeSpan.ToString(@"hh\:mm\:ss");

            string daysPart = timeSpan.Days == 1 ? "1 day" : $"{timeSpan.Days} days";
            string timePart = timeSpan.ToString(@"hh\:mm\:ss");
            return $"{daysPart}, {timePart}";
        }
    }
}
