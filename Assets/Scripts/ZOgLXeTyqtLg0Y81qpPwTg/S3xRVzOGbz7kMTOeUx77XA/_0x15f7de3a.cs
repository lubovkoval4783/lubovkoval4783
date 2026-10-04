using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0x15f7de3a : MonoBehaviour
{
    private static Rect _0x3892bcb3 = Rect.zero;
    private static bool _0x0f54e414;
    private static Vector2 _0x4a98d879 = Vector2.zero;
    private static UnityEvent _0xcdfaea64 = new();
    private static void SafeAreaChanged()
    {
        _0x3892bcb3 = Screen.safeArea;
        for (int _0x907f7f84 = 0; _0x907f7f84 < _0x372d8dc7.Count; _0x907f7f84++)
            _0x372d8dc7[_0x907f7f84]._0x4ca16281();
    }

    private RectTransform _0x45fcb702;
    private static void OrientationChanged()
    {
        _0x681d3034 = Screen.orientation;
        _0x4a98d879.x = Screen.width;
        _0x4a98d879.y = Screen.height;
        _0xcdfaea64.Invoke();
    }

    private void Update()
    {
        if (_0x372d8dc7[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x681d3034)
            OrientationChanged();
        if (Screen.safeArea != _0x3892bcb3)
            SafeAreaChanged();
        if (Screen.width != _0x4a98d879.x || Screen.height != _0x4a98d879.y)
            ResolutionChanged();
    }

    private RectTransform _0x072968e5;
    private void Awake()
    {
        if (!_0x372d8dc7.Contains(this))
            _0x372d8dc7.Add(this);
        this._0x792de819 = this.GetComponent<Canvas>();
        this._0x072968e5 = this.GetComponent<RectTransform>();
        this._0x45fcb702 = this.transform.Find(_0xab53feb3._0xe709228e(new byte[8] { 195, 241, 246, 245, 209, 226, 245, 241 }, 144)) as RectTransform;
        if (!_0x0f54e414)
        {
            _0x681d3034 = Screen.orientation;
            _0x4a98d879.x = Screen.width;
            _0x4a98d879.y = Screen.height;
            _0x3892bcb3 = Screen.safeArea;
            _0x0f54e414 = true;
        }

        this._0x4ca16281();
    }

    private static ScreenOrientation _0x681d3034 = ScreenOrientation.LandscapeLeft;
    private static void ResolutionChanged()
    {
        _0x4a98d879.x = Screen.width;
        _0x4a98d879.y = Screen.height;
        _0xcdfaea64.Invoke();
    }

    private static readonly List<_0x15f7de3a> _0x372d8dc7 = new();
    private void _0x4ca16281()
    {
        if (this._0x45fcb702 == null)
            return;
        Rect _0x795086ae = Screen.safeArea;
        Vector2 _0xd899743a = _0x795086ae.position;
        Vector2 _0x7483e193 = _0x795086ae.position + _0x795086ae.size;
        _0xd899743a.x /= this._0x792de819.pixelRect.width;
        _0xd899743a.y /= this._0x792de819.pixelRect.height;
        _0x7483e193.x /= this._0x792de819.pixelRect.width;
        _0x7483e193.y /= this._0x792de819.pixelRect.height;
        this._0x45fcb702.anchorMin = _0xd899743a;
        this._0x45fcb702.anchorMax = _0x7483e193;
    }

    private Canvas _0x792de819;
    private void OnDestroy()
    {
        if (_0x372d8dc7 != null && _0x372d8dc7.Contains(this))
            _0x372d8dc7.Remove(this);
    }
}

internal static class _0xab53feb3
{
    internal static string _0xe709228e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}