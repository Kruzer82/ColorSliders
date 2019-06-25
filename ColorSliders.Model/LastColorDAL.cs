namespace ColorSliders.Model
{
    public static class LastColorDAL
    {
        public static RGB ReadLastRGB()
        {
            Properties.Settings settings = Properties.Settings.Default;

            return new RGB(settings.LastRed, settings.LastGreen, settings.LastBlue);
        }

        public static void WriteLastRGB(RGB color)
        {
            Properties.Settings settings = Properties.Settings.Default;

            settings.LastRed = color.Red;
            settings.LastGreen = color.Green;
            settings.LastBlue = color.Blue;
            settings.Save();
        }
    }
}
