using Microsoft.EntityFrameworkCore;

using CsStarter.Data;
using Microsoft.Data.SqlClient;
using System;

namespace CsStarter.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(string connectionString)
        {
            try
            {
                // Validate connection string
                _ = new SqlConnectionStringBuilder(connectionString);
            }
            catch (Exception ex) when 
            (
                ex is System.Collections.Generic.KeyNotFoundException
                or FormatException
                or ArgumentException
            )
            {
                throw new ArgumentException
                (
                    "Invalid connection string. See inner exception",
                    nameof(connectionString),
                    ex
                );
            }

            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }
        public DbSet<Record> Records { get; set; } = null!; // To avoid nullable reference type warnings.
                                                        // Won't actually be null.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
