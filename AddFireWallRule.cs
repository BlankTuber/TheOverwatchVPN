using NetFwTypeLib;

namespace TheOverwatchVPN
{
    public class AddFireWallRule
    {
        public void AddFWRule(IpAdressEntry entry)
        {
            Type? netFwPolicy2Type = Type.GetTypeFromProgID("HNetCfg.FwPolicy2") ?? throw new InvalidOperationException("FWPolicy2 type not found.");
            INetFwPolicy2? fwPolicy2 = Activator.CreateInstance(netFwPolicy2Type) as INetFwPolicy2 ?? throw new InvalidOperationException("Failed to create FWPolicy2 instance.");
            
            Type? netFwRuleType = Type.GetTypeFromProgID("HNetCfg.FWRule") ?? throw new InvalidOperationException("FWRule type not found.");
            INetFwRule? newRule = Activator.CreateInstance(netFwRuleType) as INetFwRule ?? throw new InvalidOperationException("Failed to create FWRule instance.");
            
            newRule.Name = $"Overwatch_BlockIP_{entry.StartIp}";
            newRule.Description = "Automatically blocked this IP. Added by TheOverwatchVPN";
            newRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_ANY;
            newRule.LocalPorts = "*";
            newRule.RemotePorts = "*";
            newRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            newRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            newRule.Enabled = true;

            if (entry.IsRange)
            {
                newRule.RemoteAddresses = $"{entry.StartIp}-{entry.EndIp}";
            }
            else
            {
                newRule.RemoteAddresses = entry.PrefixLength.HasValue ? $"{entry.StartIp}/{entry.PrefixLength}" : entry.StartIp;
            }

            fwPolicy2.Rules.Add(newRule);
        }

        public void RemoveFWRule(string ruleName)
        {
            Type? netFwPolicy2Type = Type.GetTypeFromProgID("HNetCfg.FwPolicy2") ?? throw new InvalidOperationException("FWPolicy2 type not found.");
            INetFwPolicy2? fwPolicy2 = Activator.CreateInstance(netFwPolicy2Type) as INetFwPolicy2 ?? throw new InvalidOperationException("Failed to create FWPolicy2 instance.");
            
            fwPolicy2.Rules.Remove(ruleName);
        }
    }
}
