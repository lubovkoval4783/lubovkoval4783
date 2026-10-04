using UnityEngine;

/// The one palette every screen of this game reads from: stage, panels, pops,
/// world sprites and the splash bar. Keeping it in a single place is what stops
/// the menu and the run from drifting apart.
///
/// Text colours are not interchangeable with fill colours here. The shared font
/// material carries ONE outline colour (Ink), so a face colour close to it turns
/// the glyph into a blob. Ruby and Amethyst are fills only; Rose is the light
/// stand-in wherever a warning needs to be spelled out in words.
public static class _0x50c58425
{
    /// The splash bar track: stage black at an alpha you can actually see.
    public static readonly Color TrackDark = new Color(0.086f, 0.067f, 0.118f, 0.85f);
    /// #7740B1 - stage glow, gem 1. FILL ONLY, never a text colour.
    public static readonly Color Amethyst = new Color(0.467f, 0.251f, 0.694f, 1f);
    /// #34B8AA - accuracy, progress, gem 4.
    public static readonly Color Jade = new Color(0.204f, 0.722f, 0.667f, 1f);
    /// #9C8FB5 - secondary captions.
    public static readonly Color Muted = new Color(0.612f, 0.561f, 0.710f, 1f);
    public static Color WithAlpha(Color _0xc3746be4, float _0x9cd9ab65)
    {
        return new Color(_0xc3746be4.r, _0xc3746be4.g, _0xc3746be4.b, _0x9cd9ab65);
    }

    /// #F1C24A - the accent of every action, the strong beat, gem 3.
    public static readonly Color Topaz = new Color(0.945f, 0.761f, 0.290f, 1f);
    /// #FF7EA3 - lightened ruby: the only warm colour that is legible as text.
    public static readonly Color Rose = new Color(1f, 0.494f, 0.639f, 1f);
    /// Colour of gem 0..4 along the arc, left to right. One gem is always one
    /// colour, in the menu preview and in the run alike.
    public static Color Gem(int _0xa867aae8)
    {
        int _0x5aeccec7 = ((_0xa867aae8 % 5) + 5) % 5;
        if (_0x5aeccec7 == 0)
        {
            return Amethyst;
        }

        if (_0x5aeccec7 == 1)
        {
            return Ruby;
        }

        if (_0x5aeccec7 == 2)
        {
            return Topaz;
        }

        if (_0x5aeccec7 == 3)
        {
            return Jade;
        }

        return Pearl;
    }

    /// #DA3B69 - gem 2, pressed state. FILL ONLY, never a text colour.
    public static readonly Color Ruby = new Color(0.855f, 0.231f, 0.412f, 1f);
    /// #1E1630 - card and panel body.
    public static readonly Color Surface = new Color(0.118f, 0.086f, 0.188f, 1f);
    /// #2A2138 - the raised edge of a card.
    public static readonly Color SurfaceEdge = new Color(0.165f, 0.129f, 0.220f, 1f);
    /// #16111E - stage black, also the outline colour of every label.
    public static readonly Color Ink = new Color(0.086f, 0.067f, 0.118f, 1f);
    /// #F5EADB - the pearl star gem and the default text colour.
    public static readonly Color Pearl = new Color(0.961f, 0.918f, 0.859f, 1f);
}