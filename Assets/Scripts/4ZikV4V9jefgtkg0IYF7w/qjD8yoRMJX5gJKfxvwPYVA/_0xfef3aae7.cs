using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xfef3aae7 : MonoBehaviour
{
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x40f2fa09 = this.gameObject.GetComponent<_0xfef3aae7>();
    }

    private Touch? _0x9b12d3de()
    {
        if (!_0xe83c15f0.Instance._0x84257f2c)
            return null;
        foreach (Touch _0x1a6ea0cb in Touch.activeTouches)
            if (_0x1a6ea0cb.ended)
                if (this._0xc1015870(_0x1a6ea0cb))
                    return _0x1a6ea0cb;
        return null;
    }

    private void _0x6ef9c63c(Touch? _0x82e95e35)
    {
        if (!_0xe83c15f0.Instance._0x84257f2c)
        {
            _0x82e95e35 = null;
            return;
        }

        int _0xb951ec41 = _0x82e95e35.Value.touchId;
        _0x82e95e35 = Touch.activeTouches.FirstOrDefault(_0xa31d8800 => _0xa31d8800.touchId == _0xb951ec41);
        if (!this._0xc1015870(_0x82e95e35.Value))
            _0x82e95e35 = null;
    }

    private static _0xfef3aae7 _0x40f2fa09;
    private Touch? _0xbae4966d(Bounds _0xa9a186aa, TouchPhase _0x2c49352c)
    {
        if (!_0xe83c15f0.Instance._0x84257f2c)
            return null;
        foreach (Touch _0xbe2025a9 in Touch.activeTouches)
            if (_0xbe2025a9.phase == _0x2c49352c)
            {
                Vector3 _0x2ec1badc = Camera.main.ScreenToWorldPoint(_0xbe2025a9.screenPosition);
                Vector3 _0xdc1f26f4 = new(_0x2ec1badc.x, _0x2ec1badc.y, _0xa9a186aa.center.z);
                if (_0xa9a186aa.Contains(_0xdc1f26f4) && this._0xc1015870(_0xbe2025a9))
                    return _0xbe2025a9;
            }

        return null;
    }

    private Touch? _0x659b2288(Bounds _0x0c1074a1)
    {
        if (!_0xe83c15f0.Instance._0x84257f2c)
            return null;
        foreach (Touch _0x7cad1acf in Touch.activeTouches)
            if (!_0x7cad1acf.ended)
            {
                Vector3 _0xfe6099d5 = Camera.main.ScreenToWorldPoint(_0x7cad1acf.screenPosition);
                Vector3 _0x838837af = new(_0xfe6099d5.x, _0xfe6099d5.y, _0x0c1074a1.center.z);
                if (_0x0c1074a1.Contains(_0x838837af) && this._0xc1015870(_0x7cad1acf))
                    return _0x7cad1acf;
            }

        return null;
    }

    private Touch? _0x601a1f9b()
    {
        if (!_0xe83c15f0.Instance._0x84257f2c)
            return null;
        foreach (Touch _0xf5fe1d4e in Touch.activeTouches)
            if (!_0xf5fe1d4e.ended)
                if (this._0xc1015870(_0xf5fe1d4e))
                    return _0xf5fe1d4e;
        return null;
    }

    private bool _0xc1015870(Touch? _0xb2627303)
    {
        if (!_0xb2627303.HasValue)
            return false;
        Vector3 _0x878b5b74 = Camera.main.ScreenToWorldPoint(_0xb2627303.Value.screenPosition);
        Vector3 _0x3883dfd9 = _0x878b5b74;
        _0x3883dfd9.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x3883dfd9))
            return true;
        _0xb2627303 = null;
        return false;
    }

    private bool _0x379b5e1d(Touch? _0x7987c875, Bounds _0x245d6181, TouchPhase _0x751e5b79)
    {
        if (!_0xe83c15f0.Instance._0x84257f2c)
        {
            _0x7987c875 = null;
            return false;
        }

        if (_0x7987c875 != null)
            if (_0x7987c875.Value.phase == _0x751e5b79)
            {
                Vector3 _0xc444ab3c = Camera.main.ScreenToWorldPoint(_0x7987c875.Value.screenPosition);
                Vector3 _0x623aa03a = new(_0xc444ab3c.x, _0xc444ab3c.y, _0x245d6181.center.z);
                if (_0x245d6181.Contains(_0x623aa03a) && this._0xc1015870(_0x7987c875.Value))
                    return true;
            }

        return false;
    }

    public BoxCollider2D CameraTouchBounds;
    private Touch? _0xa6486e10(Bounds _0x1a25df5f)
    {
        if (!_0xe83c15f0.Instance._0x84257f2c)
            return null;
        foreach (Touch _0x8b944382 in Touch.activeTouches)
            if (_0x8b944382.ended)
            {
                Vector3 _0x8150ec4d = Camera.main.ScreenToWorldPoint(_0x8b944382.screenPosition);
                Vector3 _0x8706accf = new(_0x8150ec4d.x, _0x8150ec4d.y, _0x1a25df5f.center.z);
                if (_0x1a25df5f.Contains(_0x8706accf) && this._0xc1015870(_0x8b944382))
                    return _0x8b944382;
            }

        return null;
    }
}