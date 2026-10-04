using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The run's own readouts, built as this game's own objects inside the panel body
/// rather than dropped into the template's placeholder slots (rule C.2).
///
/// The tap field is deliberately the FIRST child: inside one canvas the later
/// sibling wins the raycast, so the back and pause controls built after it keep
/// their own presses while every other touch falls through to the field.
public sealed class _0x7a377452 : MonoBehaviour
{
    private TextMeshProUGUI _0x04620abb;
    /// One statistic: a big number over a small caption, each inside its OWN third
    /// of the row. The columns never share horizontal space, so nothing can end up
    /// printed across its neighbour (rule C.25).
    private TextMeshProUGUI Readout(Transform _0x3faf00d3, string _0xeb8d420a, float _0x128d2590, string _0xb472212b, string _0x00678fcf, Color _0xa23de131, TMP_FontAsset _0x0c5de948)
    {
        TextMeshProUGUI _0xf3d626a5 = _0x1b8c9d8a.Caption(_0x3faf00d3, _0xeb8d420a + _0xa7e82771._0x9ec49df8(new byte[5] { 148, 163, 174, 183, 167 }, 194), new Vector2(0.5f, 1f), new Vector2(_0x128d2590, -442f), new Vector2(330f, 82f), _0xb472212b, 64f, _0xa23de131, TextAlignmentOptions.Center, _0x0c5de948);
        _0x1b8c9d8a.Caption(_0x3faf00d3, _0xeb8d420a + _0xa7e82771._0x9ec49df8(new byte[7] { 106, 72, 89, 93, 64, 70, 71 }, 41), new Vector2(0.5f, 1f), new Vector2(_0x128d2590, -500f), new Vector2(330f, 44f), _0x00678fcf, 32f, _0x50c58425.Pearl, TextAlignmentOptions.Center, _0x0c5de948);
        return _0xf3d626a5;
    }

    private const int BeatDots = 4;
    private Image _0x0bf8918f;
    private Button _0x553aa7c6;
    public void _0x378e52bb(int _0xf2e9c5e3, int _0xb0b05d70)
    {
        if (this._0x99bec0f1 != null)
        {
            this._0x99bec0f1.text = _0xa7e82771._0x9ec49df8(new byte[7] { 31, 7, 29, 14, 28, 10, 111 }, 79) + Mathf.Clamp(_0xf2e9c5e3 + 1, 1, _0xb0b05d70) + _0xa7e82771._0x9ec49df8(new byte[3] { 212, 219, 212 }, 244) + _0xb0b05d70;
        }
    }

    private TextMeshProUGUI _0x4c7580c3;
    private _0xf4af58a1 _0x74c7d772;
    public void _0x8f1c877c(int _0x3987e124)
    {
        for (int _0x5911d796 = 0; _0x5911d796 < BeatDots; _0x5911d796++)
        {
            if (this._0xf313c623[_0x5911d796] == null)
            {
                continue;
            }

            bool _0x705c95eb = _0x5911d796 <= _0x3987e124;
            this._0xf313c623[_0x5911d796].color = _0x705c95eb ? _0x50c58425.WithAlpha(_0x50c58425.Topaz, 1f) : _0x50c58425.WithAlpha(_0x50c58425.Pearl, 0.25f);
        }
    }

