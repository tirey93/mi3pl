
using Microsoft.Extensions.Options;
using po2tomi_converter.Settings;
using System.Text;
using po2tomi_converter.Dtos;
using po2tomi_converter.Utils;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace po2tomi_converter.Commands
{
    public class ToPoCommand
    {
        private readonly MainSettings _settings;
        private readonly Dictionary<int, Line> _dictEngSteam;
        private readonly List<Line> _linesEng;
        private readonly Dictionary<string, Line> _dictPl;

        public bool HasErrors { get; set; }

        public ToPoCommand(IOptions<MainSettings> options) 
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            _settings = options.Value;

            var errors = string.Empty;
            if (!File.Exists(_settings.PlFileLocation))
                errors += "Error: GogPlFile was not found in given path\n";
            if (!File.Exists(_settings.EngFileLocation))
                errors += "Error: GogEngFile was not found in given path\n";
            if (!string.IsNullOrEmpty(errors))
            {
                Console.WriteLine(errors);
                HasErrors = true;
                return;
            }

            _linesEng = [.. LineUtils.LoadLines(_settings.EngFileLocation)];
            _dictPl = LineUtils.LoadLines(_settings.PlFileLocation)
                .ToDictionary(x => x.Markup, y => y);
        }

        public void Execute()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var line in _linesEng)
            {
                if (_dictPl.TryGetValue(line.Markup, out var plStr)) 
                {
                    sb.AppendLine(ToPo(line.Markup, line.Contents, plStr.Contents));
                }
                else
                {
                    sb.AppendLine(ToPo(line.Markup, line.Contents, line.Contents));
                }
            }

            File.WriteAllText(_settings.PoFileLocation, sb.ToString());
        }

        private static string ToPo(string markup, string engStr, string plStr)
        {
            var result = $"msgctxt \"{markup}\"\n";
            result += $"msgid \"{engStr}\"\n";
            result += $"msgstr \"{plStr}\"\n\n";

            return result;
        }
    }
}
