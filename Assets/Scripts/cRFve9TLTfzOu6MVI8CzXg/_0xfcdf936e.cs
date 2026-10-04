using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Builds the menu: the stardust readout, a live preview of the arc, what the
/// player is being asked to do, the records, the three tracks and the control
/// that starts a run.
///
/// The template's own scene-loading control is kept and re-dressed rather than
/// duplicated, so exactly one thing on this screen starts the show - and this
/// class never loads the scene itself, or the press would load it twice.
public sealed class _0xfcdf936e : MonoBehaviour
{
    [SerializeField]
    private Sprite _starIcon;
    private void _0xdf3d1d7b()
    {
        this._0xe0e9a87d._0x8d1701dc();
        this._0x66dd42f3 = 0;
        this._0x9bbbf53f();
        this._0x9b9d6301._0x233e0882(this._0xe0e9a87d._0xfbabe7f1);
        this._0x9b9d6301._0xa8eec101.transform.DOKill(true);
        this._0x9b9d6301._0xa8eec101.transform.DOPunchScale(Vector3.one * 0.09f, 0.3f, 8, 0.7f);
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private void Start()
    {
        _0x8def4c1e.BlankUnusedPages();
        _0x8def4c1e.ThemeSplashSlider();
        _0x8def4c1e.DressSplash(this._font, this._emblemSprite, this._raySprite, this._plateSprite);
        Transform _0xd2e87c58 = _0x8def4c1e.PanelBody(_0xc29566dc._0x97b1c56c.DEFAULT);
        if (_0xd2e87c58 == null)
        {
            return;
        }

        Transform _0x69c6cd46 = this._playSlot != null ? this._playSlot.transform : null;
        _0x8def4c1e.ClearPanelBody(_0xc29566dc._0x97b1c56c.DEFAULT, _0x69c6cd46);
        if (this._board != null)
        {
            this._board._0x408f76de();
            this._board._0xa45474dd();
        }

        this._0x66dd42f3 = this._0xe0e9a87d._0x263cd408;
        this._0x80248f93(_0xd2e87c58);
        this._0x2103acf8(_0xd2e87c58);
        this._0xe59e17ef(_0xd2e87c58);
        this._0xd63b9dac(_0xd2e87c58);
        this._0xdcff9436(_0xd2e87c58);
        this._0x18183449();
        this._0x65ce9b53 = new _0xae4000ec(this._font, this._plateSprite);
        this._0x65ce9b53._0xce7cff7b(_0xd2e87c58, this._closeIcon, this._ringIcon, this._gemIcon, this._starIcon);
        if (this._0x65ce9b53._0xc8a598db != null)
        {
            this._0x65ce9b53._0xc8a598db.onClick.AddListener(() => this._0xcf59d928());
        }

        if (this._0x65ce9b53._0x53c91681 != null)
        {
            this._0x65ce9b53._0x53c91681.onClick.AddListener(() => this._0xcf59d928());
        }

        if (this._0x65ce9b53._0xcd6ef6c0 != null)
        {
            this._0x65ce9b53._0xcd6ef6c0.onClick.AddListener(() => this._0xcf59d928());
        }

        this._0x9b9d6301 = new _0x1eacab71(this._font, this._plateSprite);
        this._0x9b9d6301._0xbfaac626(_0xd2e87c58, this._closeIcon);
        this._0x9b9d6301._0x233e0882(this._0xe0e9a87d._0xfbabe7f1);
        if (this._0x9b9d6301._0xb6094def != null)
        {
            this._0x9b9d6301._0xb6094def.onClick.AddListener(() => this._0xc655752f());
        }

        if (this._0x9b9d6301._0xa8eec101 != null)
        {
            this._0x9b9d6301._0xa8eec101.onClick.AddListener(() => this._0xdf3d1d7b());
        }

        if (this._0x9b9d6301._0x62adf262 != null)
        {
            this._0x9b9d6301._0x62adf262.onClick.AddListener(() => this._0xa1c7bb66());
        }

        if (this._0x9b9d6301._0x8ae03bae != null)
        {
            this._0x9b9d6301._0x8ae03bae.onClick.AddListener(() => this._0xa1c7bb66());
        }

        this._0x9bbbf53f();
    }

    /// One record. The value is the big thing on the card and the caption sits
    /// under it, both inside the card's own column, so three of them in a row can
    /// never print across one another.
    private TextMeshProUGUI _0x47dc3c04(Transform _0x38e9cf44, float _0xdf35d944, string _0xea20aa40, Color _0x0bf04bca)
    {
        Image _0xdf324ec4 = _0x1b8c9d8a.Plate(_0x38e9cf44, _0x64ac5f11._0xc477f20d(new byte[10] { 88, 111, 105, 101, 120, 110, 73, 107, 120, 110 }, 10), new Vector2(0.5f, 1f), new Vector2(_0xdf35d944, -1300f), new Vector2(340f, 190f), this._plateSprite, _0x50c58425.WithAlpha(_0x0bf04bca, 0.45f));
        Image _0x90b92195 = _0x1b8c9d8a.Plate(_0xdf324ec4.transform, _0x64ac5f11._0xc477f20d(new byte[10] { 13, 58, 60, 48, 45, 59, 25, 62, 60, 58 }, 95), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(316f, 166f), this._plateSprite, _0x50c58425.WithAlpha(_0x50c58425.Surface, 0.97f));
        TextMeshProUGUI _0xe4823a33 = _0x1b8c9d8a.Caption(_0x90b92195.transform, _0x64ac5f11._0xc477f20d(new byte[11] { 184, 143, 137, 133, 152, 142, 188, 139, 134, 159, 143 }, 234), new Vector2(0.5f, 1f), new Vector2(0f, -56f), new Vector2(296f, 84f), _0x64ac5f11._0xc477f20d(new byte[1] { 130 }, 175), 64f, _0x0bf04bca, TextAlignmentOptions.Center, this._font);
        _0x1b8c9d8a.Caption(_0x90b92195.transform, _0x64ac5f11._0xc477f20d(new byte[13] { 106, 93, 91, 87, 74, 92, 123, 89, 72, 76, 81, 87, 86 }, 56), new Vector2(0.5f, 1f), new Vector2(0f, -126f), new Vector2(296f, 48f), _0xea20aa40, 32f, _0x50c58425.Pearl, TextAlignmentOptions.Center, this._font);
        return _0xe4823a33;
    }

    private TextMeshProUGUI _0xc356176f;
    private int _0x66dd42f3;
    private void _0xc655752f()
    {
        this._0xe0e9a87d._0xfbabe7f1 = !this._0xe0e9a87d._0xfbabe7f1;
        this._0x9b9d6301._0x233e0882(this._0xe0e9a87d._0xfbabe7f1);
        if (this._0xe0e9a87d._0xfbabe7f1)
        {
            try
            {
                Handheld.Vibrate();
            }
            catch (System.Exception)
            {
            }
        }

        this._0x9b9d6301._0xb6094def.transform.DOKill(true);
        this._0x9b9d6301._0xb6094def.transform.DOPunchScale(Vector3.one * 0.07f, 0.26f, 8, 0.7f);
    }

    private readonly Image[] _0x8e22ad49 = new Image[_0x81d63b54.TrackCount];
    [SerializeField]
    private Sprite _gemIcon;
    private _0xae4000ec _0x65ce9b53;
    private void _0x9bbbf53f()
    {
        for (int _0x5fcf9749 = 0; _0x5fcf9749 < _0x81d63b54.TrackCount; _0x5fcf9749++)
        {
            bool _0xc3733a85 = _0x5fcf9749 == this._0x66dd42f3;
            if (this._0x4141cce3[_0x5fcf9749] != null)
            {
                this._0x4141cce3[_0x5fcf9749].color = _0xc3733a85 ? _0x50c58425.WithAlpha(_0x50c58425.Topaz, 1f) : _0x50c58425.WithAlpha(_0x50c58425.SurfaceEdge, 0.9f);
            }

            if (this._0x8e22ad49[_0x5fcf9749] != null)
            {
                this._0x8e22ad49[_0x5fcf9749].color = _0xc3733a85 ? _0x50c58425.WithAlpha(_0x50c58425.Surface, 0.99f) : _0x50c58425.WithAlpha(_0x50c58425.Surface, 0.55f);
            }
        }

        _0x9739adad _0x558a62d9 = _0x81d63b54.Track(this._0x66dd42f3);
        if (this._0x5ea8821a != null)
        {
            this._0x5ea8821a.text = _0x64ac5f11._0xc477f20d(new byte[14] { 159, 153, 138, 136, 128, 235, 152, 142, 159, 235, 235, 230, 235, 235 }, 203) + _0x558a62d9.Title + _0x64ac5f11._0xc477f20d(new byte[5] { 240, 240, 253, 240, 240 }, 208) + _0x558a62d9.Bpm + _0x64ac5f11._0xc477f20d(new byte[4] { 238, 140, 158, 131 }, 206);
        }

        if (this._0x3ac34078 != null)
        {
            this._0x3ac34078.text = _0x64ac5f11._0xc477f20d(new byte[7] { 19, 28, 1, 5, 23, 0, 114 }, 82) + _0x558a62d9.Phrases + _0x64ac5f11._0xc477f20d(new byte[20] { 41, 89, 65, 91, 72, 90, 76, 90, 41, 70, 71, 41, 93, 65, 76, 41, 75, 76, 72, 93 }, 9);
        }

        if (this._0x7e7f209f != null)
        {
            this._0x7e7f209f.text = this._0xe0e9a87d._0xe3cb90cf.ToString();
        }

        int _0xdfd8043f = this._0xe0e9a87d._0x8420aa52;
        if (this._0xae51a937 != null)
        {
            this._0xae51a937.text = _0xdfd8043f > 0 ? _0xdfd8043f + _0x64ac5f11._0xc477f20d(new byte[1] { 216 }, 253) : _0x64ac5f11._0xc477f20d(new byte[1] { 157 }, 176);
        }

        string _0x059688fc = this._0xe0e9a87d._0x6f23dc24;
        if (this._0x19461d13 != null)
        {
            this._0x19461d13.text = string.IsNullOrEmpty(_0x059688fc) ? _0x64ac5f11._0xc477f20d(new byte[1] { 36 }, 9) : _0x059688fc;
        }

        int _0xa87463c9 = this._0xe0e9a87d._0xdb9e8135;
        if (this._0xc356176f != null)
        {
            this._0xc356176f.text = _0xa87463c9 > 0 ? _0x64ac5f11._0xc477f20d(new byte[1] { 171 }, 211) + _0xa87463c9 : _0x64ac5f11._0xc477f20d(new byte[1] { 56 }, 21);
        }
    }

    private int _0x516d753e;
    [SerializeField]
    private Sprite _closeIcon;
    private void _0xaeb43532()
    {
        if (this._0x9b9d6301 != null)
        {
            this._0x9b9d6301._0x233e0882(this._0xe0e9a87d._0xfbabe7f1);
            this._0x9b9d6301._0x32e0a1b8(true);
        }
    }

    private Transform _0x8e26a75f;
    private TextMeshProUGUI _0x7e7f209f;
    [SerializeField]
    private _0xc045d7a0 _board;
    private void _0xd63b9dac(Transform _0xc319fc9a)
    {
        for (int _0x78049588 = 0; _0x78049588 < _0x81d63b54.TrackCount; _0x78049588++)
        {
            int _0xb4e9e30e = _0x78049588;
            _0x9739adad _0x59e83b45 = _0x81d63b54.Track(_0x78049588);
            Image _0xf869aafa = _0x1b8c9d8a.Plate(_0xc319fc9a, _0x64ac5f11._0xc477f20d(new byte[9] { 238, 200, 219, 217, 209, 249, 219, 200, 222 }, 186), new Vector2(0.5f, 1f), new Vector2((_0x78049588 - 1) * 380f, -1580f), new Vector2(360f, 300f), this._plateSprite, _0x50c58425.WithAlpha(_0x50c58425.SurfaceEdge, 0.9f));
            Image _0x48454843 = _0x1b8c9d8a.Plate(_0xf869aafa.transform, _0x64ac5f11._0xc477f20d(new byte[9] { 148, 178, 161, 163, 171, 134, 161, 163, 165 }, 192), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(336f, 276f), this._plateSprite, _0x50c58425.WithAlpha(_0x50c58425.Surface, 0.97f));
            _0x48454843.raycastTarget = true;
            _0x48454843.canvasRenderer.cullTransparentMesh = false;
            Button _0x85afba92 = _0x48454843.gameObject.AddComponent<Button>();
            _0x85afba92.targetGraphic = _0x48454843;
            ColorBlock _0xceef8a06 = _0x85afba92.colors;
            _0xceef8a06.normalColor = Color.white;
            _0xceef8a06.highlightedColor = Color.white;
            _0xceef8a06.pressedColor = new Color(0.72f, 0.72f, 0.72f, 1f);
            _0xceef8a06.selectedColor = Color.white;
            _0xceef8a06.disabledColor = new Color(0.5f, 0.5f, 0.5f, 0.6f);
            _0xceef8a06.colorMultiplier = 1f;
            _0xceef8a06.fadeDuration = 0.08f;
            _0x85afba92.colors = _0xceef8a06;
            _0x85afba92.onClick.AddListener(() => this._0xbaa4bbdf(_0xb4e9e30e));
            _0x1b8c9d8a.Caption(_0x48454843.transform, _0x64ac5f11._0xc477f20d(new byte[10] { 176, 150, 133, 135, 143, 176, 141, 144, 136, 129 }, 228), new Vector2(0.5f, 1f), new Vector2(0f, -48f), new Vector2(300f, 60f), _0x59e83b45.Title, 36f, _0x50c58425.Pearl, TextAlignmentOptions.Center, this._font);
            _0x1b8c9d8a.Caption(_0x48454843.transform, _0x64ac5f11._0xc477f20d(new byte[10] { 135, 161, 178, 176, 184, 135, 182, 190, 163, 188 }, 211), new Vector2(0.5f, 1f), new Vector2(0f, -118f), new Vector2(300f, 70f), _0x59e83b45.Bpm + _0x64ac5f11._0xc477f20d(new byte[4] { 123, 25, 11, 22 }, 91), 44f, _0x50c58425.Topaz, TextAlignmentOptions.Center, this._font);
            _0x1b8c9d8a.Caption(_0x48454843.transform, _0x64ac5f11._0xc477f20d(new byte[11] { 75, 109, 126, 124, 116, 83, 122, 113, 120, 107, 119 }, 31), new Vector2(0.5f, 1f), new Vector2(0f, -178f), new Vector2(300f, 52f), _0x59e83b45.Phrases + _0x64ac5f11._0xc477f20d(new byte[8] { 116, 4, 28, 6, 21, 7, 17, 7 }, 84), 34f, _0x50c58425.Jade, TextAlignmentOptions.Center, this._font);
            for (int _0xe5fa888a = 0; _0xe5fa888a < _0x81d63b54.TrackCount; _0xe5fa888a++)
            {
                _0x1b8c9d8a.Picture(_0x48454843.transform, _0x64ac5f11._0xc477f20d(new byte[8] { 118, 80, 67, 65, 73, 114, 75, 82 }, 34), new Vector2(0.5f, 1f), new Vector2((_0xe5fa888a - 1) * 54f, -236f), new Vector2(38f, 38f), this._pipSprite, _0xe5fa888a <= _0xb4e9e30e ? _0x50c58425.Topaz : _0x50c58425.WithAlpha(_0x50c58425.Pearl, 0.25f));
            }

            this._0x4141cce3[_0x78049588] = _0xf869aafa;
            this._0x8e22ad49[_0x78049588] = _0x48454843;
        }

        this._0x5ea8821a = _0x1b8c9d8a.Caption(_0xc319fc9a, _0x64ac5f11._0xc477f20d(new byte[11] { 74, 108, 127, 125, 117, 77, 106, 127, 106, 107, 109 }, 30), new Vector2(0.5f, 1f), new Vector2(0f, -1800f), new Vector2(1060f, 62f), _0x64ac5f11._0xc477f20d(new byte[9] { 137, 143, 156, 158, 150, 253, 142, 152, 137 }, 221), 36f, _0x50c58425.Topaz, TextAlignmentOptions.Center, this._font);
    }

    private TextMeshProUGUI _0x19461d13;
    private void _0xf5a844c4()
    {
        if (this._0x65ce9b53 != null)
        {
            this._0x65ce9b53._0xa3ebf60e(true);
        }
    }

    [SerializeField]
    private Sprite _ringIcon;
    private void _0xe59e17ef(Transform _0xa4bfdced)
    {
        this._0xae51a937 = this._0x47dc3c04(_0xa4bfdced, -368f, _0x64ac5f11._0xc477f20d(new byte[13] { 3, 4, 18, 21, 97, 0, 2, 2, 20, 19, 0, 2, 24 }, 65), _0x50c58425.Topaz);
        this._0x19461d13 = this._0x47dc3c04(_0xa4bfdced, 0f, _0x64ac5f11._0xc477f20d(new byte[9] { 132, 131, 149, 146, 230, 148, 135, 136, 141 }, 198), _0x50c58425.Pearl);
        this._0xc356176f = this._0x47dc3c04(_0xa4bfdced, 368f, _0x64ac5f11._0xc477f20d(new byte[14] { 253, 254, 255, 246, 244, 226, 229, 145, 226, 229, 227, 244, 240, 250 }, 177), _0x50c58425.Jade);
    }

    private readonly _0x2a2ce1f2 _0xe0e9a87d = new _0x2a2ce1f2();
    [SerializeField]
    private Sprite _plateSprite;
    private void _0xa1c7bb66()
    {
        if (this._0x9b9d6301 != null)
        {
            this._0x9b9d6301._0x32e0a1b8(false);
        }
    }

    /// The preview arc keeps calling a slow phrase of its own so the menu shows
    /// the mechanic rather than describing it.
    private void Update()
    {
        if (this._board == null)
        {
            return;
        }

        this._0x0dc55a11 += Time.deltaTime;
        if (this._0x0dc55a11 < PreviewBeat)
        {
            return;
        }

        this._0x0dc55a11 = 0f;
        this._board._0xdef377c6(this._0x516d753e % 4 == 0);
        _0x9f35f5f9 _0xe0f3723c = this._board._0xde802e03(this._0x516d753e % this._board._0x07abe8e6);
        if (_0xe0f3723c != null)
        {
            _0xe0f3723c.Call(PreviewBeat);
        }

        this._0x516d753e++;
    }

    [SerializeField]
    private Sprite _emblemSprite;
    private float _0x0dc55a11;
    [SerializeField]
    private Sprite _gearIcon;
    [SerializeField]
    private Sprite _raySprite;
    private void OnDestroy()
    {
        if (this._0x8e26a75f != null)
        {
            this._0x8e26a75f.DOKill(false);
        }
    }

    [SerializeField]
    private _0xb96b4dcd _playSlot;
    private void _0x80248f93(Transform _0x26863a61)
    {
        Image _0x69763208 = _0x1b8c9d8a.Plate(_0x26863a61, _0x64ac5f11._0xc477f20d(new byte[13] { 240, 215, 194, 209, 199, 214, 208, 215, 243, 207, 194, 215, 198 }, 163), new Vector2(0.5f, 1f), new Vector2(-320f, -150f), new Vector2(520f, 112f), this._plateSprite, _0x50c58425.WithAlpha(_0x50c58425.Surface, 0.96f));
        _0x1b8c9d8a.Picture(_0x69763208.transform, _0x64ac5f11._0xc477f20d(new byte[12] { 221, 250, 239, 252, 234, 251, 253, 250, 195, 239, 252, 229 }, 142), new Vector2(0f, 0.5f), new Vector2(66f, 0f), new Vector2(60f, 60f), this._pipSprite, _0x50c58425.Topaz);
        this._0x7e7f209f = _0x1b8c9d8a.Caption(_0x69763208.transform, _0x64ac5f11._0xc477f20d(new byte[13] { 188, 155, 142, 157, 139, 154, 156, 155, 185, 142, 131, 154, 138 }, 239), new Vector2(1f, 0.5f), new Vector2(-190f, 0f), new Vector2(340f, 84f), _0x64ac5f11._0xc477f20d(new byte[1] { 171 }, 155), 46f, _0x50c58425.Topaz, TextAlignmentOptions.Right, this._font);
        Button _0x32b60ecb = _0x1b8c9d8a.IconAction(_0x26863a61, _0x64ac5f11._0xc477f20d(new byte[12] { 72, 126, 111, 111, 114, 117, 124, 104, 72, 119, 116, 111 }, 27), new Vector2(0.5f, 1f), new Vector2(490f, -150f), 112f, this._plateSprite, _0x50c58425.WithAlpha(_0x50c58425.Surface, 0.96f), this._gearIcon, _0x50c58425.Pearl);
        _0x32b60ecb.onClick.AddListener(() => this._0xaeb43532());
        _0x1b8c9d8a.Picture(_0x26863a61, _0x64ac5f11._0xc477f20d(new byte[10] { 12, 36, 47, 52, 4, 44, 35, 45, 36, 44 }, 65), new Vector2(0.5f, 1f), new Vector2(0f, -360f), new Vector2(220f, 220f), this._emblemSprite, _0x50c58425.Pearl);
    }

    /// Choosing a track answers in three visible ways at once - the card takes the
    /// accent frame, the others step back, and the live line under the strip is
    /// rewritten. A caption change on its own would not read on a screenshot
    /// (rule C.7).
    private void _0xbaa4bbdf(int _0xa47ae4e5)
    {
        this._0x66dd42f3 = Mathf.Clamp(_0xa47ae4e5, 0, _0x81d63b54.TrackCount - 1);
        this._0xe0e9a87d._0x263cd408 = this._0x66dd42f3;
        this._0x9bbbf53f();
        if (this._0x4141cce3[this._0x66dd42f3] != null)
        {
            this._0x4141cce3[this._0x66dd42f3].transform.DOKill(true);
            this._0x4141cce3[this._0x66dd42f3].transform.DOPunchScale(Vector3.one * 0.07f, 0.26f, 8, 0.7f);
        }
    }

    private void _0xcf59d928()
    {
        if (this._0x65ce9b53 != null)
        {
            this._0x65ce9b53._0xa3ebf60e(false);
        }
    }

    private readonly Image[] _0x4141cce3 = new Image[_0x81d63b54.TrackCount];
    private TextMeshProUGUI _0x3ac34078;
    /// The template's play control ships invisible - the variant switches every
    /// layer of its own chrome off. A face is added as a CHILD of it, so the press
    /// still lands on the template button and the scene is loaded by its driver.
    private void _0x18183449()
    {
        if (this._playSlot == null)
        {
            return;
        }

        Transform _0x69a85331 = this._playSlot.transform;
        Image _0x31ad9258 = _0x1b8c9d8a.Plate(_0x69a85331, _0x64ac5f11._0xc477f20d(new byte[8] { 138, 182, 187, 163, 156, 187, 185, 191 }, 218), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(760f, 172f), this._plateSprite, _0x50c58425.Topaz);
        _0x31ad9258.raycastTarget = true;
        _0x31ad9258.canvasRenderer.cullTransparentMesh = false;
        _0x1b8c9d8a.Caption(_0x31ad9258.transform, _0x64ac5f11._0xc477f20d(new byte[9] { 11, 55, 58, 34, 23, 58, 57, 62, 55 }, 91), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(690f, 112f), _0x64ac5f11._0xc477f20d(new byte[4] { 223, 195, 206, 214 }, 143), 66f, _0x50c58425.Ink, TextAlignmentOptions.Center, this._font);
        this._0x8e26a75f = _0x31ad9258.transform;
        this._0x8e26a75f.localScale = Vector3.one;
        this._0x8e26a75f.DOScale(1.035f, 1.6f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    private void _0xdcff9436(Transform _0xf4a8af4d)
    {
        Button _0x9d6669c4 = _0x1b8c9d8a.Action(_0xf4a8af4d, _0x64ac5f11._0xc477f20d(new byte[9] { 138, 173, 181, 150, 173, 145, 174, 173, 182 }, 194), new Vector2(0.5f, 0f), new Vector2(0f, 518f), new Vector2(420f, 120f), this._plateSprite, _0x50c58425.WithAlpha(_0x50c58425.Amethyst, 0.95f), _0x64ac5f11._0xc477f20d(new byte[11] { 46, 41, 49, 70, 50, 41, 70, 54, 42, 39, 63 }, 102), 38f, _0x50c58425.Pearl, this._font);
        _0x9d6669c4.onClick.AddListener(() => this._0xf5a844c4());
        _0x1b8c9d8a.Caption(_0xf4a8af4d, _0x64ac5f11._0xc477f20d(new byte[8] { 176, 152, 147, 136, 181, 148, 147, 137 }, 253), new Vector2(0.5f, 0f), new Vector2(0f, 358f), new Vector2(1060f, 58f), _0x64ac5f11._0xc477f20d(new byte[39] { 143, 154, 139, 251, 143, 147, 158, 251, 151, 146, 143, 251, 156, 158, 150, 136, 251, 251, 246, 251, 251, 147, 148, 151, 159, 251, 143, 147, 158, 251, 139, 158, 154, 137, 151, 251, 156, 158, 150 }, 219), 34f, _0x50c58425.WithAlpha(_0x50c58425.Pearl, 0.9f), TextAlignmentOptions.Center, this._font);
    }

    private TextMeshProUGUI _0x5ea8821a;
    [SerializeField]
    private Sprite _pipSprite;
    private _0x1eacab71 _0x9b9d6301;
    private const float PreviewBeat = 0.62f;
    private void _0x2103acf8(Transform _0x33fae8d6)
    {
        this._0x3ac34078 = _0x1b8c9d8a.Caption(_0x33fae8d6, _0x64ac5f11._0xc477f20d(new byte[13] { 120, 85, 93, 82, 84, 67, 94, 65, 82, 123, 94, 89, 82 }, 55), new Vector2(0.5f, 1f), new Vector2(0f, -1070f), new Vector2(1060f, 70f), _0x64ac5f11._0xc477f20d(new byte[31] { 158, 137, 156, 137, 141, 152, 236, 152, 132, 137, 236, 128, 133, 152, 236, 139, 137, 129, 159, 236, 131, 130, 236, 152, 132, 137, 236, 142, 137, 141, 152 }, 204), 46f, _0x50c58425.Pearl, TextAlignmentOptions.Center, this._font);
        _0x1b8c9d8a.Caption(_0x33fae8d6, _0x64ac5f11._0xc477f20d(new byte[12] { 253, 208, 216, 215, 209, 198, 219, 196, 215, 225, 199, 208 }, 178), new Vector2(0.5f, 1f), new Vector2(0f, -1145f), new Vector2(1060f, 58f), _0x64ac5f11._0xc477f20d(new byte[30] { 17, 31, 31, 10, 122, 27, 25, 25, 15, 8, 27, 25, 3, 122, 27, 14, 122, 98, 111, 127, 122, 21, 8, 122, 18, 19, 29, 18, 31, 8 }, 90), 36f, _0x50c58425.Jade, TextAlignmentOptions.Center, this._font);
    }

    private TextMeshProUGUI _0xae51a937;
}

internal static class _0x64ac5f11
{
    internal static string _0xc477f20d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}