    private void BuildMeter(Transform _0xd70c9e72, Sprite _0x9cc5341f, Sprite _0x3787f54f, TMP_FontAsset _0xe43fc953)
    {
        Image _0x6fc6fc6e = _0x1b8c9d8a.Plate(_0xd70c9e72, _0xa7e82771._0x9ec49df8(new byte[10] { 244, 220, 205, 220, 203, 237, 203, 216, 218, 210 }, 185), new Vector2(0.5f, 1f), new Vector2(0f, -300f), new Vector2(1000f, 48f), _0x9cc5341f, _0x50c58425.TrackDark);
        GameObject _0x96cc6cde = new GameObject(_0xa7e82771._0x9ec49df8(new byte[9] { 197, 237, 252, 237, 250, 206, 225, 228, 228 }, 136), typeof(RectTransform));
        this._0x677d540f = _0x96cc6cde.GetComponent<RectTransform>();
        this._0x677d540f.SetParent(_0x6fc6fc6e.transform, false);
        this._0x677d540f.anchorMin = new Vector2(0f, 0.5f);
        this._0x677d540f.anchorMax = new Vector2(0f, 0.5f);
        this._0x677d540f.pivot = new Vector2(0f, 0.5f);
        this._0x267ae803 = 976f;
        this._0x677d540f.sizeDelta = new Vector2(this._0x267ae803, 30f);
        this._0x677d540f.anchoredPosition = new Vector2(12f, 0f);
        this._0x677d540f.localScale = Vector3.one;
        this._0x0bf8918f = _0x96cc6cde.AddComponent<Image>();
        this._0x0bf8918f.sprite = _0x3787f54f;
        this._0x0bf8918f.type = _0x3787f54f != null ? Image.Type.Sliced : Image.Type.Simple;
        // The fill shrinks to nothing as the rhythm drains, so its rounded caps are
        // kept small enough that they never meet across a nearly empty bar.
        this._0x0bf8918f.pixelsPerUnitMultiplier = 4f;
        this._0x0bf8918f.color = _0x50c58425.Jade;
        this._0x0bf8918f.raycastTarget = false;
        _0x1b8c9d8a.Caption(_0xd70c9e72, _0xa7e82771._0x9ec49df8(new byte[10] { 78, 102, 119, 102, 113, 79, 98, 97, 102, 111 }, 3), new Vector2(0.5f, 1f), new Vector2(0f, -352f), new Vector2(420f, 44f), _0xa7e82771._0x9ec49df8(new byte[6] { 182, 172, 189, 176, 172, 169 }, 228), 32f, _0x50c58425.Pearl, TextAlignmentOptions.Center, _0xe43fc953);
    }

    public _0xf4af58a1 _0x8aa406e1
    {
        get
        {
            return this._0x74c7d772;
        }
    }

    private void _0xe3bbf32b(float width)
    {
        if (this._0x677d540f != null)
        {
            this._0x677d540f.sizeDelta = new Vector2(Mathf.Max(0f, width), 30f);
        }
    }

