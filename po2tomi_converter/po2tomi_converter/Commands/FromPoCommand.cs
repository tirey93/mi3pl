
using Microsoft.Extensions.Options;
using po2tab_converter.Utils;
using po2tomi_converter.Settings;
using System.Text;

namespace po2tomi_converter.Commands
{
    public class FromPoCommand
    {
        private readonly MainSettings _settings;
        public bool HasErrors { get; set; }

        public FromPoCommand(IOptions<MainSettings> options) 
        {
            _settings = options.Value;

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            _settings = options.Value;

            var errors = string.Empty;
            if (!File.Exists(_settings.PoFileLocation))
                errors += "Error: PoFileLocation was not found in given path\n";
            if (!string.IsNullOrEmpty(errors))
            {
                Console.WriteLine(errors);
                HasErrors = true;
                return;
            }
        }

        public void Execute()
        {
            string file = File.ReadAllText(_settings.PoFileLocation);
            var splitted = file.Split("msgctxt");

            string result = "";
            string errors = "";

            foreach (var text in splitted)
            {
                if (string.IsNullOrEmpty(text)) continue;
                var textWithCuttedStart = "msgctxt" + text;

                var splitter = new PoSplitter(textWithCuttedStart);
                if (!splitter.IsValid)
                    continue;

                try
                {
                    var markup = splitter.Markup;
                    string textTarget = markup;
                    var plText = splitter.PlText;
                    if (!string.IsNullOrEmpty(plText))
                    {
                        textTarget = plText;
                    }
                    else if (!string.IsNullOrEmpty(splitter.OrgText))
                    {
                        textTarget = splitter.OrgText;
                    }

                    result += markup + "\t" + textTarget + "\r\n";
                }
                catch (Exception ex)
                {
                    errors += textWithCuttedStart;
                    errors += ex.Message;
                    errors += "\n\n";
                }
            }

            File.WriteAllText(_settings.PlFileLocation, result);
        }
    }
}
