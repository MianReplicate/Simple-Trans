using rjw;
using Verse;

namespace Simple_Trans;

public static class SimpleTransRJWUtility
{
    public static bool HasPenis(Pawn a)
    {
        return Genital_Helper.has_male_bits(a, a.GetGenitalsList());
    }
    public static bool HasVagina(Pawn a)
    {
        return Genital_Helper.has_vagina(a, a.GetGenitalsList());
    }
}