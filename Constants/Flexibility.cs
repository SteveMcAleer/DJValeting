namespace DJValeting.Constants
{
    public static class Flexibility
    {
        public const string OneDay = "one-day";
        public const string TwoDays = "two-days";
        public const string ThreeDays = "three-days";

        public static string GetDisplayText(string value)
        {
            string text = "";

            switch (value)
            {
                case OneDay:
                    text = "+/- 1 Day";
                    break;
                case TwoDays:
                    text = "+/- 2 Days";
                    break;
                case ThreeDays:
                    text = "+/- 3 Days";
                    break;
            }

            return text;
        }
    }
}