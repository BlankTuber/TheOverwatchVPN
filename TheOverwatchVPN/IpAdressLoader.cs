using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace TheOverwatchVPN
{
    public class IpAdressLoader
    {
        private static readonly Regex cidrPattern = new Regex(@"^(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})/(\d{1,2})$");
        private static readonly Regex rangePattern = new Regex(@"^(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})-(\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3})$");

        public static List<IpAdressEntry> LoadIpAdresses(string filePath)
        {
            var ipEntries = new List<IpAdressEntry>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var cidrMatch = cidrPattern.Match(line);
                var rangeMatch = rangePattern.Match(line);

                if (cidrMatch.Success)
                {
                    string ip = cidrMatch.Groups[1].Value;
                    int prefixLenght = int.Parse(cidrMatch.Groups[2].Value);
                    ipEntries.Add(new IpAdressEntry(ip, null, prefixLenght));
                }
                else if (rangeMatch.Success)
                {
                    string startIp = rangeMatch.Groups[1].Value;
                    string endIp = rangeMatch.Groups[2].Value;
                    ipEntries.Add(new IpAdressEntry(startIp, endIp, null));
                }
                else
                {
                    Console.WriteLine($"Invalid IP format: {line}");
                }
            }
            return ipEntries;
        }
    }
}
