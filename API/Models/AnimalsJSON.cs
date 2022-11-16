using System.Collections.ObjectModel;

namespace SeleniumApp1.API.Models
{

    public class Animals
    {
        public int? Count { get; init; }
        public Collection<Entry>? Entry { get; init; }


    }

    public class Entry
    {
        public string? API { get; set; }
        public string? Description { get; set; }
        public string? Auth { get; set; }
        public bool? HTTPS { get; set; }
        public string? Cors { get; set; }
        public string? Link { get; set; }
        public string? Category { get; set; }
    }

}