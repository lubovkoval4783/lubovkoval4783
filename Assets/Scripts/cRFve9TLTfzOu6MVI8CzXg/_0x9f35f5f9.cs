using DG.Tweening;
using UnityEngine;

/// One gem on the arc: the stone itself, the halo that says what the show is
/// doing with it, and the short animations that carry each state. Everything is
/// sized from a base handed in by the board, never from a literal, so the same
/// code reads correctly on any aspect ratio.
public sealed class _0x9f35f5f9 : MonoBehaviour
{
    public void _0x71c47c80(SpriteRenderer _0x1b7f9de3, SpriteRenderer _0x442ff541, Color _0x811738dc)
    {
        this._0xbc38a329 = _0x1b7f9de3;
        this._0x6093cb77 = _0x442ff541;
        this._0x0d7b7853 = _0x811738dc;
        this._0x947e2664 = this.transform.localScale;
        if (this._0xbc38a329 != null)
        {
            this._0xbc38a329.color = _0x50c58425.WithAlpha(_0x811738dc, 0.82f);
        }

        if (this._0x6093cb77 != null)
        {
            this._0x6093cb77.color = _0x50c58425.WithAlpha(_0x811738dc, 0f);
        }
    }

    /// A finger is down on the pearl star: the halo stays lit for as long as it is.
    public void _0x8554d2ed(bool _0x68b816c2)
    {
        if (this._0x6093cb77 == null)
        {
            return;
        }

        this._0x6093cb77.DOKill(false);
        this._0x6093cb77.color = _0x50c58425.WithAlpha(_0x68b816c2 ? _0x50c58425.Pearl : this._0x0d7b7853, _0x68b816c2 ? 1f : 0f);
    }

    private void _0x60a4a77a(float _0x8dc90c5d)
    {
        this.transform.DOScale(this._0x947e2664, _0x8dc90c5d * 1.4f).SetEase(Ease.OutQuad);
    }

    private SpriteRenderer _0x6093cb77;
    private bool _0x978bf227;
    private Color _0x0d7b7853;
    /// The show calls this gem: a bright flare and a swell, the size of one beat.
    public void Call(float _0xf22840e4)
    {
        this._0x6226830c();
        float _0xcaa5ea3b = Mathf.Clamp(_0xf22840e4 * 0.32f, 0.10f, 0.28f);
        this.transform.localScale = this._0x947e2664;
        this.transform.DOScale(this._0x947e2664 * 1.22f, _0xcaa5ea3b).SetEase(Ease.OutQuad).OnComplete(() => this._0x60a4a77a(_0xcaa5ea3b));
        if (this._0xbc38a329 != null)
        {
            this._0xbc38a329.color = _0x50c58425.WithAlpha(this._0x0d7b7853, 1f);
        }

        if (this._0x6093cb77 != null)
        {
            this._0x6093cb77.color = _0x50c58425.WithAlpha(this._0x0d7b7853, 0.95f);
            this._0x6093cb77.DOFade(0.35f, _0xcaa5ea3b * 3f).SetEase(Ease.OutQuad);
        }
    }

    private Vector3 _0x947e2664;
    public Color _0x188b7b16
    {
        get
        {
            return this._0x0d7b7853;
        }
    }

    private void OnDestroy()
    {
        this._0x6226830c();
    }

    /// A note let through: the halo turns rose and the stone rocks once.
    public void _0xe6437280()
    {
        this._0x978bf227 = false;
        this._0x6226830c();
        this.transform.localScale = this._0x947e2664;
        if (this._0x6093cb77 != null)
        {
            this._0x6093cb77.color = _0x50c58425.WithAlpha(_0x50c58425.Rose, 0.9f);
            this._0x6093cb77.DOFade(0f, 0.3f).SetEase(Ease.OutQuad);
        }

        this.transform.DOShakePosition(0.22f, this._0x947e2664.x * 0.18f, 14, 90f, false, true);
    }

    /// The player's window is open: a slow breath so it is obvious which gems can
    /// still be answered.
    public void _0x65605a63()
    {
        if (this._0x978bf227)
        {
            return;
        }

        this._0x978bf227 = true;
        this._0x6226830c();
        this.transform.localScale = this._0x947e2664;
        this.transform.DOScale(this._0x947e2664 * 1.05f, 0.5f).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        if (this._0xbc38a329 != null)
        {
            this._0xbc38a329.color = _0x50c58425.WithAlpha(this._0x0d7b7853, 0.95f);
        }

        if (this._0x6093cb77 != null)
        {
            this._0x6093cb77.color = _0x50c58425.WithAlpha(this._0x0d7b7853, 0.5f);
        }
    }

    private SpriteRenderer _0xbc38a329;
    /// A clean answer. Perfect gets the gold flash, anything else the gem's own.
    public void _0x759124e4(bool _0x5396e661)
    {
        this._0x978bf227 = false;
        this._0x6226830c();
        this.transform.localScale = this._0x947e2664;
        this.transform.DOPunchScale(this._0x947e2664 * (_0x5396e661 ? 0.18f : 0.10f), 0.26f, 8, 0.7f);
        if (this._0x6093cb77 != null)
        {
            this._0x6093cb77.color = _0x50c58425.WithAlpha(_0x5396e661 ? _0x50c58425.Topaz : this._0x0d7b7853, 1f);
            this._0x6093cb77.DOFade(0f, 0.34f).SetEase(Ease.OutQuad);
        }
    }

    private void _0x6226830c()
    {
        this.transform.DOKill(false);
        if (this._0x6093cb77 != null)
        {
            this._0x6093cb77.DOKill(false);
        }
    }

    /// Resting: the stone is lit but quiet and the halo is gone.
    public void _0x0262fa89()
    {
        this._0x978bf227 = false;
        this._0x6226830c();
        this.transform.localScale = this._0x947e2664;
        if (this._0xbc38a329 != null)
        {
            this._0xbc38a329.color = _0x50c58425.WithAlpha(this._0x0d7b7853, 0.82f);
        }

        if (this._0x6093cb77 != null)
        {
            this._0x6093cb77.color = _0x50c58425.WithAlpha(this._0x0d7b7853, 0f);
        }
    }
}