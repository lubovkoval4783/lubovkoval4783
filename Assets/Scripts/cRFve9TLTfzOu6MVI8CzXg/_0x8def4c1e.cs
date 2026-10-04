using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Everything this game does TO the scene template: reaching panel bodies by their
/// SETTINGS index, clearing the bodies it rebuilds, blanking the filler copy the
/// template ships on pages this game never opens, theming the splash loading bar
/// and dressing the splash with an abstract mark.
///
/// Panels are addressed by index only. Names do not survive obfuscation, and the
/// controllers index their pools, so an index is the one durable handle.
public static class _0x8def4c1e
{
    /// Splash bar: a gold fill on a stage-black track with real alpha. The template
    /// ships both white, the track at alpha 0.004, which reads as no bar at all.
    ///
    /// The bar keeps the size its prefab gives it. Its Fill Area insets itself
    /// inside that root by 30 x 80 units, so shrinking the root collapses both the
    /// track and the fill to nothing.
    public static void ThemeSplashSlider()
    {
        Transform _0xc8d488cf = PanelBody(_0xc29566dc._0x97b1c56c.SPLASH);
        if (_0xc8d488cf == null)
        {
            return;
        }

        Slider _0x9b1fbb5b = _0xc8d488cf.GetComponentInChildren<Slider>(true);
        if (_0x9b1fbb5b == null)
        {
            return;
        }

        Image _0xc6efe97b = _0x9b1fbb5b.fillRect != null ? _0x9b1fbb5b.fillRect.GetComponent<Image>() : null;
        if (_0xc6efe97b != null)
        {
            _0xc6efe97b.color = _0x50c58425.Topaz;
        }

        Transform _0x1e5e3fea = _0x9b1fbb5b.fillRect != null ? _0x9b1fbb5b.fillRect.parent : null;
        Image _0xfb32a97d = _0x1e5e3fea != null ? _0x1e5e3fea.GetComponent<Image>() : null;
        if (_0xfb32a97d != null)
        {
            _0xfb32a97d.color = _0x50c58425.TrackDark;
        }
    }

    /// Empties the filler strings out of every template page this game does not
    /// dress itself. The page stays in the pool - the controller addresses panels
    /// by index and a removed page would break its navigation.
    public static void BlankUnusedPages()
    {
        for (int _0xa1b671a8 = 0; _0xa1b671a8 < _0x00ec0a51.Length; _0xa1b671a8++)
        {
            Transform _0x12afce0f = PanelBody(_0x00ec0a51[_0xa1b671a8]);
            if (_0x12afce0f == null)
            {
                continue;
            }

            TMP_Text[] _0x82243c8e = _0x12afce0f.GetComponentsInChildren<TMP_Text>(true);
            for (int _0x2ba5e5f5 = 0; _0x2ba5e5f5 < _0x82243c8e.Length; _0x2ba5e5f5++)
            {
                if (_0x82243c8e[_0x2ba5e5f5] != null)
                {
                    _0x82243c8e[_0x2ba5e5f5].text = string.Empty;
                }
            }
        }
    }

