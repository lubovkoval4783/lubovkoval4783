using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Owns the three result cards. The template pops carry another game's wording, a
/// grey body and a close button whose icon sprite is missing - which Unity draws
/// as a plain white square. So every child of a pop body is switched off and this
/// game builds its own card inside it: header, illustration, two metric lines,
/// two captioned actions and a real close glyph from a serialized sprite
/// (rule C.3).
///
/// Each button is built explicitly with its own caption, so no caption can end up
/// on the close cross the way an index-ordered pass would put it there (C.17).
public sealed class _0xf30072b9 : MonoBehaviour
{
    public void _0x03af6ebd(string _0xdb5f8d7a, int _0x0703190b, int _0x35ccf655, int _0xb0a31465, string _0x210409ea, int _0x51c22a50)
    {
        this.Write(Lose, _0xdb5f8d7a, _0x210409ea, _0x18abcb69._0x095aa39c(new byte[9] { 237, 239, 239, 249, 254, 237, 239, 245, 140 }, 172) + _0x0703190b + _0x18abcb69._0x095aa39c(new byte[14] { 127, 122, 122, 119, 122, 122, 10, 18, 8, 27, 9, 31, 9, 122 }, 90) + _0x35ccf655 + _0x18abcb69._0x095aa39c(new byte[3] { 250, 245, 250 }, 218) + _0xb0a31465, _0x18abcb69._0x095aa39c(new byte[10] { 164, 163, 182, 165, 179, 162, 164, 163, 215, 220 }, 247) + _0x51c22a50, _0x18abcb69._0x095aa39c(new byte[42] { 69, 83, 70, 81, 90, 50, 70, 90, 87, 50, 64, 91, 92, 85, 50, 63, 50, 83, 92, 65, 69, 87, 64, 50, 69, 90, 87, 92, 50, 91, 70, 50, 65, 92, 83, 66, 65, 50, 65, 90, 71, 70 }, 18));
    }

    public void _0xa57a3bc1()
    {
        _0x11d21c90 _0x0a626d7d = _0x23d9e2a2.Instance._0xc2ba422e(_0xc29566dc._0xf58e677e.PAUSE);
        if (_0x0a626d7d == null)
        {
            return;
        }

        _0x23d9e2a2.Instance._0x4f08a333(_0xc29566dc._0xf58e677e.PAUSE);
    }

    private readonly Button[] _0x3e95f02f = new Button[3];
    [SerializeField]
    private Sprite _closeIcon;
    private bool _0x965c3c7a;
    private readonly TextMeshProUGUI[] _0xeb7d92c2 = new TextMeshProUGUI[3];
    private const int Pause = 2;
    private readonly TextMeshProUGUI[] _0x0f261774 = new TextMeshProUGUI[3];
    public Button _0xf69966e0
    {
        get
        {
            return this._0x3e95f02f[Pause];
        }
    }

    private readonly TextMeshProUGUI[] _0x6aa2a02b = new TextMeshProUGUI[3];
    public void _0x2a333385()
    {
        _0x23d9e2a2 _0x9101a30d = _0x23d9e2a2.Instance;
        if (_0x9101a30d != null)
        {
            _0x9101a30d._0x3cacdc88();
        }
    }

    [SerializeField]
    private Sprite _rankStarSprite;
    public Button _0x9f460399
    {
        get
        {
            return this._0x1210a512[Lose];
        }
    }

    public Button _0xda28e842
    {
        get
        {
            return this._0x1210a512[Pause];
        }
    }

    public void _0x3b51cb88()
    {
        _0x11d21c90 _0xf531a521 = _0x23d9e2a2.Instance._0xc2ba422e(_0xc29566dc._0xf58e677e.LOSE);
        if (_0xf531a521 == null)
        {
            return;
        }

        _0x23d9e2a2.Instance._0x4f08a333(_0xc29566dc._0xf58e677e.LOSE);
    }