    private TextMeshProUGUI _0x42299021;
    private readonly Image[] _0x01ae4203 = new Image[MissPips];
    private TextMeshProUGUI _0x99bec0f1;
    public void _0x34073602(Transform _0x1f68f34a, TMP_FontAsset _0x558e1212, Sprite _0xdcb541b4, Sprite _0x08c61658, Sprite _0xdb85d25d, Sprite _0xf2bb52ab, Sprite _0xc730447a)
    {
        RectTransform _0xdc210738 = _0x1b8c9d8a.Stretch(_0x1f68f34a, _0xa7e82771._0x9ec49df8(new byte[6] { 71, 96, 123, 93, 96, 113 }, 21));
        Image _0x9a8046d5 = _0x1b8c9d8a.TapSurface(_0xdc210738, _0xa7e82771._0x9ec49df8(new byte[10] { 45, 10, 31, 25, 27, 42, 17, 11, 29, 22 }, 126));
        this._0x74c7d772 = _0x9a8046d5.gameObject.AddComponent<_0xf4af58a1>();
        this._0x553aa7c6 = _0x1b8c9d8a.IconAction(_0xdc210738, _0xa7e82771._0x9ec49df8(new byte[8] { 33, 2, 0, 8, 48, 15, 12, 23 }, 99), new Vector2(0.5f, 1f), new Vector2(-500f, -150f), 112f, _0xdcb541b4, _0x50c58425.WithAlpha(_0x50c58425.Surface, 0.95f), _0xf2bb52ab, _0x50c58425.Pearl);
        this._0x6401268f = _0x1b8c9d8a.IconAction(_0xdc210738, _0xa7e82771._0x9ec49df8(new byte[9] { 96, 81, 69, 67, 85, 99, 92, 95, 68 }, 48), new Vector2(0.5f, 1f), new Vector2(500f, -150f), 112f, _0xdcb541b4, _0x50c58425.WithAlpha(_0x50c58425.Surface, 0.95f), _0xc730447a, _0x50c58425.Pearl);
        this._0x99bec0f1 = _0x1b8c9d8a.Caption(_0xdc210738, _0xa7e82771._0x9ec49df8(new byte[10] { 34, 26, 0, 19, 1, 23, 62, 27, 28, 23 }, 114), new Vector2(0.5f, 1f), new Vector2(0f, -150f), new Vector2(560f, 88f), _0xa7e82771._0x9ec49df8(new byte[13] { 75, 83, 73, 90, 72, 94, 59, 42, 59, 52, 59, 42, 41 }, 27), 46f, _0x50c58425.Pearl, TextAlignmentOptions.Center, _0x558e1212);
        this.BuildMeter(_0xdc210738, _0xdcb541b4, _0x08c61658, _0x558e1212);
        this._0x4c7580c3 = this.Readout(_0xdc210738, _0xa7e82771._0x9ec49df8(new byte[8] { 130, 160, 160, 182, 177, 162, 160, 186 }, 195), -380f, _0xa7e82771._0x9ec49df8(new byte[4] { 35, 34, 34, 55 }, 18), _0xa7e82771._0x9ec49df8(new byte[8] { 226, 224, 224, 246, 241, 226, 224, 250 }, 163), _0x50c58425.Jade, _0x558e1212);
        this._0x42299021 = this.Readout(_0xdc210738, _0xa7e82771._0x9ec49df8(new byte[6] { 69, 98, 100, 115, 119, 125 }, 22), 0f, _0xa7e82771._0x9ec49df8(new byte[2] { 91, 19 }, 35), _0xa7e82771._0x9ec49df8(new byte[6] { 177, 182, 176, 167, 163, 169 }, 226), _0x50c58425.Topaz, _0x558e1212);
        _0x1b8c9d8a.Caption(_0xdc210738, _0xa7e82771._0x9ec49df8(new byte[9] { 54, 18, 8, 8, 55, 26, 25, 30, 23 }, 123), new Vector2(0.5f, 1f), new Vector2(380f, -500f), new Vector2(340f, 44f), _0xa7e82771._0x9ec49df8(new byte[11] { 10, 3, 18, 102, 18, 14, 20, 9, 19, 1, 14 }, 70), 32f, _0x50c58425.Pearl, TextAlignmentOptions.Center, _0x558e1212);
        for (int _0x17fcf987 = 0; _0x17fcf987 < MissPips; _0x17fcf987++)
        {
            this._0x01ae4203[_0x17fcf987] = _0x1b8c9d8a.Picture(_0xdc210738, _0xa7e82771._0x9ec49df8(new byte[7] { 166, 130, 152, 152, 187, 130, 155 }, 235), new Vector2(0.5f, 1f), new Vector2(380f + ((_0x17fcf987 - 2) * 48f), -442f), new Vector2(34f, 34f), _0xdb85d25d, _0x50c58425.WithAlpha(_0x50c58425.Pearl, 0.28f));
        }

        for (int _0x7b43efe3 = 0; _0x7b43efe3 < BeatDots; _0x7b43efe3++)
        {
            this._0xf313c623[_0x7b43efe3] = _0x1b8c9d8a.Picture(_0xdc210738, _0xa7e82771._0x9ec49df8(new byte[7] { 175, 136, 140, 153, 189, 132, 157 }, 237), new Vector2(0.5f, 1f), new Vector2((_0x7b43efe3 - 1.5f) * 62f, -572f), new Vector2(34f, 34f), _0xdb85d25d, _0x50c58425.WithAlpha(_0x50c58425.Pearl, 0.25f));
        }

        // The control hint names the gesture AND what it does, and it never fades
        // out completely - a hint nobody can read on the review frames is not a hint
        // (rule C.6).
        this._0x04620abb = _0x1b8c9d8a.Caption(_0xdc210738, _0xa7e82771._0x9ec49df8(new byte[11] { 182, 154, 155, 129, 135, 154, 153, 189, 156, 155, 129 }, 245), new Vector2(0.5f, 0f), new Vector2(0f, 300f), new Vector2(1060f, 78f), _0xa7e82771._0x9ec49df8(new byte[39] { 144, 133, 148, 228, 144, 140, 129, 228, 136, 141, 144, 228, 131, 129, 137, 151, 228, 228, 233, 228, 228, 140, 139, 136, 128, 228, 144, 140, 129, 228, 148, 129, 133, 150, 136, 228, 131, 129, 137 }, 196), 40f, _0x50c58425.Topaz, TextAlignmentOptions.Center, _0x558e1212);
    }

