using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x6c2d213c : MonoBehaviour
{
    public void _0x9f5eb49c()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0xb128ea33?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x4fc2dbfa = false;
    }

    public GameObject Content;
    private Sequence _0xb128ea33;
    public void _0x941fe597()
    {
        this._0xb128ea33?.Kill();
        this.AnimationSlider.value = _0x4fc2dbfa ? this.SecondPassSliderValue : 0.05f;
    }

    public GameObject Error;
    private void _0xb8ab0390()
    {
        this.AnimationSlider.value = 0.05f;
        _0x4fc2dbfa = !_0x4fc2dbfa;
        this._0xb128ea33 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xdcd07c91 => this.AnimationSlider.value = _0xdcd07c91, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0xe91eb0ad._0xcf88cf27?._0x078bfe0e();
        });
    }

    public GameObject Background;
    public float FirstAnimationTime = 10.0f;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xc29566dc._0x4e12825d.SCENE_0 && !_0x4fc2dbfa)
        {
            this._0xb8ab0390();
        }
        else
        {
            this._0x2a7288ee();
        }
    }

    private static bool _0x4fc2dbfa = false;
    public void _0x2a7288ee()
    {
        this._0x941fe597();
        bool _0x2df8e733 = _0x4fc2dbfa;
        this._0xb128ea33 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xdcd07c91 => this.AnimationSlider.value = _0xdcd07c91, _0x2df8e733 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x4fc2dbfa = !_0x4fc2dbfa;
    }

    public Slider AnimationSlider;
    public float SecondPassSliderValue = 0.5f;
    public float DefaultAnimationTime = 0.4f;
    public void _0x12c9c677()
    {
        this._0xb128ea33?.Pause();
    }

    public void _0x45003897()
    {
        this._0xb128ea33?.Play();
    }

    public static _0x6c2d213c Instance;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x6c2d213c>();
    }
}