using DG.Tweening;
using UnityEngine;

/// The stage itself: proscenium frame, haze, footlight strip, five pedestals and
/// the five gems that stand on them, plus the metronome ring, the hold ribbon and
/// a small pool of sparks.
///
/// Not one size here is a literal. The camera gives the half height and the
/// aspect, the arc takes an agreed fraction of the screen width, and the pitch
/// between gems and every gem's own size fall out of that (rule C.0). The same
/// board therefore composes correctly in the menu preview and in the run, with
/// only the fractions below telling them apart.
public sealed class _0xc045d7a0 : MonoBehaviour
{
    [SerializeField]
    private Sprite _gemRuby;
    [SerializeField]
    private bool _showRing = true;
    [SerializeField]
    private float _ringCentreFraction = 0.16f;
    [SerializeField]
    private SpriteRenderer _haloPrefab;
    [SerializeField]
    private Sprite _gemStar;
    [SerializeField]
    private SpriteRenderer _archPrefab;
    private Sprite _0x668beed3(int _0xfa216f20)
    {
        if (_0xfa216f20 == 0)
        {
            return this._gemAmethyst;
        }

        if (_0xfa216f20 == 1)
        {
            return this._gemRuby;
        }

        if (_0xfa216f20 == 2)
        {
            return this._gemTopaz;
        }

        if (_0xfa216f20 == 3)
        {
            return this._gemJade;
        }

        return this._gemStar;
    }

    [SerializeField]
    private bool _showFrame = true;
    private _0xe8dae38a _0x5ac6dba9;
    [SerializeField]
    private Sprite _gemAmethyst;
    /// The ribbon of light that rises out of a gem while it is being held. Its
    /// height is the hold length, so the player sees how much is left.
    public void _0x0f7e8540(int _0x011a3221, float _0x15b7fe9a)
    {
        if (this._0xcad43ed7 == null)
        {
            return;
        }

        Vector2 _0x805f564c = this._0x1f807002(_0x011a3221);
        float _0x63e8db72 = this._0x361ffa3a * 2.6f;
        this._0xf6f19f43();
        this._0xcad43ed7.DOKill(false);
        this._0xcad43ed7.size = new Vector2(this._0xfe5d043b * 0.34f, this._0x361ffa3a * 0.2f);
        this._0xcad43ed7.transform.position = new Vector3(_0x805f564c.x, _0x805f564c.y, 0f);
        this._0xcad43ed7.color = _0x50c58425.WithAlpha(_0x50c58425.Pearl, 0.95f);
        this._0x153cf841 = DOTween.To(() => this._0xcad43ed7.size.y, _0x6f660d39 => this.SetRibbonHeight(_0x805f564c, _0x6f660d39), _0x63e8db72, Mathf.Max(0.1f, _0x15b7fe9a)).SetEase(Ease.Linear);
    }

    private const int BurstPool = 8;
    private const int GemCount = 5;
    [SerializeField]
    private SpriteRenderer _footlightPrefab;
    [SerializeField]
    private SpriteRenderer _hazePrefab;
    private Tween _0x153cf841;
    private Camera _0xcecf4cb7;
    [SerializeField]
    private SpriteRenderer _ribbonPrefab;
    public void _0x04307edc()
    {
        if (this._0xcad43ed7 == null)
        {
            return;
        }

        this._0xf6f19f43();
        this._0xcad43ed7.DOKill(false);
        this._0xcad43ed7.color = _0x50c58425.WithAlpha(_0x50c58425.Pearl, 0f);
    }

