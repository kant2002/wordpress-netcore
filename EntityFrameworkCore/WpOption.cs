// <copyright file="WpOption.cs" company="Andrii Kurdiumov">
// Copyright (c) Andrii Kurdiumov. All rights reserved.
// </copyright>

namespace AndriiKurdiumov.Wordpress.EntityFrameworkCore
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// WordPress options table.
    /// </summary>
    [Table("wp_options")]
    public class WpOption
    {
        /// <summary>
        /// Gets or sets id of the option.
        /// </summary>
        [Column("option_id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of the option.
        /// </summary>
        [Column("option_name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets value of the option.
        /// </summary>
        [Column("option_value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets autoload value for property.
        /// </summary>
        [Column("autoload")]
        public string Autoload { get; set; }
    }
}
