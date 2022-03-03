using System;

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
            switch (icon)
            {
                case IconId.Muted:
                    return (string)App.Current.Resources["MuteIconDark"];
                case IconId.SpeakerZeroBars:
                    return (string)App.Current.Resources["ZeroIconDark"];
                case IconId.SpeakerOneBar:
                    return (string)App.Current.Resources["LowIconDark"];
                case IconId.SpeakerTwoBars:
                    return (string)App.Current.Resources["MediumIconDark"];
                case IconId.SpeakerThreeBars:
                    return (string)App.Current.Resources["HighIconDark"];
                default:
                    return (string)App.Current.Resources["NoneIconDark"];
            }
        }
    }
}
