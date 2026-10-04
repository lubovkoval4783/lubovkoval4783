using DG.Tweening;
using UnityEngine;

/// The metronome. With no sound in this game the beat has to be visible, so the
/// ring closes in on every beat and snaps back open - the moment it is at its
/// tightest IS the beat, and the whole control scheme is read off that.
public sealed class _0xe8dae38a : MonoBehaviour
{
    /// A slow breath for the menu preview, where there is no run to keep time for.
    public void _0xf666c44e(float _0xdad6e0cc)
    {
        this.transform.DOKill(false);
        this.transform.localScale = this._0x222d155e;
        this.transform.DOScale(this._0x222d155e * 0.86f, Mathf.Max(0.4f, _0xdad6e0cc)).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        if (this._0x32971656 != null)
        {
            this._0x32971656.color = _0x50c58425.WithAlpha(_0x50c58425.Topaz, 0.55f);
        }
    }

    /// One beat: contract over most of it, then reopen at once.
    public void _0xd10ef2c7(float _0xb015bbf3, bool _0xefdad0ae)
    {
        this.transform.DOKill(false);
        this.transform.localScale = this._0x222d155e;
        float _0xce2a947e = Mathf.Max(0.05f, _0xb015bbf3 * 0.82f);
        this.transform.DOScale(this._0x222d155e * 0.62f, _0xce2a947e).SetEase(Ease.InQuad).OnComplete(() => this._0xa81a53e7());
        if (this._0x32971656 != null)
        {
            this._0x32971656.DOKill(false);
            this._0x32971656.color = _0x50c58425.WithAlpha(_0xefdad0ae ? _0x50c58425.Topaz : _0x50c58425.Amethyst, _0xefdad0ae ? 0.95f : 0.6f);
            this._0x32971656.DOFade(_0xefdad0ae ? 0.45f : 0.35f, _0xce2a947e).SetEase(Ease.InQuad);
        }
    }

    private void _0xa81a53e7()
    {
        this.transform.localScale = this._0x222d155e;
    }

    private void OnDestroy()
    {
        this.transform.DOKill(false);
        if (this._0x32971656 != null)
        {
            this._0x32971656.DOKill(false);
        }
    }

    private Vector3 _0x222d155e;
    public void _0x6180c4ce(SpriteRenderer _0xd024fa32)
    {
        this._0x32971656 = _0xd024fa32;
        this._0x222d155e = this.transform.localScale;
        if (this._0x32971656 != null)
        {
            this._0x32971656.color = _0x50c58425.WithAlpha(_0x50c58425.Topaz, 0.55f);
        }
    }

    private SpriteRenderer _0x32971656;
}