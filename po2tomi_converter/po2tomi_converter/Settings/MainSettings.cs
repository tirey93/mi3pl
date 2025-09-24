
namespace po2tomi_converter.Settings
{
    public class MainSettings
    {
        public Mode Mode { get; set; }
        public string PoFileLocation { get; set; }
        public string EngFileLocation { get; set; }
        public string PlFileLocation { get; set; }
    }

    public enum Mode
    {
        ToPo,
        FromPo,
    }
}
