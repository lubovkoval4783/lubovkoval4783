using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Construction helpers for the UGUI this game builds at runtime. Every number is
/// expressed in the canvas reference resolution (1242 x 2688), so one set of
/// coordinates reads the same on every device.
///
/// Draw order inside a canvas is sibling order, so each helper adds its fill
/// FIRST and its glyph or caption after: a background can never cover its own
/// label (rule C.13 / E.1).
public static class _0x1b8c9d8a
{
    public static TextMeshProUGUI Caption(Transform _0x88612e27, string _0xeeed4ff7, Vector2 _0x91efec5c, Vector2 _0x6e0b71c8, Vector2 _0x8cba6f6a, string _0x54b61ad9, float _0x401900f6, Color _0xe34f7196, TextAlignmentOptions _0xbd01dfb3, TMP_FontAsset _0x4e42a856)
    {
        RectTransform _0x8011ac11 = Node(_0x88612e27, _0xeeed4ff7, _0x91efec5c, _0x6e0b71c8, _0x8cba6f6a);
        TextMeshProUGUI _0x7d6c50cd = _0x8011ac11.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x4e42a856 != null)
        {
            _0x7d6c50cd.font = _0x4e42a856;
        }

        _0x7d6c50cd.text = _0x54b61ad9;
        _0x7d6c50cd.alignment = _0xbd01dfb3;
        _0x7d6c50cd.raycastTarget = false;
        _0x08792947.ApplyLayout(_0x7d6c50cd, _0x401900f6);
        _0x08792947.ApplyOutline(_0x7d6c50cd, _0xe34f7196);
        return _0x7d6c50cd;
    }

    /// Corner radius of a 9-sliced plate comes from this multiplier: the higher it
    /// is, the smaller the drawn border and the sharper the corner. It also has to
    /// keep the two borders from meeting in the middle of a small plate, which is
    /// what turns a 26px dot into a smear - hence the size-aware floor.
    public static float SliceScale(Vector2 _0xc3529946)
    {
        float _0xf16b4d31 = Mathf.Max(1f, Mathf.Min(_0xc3529946.x, _0xc3529946.y));
        return Mathf.Max(1.4f, 160f / _0xf16b4d31);
    }

    public const float RefWidth = 1242f;
    /// A 9-sliced plate: stretching is its purpose, so no aspect is preserved.
    public static Image Plate(Transform _0x160b9629, string _0x0227144e, Vector2 _0x993ae3d9, Vector2 _0x830bed77, Vector2 _0x81dca4af, Sprite _0xb6c117f5, Color _0x72b452e8)
    {
        RectTransform _0x20c0006b = Node(_0x160b9629, _0x0227144e, _0x993ae3d9, _0x830bed77, _0x81dca4af);
        Image _0x5599f2cf = _0x20c0006b.gameObject.AddComponent<Image>();
        _0x5599f2cf.sprite = _0xb6c117f5;
        _0x5599f2cf.type = _0xb6c117f5 != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x5599f2cf.pixelsPerUnitMultiplier = SliceScale(_0x81dca4af);
        _0x5599f2cf.color = _0x72b452e8;
        _0x5599f2cf.raycastTarget = false;
        return _0x5599f2cf;
    }

    /// Content art: the sprite keeps its own proportions, whatever box it is given.
    public static Image Picture(Transform _0x9e91062b, string _0xd4d4ecbf, Vector2 _0xd0341494, Vector2 _0x9b667ffd, Vector2 _0x06513515, Sprite _0x8ab5bc72, Color _0x3359827d)
    {
        RectTransform _0xdd2fa5d8 = Node(_0x9e91062b, _0xd4d4ecbf, _0xd0341494, _0x9b667ffd, _0x06513515);
        Image _0xfad00452 = _0xdd2fa5d8.gameObject.AddComponent<Image>();
        _0xfad00452.sprite = _0x8ab5bc72;
        _0xfad00452.type = Image.Type.Simple;
        _0xfad00452.preserveAspect = true;
        _0xfad00452.color = _0x3359827d;
        _0xfad00452.raycastTarget = false;
        return _0xfad00452;
    }

    /// Full-surface tap target. A fully transparent Image is culled by the
    /// raycaster, so it keeps a trace of alpha and its mesh alive.
    public static Image TapSurface(Transform _0xbaae615f, string _0x531f1c54)
    {
        RectTransform _0xfbd4c907 = Stretch(_0xbaae615f, _0x531f1c54);
        Image _0x6d3e4033 = _0xfbd4c907.gameObject.AddComponent<Image>();
        _0x6d3e4033.color = new Color(0f, 0f, 0f, 0.004f);
        _0x6d3e4033.raycastTarget = true;
        _0x6d3e4033.canvasRenderer.cullTransparentMesh = false;
        return _0x6d3e4033;
    }

    public static void SetVisible(Component _0xdaa98c62, bool _0x69c392c1)
    {
        if (_0xdaa98c62 != null && _0xdaa98c62.gameObject.activeSelf != _0x69c392c1)
        {
            _0xdaa98c62.gameObject.SetActive(_0x69c392c1);
        }
    }

    /// Square icon button. The glyph is added after the fill, so it draws on top.
    public static Button IconAction(Transform _0x78deb4dd, string _0xc5d1dc28, Vector2 _0x2a37b0d3, Vector2 _0x684f8456, float _0xc1aba8f5, Sprite _0x353dc063, Color _0xd48db750, Sprite _0x440ca902, Color _0x91d7c074)
    {
        Button _0x47ef6a00 = Action(_0x78deb4dd, _0xc5d1dc28, _0x2a37b0d3, _0x684f8456, new Vector2(_0xc1aba8f5, _0xc1aba8f5), _0x353dc063, _0xd48db750, string.Empty, _0x08792947.UiFontFloor, _0x50c58425.Pearl, null);
        Picture(_0x47ef6a00.transform, _0xc5d1dc28 + _0x397c2f07._0xe71fa8f1(new byte[6] { 147, 171, 160, 181, 188, 164 }, 204), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xc1aba8f5 * 0.54f, _0xc1aba8f5 * 0.54f), _0x440ca902, _0x91d7c074);
        return _0x47ef6a00;
    }

    public const float RefHeight = 2688f;
    /// A rect whose anchors collapse to one point, so its size is exactly what is
    /// written here and is never inherited from a stretching parent.
    public static RectTransform Node(Transform _0x5f8a5964, string _0x11bf0d4f, Vector2 _0xc333240c, Vector2 _0xbc40d870, Vector2 _0xf444d839)
    {
        GameObject _0xe6a063ac = new GameObject(_0x11bf0d4f, typeof(RectTransform));
        RectTransform _0x12905f2b = _0xe6a063ac.GetComponent<RectTransform>();
        _0x12905f2b.SetParent(_0x5f8a5964, false);
        _0x12905f2b.anchorMin = _0xc333240c;
        _0x12905f2b.anchorMax = _0xc333240c;
        _0x12905f2b.pivot = new Vector2(0.5f, 0.5f);
        _0x12905f2b.anchoredPosition = _0xbc40d870;
        _0x12905f2b.sizeDelta = _0xf444d839;
        _0x12905f2b.localScale = Vector3.one;
        return _0x12905f2b;
    }

    /// A pressable surface. The fill is the press target AND the visible face, so
    /// the colour tint of the button actually shows; a transparent hit layer as the
    /// target graphic would give no press feedback at all.
    public static Button Action(Transform _0x4f5c365d, string _0xd7de666d, Vector2 _0x88019158, Vector2 _0x6849298e, Vector2 _0xaf74e2cc, Sprite _0x5eec8d5a, Color _0x22d6a5dc, string _0x46f5b55f, float _0x8ae08bb0, Color _0x5e56d2a2, TMP_FontAsset _0xe41a4bed)
    {
        RectTransform _0xb4a0c0b9 = Node(_0x4f5c365d, _0xd7de666d, _0x88019158, _0x6849298e, _0xaf74e2cc);
        Image _0x17d7adb1 = _0xb4a0c0b9.gameObject.AddComponent<Image>();
        _0x17d7adb1.sprite = _0x5eec8d5a;
        _0x17d7adb1.type = _0x5eec8d5a != null ? Image.Type.Sliced : Image.Type.Simple;
        _0x17d7adb1.pixelsPerUnitMultiplier = SliceScale(_0xaf74e2cc);
        _0x17d7adb1.color = _0x22d6a5dc;
        _0x17d7adb1.raycastTarget = true;
        _0x17d7adb1.canvasRenderer.cullTransparentMesh = false;
        Button _0x07a6917b = _0xb4a0c0b9.gameObject.AddComponent<Button>();
        _0x07a6917b.targetGraphic = _0x17d7adb1;
        ColorBlock _0x6720d447 = _0x07a6917b.colors;
        _0x6720d447.normalColor = Color.white;
        _0x6720d447.highlightedColor = Color.white;
        _0x6720d447.pressedColor = new Color(0.7f, 0.7f, 0.7f, 1f);
        _0x6720d447.selectedColor = Color.white;
        _0x6720d447.disabledColor = new Color(0.5f, 0.5f, 0.5f, 0.6f);
        _0x6720d447.colorMultiplier = 1f;
        _0x6720d447.fadeDuration = 0.08f;
        _0x07a6917b.colors = _0x6720d447;
        if (!string.IsNullOrEmpty(_0x46f5b55f))
        {
            Caption(_0xb4a0c0b9, _0xd7de666d + _0x397c2f07._0xe71fa8f1(new byte[5] { 190, 149, 132, 153, 149 }, 225), new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xaf74e2cc.x - 44f, _0xaf74e2cc.y - 26f), _0x46f5b55f, _0x8ae08bb0, _0x5e56d2a2, TextAlignmentOptions.Center, _0xe41a4bed);
        }

        return _0x07a6917b;
    }

    /// A rect stretched over its whole parent. Hosts made with new GameObject(...)
    /// start at 100x100, and every child would then resolve its anchors against
    /// 100x100 instead of the panel - so this is applied immediately after parenting.
    public static RectTransform Stretch(Transform _0x8693d003, string _0x459539be)
    {
        GameObject _0x93053901 = new GameObject(_0x459539be, typeof(RectTransform));
        RectTransform _0xb195815a = _0x93053901.GetComponent<RectTransform>();
        _0xb195815a.SetParent(_0x8693d003, false);
        _0xb195815a.anchorMin = Vector2.zero;
        _0xb195815a.anchorMax = Vector2.one;
        _0xb195815a.offsetMin = Vector2.zero;
        _0xb195815a.offsetMax = Vector2.zero;
        _0xb195815a.localScale = Vector3.one;
        return _0xb195815a;
    }
}

internal static class _0x397c2f07
{
    internal static string _0xe71fa8f1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}