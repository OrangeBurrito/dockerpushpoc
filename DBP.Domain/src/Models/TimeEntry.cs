public class TimeEntry {
    public Guid Id { get; set; }
    public DateTimeOffset Date { get; set; }
    public decimal Hours { get; set; }
    public string Note { get; set; } = null!;
} 