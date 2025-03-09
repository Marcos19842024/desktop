using System.Drawing;

namespace Negocio
{
    public static class HexColorExtensions
    {
        public static string ToHex(this Color C) => $"#{C.R:X2}{C.G:X2}{C.B:X2}";
    }
}