using TMPro;
using UnityEngine;
using static _0xc29566dc;

public class _0x745be813 : MonoBehaviour
{
    public void _0xb9f7a6e8()
    {
        this.MoneyCountText.text = _0xbbab0871._0x1003ec82.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xa1f36754;
            if (this.gameObject.TryGetComponent(out _0xa1f36754))
                this.MoneyCountText = _0xa1f36754;
        }

        this._0xb9f7a6e8();
    }

    public TMP_Text MoneyCountText;
}