    private float _0x361ffa3a;
    /// Which gem a touch belongs to. The catch radius is generous on purpose: the
    /// arc is a row of thumb targets, not a set of pixel-accurate buttons.
    public int _0x7860b5c6(Vector2 _0xa687a964)
    {
        int _0x302403c8 = -1;
        float _0x70d48b24 = this._0xfe5d043b * 0.85f;
        for (int _0x10b92675 = 0; _0x10b92675 < GemCount; _0x10b92675++)
        {
            float _0xec0a131c = Vector2.Distance(_0xa687a964, this._0x1688f4dc[_0x10b92675]);
            if (_0xec0a131c < _0x70d48b24)
            {
                _0x70d48b24 = _0xec0a131c;
                _0x302403c8 = _0x10b92675;
            }
        }

        return _0x302403c8;
    }

    private readonly _0x9f35f5f9[] _0x8deb054a = new _0x9f35f5f9[GemCount];
    private float _0xfe5d043b;
    public void _0xa45474dd()
    {
        for (int _0x57350189 = 0; _0x57350189 < GemCount; _0x57350189++)
        {
            if (this._0x8deb054a[_0x57350189] != null)
            {
                this._0x8deb054a[_0x57350189]._0x0262fa89();
            }
        }

        this._0x04307edc();
    }

    private void SetRibbonHeight(Vector2 _0x7dead4ef, float height)
    {
        if (this._0xcad43ed7 == null)
        {
            return;
        }

        this._0xcad43ed7.size = new Vector2(this._0xfe5d043b * 0.34f, height);
        this._0xcad43ed7.transform.position = new Vector3(_0x7dead4ef.x, _0x7dead4ef.y + (height * 0.5f), 0f);
    }

    public void _0x8c3ef777(int _0xc7e4ebf5, Color _0xe06ed7de)
    {
        SpriteRenderer _0x19bac9a3 = this._0xd749a9c9[this._0x0368140b % BurstPool];
        this._0x0368140b++;
        if (_0x19bac9a3 == null)
        {
            return;
        }

        _0x19bac9a3.DOKill(false);
        _0x19bac9a3.transform.DOKill(false);
        _0x19bac9a3.transform.position = new Vector3(this._0x1f807002(_0xc7e4ebf5).x, this._0x1f807002(_0xc7e4ebf5).y, 0f);
        _0x19bac9a3.transform.localScale = Vector3.one * 0.4f;
        _0x19bac9a3.color = _0x50c58425.WithAlpha(_0xe06ed7de, 1f);
        _0x19bac9a3.transform.DOScale(1.3f, 0.34f).SetEase(Ease.OutQuad);
        _0x19bac9a3.DOFade(0f, 0.34f).SetEase(Ease.OutQuad);
    }

    [SerializeField]
    private Sprite _gemJade;
    [SerializeField]
    private Sprite _gemTopaz;
    private SpriteRenderer _0xcad43ed7;
    [SerializeField]
    private float _arcCentreFraction = -0.46f;
    public int _0x07abe8e6
    {
        get
        {
            return GemCount;
        }
    }

    /// The footlight strip answers every beat: gold on the strong one, amethyst on
    /// the weak ones. Together with the ring it is the whole tempo readout.
    public void _0xdef377c6(bool _0x361deb1e)
    {
        if (this._0x9bb19414 == null)
        {
            return;
        }

        this._0x9bb19414.DOKill(false);
        this._0x9bb19414.color = _0x50c58425.WithAlpha(_0x361deb1e ? _0x50c58425.Topaz : _0x50c58425.Amethyst, _0x361deb1e ? 1f : 0.75f);
        this._0x9bb19414.DOColor(_0x50c58425.WithAlpha(_0x50c58425.Amethyst, 0.45f), 0.16f).SetEase(Ease.OutQuad);
    }

    private bool _0xaf10a9ef;
    [SerializeField]
    private float _widthFraction = 0.86f;
    public float _0x20fcc4b3
    {
        get
        {
            return this._0xfe5d043b;
        }
    }

    [SerializeField]
    private SpriteRenderer _gemPrefab;
    private readonly Vector2[] _0x1688f4dc = new Vector2[GemCount];
    private readonly SpriteRenderer[] _0xd749a9c9 = new SpriteRenderer[BurstPool];
    public Camera _0xa7b3a759
    {
        get
        {
            return this._0xcecf4cb7;
        }
    }

