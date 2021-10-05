using MyJetWallet.Sdk.Service;
using MyYamlParser;

namespace Service.LkkPool.Settings
{
    public class SettingsModel
    {
        [YamlProperty("LkkPool.SeqServiceUrl")]
        public string SeqServiceUrl { get; set; }

        [YamlProperty("LkkPool.ZipkinUrl")]
        public string ZipkinUrl { get; set; }

        [YamlProperty("LkkPool.ElkLogs")]
        public LogElkSettings ElkLogs { get; set; }
    }
}
