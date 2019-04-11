// <copyright file="WpPmProMembershipUser.cs" company="Andrii Kurdiumov">
// Copyright (c) Andrii Kurdiumov. All rights reserved.
// </copyright>

namespace AndriiKurdiumov.Wordpress.EntityFrameworkCore
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Membership users.
    /// </summary>
    public class WpPmProMembershipUser
    {
        /// <summary>
        /// Gets or sets id of the membership user registration
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets status of the user's id.
        /// </summary>
        [Column("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets status of the user's membership level.
        /// </summary>
        [Column("membership_id")]
        public int MembershipId { get; set; }

        /// <summary>
        /// Gets or sets status of the user's membership level.
        /// </summary>
        [Column("status")]
        public string Status { get; set; }
    }
}
