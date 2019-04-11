// <copyright file="WpUserMeta.cs" company="Andrii Kurdiumov">
// Copyright (c) Andrii Kurdiumov. All rights reserved.
// </copyright>

namespace AndriiKurdiumov.Wordpress.EntityFrameworkCore
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Entity which represetns Wordpress wp_usermeta table.
    /// </summary>
    [Table("wp_usermeta")]
    public class WpUserMeta
    {
        /// <summary>
        /// Gets or sets id of the user metadata row.
        /// </summary>
        [Column("umeta_id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets id of the user.
        /// </summary>
        [Column("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets key of the user metadata.
        /// </summary>
        [Column("meta_key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets value of the metadata
        /// </summary>
        [Column("meta_value")]
        public string Value { get; set; }
    }
}
