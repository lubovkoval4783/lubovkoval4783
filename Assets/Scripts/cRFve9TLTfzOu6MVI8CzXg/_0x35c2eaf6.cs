using UnityEngine;

/// Who takes the menu off the splash.
///
/// In the menu scene the template's PanelController shows the splash panel and
/// then never touches it again: the single hand-off to the default panel is a
/// call on the template's start-up helper, made from the loading tween's
/// completion and from the helper's own start-up. If that helper cannot be
/// reached, nothing ever shows the default panel - the loading bar fills to the
/// end and the splash owns the screen for the rest of the session, with the
/// whole menu built underneath it and invisible.
///
/// So the menu owns its entrance. The helper is probed once: while it is alive
/// the hand-off is left entirely to it, which is what the template intends and
/// what keeps the helper's own flow (it may legitimately open something else
/// instead of the menu) unaffected. If the probe comes back dead, this shows
/// the default panel itself, after a beat long enough for the splash to read as
/// a splash rather than a flash.
public sealed class _0x35c2eaf6 : MonoBehaviour
{
    private void Update()
    {
        if (this._0xcae048aa)
        {
            return;
        }

        _0xb67d6cae _0x5ded733d = _0xb67d6cae.Instance;
        if (_0x5ded733d == null)
        {
            return;
        }

        if (_0x5ded733d.CurrentPanelIndex != _0xc29566dc._0x97b1c56c.SPLASH)
        {
            // Someone - the template helper, or a later navigation - already took
            // the screen off the splash. Nothing left to guard.
            this._0xcae048aa = true;
            return;
        }

        if (!this._0x2c5b8d79)
        {
            return;
        }

        this._0x3eac96d4 += Time.unscaledDeltaTime;
        if (this._0x3eac96d4 < this._splashBeat)
        {
            return;
        }

        this._0xcae048aa = true;
        this._0x14417fda();
    }

    /// The same two moves the template's helper makes when it hands over: stop
    /// the loading bar at full, then show the default panel.
    private void _0x14417fda()
    {
        _0x6c2d213c _0x25ecc225 = _0x6c2d213c.Instance;
        if (_0x25ecc225 != null)
        {
            _0x25ecc225._0x9f5eb49c();
        }

        _0xb67d6cae _0x635602c3 = _0xb67d6cae.Instance;
        if (_0x635602c3 == null || _0x635602c3.Panels == null)
        {
            return;
        }

        if (_0xc29566dc._0x97b1c56c.DEFAULT < 0 || _0xc29566dc._0x97b1c56c.DEFAULT >= _0x635602c3.Panels.Count)
        {
            return;
        }

        _0x635602c3._0xc4f3524a(_0xc29566dc._0x97b1c56c.DEFAULT);
    }

    private float _0x3eac96d4;
    /// Reading the helper's instance is itself what makes the runtime initialise
    /// the helper's type, so the read is the probe. A type whose initialiser
    /// threw rethrows that failure on every single access for the rest of the
    /// process - which is exactly the state in which nothing will ever hand the
    /// screen over, and the state this guard exists for.
    private static bool IsLaunchOwnerAlive()
    {
        try
        {
            return _0xe91eb0ad._0xcf88cf27 != null;
        }
        catch (System.Exception)
        {
            return false;
        }
    }

    private bool _0x2c5b8d79;
    /// How long the splash stays up before this takes over. Only ever used when
    /// the template's own hand-off is known to be unavailable.
    [SerializeField]
    private float _splashBeat = 2f;
    private bool _0xcae048aa;
    private void Start()
    {
        this._0x2c5b8d79 = !IsLaunchOwnerAlive();
    }
}