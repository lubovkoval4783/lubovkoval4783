using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The settings sheet. It carries only switches that DO something: this game has
/// no audio at all, so a volume slider or a speaker toggle would be a control
/// that changes nothing, and a control that cannot answer a press is worse than
/// no control (rules C.20 and C.7).
public sealed class _0x1eacab71
{
    private TextMeshProUGUI _0xe507bfde;
    private TextMeshProUGUI _0xa1d9366a;
    public Button _0x62adf262
    {
        get
        {
            return this._0x932eb6ab;
        }
    }

    private Button _0x932eb6ab;
    private readonly TMP_FontAsset _0x843be2e9;
    /// The dimmed surround is a close control too, so a press that lands next to
    /// the corner glyph still dismisses the sheet instead of doing nothing.
    public Button _0x8ae03bae
    {
        get
        {
            return this._0xd6ae2cab;
        }
    }

    public void _0x32e0a1b8(bool _0xad5f92dc)
    {
        if (this._0x7a7fd60a != null)
        {
            this._0x7a7fd60a.SetActive(_0xad5f92dc);
        }
    }

    private Button _0xe272cf7e;
    public Button _0xb6094def
    {
        get
        {
            return this._0x6801809c;
        }
    }

    public void _0xbfaac626(Transform _0x28d832ee, Sprite _0xe7d9a670)
    {
        RectTransform _0x08037a5e = _0x1b8c9d8a.Stretch(_0x28d832ee, _0x3a903a42._0xdf12e99e(new byte[13] { 186, 140, 157, 157, 128, 135, 142, 154, 186, 129, 140, 140, 157 }, 233));
        this._0x7a7fd60a = _0x08037a5e.gameObject;
        Image _0xeda4b7d5 = _0x08037a5e.gameObject.AddComponent<Image>();
        _0xeda4b7d5.color = _0x50c58425.WithAlpha(_0x50c58425.Ink, 0.9f);
        _0xeda4b7d5.raycastTarget = true;
        _0xeda4b7d5.canvasRenderer.cullTransparentMesh = false;
        this._0xd6ae2cab = _0x08037a5e.gameObject.AddComponent<Button>();
        this._0xd6ae2cab.targetGraphic = _0xeda4b7d5;
        this._0xd6ae2cab.transition = Selectable.Transition.None;
        Image _0x5360f28b = _0x1b8c9d8a.Plate(_0x08037a5e, _0x3a903a42._0xdf12e99e(new byte[12] { 182, 128, 145, 145, 140, 139, 130, 150, 166, 132, 151, 129 }, 229), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1020f, 1080f), this._0x3e634f53, _0x50c58425.WithAlpha(_0x50c58425.Surface, 0.99f));
        // The card blocks the surround, so only a press OUTSIDE it closes the sheet.
        _0x5360f28b.raycastTarget = true;
        _0x5360f28b.canvasRenderer.cullTransparentMesh = false;
        Image _0x82ae9b5d = _0x1b8c9d8a.Plate(_0x5360f28b.transform, _0x3a903a42._0xdf12e99e(new byte[11] { 69, 115, 98, 98, 127, 120, 113, 101, 68, 127, 123 }, 22), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(988f, 1048f), this._0x3e634f53, _0x50c58425.WithAlpha(_0x50c58425.Topaz, 0.35f));
        _0x1b8c9d8a.Plate(_0x82ae9b5d.transform, _0x3a903a42._0xdf12e99e(new byte[12] { 223, 233, 248, 248, 229, 226, 235, 255, 206, 227, 232, 245 }, 140), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(964f, 1024f), this._0x3e634f53, _0x50c58425.WithAlpha(_0x50c58425.Ink, 0.94f));
        _0x1b8c9d8a.Caption(_0x5360f28b.transform, _0x3a903a42._0xdf12e99e(new byte[13] { 109, 91, 74, 74, 87, 80, 89, 77, 106, 87, 74, 82, 91 }, 62), new Vector2(0.5f, 1f), new Vector2(0f, -120f), new Vector2(860f, 100f), _0x3a903a42._0xdf12e99e(new byte[14] { 244, 243, 230, 224, 226, 135, 244, 226, 243, 243, 238, 233, 224, 244 }, 167), 62f, _0x50c58425.Topaz, TextAlignmentOptions.Center, this._0x843be2e9);
        _0x1b8c9d8a.Caption(_0x5360f28b.transform, _0x3a903a42._0xdf12e99e(new byte[12] { 186, 147, 130, 134, 155, 145, 129, 190, 147, 144, 151, 158 }, 242), new Vector2(0f, 1f), new Vector2(330f, -320f), new Vector2(520f, 72f), _0x3a903a42._0xdf12e99e(new byte[9] { 137, 150, 157, 141, 158, 139, 150, 144, 145 }, 223), 42f, _0x50c58425.Pearl, TextAlignmentOptions.Left, this._0x843be2e9);
        this._0x6801809c = _0x1b8c9d8a.Action(_0x5360f28b.transform, _0x3a903a42._0xdf12e99e(new byte[13] { 112, 89, 72, 76, 81, 91, 75, 108, 87, 95, 95, 84, 93 }, 56), new Vector2(1f, 1f), new Vector2(-150f, -320f), new Vector2(220f, 100f), this._0x3e634f53, _0x50c58425.Jade, _0x3a903a42._0xdf12e99e(new byte[2] { 83, 82 }, 28), 42f, _0x50c58425.Ink, this._0x843be2e9);
        this._0xfade9cbc = this._0x6801809c.targetGraphic as Image;
        this._0xe507bfde = this._0x6801809c.GetComponentInChildren<TextMeshProUGUI>(true);
        _0x1b8c9d8a.Caption(_0x5360f28b.transform, _0x3a903a42._0xdf12e99e(new byte[10] { 216, 239, 249, 239, 254, 198, 235, 232, 239, 230 }, 138), new Vector2(0f, 1f), new Vector2(330f, -470f), new Vector2(520f, 72f), _0x3a903a42._0xdf12e99e(new byte[8] { 147, 145, 140, 132, 145, 134, 144, 144 }, 195), 42f, _0x50c58425.Pearl, TextAlignmentOptions.Left, this._0x843be2e9);
        this._0xe272cf7e = _0x1b8c9d8a.Action(_0x5360f28b.transform, _0x3a903a42._0xdf12e99e(new byte[11] { 182, 129, 151, 129, 144, 165, 135, 144, 141, 139, 138 }, 228), new Vector2(1f, 1f), new Vector2(-150f, -470f), new Vector2(220f, 100f), this._0x3e634f53, _0x50c58425.Ruby, _0x3a903a42._0xdf12e99e(new byte[4] { 161, 191, 166, 179 }, 246), 42f, _0x50c58425.Pearl, this._0x843be2e9);
        this._0xa1d9366a = _0x1b8c9d8a.Caption(_0x5360f28b.transform, _0x3a903a42._0xdf12e99e(new byte[14] { 118, 64, 81, 81, 76, 75, 66, 86, 118, 81, 68, 81, 80, 86 }, 37), new Vector2(0.5f, 1f), new Vector2(0f, -640f), new Vector2(860f, 140f), _0x3a903a42._0xdf12e99e(new byte[57] { 165, 185, 180, 209, 162, 165, 176, 182, 180, 209, 176, 191, 162, 166, 180, 163, 162, 209, 180, 167, 180, 163, 168, 209, 179, 180, 176, 165, 251, 166, 184, 165, 185, 209, 189, 184, 182, 185, 165, 221, 209, 191, 180, 167, 180, 163, 209, 166, 184, 165, 185, 209, 162, 190, 164, 191, 181 }, 241), 34f, _0x50c58425.Muted, TextAlignmentOptions.Center, this._0x843be2e9);
        this._0x932eb6ab = _0x1b8c9d8a.IconAction(_0x5360f28b.transform, _0x3a903a42._0xdf12e99e(new byte[13] { 48, 6, 23, 23, 10, 13, 4, 16, 32, 15, 12, 16, 6 }, 99), new Vector2(1f, 1f), new Vector2(-84f, -84f), 100f, this._0x3e634f53, _0x50c58425.WithAlpha(_0x50c58425.SurfaceEdge, 0.95f), _0xe7d9a670, _0x50c58425.Pearl);
        this._0x32e0a1b8(false);
    }

    public Button _0xa8eec101
    {
        get
        {
            return this._0xe272cf7e;
        }
    }

    private Button _0xd6ae2cab;
    public _0x1eacab71(TMP_FontAsset _0x2d0ff312, Sprite _0x4b5ebea6)
    {
        this._0x843be2e9 = _0x2d0ff312;
        this._0x3e634f53 = _0x4b5ebea6;
    }

    private Button _0x6801809c;
    private Image _0xfade9cbc;
    private GameObject _0x7a7fd60a;
    /// The vibration switch has to be readable on a still frame, so it changes its
    /// own colour and word together rather than only one of the two.
    public void _0x233e0882(bool _0xeb5d23b0)
    {
        if (this._0xe507bfde != null)
        {
            this._0xe507bfde.text = _0xeb5d23b0 ? _0x3a903a42._0xdf12e99e(new byte[2] { 163, 162 }, 236) : _0x3a903a42._0xdf12e99e(new byte[3] { 174, 167, 167 }, 225);
        }

        if (this._0xfade9cbc != null)
        {
            this._0xfade9cbc.color = _0xeb5d23b0 ? _0x50c58425.Jade : _0x50c58425.SurfaceEdge;
        }

        if (this._0xa1d9366a != null)
        {
            this._0xa1d9366a.text = _0xeb5d23b0 ? _0x3a903a42._0xdf12e99e(new byte[60] { 133, 150, 133, 146, 153, 224, 131, 140, 133, 129, 142, 224, 129, 142, 147, 151, 133, 146, 224, 135, 137, 150, 133, 147, 224, 129, 224, 147, 136, 143, 146, 148, 224, 130, 149, 154, 154, 202, 148, 136, 133, 224, 147, 148, 129, 135, 133, 224, 147, 148, 129, 153, 147, 224, 147, 137, 140, 133, 142, 148 }, 192) : _0x3a903a42._0xdf12e99e(new byte[57] { 127, 99, 110, 11, 120, 127, 106, 108, 110, 11, 106, 101, 120, 124, 110, 121, 120, 11, 110, 125, 110, 121, 114, 11, 105, 110, 106, 127, 33, 124, 98, 127, 99, 11, 103, 98, 108, 99, 127, 7, 11, 101, 110, 125, 110, 121, 11, 124, 98, 127, 99, 11, 120, 100, 126, 101, 111 }, 43);
        }
    }

    private readonly Sprite _0x3e634f53;
}

internal static class _0x3a903a42
{
    internal static string _0xdf12e99e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}