    public Vector2 _0x1f807002(int _0xb7ffa0d5)
    {
        if (_0xb7ffa0d5 < 0 || _0xb7ffa0d5 >= GemCount)
        {
            return Vector2.zero;
        }

        return this._0x1688f4dc[_0xb7ffa0d5];
    }

    private void OnDestroy()
    {
        this._0xf6f19f43();
    }

    /// Spawns one prefab and gives it its computed size. Scale stays at one: the
    /// sliced size is the single source of truth for how big a sprite really is.
    private SpriteRenderer Place(SpriteRenderer _0x5c9ba346, Vector2 _0x0e1dcd5c, Vector2 _0xc55e0203, Color _0x944dc523)
    {
        if (_0x5c9ba346 == null)
        {
            return null;
        }

        SpriteRenderer _0xa4ddd33e = Instantiate(_0x5c9ba346, this.transform);
        _0xa4ddd33e.transform.position = new Vector3(_0x0e1dcd5c.x, _0x0e1dcd5c.y, 0f);
        _0xa4ddd33e.transform.localScale = Vector3.one;
        _0xa4ddd33e.size = _0xc55e0203;
        _0xa4ddd33e.color = _0x944dc523;
        return _0xa4ddd33e;
    }

    [SerializeField]
    private float _ringWidthFraction = 0.41f;
    public _0xe8dae38a _0xb3901f69
    {
        get
        {
            return this._0x5ac6dba9;
        }
    }

    [SerializeField]
    private SpriteRenderer _ringPrefab;
    private SpriteRenderer _0x9bb19414;
    [SerializeField]
    private SpriteRenderer _burstPrefab;
    public _0x9f35f5f9 _0xde802e03(int _0xb5b97de8)
    {
        if (_0xb5b97de8 < 0 || _0xb5b97de8 >= GemCount)
        {
            return null;
        }

        return this._0x8deb054a[_0xb5b97de8];
    }

    private int _0x0368140b;
    private void _0xf6f19f43()
    {
        if (this._0x153cf841 != null)
        {
            this._0x153cf841.Kill(false);
            this._0x153cf841 = null;
        }
    }

