using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xa2808acf : MonoBehaviour
{
    private Image _0x34bf640f;
    private void _0xd0035183()
    {
        if (this._0x34bf640f.canvasRenderer.GetColor() != this._0x040579bf.canvasRenderer.GetColor())
            this._0x040579bf.canvasRenderer.SetColor(this._0x34bf640f.canvasRenderer.GetColor());
    }

    private TMP_Text _0x040579bf;
    private void Update()
    {
        this._0xd0035183();
    }
}