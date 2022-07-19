namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public string Convert(string alphabet)
        {

            switch (alphabet)
            {
                case "A": return "LA"; break;
                case "B": return "SI"; break;
                case "C": return "DO"; break;
                case "D": return "RE"; break;
                case "E": return "MI"; break;
                case "F": return "FA"; break;
                case "G": return "SOL"; break;
                default: return string.Empty;

            }

        }

    }
}