    [SerializeField]
    private Sprite _emblemSprite;
    public void _0x68f5c4b1()
    {
        _0x11d21c90 _0x9a238b19 = _0x23d9e2a2.Instance._0xc2ba422e(_0xc29566dc._0xf58e677e.WIN);
        if (_0x9a238b19 == null)
        {
            return;
        }

        _0x23d9e2a2.Instance._0x4f08a333(_0xc29566dc._0xf58e677e.WIN);
    }

    public void _0x1e47dff7()
    {
        if (this._0x965c3c7a)
        {
            return;
        }

        _0x23d9e2a2 _0x072adc78 = _0x23d9e2a2.Instance;
        if (_0x072adc78 == null || _0x072adc78.Pops == null)
        {
            return;
        }

        _0x11d21c90 _0x3474c83b = _0x23d9e2a2.Instance._0xc2ba422e(_0xc29566dc._0xf58e677e.WIN);
        _0x11d21c90 _0xb6f1587d = _0x23d9e2a2.Instance._0xc2ba422e(_0xc29566dc._0xf58e677e.LOSE);
        _0x11d21c90 _0x567dd3ce = _0x23d9e2a2.Instance._0xc2ba422e(_0xc29566dc._0xf58e677e.PAUSE);
        this._0x6dbe786e(_0x3474c83b, Win, _0x18abcb69._0x095aa39c(new byte[13] { 176, 187, 182, 186, 167, 176, 213, 176, 180, 167, 187, 176, 177 }, 245), _0x50c58425.Topaz, _0x18abcb69._0x095aa39c(new byte[10] { 139, 151, 154, 130, 251, 154, 156, 154, 146, 149 }, 219), _0x18abcb69._0x095aa39c(new byte[13] { 210, 209, 211, 219, 176, 196, 223, 176, 195, 196, 209, 215, 213 }, 144), true);
        this._0x6dbe786e(_0xb6f1587d, Lose, _0x18abcb69._0x095aa39c(new byte[15] { 120, 110, 105, 111, 122, 114, 117, 27, 127, 105, 116, 107, 107, 126, 127 }, 59), _0x50c58425.Rose, _0x18abcb69._0x095aa39c(new byte[9] { 123, 125, 118, 15, 110, 104, 110, 102, 97 }, 47), _0x18abcb69._0x095aa39c(new byte[13] { 142, 141, 143, 135, 236, 152, 131, 236, 159, 152, 141, 139, 137 }, 204), false);
        this._0x6dbe786e(_0x567dd3ce, Pause, _0x18abcb69._0x095aa39c(new byte[12] { 66, 69, 95, 78, 89, 70, 66, 88, 88, 66, 68, 69 }, 11), _0x50c58425.Pearl, _0x18abcb69._0x095aa39c(new byte[6] { 227, 244, 226, 228, 252, 244 }, 177), _0x18abcb69._0x095aa39c(new byte[13] { 104, 107, 105, 97, 10, 126, 101, 10, 121, 126, 107, 109, 111 }, 42), false);
        this._0x965c3c7a = true;
    }

    public void FillPause(int _0x0ae2dd25, int _0xb5ba3653, int _0x2b184ccb, int _0x53f38533)
    {
        this.Write(Pause, _0x18abcb69._0x095aa39c(new byte[12] { 217, 222, 196, 213, 194, 221, 217, 195, 195, 217, 223, 222 }, 144), _0x18abcb69._0x095aa39c(new byte[2] { 77, 77 }, 4), _0x18abcb69._0x095aa39c(new byte[7] { 250, 226, 248, 235, 249, 239, 138 }, 170) + Mathf.Clamp(_0x0ae2dd25 + 1, 1, _0xb5ba3653) + _0x18abcb69._0x095aa39c(new byte[3] { 102, 105, 102 }, 70) + _0xb5ba3653 + _0x18abcb69._0x095aa39c(new byte[14] { 188, 188, 177, 188, 188, 221, 223, 223, 201, 206, 221, 223, 197, 188 }, 156) + _0x2b184ccb + _0x18abcb69._0x095aa39c(new byte[1] { 93 }, 120), _0x18abcb69._0x095aa39c(new byte[7] { 217, 195, 210, 223, 195, 198, 171 }, 139) + _0x53f38533 + _0x18abcb69._0x095aa39c(new byte[1] { 141 }, 168), _0x18abcb69._0x095aa39c(new byte[28] { 135, 155, 150, 243, 128, 135, 146, 148, 150, 243, 154, 128, 243, 155, 156, 159, 151, 154, 157, 148, 243, 149, 156, 129, 243, 138, 156, 134 }, 211));
    }

