// <copyright file="IWpPrefixProvider.cs" company="Andrii Kurdiumov">
// Copyright (c) Andrii Kurdiumov. All rights reserved.
// </copyright>

namespace AndriiKurdiumov.Wordpress.EntityFrameworkCore
{
    /// <summary>
    /// Provides information about Word Press schema table.
    /// </summary>
    public interface IWpPrefixProvider
    {
        /// <summary>
        /// Gets table prefix for Word Press.
        /// </summary>
        string WpTablePrefix { get; }
    }
}
