using System;
using System.Data.Entity;

public class AppContext: DbContext
{
	public AppContext() : base("AppContext")
    {
	}
	public DbSet<User> Users { get; set; }
}
