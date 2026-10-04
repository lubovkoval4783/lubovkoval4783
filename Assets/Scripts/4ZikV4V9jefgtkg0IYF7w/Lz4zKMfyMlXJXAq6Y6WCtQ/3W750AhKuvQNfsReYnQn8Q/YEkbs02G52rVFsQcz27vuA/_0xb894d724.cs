using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xb894d724 : MonoBehaviour
{
    public void _0xa5ab2002()
    {
        this._0x179f87fc();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0xb67d6cae.Instance._0xc7b194ed(_0xb67d6cae.Instance.CurrentPanelIndex);
    }

    public GameObject Content;
    public TMP_Text MainText;
    private bool _0x4a32c4f6 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public Ease Ease = Ease.OutSine;
    private void _0x179f87fc()
    {
        if (this.OuterBackground != null)
        {
            Image _0x8542be62 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x8542be62, true);
            _0x8542be62.DOFade(1f, 0f);
        }
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x8a5c43ca();
    }

    public bool IsScaledDownOnAwake = true;
    private void _0x8a5c43ca()
    {
        if (this.OuterBackground != null)
        {
            Image _0x34280107 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x34280107, true);
            _0x34280107.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public GameObject OuterBackground;
    public void _0x8d61825f()
    {
        this._0xe92633a7();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public float ScaleDuration = 0.4f;
    private void _0xfde47dbd()
    {
        if (this.OuterBackground != null)
        {
            Image _0xdfe688ea = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xdfe688ea, true);
            _0xdfe688ea.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public TMP_Text HeaderText;
    public void Show()
    {
        this._0xfde47dbd();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0xb67d6cae.Instance._0xc7b194ed(_0xb67d6cae.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0xe92633a7()
    {
        if (this.OuterBackground != null)
        {
            Image _0x64f83659 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x64f83659, true);
            _0x64f83659.DOFade(0f, this.ScaleDuration);
        }
    }
}