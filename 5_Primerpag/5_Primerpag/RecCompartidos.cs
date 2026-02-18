namespace Mod2_UI;
    static class RecCompartidos
    {
        public static readonly Color FontColor = Color.FromRgb(0, 0, 0xFF);
        public static readonly Color BackgroundColor = Color.FromRgb(0xFF, 0xF0, 0xAD);
    }
    public class GlobalFontSizeExtension : IMarkupExtension
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Notes.MiTemaFuente;
        }

    }
