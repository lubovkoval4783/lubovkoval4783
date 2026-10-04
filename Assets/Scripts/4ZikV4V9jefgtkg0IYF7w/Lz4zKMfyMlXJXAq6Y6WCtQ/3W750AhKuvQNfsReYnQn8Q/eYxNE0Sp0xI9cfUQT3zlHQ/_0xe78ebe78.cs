using UnityEngine;
using UnityEngine.UI;

public class _0xe78ebe78 : MonoBehaviour
{
    private Button _0x83c188f1;
    private bool _0xfecc3498;
    private void Awake()
    {
        if (this._0x83c188f1 == null)
            if (!this.TryGetComponent(out this._0x83c188f1))
                this._0x83c188f1 = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this._0xfecc3498)
            this._0x83c188f1.onClick.AddListener(() => _0xb67d6cae.Instance._0x1cd96466());
        else
            this._0x83c188f1.onClick.AddListener(() => _0xb67d6cae.Instance._0xc4f3524a(this._0x73663ff0));
    }

    private int _0x73663ff0;
}