using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace TheOverwatchVPN
{
    public class FireWallManager
    {
        private readonly HttpClient httpClient = new HttpClient();
        private readonly AddFireWallRule ruleManager = new AddFireWallRule();

        // Constructor
        public FireWallManager()
        {
            // Initialization, if necessary
        }

        public async Task EnableRegionRules(string region)
        {
            var ipEntries = await FetchIpListsFromGitHub(region);
            foreach (var entry in ipEntries)
            {
                // Use ruleManager, the instance of AddFireWallRule, to add firewall rules
                ruleManager.AddFWRule(entry);  // Note: Assumes AddFWRule is synchronous
            }
        }

        public async Task DisableRegionRules(string region)
        {
            var ipEntries = await FetchIpListsFromGitHub(region);
            foreach (var entry in ipEntries)
            {
                // Similarly, use ruleManager to remove firewall rules
                ruleManager.RemoveFWRule($"Overwatch_BlockIP_{entry.StartIp}");  // Note: Assumes RemoveFWRule is synchronous
            }
        }

        private async Task<List<IpAdressEntry>> FetchIpListsFromGitHub(string region)
        {
            List<IpAdressEntry> entries = new List<IpAdressEntry>();
            string regionFileName = $"{region.ToLower()}.txt";
            string fileUrl = $"https://raw.githubusercontent.com/BlankTuber/TheOverwatchVPN/master/ipLists/{regionFileName}";

            MessageBox.Show(fileUrl, "File URL", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string fileContent = await httpClient.GetStringAsync(fileUrl);

            var lines = fileContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var entry = ParseLineToIpAddressEntry(line);
                if (entry != null)
                {
                    entries.Add(entry);
                }
            }

            return entries;
        }

        private IpAdressEntry ParseLineToIpAddressEntry(string line)
        {
            // Check if the line is an IP range (e.g., "192.168.1.1-192.168.1.255")
            if (line.Contains('-'))
            {
                var parts = line.Split('-');
                if (parts.Length == 2 && IsValidIp(parts[0]) && IsValidIp(parts[1]))
                {
                    return new IpAdressEntry(parts[0], parts[1]);
                }
            }
            // Check if the line is a single IP or CIDR notation (e.g., "192.168.1.1" or "192.168.1.1/24")
            else
            {
                string[] cidrParts = line.Split('/');
                string ipPart = cidrParts[0];
                int? prefixLength = null;

                if (cidrParts.Length == 2 && int.TryParse(cidrParts[1], out int length))
                {
                    prefixLength = length;
                }

                if (IsValidIp(ipPart))
                {
                    return new IpAdressEntry(ipPart, null, prefixLength);
                }
            }

            // If the line doesn't match any known format, return null
            return null;
        }

        private bool IsValidIp(string ip)
        {
            return IPAddress.TryParse(ip, out _);
        }
    }
}