    public Button _0xf108f034
    {
        get
        {
            return this._0x1210a512[Win];
        }
    }

    public Button _0x0211ea19
    {
        get
        {
            return this._0x65a07d37[Lose];
        }
    }

    private const int Lose = 1;
    public Button _0x63a956c3
    {
        get
        {
            return this._0x65a07d37[Win];
        }
    }

    public Button _0x29c902a1
    {
        get
        {
            return this._0x65a07d37[Pause];
        }
    }

    private readonly TextMeshProUGUI[] _0xdfa59e83 = new TextMeshProUGUI[3];
    [SerializeField]
    private Sprite _plateSprite;
    public Button _0x9183fd00
    {
        get
        {
            return this._0x3e95f02f[Win];
        }
    }

    private readonly TextMeshProUGUI[] _0xdbfc5b37 = new TextMeshProUGUI[3];
    private readonly Button[] _0x1210a512 = new Button[3];
    private readonly Button[] _0x65a07d37 = new Button[3];
    private const int Win = 0;
    [SerializeField]
    private TMP_FontAsset _font;
    public void _0x201ded4c(string _0xe78157db, int _0x3531c2a3, int _0x84645bdc, int _0xf222084e)
    {
        this.Write(Win, _0x18abcb69._0x095aa39c(new byte[13] { 222, 213, 216, 212, 201, 222, 187, 222, 218, 201, 213, 222, 223 }, 155), _0xe78157db, _0x18abcb69._0x095aa39c(new byte[9] { 41, 43, 43, 61, 58, 41, 43, 49, 72 }, 104) + _0x3531c2a3 + _0x18abcb69._0x095aa39c(new byte[14] { 40, 45, 45, 32, 45, 45, 94, 89, 95, 72, 76, 70, 45, 117 }, 13) + _0x84645bdc, _0x18abcb69._0x095aa39c(new byte[10] { 67, 68, 81, 66, 84, 69, 67, 68, 48, 59 }, 16) + _0xf222084e, _0x18abcb69._0x095aa39c(new byte[30] { 143, 147, 158, 251, 147, 148, 142, 136, 158, 251, 140, 154, 149, 143, 136, 251, 154, 149, 148, 143, 147, 158, 137, 251, 139, 147, 137, 154, 136, 158 }, 219));
        if (this._0x7928f335[Win] != null)
        {
            this._0x7928f335[Win].color = _0xe78157db == _0x18abcb69._0x095aa39c(new byte[1] { 145 }, 194) ? _0x50c58425.Topaz : (_0xe78157db == _0x18abcb69._0x095aa39c(new byte[1] { 155 }, 218) ? _0x50c58425.Jade : _0x50c58425.Pearl);
        }
    }

    private void Write(int _0x27e05550, string _0x80179471, string _0xec292a8e, string _0x7c64896f, string _0xb1252d76, string _0xfa9e5fba)
    {
        if (this._0xeb7d92c2[_0x27e05550] != null)
        {
            this._0xeb7d92c2[_0x27e05550].text = _0xfa9e5fba;
        }

        if (this._0x0f261774[_0x27e05550] != null)
        {
            this._0x0f261774[_0x27e05550].text = _0x80179471;
        }

        if (this._0xdfa59e83[_0x27e05550] != null)
        {
            this._0xdfa59e83[_0x27e05550].text = _0xec292a8e;
        }

        if (this._0xdbfc5b37[_0x27e05550] != null)
        {
            this._0xdbfc5b37[_0x27e05550].text = _0x7c64896f;
        }

        if (this._0x6aa2a02b[_0x27e05550] != null)
        {
            this._0x6aa2a02b[_0x27e05550].text = _0xb1252d76;
        }
    }

