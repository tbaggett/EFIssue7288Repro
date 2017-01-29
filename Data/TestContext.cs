using Microsoft.EntityFrameworkCore;
using EFIssue7288Repro.Models;

namespace EFIssue7288Repro.Data
{
    public class TestContext : DbContext
    {
        public DbSet<TestModel> TestModels { get; set; }

        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }
    }
}