namespace TheOverwatchVPN
{
    public class IpAdressEntry
    {
        public string StartIp { get; set; }
        public string? EndIp { get; set; }
        public int? PrefixLength { get; set; }
        public bool IsRange => EndIp != null;

        public IpAdressEntry(string startIp, string? endIp = null, int? prefixLength = null)
        {
            StartIp = startIp;
            EndIp = endIp;
            PrefixLength = prefixLength;
        }
    }
}
