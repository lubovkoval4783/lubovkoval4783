using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xf05bdc71 : MonoBehaviour
{
    private void _0xeb026c52()
    {
        if (this.ScoreCurrent > _0xe83c15f0._0x662eac36._0xfaacfd22)
            _0xe83c15f0._0x662eac36._0xfaacfd22 = this.ScoreCurrent;
        if (_0xe797ba9c.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0xb5e55752)
                this._0x111b10ae();
    }

    public List<TMP_Text> TimerText = new();
    public int CustomTargetScore = 10;
    [HideInInspector]
    public bool IsGameEnd;
    public void _0x111b10ae()
    {
        if (!this.IsGameEnd)
        {
            this._0xe5791910();
            _0xe83c15f0.IsAfterLevelComplete = true;
            _0xe83c15f0.IsAfterLevelFailed = false;
            _0x11d21c90 _0xcd79a07d = _0x23d9e2a2.Instance._0xc2ba422e(_0xc29566dc._0xf58e677e.WIN).GetComponent<_0x11d21c90>();
            if (_0xe797ba9c.Instance.IsCheckScoreEnabled)
                _0xcd79a07d.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xb5e55752}";
            else
                _0xcd79a07d.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0xe797ba9c.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xc29566dc._0xbbab0871._0x1003ec82)
                    _0xc29566dc._0xbbab0871._0x1003ec82 = this.ScoreCurrent;
                _0xcd79a07d.ContentAdditionalText.text = $"{_0xc29566dc._0xbbab0871._0x1003ec82}";
            }
            else
            {
                _0xcd79a07d.ContentAdditionalText.text = $"{this._0x4a8d4033}";
                _0xc29566dc._0xbbab0871._0x1003ec82 += this._0x4a8d4033;
            }

            if (_0xe797ba9c.Instance.IsLevelIncrementOnWin)
                ++_0xe83c15f0._0x662eac36._0xbd571846;
            _0x23d9e2a2.Instance._0x4f08a333(_0xc29566dc._0xf58e677e.WIN);
        }
    }

    public int CustomTimeInitial = 30;
    public void _0x4eae4f00(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0x2ab3c785();
            this._0xeb026c52();
        }
    }

    public List<Button> HomeButtons = new();
    private void _0x686362f8()
    {
        this.TimerText.ForEach(_0xab11b19d => _0xab11b19d.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0x58ce7001._0xd14c18a1(new byte[6] { 211, 211, 226, 132, 205, 205 }, 190)));
    }

    private IEnumerator _0x2b12e2ec()
    {
        this._0x686362f8();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xe83c15f0.Instance._0x5790f48f == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xe83c15f0.Instance._0x84257f2c)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x686362f8();
            }
        }

        if (!this.IsGameEnd)
            this._0x10912de4();
    }

    [HideInInspector]
    public int TimeLeft;
    public List<Button> PauseButtons = new();
    private void _0xe5791910()
    {
        this.IsGameEnd = true;
        _0xe83c15f0.IsAfterLevelComplete = true;
    }

    public void _0x10912de4()
    {
        if (_0xe797ba9c.Instance.IsOnlyWinGameEndEnabled)
            this._0x111b10ae();
        if (!this.IsGameEnd)
        {
            this._0xe5791910();
            _0xe83c15f0.IsAfterLevelComplete = false;
            _0xe83c15f0.IsAfterLevelFailed = true;
            _0x11d21c90 _0x46fb1f91 = _0x23d9e2a2.Instance._0xc2ba422e(_0xc29566dc._0xf58e677e.LOSE).GetComponent<_0x11d21c90>();
            if (_0xe797ba9c.Instance.IsCheckScoreEnabled)
                _0x46fb1f91.ContentMainText.text = $"{this.ScoreCurrent}/{this._0xb5e55752}";
            else
                _0x46fb1f91.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x46fb1f91.ContentAdditionalText.text = $"{0}";
            _0xc29566dc._0xbbab0871._0x1003ec82 += 0;
            _0x23d9e2a2.Instance._0x4f08a333(_0xc29566dc._0xf58e677e.LOSE);
        }
    }

    private void _0x2ab3c785()
    {
        if (_0xe797ba9c.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xab11b19d => _0xab11b19d.text = $"{this.ScoreCurrent}/{this._0xb5e55752}");
        else
            this.ScoreText.ForEach(_0xab11b19d => _0xab11b19d.text = $"{this.ScoreCurrent}");
    }

    public List<TMP_Text> SubtitleText = new();
    [HideInInspector]
    public int ScoreCurrent;
    private void Awake()
    {
        _0x17b82c5f = this.gameObject.GetComponent<_0xf05bdc71>();
    }

    [HideInInspector]
    public int CurrentGameIndex;
    private static _0xf05bdc71 _0x17b82c5f;
    public void _0x628a00c4()
    {
        _0xe83c15f0.Instance._0xfe06137b(true);
        _0xe83c15f0.Instance.LoadSceneByIndex(_0xc29566dc._0x4e12825d.SCENE_0);
    }

    private int _0xf5c38d14 => this.CustomTimeInitial + _0xe83c15f0._0x662eac36._0xbd571846 * 10;

    public List<TMP_Text> ScoreText = new();
    private void _0x49a0eda1()
    {
        if (this.ScoreCurrent >= this._0xb5e55752)
            this._0x111b10ae();
        else
            this._0x10912de4();
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xf5c38d14;
        this.CurrentGameIndex = _0xe83c15f0.Instance._0x5790f48f;
        foreach (Button _0x8332cc03 in this.HomeButtons)
            _0x8332cc03.onClick.AddListener(() =>
            {
                this._0x628a00c4();
            });
        foreach (Button _0x60ec1351 in this.PauseButtons)
            _0x60ec1351.onClick.AddListener(() =>
            {
                _0xe83c15f0.Instance._0xfe06137b(false);
                _0x23d9e2a2.Instance._0x4f08a333(_0xc29566dc._0xf58e677e.PAUSE);
            });
        this._0x2ab3c785();
        this.LevelNumberText.ForEach(_0xab11b19d => _0xab11b19d.text = $"LVL {_0xe83c15f0._0x662eac36._0xbd571846 + 1}");
        if (_0xe797ba9c.Instance.IsTimerEnabled)
        {
            this._0x686362f8();
            this.StartCoroutine(this._0x2b12e2ec());
        }
    }

    public List<TMP_Text> LevelNumberText = new();
    private int _0x4a8d4033 => this.ScoreCurrent;
    private int _0xb5e55752 => this.CustomTargetScore + _0xe83c15f0._0x662eac36._0xbd571846 * 10;
}

internal static class _0x58ce7001
{
    internal static string _0xd14c18a1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}