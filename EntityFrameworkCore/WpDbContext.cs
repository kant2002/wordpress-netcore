// <copyright file="WpDbContext.cs" company="Andrii Kurdiumov">
// Copyright (c) Andrii Kurdiumov. All rights reserved.
// </copyright>

namespace AndriiKurdiumov.Wordpress.EntityFrameworkCore
{
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Database context for the Word Press application.
    /// </summary>
    public class WpDbContext : DbContext
    {
        private readonly string tablePrefix;

        /// <summary>
        /// Initializes a new instance of the <see cref="WpDbContext"/> class.
        /// </summary>
        /// <param name="options">Database context options.</param>
        /// <param name="wpPrefixProvider">Wordpress table prefix provider</param>
        public WpDbContext(DbContextOptions<WpDbContext> options, IWpPrefixProvider wpPrefixProvider)
            : base(options)
        {
            this.tablePrefix = wpPrefixProvider?.WpTablePrefix ?? "wp_";
        }

        /// <summary>
        /// Gets or sets set of WordPress options.
        /// </summary>
        public DbSet<WpOption> WpOptions { get; set; }

        /// <summary>
        /// Gets or sets set of WordPress user metadata.
        /// </summary>
        public DbSet<WpUserMeta> WpUserMetas { get; set; }

        /// <summary>
        /// Gets or sets set of WordPress user metadata.
        /// </summary>
        public DbSet<WpPmProMembershipUser> WpPmProMembershipUsers { get; set; }

        /// <summary>
        /// Gets or sets set of WordPress user metadata.
        /// </summary>
        public DbSet<WpPmProMembershipLevel> WpPmProMembershipLevels { get; set; }

        /// <summary>
        /// Override this method to further configure the model that was discovered by
        /// convention from the entity types exposed in <see cref="DbSet{TEntity}"/>
        /// properties on your derived context. The resulting model may be cached and
        /// re-used for subsequent instances of your derived context
        /// </summary>
        /// <param name="modelBuilder">
        /// The builder being used to construct the model for this context. Databases
        /// (and other extensions) typically define extension methods on this object
        /// that allow you to configure aspects of the model that are specific
        /// to a given database
        /// </param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<WpOption>()
                .ToTable(this.tablePrefix + "options");
            modelBuilder.Entity<WpUserMeta>()
                .ToTable(this.tablePrefix + "usermeta");
            modelBuilder.Entity<WpPmProMembershipUser>()
                .ToTable(this.tablePrefix + "pmpro_memberships_users");
            modelBuilder.Entity<WpPmProMembershipLevel>()
                .ToTable(this.tablePrefix + "pmpro_membership_levels");
        }
    }
}
