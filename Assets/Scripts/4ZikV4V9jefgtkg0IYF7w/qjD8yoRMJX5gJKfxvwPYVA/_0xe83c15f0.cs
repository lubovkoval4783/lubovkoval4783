using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xc29566dc;

public class _0xe83c15f0 : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xe83c15f0>();
        this.RootGameObject = GameObject.FindWithTag(_0x96cf8927._0xa405117e(new byte[4] { 163, 158, 158, 133 }, 241));
        if (this._0x5790f48f == _0x4e12825d.SCENE_0)
            this._0xfe06137b(true);
        else
            this._0xfe06137b(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x745be813>(true).ToList();
    }

    public void _0x67fa7bf6()
    {
        _0x662eac36._0x8eca3f99 = true;
    }

    private void _0xb598d560(Transform _0x63f32744)
    {
        Transform[] _0x22017754 = _0x63f32744.GetComponentsInChildren<Transform>();
        foreach (Transform _0xa1e89ba5 in _0x22017754)
            if (_0xa1e89ba5 != null && DOTween.IsTweening(_0xa1e89ba5))
            {
                if (this._0x84257f2c)
                    DOTween.Play(_0xa1e89ba5);
                else
                    DOTween.Pause(_0xa1e89ba5);
            }
    }

    private void _0x83050e05()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0x4e12825d.SCENE_0);
    }

    public void _0xfe06137b(bool _0x935e0a1a)
    {
        this._0x84257f2c = _0x935e0a1a;
        this._0xff8bc124(!this._0x84257f2c);
        Physics2D.simulationMode = this._0x84257f2c ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xb598d560(this.EnvironmentWithTweensToToggle);
    }

    public Transform Environment;
    public void _0xf983954c()
    {
        foreach (_0x745be813 _0xa9ebe887 in this.MoneyCountContainers)
            _0xa9ebe887._0xb9f7a6e8();
    }

    private void _0xff8bc124(bool _0x1a98de2b)
    {
        Rigidbody2D[] _0x8a5749ee = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xad762804 in _0x8a5749ee)
            if (_0x1a98de2b)
                _0xad762804.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xad762804.constraints = RigidbodyConstraints2D.None;
    }

    [HideInInspector]
    public List<_0x745be813> MoneyCountContainers = new();
    private static void MakeGrid(List<RectTransform> _0xe3d2c74d, AspectRatioFitter _0xee2db38d, float _0x1f8267d8, int _0x7b2205f9, int _0x53168832)
    {
        _0xee2db38d.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0xee2db38d.aspectRatio = _0x1f8267d8;
        foreach (RectTransform _0xd405cfa1 in _0xe3d2c74d)
        {
            int _0xa94790af = _0xd405cfa1.transform.GetSiblingIndex();
            _0xd405cfa1.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xa94790af % _0x7b2205f9) * (1f / _0x7b2205f9), (_0x53168832 - (Mathf.FloorToInt((float)_0xa94790af / _0x7b2205f9) % _0x53168832 + 1f)) * (1f / _0x53168832));
            _0xd405cfa1.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xa94790af % _0x7b2205f9 + 1f) * (1f / _0x7b2205f9), (_0x53168832 - Mathf.FloorToInt((float)_0xa94790af / _0x7b2205f9) % _0x53168832) * (1f / _0x53168832));
            _0xd405cfa1.offsetMin = Vector2.zero;
            _0xd405cfa1.offsetMax = Vector2.zero;
        }
    }

    private IEnumerator _0x8a7081df(int _0x17bd151e)
    {
        _0xb67d6cae.Instance._0xc4f3524a(_0x97b1c56c.SPLASH);
        AsyncOperation _0x31e22473 = SceneManager.LoadSceneAsync(_0x17bd151e);
        while (!_0x31e22473.isDone)
            yield return null;
    }

    public static bool IsAfterLevelComplete;
    public bool _0x84257f2c { get; private set; }

    private void Start()
    {
        if (this._0x5790f48f != _0x4e12825d.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0x4e12825d.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x662eac36._0x8eca3f99 = false;
            _0x23d9e2a2.Instance._0x3cacdc88();
            _0xb67d6cae.Instance._0xc4f3524a(_0x97b1c56c.TUTORIAL0);
        });
    }

    public void LoadSceneByIndex(int _0xa5a787f7)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x8a7081df(_0xa5a787f7));
    }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public static _0x58f55d4e _0x662eac36 => _0x58f55d4e.ALL_SCENES_SETTING_SINGLETONS[Instance._0x5790f48f];

    public Transform EnvironmentWithTweensToToggle;
    public void _0x23ee822a()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    public Canvas MainCanvas;
    private static void ExitGame()
    {
        Application.Quit();
    }

    private static _0x58f55d4e GAME_INDEX_SETTINGS(int _0x8b98febf)
    {
        return _0x58f55d4e.ALL_SCENES_SETTING_SINGLETONS[_0x8b98febf];
    }

    private IEnumerator _0xb4b736c2(string _0x3ff59fcf)
    {
        _0xb67d6cae.Instance._0xc4f3524a(_0x97b1c56c.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x24789ffc = SceneManager.LoadSceneAsync(_0x3ff59fcf);
        while (!_0x24789ffc.isDone)
            yield return null;
    }

    public Button ShowResetTutorialButton;
    public int _0x5790f48f => SceneManager.GetActiveScene().buildIndex;

    public Button DeleteProgressDataButton;
    public static _0xe83c15f0 Instance;
    private static _0x58f55d4e _0xbd43fbe8 => _0x58f55d4e.ALL_SCENES_SETTING_SINGLETONS[0];

    public static bool IsAfterLevelFailed = false;
}

internal static class _0x96cf8927
{
    internal static string _0xa405117e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}