using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x6963dcb4 : MonoBehaviour
{
    private RectTransform _0xf1981880;
    private void _0x4c2fd4ea()
    {
        if (this._0x69b25de9 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0xade88964 = Screen.safeArea;
        Vector2 _0x3e9b93fd = _0xade88964.position;
        Vector2 _0xe77856a1 = _0xade88964.position + _0xade88964.size;
        _0x3e9b93fd.x /= screenWidth;
        _0x3e9b93fd.y /= screenHeight;
        _0xe77856a1.x /= screenWidth;
        _0xe77856a1.y /= screenHeight;
        this._0x69b25de9.anchorMin = _0x3e9b93fd;
        this._0x69b25de9.anchorMax = _0xe77856a1;
        this._0x69b25de9.offsetMin = Vector2.zero;
        this._0x69b25de9.offsetMax = Vector2.zero;
        if (this._0x3f50ac78 == null)
            return;
        Vector2 _0x504e545a = _0xe77856a1 - _0x3e9b93fd;
        float _0x64f91fc2 = 2f - _0x504e545a.x;
        float _0xe910fc0f = 2f - _0x504e545a.y;
        this._0x3f50ac78.referenceResolution = this._0x11bcd134 * new Vector2(_0x64f91fc2, _0xe910fc0f);
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0x5cdb70ce = 0; _0x5cdb70ce < _0x39717ce2.Count; _0x5cdb70ce++)
            _0x39717ce2[_0x5cdb70ce]._0x4c2fd4ea();
    }

    private static Rect _0x2a1008e4 = Rect.zero;
    private static bool _0x78138f06;
    private Vector2 _0x11bcd134;
    private CanvasScaler _0x3f50ac78;
    private void Awake()
    {
        if (!_0x39717ce2.Contains(this))
            _0x39717ce2.Add(this);
        this._0xd33af9c3 = this.GetComponent<Canvas>();
        this._0x3f50ac78 = this.GetComponent<CanvasScaler>();
        if (this._0x3f50ac78 != null)
            this._0x11bcd134 = this._0x3f50ac78.referenceResolution;
        this._0xf1981880 = this.GetComponent<RectTransform>();
        this._0x69b25de9 = this.transform.Find(_0xc8123609._0xeb6b1039(new byte[8] { 136, 186, 189, 190, 154, 169, 190, 186 }, 219)) as RectTransform;
        if (!_0x78138f06)
        {
            _0x16af5824 = Screen.orientation;
            _0x4d706829.x = Screen.width;
            _0x4d706829.y = Screen.height;
            _0x2a1008e4 = Screen.safeArea;
            _0x78138f06 = true;
        }

        this._0x4c2fd4ea();
    }

    private static void ResolutionChanged()
    {
        _0x4d706829.x = Screen.width;
        _0x4d706829.y = Screen.height;
        _0x2a1008e4 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xf8c8146f.Invoke();
    }

    private static void SafeAreaChanged()
    {
        _0x2a1008e4 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static ScreenOrientation _0x16af5824 = ScreenOrientation.LandscapeLeft;
    private Canvas _0xd33af9c3;
    private RectTransform _0x69b25de9;
    private void OnDestroy()
    {
        if (_0x39717ce2 != null && _0x39717ce2.Contains(this))
            _0x39717ce2.Remove(this);
    }

    private void Update()
    {
        if (_0x39717ce2.Count == 0 || _0x39717ce2[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x16af5824)
            OrientationChanged();
        if (Screen.safeArea != _0x2a1008e4)
            SafeAreaChanged();
        if (Screen.width != _0x4d706829.x || Screen.height != _0x4d706829.y)
            ResolutionChanged();
    }

    private static UnityEvent _0xf8c8146f = new();
    private void Start()
    {
    }

    private static readonly List<_0x6963dcb4> _0x39717ce2 = new();
    private static Vector2 _0x4d706829 = Vector2.zero;
    private static void OrientationChanged()
    {
        _0x16af5824 = Screen.orientation;
        _0x4d706829.x = Screen.width;
        _0x4d706829.y = Screen.height;
        _0x2a1008e4 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xf8c8146f.Invoke();
    }
}

internal static class _0xc8123609
{
    internal static string _0xeb6b1039(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}