    /// Every tutorial page the template declares. This game leaves
    /// SETUP_OBJECT.IsTutorialEnabled at 0 and explains its control on its own HOW
    /// TO PLAY sheet plus a permanent hint in the run, so none of these pages is
    /// ever shown - but the template copy on them must not reach the build either.
    private static readonly int[] _0x00ec0a51 =
    {
        _0xc29566dc._0x97b1c56c.TUTORIAL0,
        _0xc29566dc._0x97b1c56c.TUTORIAL1,
        _0xc29566dc._0x97b1c56c.TUTORIAL2,
        _0xc29566dc._0x97b1c56c.TUTORIAL3,
        _0xc29566dc._0x97b1c56c.TUTORIAL4,
        _0xc29566dc._0x97b1c56c.TUTORIAL5,
        _0xc29566dc._0x97b1c56c.TUTORIAL6,
    };
    /// The splash mark: a faceted jewel inside a fan of light, and one functional
    /// line. Branding here is shape and colour - there is no name on screen, by
    /// design and by rule.
    public static void DressSplash(TMP_FontAsset _0xc7ae9613, Sprite _0x4b47fe8c, Sprite _0xbce4e954, Sprite _0x709a2ebc)
    {
        Transform _0x88c083b5 = PanelBody(_0xc29566dc._0x97b1c56c.SPLASH);
        if (_0x88c083b5 == null)
        {
            return;
        }

        RectTransform _0x6c214f5c = _0x1b8c9d8a.Stretch(_0x88c083b5, _0xc962db2a._0xe184f6e9(new byte[10] { 148, 183, 171, 166, 180, 175, 138, 166, 181, 172 }, 199));
        _0x6c214f5c.SetAsFirstSibling();
        Image _0xc0175ebe = _0x6c214f5c.gameObject.AddComponent<Image>();
        _0xc0175ebe.color = _0x50c58425.WithAlpha(_0x50c58425.Ink, 0.72f);
        _0xc0175ebe.raycastTarget = false;
        RectTransform _0xb0f261a0 = _0x1b8c9d8a.Node(_0x6c214f5c, _0xc962db2a._0xe184f6e9(new byte[9] { 25, 58, 38, 43, 57, 34, 12, 43, 36 }, 74), new Vector2(0.5f, 0.5f), new Vector2(0f, 300f), new Vector2(620f, 620f));
        for (int _0xa190b2d1 = 0; _0xa190b2d1 < 18; _0xa190b2d1++)
        {
            float _0xa28a0da1 = (360f / 18f) * _0xa190b2d1;
            float _0x578b5e14 = _0xa28a0da1 * Mathf.Deg2Rad;
            Image _0x69f2d38d = _0x1b8c9d8a.Plate(_0xb0f261a0, _0xc962db2a._0xe184f6e9(new byte[11] { 192, 227, 255, 242, 224, 251, 192, 227, 252, 248, 246 }, 147), new Vector2(0.5f, 0.5f), new Vector2(Mathf.Sin(_0x578b5e14) * 250f, Mathf.Cos(_0x578b5e14) * 250f), new Vector2(54f, 16f), _0x709a2ebc, _0x50c58425.WithAlpha(_0xa190b2d1 % 3 == 0 ? _0x50c58425.Topaz : _0x50c58425.Amethyst, 0.85f));
            _0x69f2d38d.rectTransform.localRotation = Quaternion.Euler(0f, 0f, -_0xa28a0da1);
        }

        _0x1b8c9d8a.Picture(_0xb0f261a0, _0xc962db2a._0xe184f6e9(new byte[9] { 131, 160, 188, 177, 163, 184, 130, 177, 169 }, 208), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(430f, 430f), _0xbce4e954, _0x50c58425.WithAlpha(_0x50c58425.Amethyst, 0.55f));
        _0x1b8c9d8a.Picture(_0xb0f261a0, _0xc962db2a._0xe184f6e9(new byte[12] { 210, 241, 237, 224, 242, 233, 196, 236, 227, 237, 228, 236 }, 129), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(300f, 300f), _0x4b47fe8c, _0x50c58425.Pearl);
        _0x1b8c9d8a.Caption(_0x6c214f5c, _0xc962db2a._0xe184f6e9(new byte[10] { 131, 160, 188, 177, 163, 184, 156, 185, 190, 181 }, 208), new Vector2(0.5f, 0.5f), new Vector2(0f, -170f), new Vector2(820f, 78f), _0xc962db2a._0xe184f6e9(new byte[16] { 230, 231, 252, 251, 252, 245, 146, 230, 250, 247, 146, 225, 230, 243, 245, 247 }, 178), 40f, _0x50c58425.Pearl, TextAlignmentOptions.Center, _0xc7ae9613);
        _0x1b8c9d8a.Plate(_0x6c214f5c, _0xc962db2a._0xe184f6e9(new byte[10] { 108, 79, 83, 94, 76, 87, 109, 74, 83, 90 }, 63), new Vector2(0.5f, 0.5f), new Vector2(0f, -240f), new Vector2(460f, 8f), _0x709a2ebc, _0x50c58425.WithAlpha(_0x50c58425.Topaz, 0.9f));
        // The loading bar must remain the LAST child of the splash body, or the mark
        // built above would be drawn over it.
        Slider _0xbc0c0db3 = _0x88c083b5.GetComponentInChildren<Slider>(true);
        if (_0xbc0c0db3 != null)
        {
            Transform _0xca6efa66 = _0xbc0c0db3.transform;
            while (_0xca6efa66.parent != null && _0xca6efa66.parent != _0x88c083b5)
            {
                _0xca6efa66 = _0xca6efa66.parent;
            }

            _0xca6efa66.SetAsLastSibling();
        }
    }

    /// The same, but keeping one branch alive - the menu needs the template's own
    /// scene-loading control, which this game re-dresses instead of duplicating.
    public static void ClearPanelBody(int _0x0620409b, Transform _0x137027c8)
    {
        Transform _0x28e50d45 = PanelBody(_0x0620409b);
        if (_0x28e50d45 == null)
        {
            return;
        }

        for (int _0xefcad0b3 = _0x28e50d45.childCount - 1; _0xefcad0b3 >= 0; _0xefcad0b3--)
        {
            Transform _0x4fe6422c = _0x28e50d45.GetChild(_0xefcad0b3);
            if (_0x4fe6422c == null)
            {
                continue;
            }

            if (_0x4fe6422c.GetComponentInChildren<_0x11d21c90>(true) != null)
            {
                continue;
            }

            if (_0x137027c8 != null && (_0x4fe6422c == _0x137027c8 || _0x137027c8.IsChildOf(_0x4fe6422c)))
            {
                continue;
            }

            _0x4fe6422c.gameObject.SetActive(false);
        }
    }

    public static Transform PanelBody(int _0x64791fb4)
    {
        _0xb67d6cae _0x3149845c = _0xb67d6cae.Instance;
        if (_0x3149845c == null || _0x3149845c.Panels == null)
        {
            return null;
        }

        if (_0x64791fb4 < 0 || _0x64791fb4 >= _0x3149845c.Panels.Count)
        {
            return null;
        }

        _0xb894d724 _0xf8868b25 = _0x3149845c.Panels[_0x64791fb4];
        if (_0xf8868b25 == null || _0xf8868b25.Content == null)
        {
            return null;
        }

        return _0xf8868b25.Content.transform;
    }

    /// Switches off whatever the template put into a panel body so this game can
    /// build its own. A branch holding a pop is left alone: pops are addressed by
    /// index and must stay reachable.
    public static void ClearPanelBody(int _0xcc9adf7c)
    {
        ClearPanelBody(_0xcc9adf7c, null);
    }
}

internal static class _0xc962db2a
{
    internal static string _0xe184f6e9(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}