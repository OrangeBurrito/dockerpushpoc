public class TimeEntryService {
    public List<TimeEntry> GetTimeEntries() => new List<TimeEntry> {
        // generate fake entries
        new TimeEntry { Id = Guid.NewGuid(), Date = DateTimeOffset.Now.AddDays(-1), Hours = 1.5m, Note = "Docker Push" },
        new TimeEntry { Id = Guid.NewGuid(), Date = DateTimeOffset.Now.Date, Hours = 2, Note = "Worked on the new API" },
    };
}