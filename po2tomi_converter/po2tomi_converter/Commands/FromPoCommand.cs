
using Microsoft.Extensions.Options;
using po2tab_converter.Utils;
using po2tomi_converter.Settings;
using System.Text;

namespace po2tomi_converter.Commands
{
    public class FromPoCommand
    {
        private readonly MainSettings _settings;

        public FromPoCommand(IOptions<MainSettings> options) 
        {
            _settings = options.Value;
        }

        public void Execute()
        {
            //var errors = string.Empty;
            //if (!File.Exists(_settings.PoFileLocation))
            //    errors += "Error: PoFile was not found in given path\n";
            //if (string.IsNullOrEmpty(_settings.SteamPlFileLocation))
            //    errors += "Error: SteamPlFile was not specified\n";
            //if (string.IsNullOrEmpty(_settings.PlFileLocation))
            //    errors += "Error: GogPlFile was not specified\n";
            //if (!string.IsNullOrEmpty(errors))
            //{
            //    Console.WriteLine(errors);
            //    return;
            //}

            //string file = File.ReadAllText(_settings.PoFileLocation);
            //var splitted = file.Split("msgctxt");

            //var resultSteamPl = new StringBuilder();
            //var resultGogPl = new StringBuilder();
            //var resultSteamOrg = new StringBuilder();
            //var resultGogOrg = new StringBuilder();

            //foreach (var text in splitted)
            //{
            //    if (string.IsNullOrEmpty(text)) continue;
            //    var textWithCuttedStart = "msgctxt" + text;

            //    var splitter = new PoSplitter(textWithCuttedStart);
            //    if (!splitter.IsValid)
            //        continue;

            //    try
            //    {
            //        var markup = splitter.Markup;
            //        var plText = splitter.PlText;
            //        var orgText = splitter.OrgText;

            //        var splittedMarkup = splitter.Markup.Split("_");
            //        var numberSteam = splittedMarkup[0];
            //        var numberGog = splittedMarkup[1];
            //        var sublineNumber = splittedMarkup[2];
            //        var author = splittedMarkup[3];

            //        if (!string.IsNullOrEmpty(numberSteam))
            //        {
            //            var toAppendSteamPl = "";
            //            var toAppendSteamOrg = "";
            //            if (sublineNumber == "0")
            //            {
            //                toAppendSteamPl = $"{numberSteam})  {author}\n{plText}\n";
            //                toAppendSteamOrg = $"{numberSteam})  {author}\n{orgText}\n";
            //            }
            //            else
            //            {
            //                toAppendSteamPl = $"{plText}\n";
            //                toAppendSteamOrg = $"{orgText}\n";
            //            }

            //            resultSteamPl.Append(toAppendSteamPl);
            //            resultSteamOrg.Append(toAppendSteamOrg);
            //        }


            //        if (!string.IsNullOrEmpty(numberGog))
            //        {
            //            var toAppendGogPl = "";
            //            var toAppendGogOrg = "";
            //            if (sublineNumber == "0")
            //            {
            //                toAppendGogPl = $"{numberGog})  {author}\n{plText}\n";
            //                toAppendGogOrg = $"{numberGog})  {author}\n{orgText}\n";
            //            }
            //            else
            //            {
            //                toAppendGogPl = $"{plText}\n";
            //                toAppendGogOrg = $"{orgText}\n";
            //            }


            //            resultGogPl.Append(toAppendGogPl);
            //            resultGogOrg.Append(toAppendGogOrg);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        errors += textWithCuttedStart;
            //        errors += ex.Message;
            //        errors += "\n\n";
            //    }
            //}

            //System.Text.EncodingProvider ppp = System.Text.CodePagesEncodingProvider.Instance;
            //Encoding.RegisterProvider(ppp);
            //if (!string.IsNullOrEmpty(errors))
            //{
            //    File.WriteAllText("errors.txt", errors, Encoding.GetEncoding("windows-1250"));
            //}

            //File.WriteAllText(_settings.SteamPlFileLocation, resultSteamPl.ToString(), Encoding.GetEncoding("windows-1250"));
            //File.WriteAllText(_settings.PlFileLocation, resultGogPl.ToString(), Encoding.GetEncoding("windows-1250"));
            //if (File.Exists(_settings.SteamEngFileLocation))
            //    File.WriteAllText(_settings.SteamEngFileLocation, resultSteamOrg.ToString(), Encoding.GetEncoding("windows-1250"));
            //if (File.Exists(_settings.EngFileLocation))
            //    File.WriteAllText(_settings.EngFileLocation, resultGogOrg.ToString(), Encoding.GetEncoding("windows-1250"));
        }
    }
}
