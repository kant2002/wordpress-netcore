// <copyright file="WpPmProMembershipLevel.cs" company="Andrii Kurdiumov">
// Copyright (c) Andrii Kurdiumov. All rights reserved.
// </copyright>

namespace AndriiKurdiumov.Wordpress.EntityFrameworkCore
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Membership level.
    /// </summary>
    public class WpPmProMembershipLevel
    {
        /// <summary>
        /// Gets or sets id of the level.
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of the membership level.
        /// </summary>
        [Column("name")]
        public string Name { get; set; }
    }
}
