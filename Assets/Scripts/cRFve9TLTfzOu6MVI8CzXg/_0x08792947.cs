using TMPro;
using UnityEngine;

/// Outline and layout discipline for every label this game builds at runtime.
///
/// Two reasons this is not left to the shared font material. First, that material
/// carries ONE outline colour for the whole app, so a dark face colour drowns in
/// its own rim - each label gets its own material instance with a rim chosen
/// against its own face. Second, TMP word wrap is unpredictable: the same box
/// gives a different number of lines per device, so wrapping is off and every
/// break is written by hand as an escape inside the string.
public static class _0x08792947
{
    /// Readability floor in canvas pixels. Autosize shrinks a line that does not
    /// fit down to exactly this, so it is the size that really ships.
    public const float UiFontFloor = 32f;
    /// Wrap off, autosize on, floor at the readable minimum. A line that will not
    /// fit at the floor gets an explicit break in the string, never a smaller font.
    public static void ApplyLayout(TMP_Text _0x7f35b282, float _0x71ed9916)
    {
        if (_0x7f35b282 == null)
        {
            return;
        }

        _0x7f35b282.enableWordWrapping = false;
        _0x7f35b282.overflowMode = TextOverflowModes.Overflow;
        _0x7f35b282.enableAutoSizing = true;
        _0x7f35b282.fontSizeMin = UiFontFloor;
        _0x7f35b282.fontSizeMax = Mathf.Max(UiFontFloor, _0x71ed9916);
        _0x7f35b282.fontSize = Mathf.Max(UiFontFloor, _0x71ed9916);
    }

    public static void ApplyOutline(TMP_Text _0xad3ce6e1, Color _0x439d77b0)
    {
        if (_0xad3ce6e1 == null)
        {
            return;
        }

        _0xad3ce6e1.color = _0x439d77b0;
        float _0x6d950df5 = (0.299f * _0x439d77b0.r) + (0.587f * _0x439d77b0.g) + (0.114f * _0x439d77b0.b);
        Color _0xc2cf586c = _0x6d950df5 < 0.5f ? _0x50c58425.Pearl : _0x50c58425.Ink;
        Material _0x13bb590f = _0xad3ce6e1.fontMaterial;
        if (_0x13bb590f == null)
        {
            return;
        }

        _0x13bb590f.EnableKeyword(ShaderUtilities.Keyword_Outline);
        _0x13bb590f.SetColor(ShaderUtilities.ID_OutlineColor, _0xc2cf586c);
        _0x13bb590f.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.2f);
        _0x13bb590f.SetFloat(ShaderUtilities.ID_FaceDilate, 0.18f);
    }
}