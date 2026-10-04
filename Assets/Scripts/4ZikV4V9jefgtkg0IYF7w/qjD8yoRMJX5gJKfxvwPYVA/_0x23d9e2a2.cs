using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xc29566dc;

public class _0x23d9e2a2 : MonoBehaviour
{
    public GameObject BlurBackground;
    private void _0xe28db462()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x23d9e2a2>();
    }

    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public void _0x3cacdc88()
    {
        this.LastPopIndexes.Clear();
        this._0xe676fa13();
        foreach (GameObject _0x2f2194f8 in this.GameObjectsToHide)
            if (_0x2f2194f8 != null)
                _0x2f2194f8.SetActive(true);
        this._0xe28db462();
    }

    public void _0xa5286450()
    {
        this.LastPopIndexes.RemoveAll(_0x80d0a417 => _0x80d0a417 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x3cacdc88();
        else
            this._0x4f08a333(this.LastPopIndexes.Last());
    }

    private void _0xe676fa13(bool _0x63d065d6 = false)
    {
        for (int _0x9a74e63f = 0; _0x9a74e63f < this.Pops.Count; ++_0x9a74e63f)
            if (this.Pops[_0x9a74e63f] != null && !(_0x9a74e63f == this.CurrentPopIndex && _0x63d065d6))
                this.Pops[_0x9a74e63f]._0xc0110506();
    }

    private void _0x9e96070c()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public List<_0x11d21c90> Pops;
    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x11d21c90 _0xe2819c90 in this.Pops)
            if (_0xe2819c90 != null)
                _0xe2819c90.gameObject.SetActive(true);
    }

    public int CurrentPopIndex;
    public float ScaleDuration = 0.4f;
    public void _0x4f08a333(int _0xe9dcfea3)
    {
        this.CurrentPopIndex = _0xe9dcfea3;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xe676fa13(true);
        this._0x9e96070c();
        this.Pops[_0xe9dcfea3].Show();
        foreach (GameObject _0x50f582c7 in this.GameObjectsToHide)
            _0x50f582c7.SetActive(false);
    }

    public _0x11d21c90 _0xc2ba422e(int _0x94e60c16)
    {
        return this.Pops[_0x94e60c16];
    }

    public List<int> LastPopIndexes = new();
    public static _0x23d9e2a2 Instance;
    public List<GameObject> GameObjectsToHide;
}