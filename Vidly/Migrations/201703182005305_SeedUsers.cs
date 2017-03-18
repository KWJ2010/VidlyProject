namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'44454d28-9c66-49e3-bd5d-e6797a98d8c4', N'Admin@vidley.com', 0, N'ANci7f7xRgDfH+7eYODm+Zf3WaBdQffaWQsAKuaX4auVw7dSwkmPMZnIStva5HVzWQ==', N'8ec71450-5ad6-4520-bbea-b99723ebee32', NULL, 0, 0, NULL, 1, 0, N'Admin@vidley.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'56cd9981-4a0e-421b-985f-4810dd5b9db1', N'guest@vidley.com', 0, N'AN8Vn3/UlaT8gP5H4FINx5L5ngaMecQkpQxVxDTA48g2JuXDRcwgUjes+Lssp0eaZw==', N'a67d70a2-ca37-4e34-9c45-7ee617956f28', NULL, 0, 0, NULL, 1, 0, N'guest@vidley.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f383a21e-503d-4465-ab01-3648441ecdec', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'44454d28-9c66-49e3-bd5d-e6797a98d8c4', N'f383a21e-503d-4465-ab01-3648441ecdec')
 
");
        }
        
        public override void Down()
        {
        }
    }
}