    private void _0x6dbe786e(_0x11d21c90 _0x526c5072, int _0x4351a8c1, string _0xadf2f33a, Color _0x248870de, string _0xab5cb43d, string _0x9d4574e7, bool _0xb3e32d8c)
    {
        if (_0x526c5072 == null || _0x526c5072.Content == null)
        {
            return;
        }

        Transform _0x963a295e = _0x526c5072.Content.transform;
        for (int _0xd208e90f = _0x963a295e.childCount - 1; _0xd208e90f >= 0; _0xd208e90f--)
        {
            _0x963a295e.GetChild(_0xd208e90f).gameObject.SetActive(false);
        }

        RectTransform _0x4b2a87e7 = _0x1b8c9d8a.Stretch(_0x963a295e, _0x18abcb69._0x095aa39c(new byte[10] { 47, 24, 14, 8, 17, 9, 53, 18, 14, 9 }, 125));
        Image _0x1b6ee546 = _0x1b8c9d8a.Plate(_0x4b2a87e7, _0x18abcb69._0x095aa39c(new byte[10] { 129, 182, 160, 166, 191, 167, 144, 178, 161, 183 }, 211), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(1000f, 1300f), this._plateSprite, _0x50c58425.WithAlpha(_0x50c58425.Surface, 0.98f));
        Image _0xc2eda26a = _0x1b8c9d8a.Plate(_0x1b6ee546.transform, _0x18abcb69._0x095aa39c(new byte[11] { 153, 174, 184, 190, 167, 191, 141, 185, 170, 166, 174 }, 203), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(964f, 1264f), this._plateSprite, _0x50c58425.WithAlpha(_0x50c58425.Topaz, 0.35f));
        _0x1b8c9d8a.Plate(_0xc2eda26a.transform, _0x18abcb69._0x095aa39c(new byte[10] { 167, 144, 134, 128, 153, 129, 183, 154, 145, 140 }, 245), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(940f, 1240f), this._plateSprite, _0x50c58425.WithAlpha(_0x50c58425.Ink, 0.92f));
        // The emblem is the badge the grade letter sits inside, so it stays faint:
        // a strong mark under a big letter reads as a printing error, not a badge.
        _0x1b8c9d8a.Picture(_0x1b6ee546.transform, _0x18abcb69._0x095aa39c(new byte[12] { 114, 69, 83, 85, 76, 84, 101, 77, 66, 76, 69, 77 }, 32), new Vector2(0.5f, 1f), new Vector2(0f, -220f), new Vector2(320f, 320f), this._emblemSprite, _0x50c58425.WithAlpha(_0x50c58425.Amethyst, 0.45f));
        this._0xdfa59e83[_0x4351a8c1] = _0x1b8c9d8a.Caption(_0x1b6ee546.transform, _0x18abcb69._0x095aa39c(new byte[11] { 73, 126, 104, 110, 119, 111, 92, 105, 122, 127, 126 }, 27), new Vector2(0.5f, 1f), new Vector2(0f, -220f), new Vector2(300f, 220f), _0xb3e32d8c ? _0x18abcb69._0x095aa39c(new byte[1] { 0 }, 65) : _0x18abcb69._0x095aa39c(new byte[1] { 170 }, 135), 150f, _0x50c58425.Pearl, TextAlignmentOptions.Center, this._font);
        if (_0xb3e32d8c)
        {
            this._0x7928f335[_0x4351a8c1] = _0x1b8c9d8a.Picture(_0x1b6ee546.transform, _0x18abcb69._0x095aa39c(new byte[11] { 63, 8, 30, 24, 1, 25, 62, 25, 12, 31, 30 }, 109), new Vector2(0.5f, 1f), new Vector2(0f, -400f), new Vector2(84f, 84f), this._rankStarSprite, _0x50c58425.Topaz);
        }

        this._0x0f261774[_0x4351a8c1] = _0x1b8c9d8a.Caption(_0x1b6ee546.transform, _0x18abcb69._0x095aa39c(new byte[12] { 214, 225, 247, 241, 232, 240, 204, 225, 229, 224, 225, 246 }, 132), new Vector2(0.5f, 1f), new Vector2(0f, -520f), new Vector2(880f, 120f), _0xadf2f33a, 72f, _0x248870de, TextAlignmentOptions.Center, this._font);
        this._0xdbfc5b37[_0x4351a8c1] = _0x1b8c9d8a.Caption(_0x1b6ee546.transform, _0x18abcb69._0x095aa39c(new byte[12] { 93, 106, 124, 122, 99, 123, 66, 106, 123, 125, 102, 108 }, 15), new Vector2(0.5f, 1f), new Vector2(0f, -680f), new Vector2(880f, 90f), _0x18abcb69._0x095aa39c(new byte[11] { 59, 57, 57, 47, 40, 59, 57, 35, 90, 74, 95 }, 122), 44f, _0x50c58425.Jade, TextAlignmentOptions.Center, this._font);
        this._0x6aa2a02b[_0x4351a8c1] = _0x1b8c9d8a.Caption(_0x1b6ee546.transform, _0x18abcb69._0x095aa39c(new byte[12] { 176, 135, 145, 151, 142, 150, 176, 135, 149, 131, 144, 134 }, 226), new Vector2(0.5f, 1f), new Vector2(0f, -790f), new Vector2(880f, 84f), _0x18abcb69._0x095aa39c(new byte[10] { 166, 161, 180, 167, 177, 160, 166, 161, 213, 197 }, 245), 40f, _0x50c58425.Topaz, TextAlignmentOptions.Center, this._font);
        this._0xeb7d92c2[_0x4351a8c1] = _0x1b8c9d8a.Caption(_0x1b6ee546.transform, _0x18abcb69._0x095aa39c(new byte[10] { 2, 53, 35, 37, 60, 36, 30, 63, 36, 53 }, 80), new Vector2(0.5f, 1f), new Vector2(0f, -900f), new Vector2(880f, 72f), string.Empty, 34f, _0x50c58425.Muted, TextAlignmentOptions.Center, this._font);
        this._0x1210a512[_0x4351a8c1] = _0x1b8c9d8a.Action(_0x1b6ee546.transform, _0x18abcb69._0x095aa39c(new byte[13] { 229, 210, 196, 194, 219, 195, 231, 197, 222, 218, 214, 197, 206 }, 183), new Vector2(0.5f, 0f), new Vector2(-240f, 150f), new Vector2(440f, 150f), this._plateSprite, _0x50c58425.Jade, _0xab5cb43d, 40f, _0x50c58425.Ink, this._font);
        this._0x3e95f02f[_0x4351a8c1] = _0x1b8c9d8a.Action(_0x1b6ee546.transform, _0x18abcb69._0x095aa39c(new byte[15] { 18, 37, 51, 53, 44, 52, 19, 37, 35, 47, 46, 36, 33, 50, 57 }, 64), new Vector2(0.5f, 0f), new Vector2(240f, 150f), new Vector2(440f, 150f), this._plateSprite, _0x50c58425.Amethyst, _0x9d4574e7, 40f, _0x50c58425.Pearl, this._font);
        this._0x65a07d37[_0x4351a8c1] = _0x1b8c9d8a.IconAction(_0x1b6ee546.transform, _0x18abcb69._0x095aa39c(new byte[11] { 23, 32, 54, 48, 41, 49, 6, 41, 42, 54, 32 }, 69), new Vector2(1f, 1f), new Vector2(-84f, -84f), 100f, this._plateSprite, _0x50c58425.WithAlpha(_0x50c58425.SurfaceEdge, 0.95f), this._closeIcon, _0x50c58425.Pearl);
        _0x1b6ee546.transform.localScale = Vector3.one;
    }

    private readonly Image[] _0x7928f335 = new Image[3];
    public Button _0x00880dbd
    {
        get
        {
            return this._0x3e95f02f[Lose];
        }
    }
}

internal static class _0x18abcb69
{
    internal static string _0x095aa39c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}