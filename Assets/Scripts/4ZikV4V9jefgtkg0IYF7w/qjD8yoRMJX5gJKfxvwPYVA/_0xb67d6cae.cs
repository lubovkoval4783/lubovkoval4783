using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xc29566dc;

public class _0xb67d6cae : MonoBehaviour
{
    private void _0xbd040b30()
    {
        this._0x2021756b(_0x97b1c56c.SPLASH);
        if (_0xe83c15f0.Instance._0x5790f48f == _0x4e12825d.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x6c2d213c.Instance.DefaultAnimationTime);
        }
    }

    private void Start()
    {
        this._0xbd040b30();
    }

    public float ScaleDuration = 0.4f;
    private void SwitchSplash()
    {
        if (_0xe797ba9c.Instance.IsTutorialEnabled && !_0xe83c15f0._0x662eac36._0x8eca3f99)
            this._0xc4f3524a(_0x97b1c56c.TUTORIAL0);
        else
            this._0xc4f3524a(_0x97b1c56c.DEFAULT);
    }

    private void _0xc8faaf5b(int _0x46779db6)
    {
        this.LastPanelIndexes.Add(_0x46779db6);
        this.CurrentPanelIndex = _0x46779db6;
        for (int _0xd60b6c66 = 0; _0xd60b6c66 < this.Panels.Count; _0xd60b6c66++)
            if (_0xd60b6c66 != _0x46779db6 && this.Panels[_0xd60b6c66] != null)
                this.Panels[_0xd60b6c66]._0x8d61825f();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xb67d6cae>();
    }

    public static _0xb67d6cae Instance;
    public void _0x1cd96466()
    {
        this.LastPanelIndexes.RemoveAll(_0x80d0a417 => _0x80d0a417 == this.CurrentPanelIndex);
        int _0xfc184691 = this.LastPanelIndexes.Last();
        this._0x35300fbc(_0xfc184691);
        this._0xc8faaf5b(_0xfc184691);
        this.CurrentPanelIndex = _0xfc184691;
        this.Panels[_0xfc184691].Show();
    }

    private void _0x2021756b(int _0x739a2624)
    {
        this._0x75914cd1(_0x739a2624);
        this._0x35300fbc(_0x739a2624);
        this.CurrentPanelIndex = _0x739a2624;
        this.Panels[_0x739a2624]._0xa5ab2002();
    }

    public void _0xc7b194ed(int _0x89017e88)
    {
        if (_0x89017e88 == _0x97b1c56c.SPLASH && _0xe83c15f0.Instance._0x5790f48f != _0x4e12825d.SCENE_0)
            _0x6c2d213c.Instance._0x2a7288ee();
        if (_0xe83c15f0.Instance._0x5790f48f != _0x4e12825d.SCENE_0)
        {
            if (_0x89017e88 == _0x97b1c56c.SPLASH || _0x89017e88 == _0x97b1c56c.TUTORIAL0)
                _0xe83c15f0.Instance._0xfe06137b(false);
            else if (_0x89017e88 == _0x97b1c56c.DEFAULT)
                _0xe83c15f0.Instance._0xfe06137b(true);
        }
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private _0xb894d724 _0x8d5b331f(int _0xa37e9047)
    {
        return this.Panels[_0xa37e9047];
    }

    public float StaticBlurMaterialInitialValue;
    public List<_0xb894d724> Panels;
    private void _0x35300fbc(int _0xcb4ff494)
    {
        if (_0xcb4ff494 == _0x97b1c56c.SPLASH)
            _0x6c2d213c.Instance._0x941fe597();
        if (_0xe83c15f0.Instance._0x5790f48f == _0x4e12825d.SCENE_0)
        {
        }
    }

    public void _0xc4f3524a(int _0xb2edfe01)
    {
        this._0x75914cd1(_0xb2edfe01);
        this._0x35300fbc(_0xb2edfe01);
        this.CurrentPanelIndex = _0xb2edfe01;
        this.Panels[_0xb2edfe01].Show();
    }

    public int CurrentPanelIndex;
    private void _0x75914cd1(int _0xd2009e96)
    {
        this.LastPanelIndexes.Add(_0xd2009e96);
        this.CurrentPanelIndex = _0xd2009e96;
        for (int _0xb649dee7 = 0; _0xb649dee7 < this.Panels.Count; _0xb649dee7++)
            if (_0xb649dee7 != _0xd2009e96 && this.Panels[_0xb649dee7] != null)
                this.Panels[_0xb649dee7]._0x8d61825f();
    }

    public bool IsShowSplashOnStart = true;
}