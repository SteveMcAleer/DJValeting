namespace DJValeting.Constants
{
    public static class VehicleSize
    {
        public const string Small = "small";
        public const string Medium = "medium";
        public const string Large = "large";
        public const string Van = "van";

        public static string GetDisplayText(string value)
        {
            string text = "";

            switch (value)
            {
                case Small:
                    text = "Small";
                    break;
                case Medium:
                    text = "Medium";
                    break;
                case Large:
                    text = "Large";
                    break;
                case Van:
                    text = "Van";
                    break;
            }

            return text;
        }
    }
}