    public void _0x408f76de()
    {
        if (this._0xaf10a9ef)
        {
            return;
        }

        this._0xaf10a9ef = true;
        this._0xcecf4cb7 = Camera.main;
        float _0x0ba17c4e = this._0xcecf4cb7 != null ? this._0xcecf4cb7.orthographicSize : 5f;
        float _0x521d7788 = _0x0ba17c4e * (this._0xcecf4cb7 != null ? this._0xcecf4cb7.aspect : 0.4615f);
        float _0x1bd14264 = 2f * _0x521d7788 * this._widthFraction;
        this._0xfe5d043b = _0x1bd14264 / GemCount;
        this._0x361ffa3a = this._0xfe5d043b * 0.86f;
        float _0x46163e79 = _0x0ba17c4e * this._arcCentreFraction;
        float _0xf2ff245a = this._0x361ffa3a * 0.35f;
        float _0x61a50637 = _0x46163e79 - (_0xf2ff245a * 0.5f);
        if (this._showFrame)
        {
            this.Place(this._hazePrefab, new Vector2(0f, _0x46163e79 + (this._0x361ffa3a * 1.1f)), new Vector2(2f * _0x521d7788, _0x0ba17c4e * 0.86f), _0x50c58425.WithAlpha(_0x50c58425.Amethyst, 0.34f));
            this.Place(this._archPrefab, Vector2.zero, new Vector2(2f * _0x521d7788, 2f * _0x0ba17c4e), _0x50c58425.WithAlpha(_0x50c58425.Topaz, 0.55f));
        }

        for (int _0x2a762628 = 0; _0x2a762628 < GemCount; _0x2a762628++)
        {
            float _0xdf6a5831 = (_0x2a762628 - 2f) / 2f;
            float _0x518f13f6 = (_0x2a762628 - 2f) * this._0xfe5d043b;
            float _0xfd5e2ad8 = _0x61a50637 + (_0xf2ff245a * (1f - (_0xdf6a5831 * _0xdf6a5831)));
            this._0x1688f4dc[_0x2a762628] = new Vector2(_0x518f13f6, _0xfd5e2ad8);
            this.Place(this._pedestalPrefab, new Vector2(_0x518f13f6, _0xfd5e2ad8 - (this._0x361ffa3a * 0.60f)), new Vector2(this._0xfe5d043b * 1.02f, this._0xfe5d043b * 0.30f), _0x50c58425.WithAlpha(_0x50c58425.SurfaceEdge, 0.95f));
            SpriteRenderer _0xe4e30a12 = this.Place(this._haloPrefab, this._0x1688f4dc[_0x2a762628], new Vector2(this._0x361ffa3a * 1.45f, this._0x361ffa3a * 1.45f), _0x50c58425.WithAlpha(_0x50c58425.Pearl, 0f));
            SpriteRenderer _0x91ac85f8 = this.Place(this._gemPrefab, this._0x1688f4dc[_0x2a762628], new Vector2(this._0x361ffa3a, this._0x361ffa3a), _0x50c58425.Pearl);
            if (_0x91ac85f8 == null)
            {
                continue;
            }

            _0x91ac85f8.sprite = this._0x668beed3(_0x2a762628);
            _0x9f35f5f9 _0x82a87e09 = _0x91ac85f8.gameObject.AddComponent<_0x9f35f5f9>();
            _0x82a87e09._0x71c47c80(_0x91ac85f8, _0xe4e30a12, _0x50c58425.Gem(_0x2a762628));
            this._0x8deb054a[_0x2a762628] = _0x82a87e09;
        }

        this._0x9bb19414 = this.Place(this._footlightPrefab, new Vector2(0f, _0x61a50637 - (this._0x361ffa3a * 1.05f)), new Vector2(_0x1bd14264, _0x0ba17c4e * 0.052f), _0x50c58425.WithAlpha(_0x50c58425.Amethyst, 0.9f));
        this._0xcad43ed7 = this.Place(this._ribbonPrefab, this._0x1688f4dc[GemCount - 1], new Vector2(this._0xfe5d043b * 0.34f, this._0x361ffa3a), _0x50c58425.WithAlpha(_0x50c58425.Pearl, 0f));
        if (this._showRing)
        {
            float _0x4a1dbf0d = 2f * _0x521d7788 * this._ringWidthFraction;
            SpriteRenderer _0xb87a49b5 = this.Place(this._ringPrefab, new Vector2(0f, _0x0ba17c4e * this._ringCentreFraction), new Vector2(_0x4a1dbf0d, _0x4a1dbf0d), _0x50c58425.WithAlpha(_0x50c58425.Topaz, 0.55f));
            if (_0xb87a49b5 != null)
            {
                this._0x5ac6dba9 = _0xb87a49b5.gameObject.AddComponent<_0xe8dae38a>();
                this._0x5ac6dba9._0x6180c4ce(_0xb87a49b5);
            }
        }

        for (int _0x900a2c84 = 0; _0x900a2c84 < BurstPool; _0x900a2c84++)
        {
            SpriteRenderer _0x96d99fa9 = this.Place(this._burstPrefab, this._0x1688f4dc[2], new Vector2(this._0x361ffa3a * 1.3f, this._0x361ffa3a * 1.3f), _0x50c58425.WithAlpha(_0x50c58425.Topaz, 0f));
            this._0xd749a9c9[_0x900a2c84] = _0x96d99fa9;
        }
    }

    [SerializeField]
    private SpriteRenderer _pedestalPrefab;
}