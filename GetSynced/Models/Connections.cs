namespace GetSynced.Models
{
    public class Connections
    {
        public string DeviceName { get; set; } = "";
        public List<string> SyncedFiles { get; set; } = new();
    }
}
