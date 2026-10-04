using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0xe5c1f299 : MonoBehaviour
{
    private float _0x7d82061c = 0.6f;
    private float _0xae294780;
    private AspectRatioFitter _0x351bce6e;
    private TMP_Text _0x18115df4;
    private float _0xb592a447 = 4;
    private float _0x5ed0747d = 1.5f;
    private void Update()
    {
        int _0x18dfe078 = 1;
        if (this._0x8fbeafa9.Count > 0)
        {
            string _0x5d55f4c2 = this._0x18115df4.text;
            foreach (string _0xad12f4c0 in this._0x8fbeafa9)
                while (_0x5d55f4c2.Contains(_0xad12f4c0))
                    _0x5d55f4c2 = _0x5d55f4c2.Replace(_0xad12f4c0, "");
            _0x18dfe078 = _0x5d55f4c2.Length;
        }
        else
        {
            _0x18dfe078 = this._0x18115df4.text.Length;
        }

        float _0x1c65c5e4 = Mathf.Clamp(this._0xae294780 + this._0x7d82061c * _0x18dfe078, this._0x5ed0747d, this._0xb592a447);
        if (!Mathf.Approximately(this._0x351bce6e.aspectRatio, _0x1c65c5e4))
            this._0x351bce6e.aspectRatio = _0x1c65c5e4;
    }

    private List<string> _0x8fbeafa9 = new();
}