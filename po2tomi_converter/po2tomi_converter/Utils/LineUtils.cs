using po2tomi_converter.Dtos;
using System.Text;
using System.Text.RegularExpressions;

namespace po2tomi_converter.Utils
{
    public class LineUtils
    {
        public static IEnumerable<Line> LoadLines(string fileLocation)
        {
            string fileEn = File.ReadAllText(fileLocation, Encoding.GetEncoding("windows-1250"));
            string[] linesEn = fileEn.Split("\r\n");
            var listEn = linesEn.Select(x => new Line(x)).Where(x => x.Markup != null);

            return listEn;
        }
    }
}
