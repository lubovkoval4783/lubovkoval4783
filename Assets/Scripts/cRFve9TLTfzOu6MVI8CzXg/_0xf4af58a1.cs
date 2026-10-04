using UnityEngine;
using UnityEngine.EventSystems;

/// The whole play field is the control, so the tap target is one full-surface UI
/// graphic rather than a button per gem. Press and release are reported as WORLD
/// points: the pointer position comes from the event system in screen pixels and
/// is converted through the camera, which is exact no matter how the UI canvas is
/// letterboxed on a given device.
///
/// Press and release are separate because the pearl star is held, not tapped.
public sealed class _0xf4af58a1 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void _0x3c712d0b(Camera _0x75590d83, System.Action<Vector2> _0xc7c8df3c, System.Action<Vector2> _0xa7d072da)
    {
        this._0x198f6f09 = _0x75590d83;
        this._0xb74c612a = _0xc7c8df3c;
        this._0x8a4fa6ce = _0xa7d072da;
    }

    private Camera _0x198f6f09;
    public void OnPointerDown(PointerEventData _0xd4fefd51)
    {
        if (this._0xb74c612a != null)
        {
            this._0xb74c612a.Invoke(this._0x50c86bee(_0xd4fefd51));
        }
    }

    public void OnPointerUp(PointerEventData _0xc09c706a)
    {
        if (this._0x8a4fa6ce != null)
        {
            this._0x8a4fa6ce.Invoke(this._0x50c86bee(_0xc09c706a));
        }
    }

    private System.Action<Vector2> _0xb74c612a;
    private System.Action<Vector2> _0x8a4fa6ce;
    private Vector2 _0x50c86bee(PointerEventData _0x2415a9df)
    {
        Camera _0x055595d8 = this._0x198f6f09 != null ? this._0x198f6f09 : Camera.main;
        if (_0x055595d8 == null || _0x2415a9df == null)
        {
            return Vector2.zero;
        }

        Vector3 _0xb46700d3 = _0x055595d8.ScreenToWorldPoint(new Vector3(_0x2415a9df.position.x, _0x2415a9df.position.y, 0f));
        return new Vector2(_0xb46700d3.x, _0xb46700d3.y);
    }
}