    private Tween _0xb68b377a;
    /// After the opening seconds the hint steps back, but it stays legible for the
    /// whole run rather than disappearing.
    public void _0xaf042d64()
    {
        if (this._0x04620abb == null)
        {
            return;
        }

        if (this._0xb68b377a != null)
        {
            this._0xb68b377a.Kill(false);
        }

        this._0xb68b377a = DOTween.To(() => this._0x04620abb.alpha, _0x9450ee34 => this._0x75239156(_0x9450ee34), 0.5f, 0.8f);
    }

    private const int MissPips = 5;
    private float _0x267ae803;
    private void OnDestroy()
    {
        if (this._0x136136b4 != null)
        {
            this._0x136136b4.Kill(false);
            this._0x136136b4 = null;
        }

        if (this._0xb68b377a != null)
        {
            this._0xb68b377a.Kill(false);
            this._0xb68b377a = null;
        }
    }

    public void _0xa4846563(int _0x055c549f)
    {
        if (this._0x42299021 == null)
        {
            return;
        }

        this._0x42299021.text = _0xa7e82771._0x9ec49df8(new byte[1] { 181 }, 205) + _0x055c549f;
        this._0x42299021.transform.DOKill(true);
        this._0x42299021.transform.DOPunchScale(Vector3.one * 0.12f, 0.2f, 8, 0.7f);
    }

    public void _0x682da06d(int _0x27403058)
    {
        if (this._0x4c7580c3 != null)
        {
            this._0x4c7580c3.text = _0x27403058 + _0xa7e82771._0x9ec49df8(new byte[1] { 241 }, 212);
        }
    }

    public void _0xd306d767(float _0xfe20e674)
    {
        float _0x0e35eb3a = Mathf.Clamp01(_0xfe20e674);
        if (this._0x677d540f != null)
        {
            if (this._0x136136b4 != null)
            {
                this._0x136136b4.Kill(false);
            }

            this._0x136136b4 = DOTween.To(() => this._0x677d540f.sizeDelta.x, _0xf4d2b5e7 => this._0xe3bbf32b(_0xf4d2b5e7), this._0x267ae803 * _0x0e35eb3a, 0.24f).SetEase(Ease.OutCubic);
        }

        if (this._0x0bf8918f != null)
        {
            Color _0x5724b6f7 = _0x0e35eb3a > 0.6f ? _0x50c58425.Jade : (_0x0e35eb3a > 0.3f ? _0x50c58425.Topaz : _0x50c58425.Ruby);
            this._0x0bf8918f.color = _0x5724b6f7;
        }
    }

    public Button _0x8613e286
    {
        get
        {
            return this._0x553aa7c6;
        }
    }

    public Button _0xd32b11fb
    {
        get
        {
            return this._0x6401268f;
        }
    }

    private Tween _0x136136b4;
    private Button _0x6401268f;
    private readonly Image[] _0xf313c623 = new Image[BeatDots];
    public void _0x9117a7a9(int _0x581db695)
    {
        for (int _0x5efbfc4a = 0; _0x5efbfc4a < MissPips; _0x5efbfc4a++)
        {
            if (this._0x01ae4203[_0x5efbfc4a] == null)
            {
                continue;
            }

            bool _0xc88f5437 = _0x5efbfc4a < _0x581db695;
            this._0x01ae4203[_0x5efbfc4a].color = _0xc88f5437 ? _0x50c58425.Rose : _0x50c58425.WithAlpha(_0x50c58425.Pearl, 0.28f);
        }
    }

    private void _0x75239156(float _0xbe8a926e)
    {
        if (this._0x04620abb != null)
        {
            this._0x04620abb.alpha = _0xbe8a926e;
        }
    }

    private RectTransform _0x677d540f;
}

internal static class _0xa7e82771
{
    internal static string _0x9ec49df8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}