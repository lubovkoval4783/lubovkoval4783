using UnityEngine;
using UnityEngine.UI;

public class _0x7533c449 : MonoBehaviour
{
    public Button Button;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xe83c15f0.Instance._0xfe06137b(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}