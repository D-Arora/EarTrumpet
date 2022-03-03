using EarTrumpet.DataModel;

namespace EarTrumpet.Interop
{
    public class SndVolSSO
    {
        public enum IconId
        {
            Muted = 120,
            SpeakerZeroBars = 121,
            SpeakerOneBar = 122,
            SpeakerTwoBars = 123,
            SpeakerThreeBars = 124,
            NoDevice = 125,
        }

        public static string GetPath(IconId icon)
        {
            string iconset = "Light";

            if (SystemSettings.IsSystemLightTheme)
            {
                iconset = "Dark";
            }

            switch (icon)
            {
                case IconId.Muted:
                    return (string)App.Current.Resources[$"MuteIcon{iconset}"];
                case IconId.SpeakerZeroBars:
                    return (string)App.Current.Resources[$"ZeroIcon{iconset}"];
                case IconId.SpeakerOneBar:
                    return (string)App.Current.Resources[$"LowIcon{iconset}"];
                case IconId.SpeakerTwoBars:
                    return (string)App.Current.Resources[$"MediumIcon{iconset}"];
                case IconId.SpeakerThreeBars:
                    return (string)App.Current.Resources[$"HighIcon{iconset}"];
                default:
                    return (string)App.Current.Resources[$"NoneIcon{iconset}"];
            }
        }
    }
}
