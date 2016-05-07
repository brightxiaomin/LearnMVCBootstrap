namespace MVCBootstrap.Migrations
{
    using MVCBootstrap.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCBootstrap.Models.SiteDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVCBootstrap.Models.SiteDataContext";
        }

        protected override void Seed(MVCBootstrap.Models.SiteDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Notifications.AddOrUpdate(notification => notification.Title,
                new Notification
                {
                    Title = "John Smith was added to the system.",
                    NotificationType = NotificationType.Registration
                },
                new Notification
                {
                    Title = "Susan Peters was added to the system.",
                    NotificationType = NotificationType.Registration
                },
                new Notification
                {
                    Title = "Just an FYI on Thursday's meeting",
                    NotificationType = NotificationType.Email
                });
        }
    }
}
