using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The control sheet. This game is not "tap the button" - it is answer a phrase
/// on the beat, and one of the five gems has to be HELD - so the gesture and what
/// it does are spelled out here as well as on the permanent hint in the run
/// (rule C.6).
public sealed class _0xae4000ec
{
    public void _0xa3ebf60e(bool _0xbf0763ad)
    {
        if (this._0xc6d2c04c != null)
        {
            this._0xc6d2c04c.SetActive(_0xbf0763ad);
        }
    }

    private GameObject _0xc6d2c04c;
    public _0xae4000ec(TMP_FontAsset _0x1b546a1c, Sprite _0xc45c5bba)
    {
        this._0x4f4fc627 = _0x1b546a1c;
        this._0x5999e261 = _0xc45c5bba;
    }

    private Button _0x453f4ca6;
    public Button _0x53c91681
    {
        get
        {
            return this._0x15217c7c;
        }
    }

    private readonly Sprite _0x5999e261;
    public void _0xce7cff7b(Transform _0x0846f78a, Sprite _0x12e8a3ca, Sprite _0xc3565c79, Sprite _0xc3dc3b6c, Sprite _0xe3e8047d)
    {
        RectTransform _0x554c7ea2 = _0x1b8c9d8a.Stretch(_0x0846f78a, _0x5cf5fbe2._0x56ee23ac(new byte[10] { 59, 28, 4, 39, 28, 32, 27, 22, 22, 7 }, 115));
        this._0xc6d2c04c = _0x554c7ea2.gameObject;
        Image _0xb6964a0d = _0x554c7ea2.gameObject.AddComponent<Image>();
        _0xb6964a0d.color = _0x50c58425.WithAlpha(_0x50c58425.Ink, 0.9f);
        _0xb6964a0d.raycastTarget = true;
        _0xb6964a0d.canvasRenderer.cullTransparentMesh = false;
        this._0x273a6e98 = _0x554c7ea2.gameObject.AddComponent<Button>();
        this._0x273a6e98.targetGraphic = _0xb6964a0d;
        this._0x273a6e98.transition = Selectable.Transition.None;
        Image _0xa545350f = _0x1b8c9d8a.Plate(_0x554c7ea2, _0x5cf5fbe2._0x56ee23ac(new byte[9] { 148, 179, 171, 136, 179, 159, 189, 174, 184 }, 220), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1060f, 1500f), this._0x5999e261, _0x50c58425.WithAlpha(_0x50c58425.Surface, 0.99f));
        // The card blocks the surround, so only a press OUTSIDE it closes the sheet.
        _0xa545350f.raycastTarget = true;
        _0xa545350f.canvasRenderer.cullTransparentMesh = false;
        Image _0x6b40fd31 = _0x1b8c9d8a.Plate(_0xa545350f.transform, _0x5cf5fbe2._0x56ee23ac(new byte[8] { 62, 25, 1, 34, 25, 36, 31, 27 }, 118), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1028f, 1468f), this._0x5999e261, _0x50c58425.WithAlpha(_0x50c58425.Topaz, 0.35f));
        _0x1b8c9d8a.Plate(_0x6b40fd31.transform, _0x5cf5fbe2._0x56ee23ac(new byte[9] { 7, 32, 56, 27, 32, 13, 32, 43, 54 }, 79), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1004f, 1444f), this._0x5999e261, _0x50c58425.WithAlpha(_0x50c58425.Ink, 0.94f));
        _0x1b8c9d8a.Caption(_0xa545350f.transform, _0x5cf5fbe2._0x56ee23ac(new byte[10] { 244, 211, 203, 232, 211, 232, 213, 200, 208, 217 }, 188), new Vector2(0.5f, 1f), new Vector2(0f, -120f), new Vector2(900f, 100f), _0x5cf5fbe2._0x56ee23ac(new byte[17] { 165, 162, 186, 205, 185, 165, 168, 205, 190, 165, 162, 186, 205, 191, 184, 163, 190 }, 237), 60f, _0x50c58425.Topaz, TextAlignmentOptions.Center, this._0x4f4fc627);
        this.Step(_0xa545350f.transform, -330f, _0xc3565c79, _0x50c58425.Topaz, _0x5cf5fbe2._0x56ee23ac(new byte[14] { 11, 29, 8, 31, 20, 124, 8, 20, 25, 124, 14, 21, 18, 27 }, 92), _0x5cf5fbe2._0x56ee23ac(new byte[63] { 200, 213, 161, 194, 205, 206, 210, 196, 210, 161, 206, 207, 161, 196, 215, 196, 211, 216, 161, 195, 196, 192, 213, 175, 139, 213, 201, 196, 161, 204, 206, 204, 196, 207, 213, 161, 200, 213, 161, 200, 210, 161, 213, 200, 198, 201, 213, 196, 210, 213, 161, 200, 210, 161, 213, 201, 196, 161, 195, 196, 192, 213, 175 }, 129));
        this.Step(_0xa545350f.transform, -650f, _0xc3dc3b6c, _0x50c58425.Jade, _0x5cf5fbe2._0x56ee23ac(new byte[17] { 30, 17, 12, 8, 26, 13, 127, 11, 23, 26, 127, 15, 23, 13, 30, 12, 26 }, 95), _0x5cf5fbe2._0x56ee23ac(new byte[65] { 24, 4, 9, 108, 31, 24, 13, 11, 9, 108, 0, 5, 11, 4, 24, 31, 108, 11, 9, 1, 31, 108, 5, 2, 108, 3, 30, 8, 9, 30, 98, 70, 24, 13, 28, 108, 24, 4, 9, 108, 31, 13, 1, 9, 108, 3, 2, 9, 31, 108, 14, 13, 15, 7, 96, 108, 5, 2, 108, 3, 30, 8, 9, 30, 98 }, 76));
        this.Step(_0xa545350f.transform, -970f, _0xe3e8047d, _0x50c58425.Pearl, _0x5cf5fbe2._0x56ee23ac(new byte[18] { 105, 110, 109, 101, 1, 117, 105, 100, 1, 113, 100, 96, 115, 109, 1, 102, 100, 108 }, 33), _0x5cf5fbe2._0x56ee23ac(new byte[80] { 209, 205, 192, 165, 213, 192, 196, 215, 201, 165, 194, 192, 200, 165, 204, 214, 165, 205, 192, 201, 193, 169, 165, 203, 202, 209, 165, 209, 196, 213, 213, 192, 193, 171, 143, 206, 192, 192, 213, 165, 220, 202, 208, 215, 165, 195, 204, 203, 194, 192, 215, 165, 193, 202, 210, 203, 165, 210, 205, 204, 201, 192, 165, 209, 205, 192, 165, 215, 204, 199, 199, 202, 203, 165, 215, 204, 214, 192, 214, 171 }, 133));
        this._0x453f4ca6 = _0x1b8c9d8a.Action(_0xa545350f.transform, _0x5cf5fbe2._0x56ee23ac(new byte[11] { 202, 237, 245, 214, 237, 195, 225, 225, 231, 242, 246 }, 130), new Vector2(0.5f, 0f), new Vector2(0f, 150f), new Vector2(520f, 150f), this._0x5999e261, _0x50c58425.Jade, _0x5cf5fbe2._0x56ee23ac(new byte[6] { 164, 172, 183, 195, 170, 183 }, 227), 46f, _0x50c58425.Ink, this._0x4f4fc627);
        this._0x15217c7c = _0x1b8c9d8a.IconAction(_0xa545350f.transform, _0x5cf5fbe2._0x56ee23ac(new byte[10] { 241, 214, 206, 237, 214, 250, 213, 214, 202, 220 }, 185), new Vector2(1f, 1f), new Vector2(-84f, -84f), 100f, this._0x5999e261, _0x50c58425.WithAlpha(_0x50c58425.SurfaceEdge, 0.95f), _0x12e8a3ca, _0x50c58425.Pearl);
        this._0xa3ebf60e(false);
    }

    /// The dimmed surround is a close control too, so a press that lands next to
    /// the corner glyph still dismisses the sheet instead of doing nothing.
    public Button _0xcd6ef6c0
    {
        get
        {
            return this._0x273a6e98;
        }
    }

    public Button _0xc8a598db
    {
        get
        {
            return this._0x453f4ca6;
        }
    }

    private readonly TMP_FontAsset _0x4f4fc627;
    private Button _0x15217c7c;
    /// One step. The badge sits in its own gutter on the left and the text column
    /// starts clear of it, so no line can ever be printed across the picture
    /// (rule C.25).
    private void Step(Transform _0x61b915b8, float _0x35b6c92c, Sprite _0xc975ab59, Color _0xddf623c6, string _0xc2ac906f, string _0x35c743e6)
    {
        const float _0x31d00814 = 150f;
        const float _0x5b4efff9 = 150f;
        const float _0x3d449fe5 = _0x31d00814 + (_0x5b4efff9 * 0.5f) + 40f;
        const float _0xe2bd97f5 = 690f;
        _0x1b8c9d8a.Picture(_0x61b915b8, _0x5cf5fbe2._0x56ee23ac(new byte[9] { 41, 14, 31, 10, 56, 27, 30, 29, 31 }, 122), new Vector2(0f, 1f), new Vector2(_0x31d00814, _0x35b6c92c), new Vector2(_0x5b4efff9, _0x5b4efff9), _0xc975ab59, _0xddf623c6);
        _0x1b8c9d8a.Caption(_0x61b915b8, _0x5cf5fbe2._0x56ee23ac(new byte[9] { 33, 6, 23, 2, 38, 27, 6, 30, 23 }, 114), new Vector2(0f, 1f), new Vector2(_0x3d449fe5 + (_0xe2bd97f5 * 0.5f), _0x35b6c92c + 56f), new Vector2(_0xe2bd97f5, 66f), _0xc2ac906f, 44f, _0xddf623c6, TextAlignmentOptions.Left, this._0x4f4fc627);
        _0x1b8c9d8a.Caption(_0x61b915b8, _0x5cf5fbe2._0x56ee23ac(new byte[10] { 206, 233, 248, 237, 217, 248, 233, 252, 244, 241 }, 157), new Vector2(0f, 1f), new Vector2(_0x3d449fe5 + (_0xe2bd97f5 * 0.5f), _0x35b6c92c - 44f), new Vector2(_0xe2bd97f5, 120f), _0x35c743e6, 34f, _0x50c58425.Pearl, TextAlignmentOptions.Left, this._0x4f4fc627);
    }

    private Button _0x273a6e98;
}

internal static class _0x5cf5fbe2
{
    internal static string _0x56ee23ac(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}