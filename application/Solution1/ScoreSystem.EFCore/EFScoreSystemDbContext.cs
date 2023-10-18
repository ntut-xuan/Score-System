using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScoreSystem.EFCore;

public class EFScoreSystemDbContext : DbContext
{
    public DbSet<ScoreRecord> ScoreRecords { get; set; }
    public string DbPath { get; }

    public EFScoreSystemDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "ScoreSystem.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

[PrimaryKey(nameof(RecordId), nameof(Suite))]
public class ScoreRecord
{
    public string User { get; set; }
    public string Title { get; set; }
    public Guid RecordId { get; set; }
    public string Suite { get; set; }
    public int Passed { get; set; }
    public int Failed { get; set; }
    public int Score { get; set; }
    
    public DateTime CreateTime { get; set; }
}