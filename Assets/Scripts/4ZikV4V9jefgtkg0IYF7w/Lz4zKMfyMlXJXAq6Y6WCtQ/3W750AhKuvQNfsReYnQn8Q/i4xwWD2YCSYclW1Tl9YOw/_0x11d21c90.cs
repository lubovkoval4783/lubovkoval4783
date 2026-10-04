using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x11d21c90 : MonoBehaviour
{
    public GameObject Content;
    public TMP_Text ContentAdditionalText;
    public bool IsScaledDownOnAwake = true;
    public Ease ease = Ease.OutSine;
    public Image ContentImage;
    private void _0x3a7e560b()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    public void _0xc0110506()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public static void HideAllPops()
    {
        _0x23d9e2a2.Instance._0x3cacdc88();
    }

    public TMP_Text ContentMainText;
    private void Start()
    {
    // Content.SetActive(false);
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x3a7e560b();
    }

    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    private bool _0xb6fbe8e7 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public float scaleDuration = 0.4f;
    public TMP_Text ContentHeaderText;
    public bool IsOnlyYScale;
}