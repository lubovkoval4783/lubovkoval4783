using UnityEngine;
using UnityEngine.UI;

public class _0xbaaf5e6d : MonoBehaviour
{
    public bool IsShowLastPop;
    public int PopToShowIndex;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x23d9e2a2.Instance._0xa5286450();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x23d9e2a2.Instance._0x3cacdc88());
        else
            this.Button.onClick.AddListener(() => _0x23d9e2a2.Instance._0x4f08a333(this.PopToShowIndex));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsHideAllPops;
    public Button Button;
}