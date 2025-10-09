namespace po2tomi_converter.Dtos
{
    public class Line
    {
        public string Markup { get; set; }
        public string Contents { get; set; }

        public Line(string line)
        {
            var splitted = line.Split('\t');
            if (splitted.Length != 2)
                return;
            Markup = splitted[0].ToUpper();
            Contents = splitted[1];
        }
    }
}
