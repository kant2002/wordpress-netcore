// <copyright file="WpPrefixProvider.cs" company="Andrii Kurdiumov">
// Copyright (c) Andrii Kurdiumov. All rights reserved.
// </copyright>

namespace AndriiKurdiumov.Wordpress.EntityFrameworkCore
{
    /// <summary>
    /// Basic Word Press Prefix provider.
    /// </summary>
    public class WpPrefixProvider : IWpPrefixProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WpPrefixProvider"/> class.
        /// </summary>
        /// <param name="prefix">WordPress table prefix to use.</param>
        public WpPrefixProvider(string prefix = "wp_") => this.WpTablePrefix = prefix;

        /// <inheritdoc />
        public string WpTablePrefix { get; }
    }
}
