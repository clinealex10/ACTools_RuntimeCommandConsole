using UnityEngine;

public static class ColorExtensions
{
    /// <summary> Changes the alpha value of this color to a given value. </summary>
    /// <param name="original"> This color. </param>
    /// <param name="alphaValue"> The alpha value this color will receive. </param>
    public static void ChangeAlphaTo(this ref Color original, float alphaValue)
    {
        original.a = alphaValue;
    }

    /// <summary> Gives the hex code of a color. </summary>
    /// <param name="original"> This color. </param>
    /// <returns> The hex code of this color. </returns>
    public static string ToHex(this Color original)
    {
        return "#" + ColorUtility.ToHtmlStringRGBA(original);
    }
}