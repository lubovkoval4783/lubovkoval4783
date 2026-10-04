using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x87944755 : MonoBehaviour
{
    private readonly List<TMP_Text> _0x6754a532 = new List<TMP_Text>();
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x331d52c1(Object _0xcfc79559)
    {
        TMP_Text _0x378d5478 = _0xcfc79559 as TMP_Text;
        if (_0x378d5478 != null)
            this._0xb1d8da67.Add(_0x378d5478);
    }

    private void LateUpdate()
    {
        if (this._0xb1d8da67.Count == 0)
            return;
        this._0x6754a532.Clear();
        this._0x6754a532.AddRange(this._0xb1d8da67);
        this._0xb1d8da67.Clear();
        for (int _0x60f0a0bf = 0; _0x60f0a0bf < this._0x6754a532.Count; _0x60f0a0bf++)
            Fix(this._0x6754a532[_0x60f0a0bf]);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x41be745f != null)
            return;
        GameObject _0x767d5946 = new GameObject(_0xfcba392b._0x7114801f(new byte[16] { 31, 38, 59, 8, 36, 37, 63, 57, 42, 56, 63, 12, 62, 42, 57, 47 }, 75));
        _0x767d5946.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x767d5946);
        _0x41be745f = _0x767d5946.AddComponent<_0x87944755>();
    }

    private readonly HashSet<TMP_Text> _0xb1d8da67 = new HashSet<TMP_Text>();
    private static void Fix(TMP_Text _0xe0aaf0ad)
    {
        if (_0xe0aaf0ad == null || !_0xe0aaf0ad.isActiveAndEnabled)
            return;
        Material _0x4fc0677c = _0xe0aaf0ad.fontSharedMaterial;
        if (_0x4fc0677c == null || !_0x4fc0677c.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x4fc0677c.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x4fc0677c.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x79174f89 = _0xe0aaf0ad.color;
        if (_0x79174f89.a <= 0f)
            return;
        Color _0x632dc616 = _0x4fc0677c.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x79174f89, _0x632dc616) >= MinRatio)
            return;
        Color _0xe732453e = Luminance(_0x632dc616) < 0.5f ? Color.white : Color.black;
        Color _0x734020b8;
        if (Ratio(_0xe732453e, _0x632dc616) < TargetRatio)
        {
            _0x734020b8 = _0xe732453e;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x2c2b9d47 = 0f;
            float _0x1bd685c8 = 1f;
            for (int _0x70c8ed1c = 0; _0x70c8ed1c < 20; _0x70c8ed1c++)
            {
                float _0xfd9b521f = (_0x2c2b9d47 + _0x1bd685c8) * 0.5f;
                if (Ratio(Color.Lerp(_0x79174f89, _0xe732453e, _0xfd9b521f), _0x632dc616) >= TargetRatio)
                    _0x1bd685c8 = _0xfd9b521f;
                else
                    _0x2c2b9d47 = _0xfd9b521f;
            }

            _0x734020b8 = Color.Lerp(_0x79174f89, _0xe732453e, _0x1bd685c8);
        }

        _0x734020b8.a = _0x79174f89.a;
        _0xe0aaf0ad.color = _0x734020b8;
    }

    private const float MinRatio = 4.5f;
    private static float Linear(float _0xe5b307db)
    {
        _0xe5b307db = Mathf.Clamp01(_0xe5b307db);
        return _0xe5b307db <= 0.03928f ? _0xe5b307db / 12.92f : Mathf.Pow((_0xe5b307db + 0.055f) / 1.055f, 2.4f);
    }

    private void OnDisable()
    {
        if (this._0xbf569444 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xbf569444);
    }

    private void OnEnable()
    {
        if (this._0xbf569444 == null)
            this._0xbf569444 = _0x838a5343 => this._0x331d52c1(_0x838a5343);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xbf569444);
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x1359ef79)
    {
        return 0.2126f * Linear(_0x1359ef79.r) + 0.7152f * Linear(_0x1359ef79.g) + 0.0722f * Linear(_0x1359ef79.b);
    }

    private static float Ratio(Color _0x152cde5d, Color _0x5065d3c9)
    {
        float _0x49df9c52 = Luminance(_0x152cde5d);
        float _0x3c51e851 = Luminance(_0x5065d3c9);
        return (Mathf.Max(_0x49df9c52, _0x3c51e851) + 0.05f) / (Mathf.Min(_0x49df9c52, _0x3c51e851) + 0.05f);
    }

    private const float MinOutlineWidth = 0.01f;
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xbf569444;
    private const float TargetRatio = 7f;
    private static _0x87944755 _0x41be745f;
}

internal static class _0xfcba392b
{
    internal static string _0x7114801f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}