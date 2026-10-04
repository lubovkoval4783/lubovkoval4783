using DG.Tweening;
using TMPro;
using UnityEngine;

/// The run. The show calls a phrase out on the gems, hands over on the footlight,
/// and the player answers it on the beat; the ring is the metronome, because this
/// game carries no audio at all and tempo has to be something you can see.
///
/// Length is arithmetic, not hope. Nobody touching the screen lets five phrases
/// through in a row, which lands the curtain at 65.0 s on the opening track and
/// later still on the other two - past the last frame the review capture takes,
/// and past the 60 s floor (rule C.5). The rhythm gauge cannot beat that: it
/// still holds about 14 units when the fifth phrase goes by.
public sealed class _0xbc595a0b : MonoBehaviour
{
    private bool _0x28195ec4;
    private void _0xb254dd19(bool _0x5628cde9)
    {
        if (!this._0x00e87e89 || this._0x3b53e17b == null)
        {
            return;
        }

        int _0x271ef74b = this._0x569b833f;
        _0x2758e0ed _0x38e3c2e4 = this._0x3b53e17b._0xb69d08a8(_0x271ef74b);
        this._0x00e87e89 = false;
        this._0x569b833f = -1;
        if (this._board != null)
        {
            this._board._0x04307edc();
            _0x9f35f5f9 _0xcbc5477e = _0x38e3c2e4 != null ? this._board._0xde802e03(_0x38e3c2e4.GemIndex) : null;
            if (_0xcbc5477e != null)
            {
                _0xcbc5477e._0x8554d2ed(false);
            }
        }

        if (_0x38e3c2e4 == null)
        {
            return;
        }

        if (_0x5628cde9)
        {
            this._0x6396bc36(_0x271ef74b, _0x38e3c2e4.GemIndex, _0x81d63b54.GoodWindow * 0.5f);
        }
        else
        {
            this._0x57ecf240(_0x271ef74b, _0x38e3c2e4.GemIndex);
        }

        if (this._0xcdeacf91 <= _0x271ef74b)
        {
            this._0xcdeacf91 = _0x271ef74b + 1;
        }
    }

    private void _0xfa9a182e(Vector2 _0x554d5fb5)
    {
        if (!this._0x00e87e89 || this._0x3b53e17b == null)
        {
            return;
        }

        _0x2758e0ed _0xfc1def1c = this._0x3b53e17b._0xb69d08a8(this._0x569b833f);
        if (_0xfc1def1c == null)
        {
            this._0x00e87e89 = false;
            return;
        }

        float _0x2e3433b6 = _0xfc1def1c.HoldBeats * this._0x357ccfba._0xe0ba1140;
        float _0xabe315af = this._0x357ccfba._0x9f687af7 - this._0xfcfbce6a;
        this._0xb254dd19(_0xabe315af >= _0x2e3433b6 * 0.8f);
    }

    private void _0xcecf3b70()
    {
        this._0xa9915aa6();
        if (this._pops != null)
        {
            this._pops._0x2a333385();
        }

        this._0x5200fc57 = false;
    }

    private readonly _0x43db2420 _0x1bc1453c = new _0x43db2420();
    [SerializeField]
    private Sprite _backIcon;
    /// Opens a new phrase, plays the call out note by note, arms the echo window
    /// and scores what came back.
    private void _0x0bf32807()
    {
        int _0x7cffa7d4 = this._0x357ccfba._0xa7b7e9bd;
        if (_0x7cffa7d4 < 0)
        {
            return;
        }

        if (_0x7cffa7d4 != this._0xf63559c8)
        {
            if (this._0xf63559c8 >= 0)
            {
                this._0xb2aa37b5();
            }

            this._0xf63559c8 = _0x7cffa7d4;
            if (_0x7cffa7d4 >= this._0x74dbcca4.Phrases)
            {
                return;
            }

            this._0x3b53e17b = this._0x1bc1453c._0xa01e94da(this._0xfcf2ba8d, this._0xa2729a8b, _0x7cffa7d4, this._0x74dbcca4);
            this._0x1510280f = new int[this._0x3b53e17b._0xd40d1e7f];
            this._0x5f67bb91 = new float[this._0x3b53e17b._0xd40d1e7f];
            this._0xd9f7fe31 = 0;
            this._0xcdeacf91 = 0;
            this._0x00e87e89 = false;
            this._0x569b833f = -1;
            if (this._board != null)
            {
                this._board._0xa45474dd();
            }

            if (this._hud != null)
            {
                this._hud._0x378e52bb(_0x7cffa7d4, this._0x74dbcca4.Phrases);
            }
        }

        if (this._0x3b53e17b == null || _0x7cffa7d4 >= this._0x74dbcca4.Phrases)
        {
            return;
        }

        _0x6640e3cb _0x4b9b8f81 = this._0x357ccfba._0x88ba590c;
        if (_0x4b9b8f81 == _0x6640e3cb.Calling)
        {
            float _0x5978a1d2 = this._0x357ccfba._0x35e95df8(_0x7cffa7d4);
            while (this._0xd9f7fe31 < this._0x3b53e17b._0xd40d1e7f)
            {
                _0x2758e0ed _0x869f2649 = this._0x3b53e17b._0xb69d08a8(this._0xd9f7fe31);
                float _0xeb964680 = _0x5978a1d2 + (_0x869f2649.Beat * this._0x357ccfba._0xe0ba1140);
                if (this._0x357ccfba._0x9f687af7 < _0xeb964680)
                {
                    break;
                }

                _0x9f35f5f9 _0xbbeaab0a = this._board != null ? this._board._0xde802e03(_0x869f2649.GemIndex) : null;
                if (_0xbbeaab0a != null)
                {
                    _0xbbeaab0a.Call(this._0x357ccfba._0xe0ba1140);
                    if (_0x869f2649.HoldBeats > 0f && this._board != null)
                    {
                        this._board._0x0f7e8540(_0x869f2649.GemIndex, _0x869f2649.HoldBeats * this._0x357ccfba._0xe0ba1140);
                    }
                }

                this._0xd9f7fe31++;
            }
        }
        else if (_0x4b9b8f81 == _0x6640e3cb.Handover)
        {
            if (this._board != null)
            {
                this._board._0x04307edc();
            }
        }
        else if (_0x4b9b8f81 == _0x6640e3cb.Echoing)
        {
            this._0xc772b160();
            this._0xb068ee26();
            this._0xa81458c4();
        }
    }

    private _0x9739adad _0x74dbcca4;
    private int _0x569b833f = -1;
    private readonly _0x2a2ce1f2 _0x3c8b0c04 = new _0x2a2ce1f2();
    private void _0x4ae83d8a()
    {
        _0xe83c15f0 _0x1090917d = _0xe83c15f0.Instance;
        if (_0x1090917d != null)
        {
            _0x1090917d.LoadSceneByIndex(_0xc29566dc._0x4e12825d.SCENE_0);
        }
    }

    private int _0xf63559c8 = -1;
    private const int NotePending = 0;
    private void _0x1f88b1ea()
    {
        if (this._hud == null)
        {
            return;
        }

        this._hud._0x682da06d(this._0x0c5696e4());
        this._hud._0xa4846563(this._0x142d2e5f);
        this._hud._0x9117a7a9(this._0x7cf9a8f5);
        this._hud._0xd306d767(this._0x44f44f99 / _0x81d63b54.MeterMax);
    }

    private int _0x7cf9a8f5;
    private int _0xd9f7fe31;
    private void _0xa9915aa6()
    {
        if (this._0xcceef7a9 != null)
        {
            this._0xcceef7a9.Kill(false);
            this._0xcceef7a9 = null;
        }
    }

    [SerializeField]
    private Sprite _pipSprite;
    private float _0x44f44f99 = _0x81d63b54.MeterMax;
    [SerializeField]
    private TMP_FontAsset _font;
    private void _0x839699b9()
    {
        bool _0xd067b9ef = this._0x357ccfba._0x9bba6874 == 0;
        if (this._board != null)
        {
            this._board._0xdef377c6(_0xd067b9ef);
            if (this._board._0xb3901f69 != null)
            {
                this._board._0xb3901f69._0xd10ef2c7(this._0x357ccfba._0xe0ba1140, _0xd067b9ef);
            }
        }

        if (this._hud != null)
        {
            this._hud._0x8f1c877c(this._0x357ccfba._0x9bba6874);
        }
    }

    private int _0xfcf2ba8d;
    /// A phrase counts as let through when half its notes or more were lost. Five
    /// of those in a row and the curtain comes down - that is the clock the whole
    /// run length is built on.
    private void _0xb2aa37b5()
    {
        if (this._0x3b53e17b == null || this._0x1510280f == null)
        {
            return;
        }

        int _0x6e8c71a7 = 0;
        int _0x270cf165 = 0;
        for (int _0xce593163 = 0; _0xce593163 < this._0x1510280f.Length; _0xce593163++)
        {
            if (this._0x1510280f[_0xce593163] == NotePending)
            {
                this._0x1510280f[_0xce593163] = NoteLost;
                this._0x90f56899++;
            }

            if (this._0x1510280f[_0xce593163] == NoteLost)
            {
                _0x6e8c71a7++;
            }
            else
            {
                _0x270cf165++;
            }
        }

        bool _0xfc77ef05 = _0x6e8c71a7 >= Mathf.CeilToInt(this._0x1510280f.Length * _0x81d63b54.PhraseMissFraction);
        if (_0xfc77ef05)
        {
            this._0x7cf9a8f5++;
            this._0x44f44f99 = Mathf.Max(0f, this._0x44f44f99 - _0x81d63b54.MeterMissedPhrasePenalty);
        }
        else
        {
            this._0x7cf9a8f5 = 0;
            if (_0x6e8c71a7 == 0 && _0x270cf165 > 0)
            {
                this._0x44f44f99 = Mathf.Min(_0x81d63b54.MeterMax, this._0x44f44f99 + _0x81d63b54.MeterPhrasePerfectBonus);
            }
        }

        this._0x1f88b1ea();
        {
#if B_LOGS
            {
                Debug.Log(_0xeb105c9a._0x9482a44c(new byte[21] { 110, 69, 93, 71, 84, 70, 80, 24, 70, 86, 90, 71, 80, 104, 21, 92, 91, 81, 80, 77, 8 }, 53) + this._0xf63559c8 + _0xeb105c9a._0x9482a44c(new byte[6] { 154, 214, 213, 201, 206, 135 }, 186) + _0x6e8c71a7 + _0xeb105c9a._0x9482a44c(new byte[8] { 182, 229, 226, 228, 227, 245, 253, 171 }, 150) + _0x270cf165 + _0xeb105c9a._0x9482a44c(new byte[5] { 46, 124, 97, 121, 51 }, 14) + this._0x7cf9a8f5 + _0xeb105c9a._0x9482a44c(new byte[7] { 212, 153, 145, 128, 145, 134, 201 }, 244) + this._0x44f44f99);
            }
#endif
        }
    }

    private void _0x6396bc36(int _0x8da4e6ad, int _0x74a0b77c, float _0x286ab1f5)
    {
        float weight;
        bool _0xd047120f = _0x286ab1f5 <= _0x81d63b54.PerfectWindow;
        if (_0xd047120f)
        {
            weight = 1f;
            this._0x44f44f99 += _0x81d63b54.MeterPerfectGain;
        }
        else if (_0x286ab1f5 <= _0x81d63b54.GoodWindow)
        {
            weight = 0.8f;
            this._0x44f44f99 += _0x81d63b54.MeterGoodGain;
        }
        else
        {
            weight = 0.55f;
            this._0x44f44f99 += _0x81d63b54.MeterOkGain;
        }

        this._0x142d2e5f++;
        if (this._0x142d2e5f > this._0xa0ec4b87)
        {
            this._0xa0ec4b87 = this._0x142d2e5f;
        }

        if (this._0x142d2e5f >= _0x81d63b54.StreakBonusFrom)
        {
            this._0x44f44f99 += _0x81d63b54.MeterStreakBonus;
        }

        this._0x44f44f99 = Mathf.Min(_0x81d63b54.MeterMax, this._0x44f44f99);
        this._0x1510280f[_0x8da4e6ad] = NoteStruck;
        this._0x5f67bb91[_0x8da4e6ad] = weight;
        this._0x90f56899++;
        this._0x7c824c7f += weight;
        if (this._board != null)
        {
            _0x9f35f5f9 _0xb87961c8 = this._board._0xde802e03(_0x74a0b77c);
            if (_0xb87961c8 != null)
            {
                _0xb87961c8._0x759124e4(_0xd047120f);
            }

            this._board._0x8c3ef777(_0x74a0b77c, _0xd047120f ? _0x50c58425.Topaz : _0x50c58425.Jade);
        }

        if (_0xd047120f && this._0x3c8b0c04._0xfbabe7f1)
        {
            this._0xfad6c6fc();
        }

        this._0x1f88b1ea();
    }

    private readonly _0xf13c07b3 _0x357ccfba = new _0xf13c07b3();
    private void _0x87c60a16()
    {
        _0xe83c15f0 _0xc8ec8f70 = _0xe83c15f0.Instance;
        if (_0xc8ec8f70 != null)
        {
            _0xc8ec8f70.LoadSceneByIndex(_0xc29566dc._0x4e12825d.SCENE_1);
        }
    }

    [SerializeField]
    private Sprite _pauseIcon;
    private int _0xcdeacf91;
    private float _0x7c824c7f;
    private int _0x0c5696e4()
    {
        if (this._0x90f56899 <= 0)
        {
            return 100;
        }

        return Mathf.Clamp(Mathf.RoundToInt((this._0x7c824c7f / this._0x90f56899) * 100f), 0, 100);
    }

    private _0x242ac267 _0x3b53e17b;
    private void _0x74a85226(Vector2 _0xdb4a3ea0)
    {
        if (this._0x5200fc57 || this._0xe2a42393 || this._board == null || this._0x3b53e17b == null)
        {
            return;
        }

        int _0x0d2384d0 = this._board._0x7860b5c6(_0xdb4a3ea0);
        if (_0x0d2384d0 < 0)
        {
            return;
        }

        if (this._0x357ccfba._0x88ba590c != _0x6640e3cb.Echoing)
        {
            _0x9f35f5f9 _0xfc8bb77a = this._board._0xde802e03(_0x0d2384d0);
            if (_0xfc8bb77a != null)
            {
                _0xfc8bb77a.Call(this._0x357ccfba._0xe0ba1140);
            }

            return;
        }

        if (this._0xcdeacf91 >= this._0x3b53e17b._0xd40d1e7f)
        {
            return;
        }

        _0x2758e0ed _0xdc7a7d85 = this._0x3b53e17b._0xb69d08a8(this._0xcdeacf91);
        if (_0xdc7a7d85.GemIndex != _0x0d2384d0)
        {
            _0x9f35f5f9 _0xca358967 = this._board._0xde802e03(_0x0d2384d0);
            if (_0xca358967 != null)
            {
                _0xca358967._0xe6437280();
            }

            this._0x57ecf240(this._0xcdeacf91, _0xdc7a7d85.GemIndex);
            this._0xcdeacf91++;
            return;
        }

        float _0xbb081a1c = this._0x357ccfba._0x7eb2e7e2(this._0xf63559c8);
        float _0xf3233151 = _0xbb081a1c + (_0xdc7a7d85.Beat * this._0x357ccfba._0xe0ba1140);
        float _0xd350f93c = Mathf.Abs(this._0x357ccfba._0x9f687af7 - _0xf3233151);
        if (_0xd350f93c > _0x81d63b54.OkWindow)
        {
            this._0x57ecf240(this._0xcdeacf91, _0xdc7a7d85.GemIndex);
            this._0xcdeacf91++;
            return;
        }

        if (_0xdc7a7d85.HoldBeats > 0f)
        {
            this._0x00e87e89 = true;
            this._0x569b833f = this._0xcdeacf91;
            this._0xfcfbce6a = this._0x357ccfba._0x9f687af7;
            _0x9f35f5f9 _0xf617b320 = this._board._0xde802e03(_0xdc7a7d85.GemIndex);
            if (_0xf617b320 != null)
            {
                _0xf617b320._0x8554d2ed(true);
            }

            this._board._0x0f7e8540(_0xdc7a7d85.GemIndex, _0xdc7a7d85.HoldBeats * this._0x357ccfba._0xe0ba1140);
            return;
        }

        this._0x6396bc36(this._0xcdeacf91, _0xdc7a7d85.GemIndex, _0xd350f93c);
        this._0xcdeacf91++;
    }

    private void _0x57ecf240(int _0x8f49fd0a, int _0x33b4ca4a)
    {
        this._0x142d2e5f = 0;
        this._0x1510280f[_0x8f49fd0a] = NoteLost;
        this._0x5f67bb91[_0x8f49fd0a] = 0f;
        this._0x90f56899++;
        if (this._board != null)
        {
            _0x9f35f5f9 _0x109e4f92 = this._board._0xde802e03(_0x33b4ca4a);
            if (_0x109e4f92 != null)
            {
                _0x109e4f92._0xe6437280();
            }
        }

        this._0x1f88b1ea();
    }

    private bool _0xe2a42393;
    private void _0x5f70cccd()
    {
        if (this._0xe2a42393)
        {
            return;
        }

        if (this._0x7cf9a8f5 >= _0x81d63b54.MissedPhraseLimit)
        {
            this._0x144a3744(false, _0xeb105c9a._0x9482a44c(new byte[15] { 240, 230, 225, 231, 242, 250, 253, 147, 247, 225, 252, 227, 227, 246, 247 }, 179));
            return;
        }

        if (this._0x44f44f99 <= 0f)
        {
            this._0x144a3744(false, _0xeb105c9a._0x9482a44c(new byte[16] { 64, 92, 81, 52, 70, 92, 77, 64, 92, 89, 52, 82, 85, 80, 81, 80 }, 20));
            return;
        }

        if (this._0x357ccfba._0xa7b7e9bd >= this._0x74dbcca4.Phrases)
        {
            int _0x1f653e3c = this._0x0c5696e4();
            if (_0x1f653e3c >= _0x81d63b54.PassAccuracy)
            {
                this._0x144a3744(true, _0xeb105c9a._0x9482a44c(new byte[13] { 5, 14, 3, 15, 18, 5, 96, 5, 1, 18, 14, 5, 4 }, 64));
            }
            else
            {
                this._0x144a3744(false, _0xeb105c9a._0x9482a44c(new byte[11] { 164, 191, 184, 160, 215, 180, 187, 184, 164, 178, 179 }, 247));
            }
        }
    }

    private float[] _0x5f67bb91;
    private void _0xc772b160()
    {
        if (this._board == null || this._0x3b53e17b == null)
        {
            return;
        }

        for (int _0x871e79c8 = this._0xcdeacf91; _0x871e79c8 < this._0x3b53e17b._0xd40d1e7f; _0x871e79c8++)
        {
            if (this._0x1510280f[_0x871e79c8] != NotePending)
            {
                continue;
            }

            _0x9f35f5f9 _0x19870c79 = this._board._0xde802e03(this._0x3b53e17b._0xb69d08a8(_0x871e79c8).GemIndex);
            if (_0x19870c79 != null)
            {
                _0x19870c79._0x65605a63();
            }
        }
    }

    private int _0xa2729a8b;
    private void _0xfad6c6fc()
    {
        try
        {
            Handheld.Vibrate();
        }
        catch (System.Exception)
        {
        }
    }

    private bool _0x00e87e89;
    /// How long the intermission holds before the show carries on by itself.
    private const float IntermissionSeconds = 7f;
    private void _0x144a3744(bool _0xa5306943, string _0x8eb7292f)
    {
        this._0xe2a42393 = true;
        if (this._board != null)
        {
            this._board._0xa45474dd();
        }

        int _0xc315510c = this._0x0c5696e4();
        string _0x22fdbea8 = _0x81d63b54.RankFor(_0xc315510c);
        int _0x5c012621 = Mathf.Clamp(this._0xf63559c8 + 1, 0, this._0x74dbcca4.Phrases);
        int _0x5e60c541 = this._0xa0ec4b87 >= 24 ? 3 : (this._0xa0ec4b87 >= 12 ? 2 : 1);
        int _0xbf7a0892 = (5 * _0x5c012621) + Mathf.RoundToInt((_0xc315510c / 100f) * _0x5c012621 * 10f * _0x5e60c541);
        this._0x3c8b0c04._0x7cac5506(_0xc315510c, _0x22fdbea8, this._0xa0ec4b87, _0xa5306943);
        this._0x3c8b0c04._0xe3cb90cf = this._0x3c8b0c04._0xe3cb90cf + _0xbf7a0892;
        if (this._pops == null)
        {
            return;
        }

        if (_0xa5306943)
        {
            this._pops._0x201ded4c(_0x22fdbea8, _0xc315510c, this._0xa0ec4b87, _0xbf7a0892);
            this._pops._0x68f5c4b1();
        }
        else
        {
            this._pops._0x03af6ebd(_0x8eb7292f, _0xc315510c, _0x5c012621, this._0x74dbcca4.Phrases, _0x22fdbea8, _0xbf7a0892);
            this._pops._0x3b51cb88();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xeb105c9a._0x9482a44c(new byte[17] { 143, 166, 161, 186, 249, 177, 186, 176, 137, 244, 177, 186, 183, 187, 166, 177, 233 }, 212) + _0xa5306943 + _0xeb105c9a._0x9482a44c(new byte[8] { 91, 9, 30, 26, 8, 20, 21, 70 }, 123) + _0x8eb7292f + _0xeb105c9a._0x9482a44c(new byte[10] { 131, 194, 192, 192, 214, 209, 194, 192, 218, 158 }, 163) + _0xc315510c + _0xeb105c9a._0x9482a44c(new byte[4] { 109, 44, 57, 112 }, 77) + this._0x357ccfba._0x9f687af7);
            }
#endif
        }
    }

    private const int NoteLost = 2;
    private void OnDestroy()
    {
        this._0xa9915aa6();
        DOTween.Kill(this.transform, false);
    }

    private void Start()
    {
        _0x8def4c1e.BlankUnusedPages();
        _0x8def4c1e.ThemeSplashSlider();
        this._0xfcf2ba8d = this._0x3c8b0c04._0x263cd408;
        this._0x74dbcca4 = _0x81d63b54.Track(this._0xfcf2ba8d);
        this._0xa2729a8b = this._0x3c8b0c04._0x8dbbf0ca();
        this._0x357ccfba._0xb2637c29(this._0x74dbcca4);
        Transform _0xdffb3fac = _0x8def4c1e.PanelBody(_0xc29566dc._0x97b1c56c.DEFAULT);
        if (_0xdffb3fac == null)
        {
            return;
        }

        _0x8def4c1e.ClearPanelBody(_0xc29566dc._0x97b1c56c.DEFAULT);
        if (this._board != null)
        {
            this._board._0x408f76de();
            this._board._0xa45474dd();
        }

        if (this._hud != null)
        {
            this._hud._0x34073602(_0xdffb3fac, this._font, this._plateSprite, this._barSprite, this._pipSprite, this._backIcon, this._pauseIcon);
            this._hud._0x378e52bb(0, this._0x74dbcca4.Phrases);
            this._hud._0x682da06d(100);
            this._hud._0xa4846563(0);
            this._hud._0x9117a7a9(0);
            this._hud._0xd306d767(1f);
            if (this._hud._0x8aa406e1 != null)
            {
                this._hud._0x8aa406e1._0x3c712d0b(this._board != null ? this._board._0xa7b3a759 : Camera.main, _0x6fb09045 => this._0x74a85226(_0x6fb09045), _0x6fb09045 => this._0xfa9a182e(_0x6fb09045));
            }

            if (this._hud._0x8613e286 != null)
            {
                this._hud._0x8613e286.onClick.AddListener(() => this._0x4ae83d8a());
            }

            if (this._hud._0xd32b11fb != null)
            {
                this._hud._0xd32b11fb.onClick.AddListener(() => this._0xd07e4f25());
            }
        }

        if (this._pops != null)
        {
            this._pops._0x1e47dff7();
            this._0x48d29182(this._pops._0xda28e842, true);
            this._0x48d29182(this._pops._0x29c902a1, true);
            this._0x48d29182(this._pops._0xf69966e0, false);
            if (this._pops._0xf108f034 != null)
            {
                this._pops._0xf108f034.onClick.AddListener(() => this._0x87c60a16());
            }

            if (this._pops._0x9f460399 != null)
            {
                this._pops._0x9f460399.onClick.AddListener(() => this._0x87c60a16());
            }

            if (this._pops._0x9183fd00 != null)
            {
                this._pops._0x9183fd00.onClick.AddListener(() => this._0x4ae83d8a());
            }

            if (this._pops._0x00880dbd != null)
            {
                this._pops._0x00880dbd.onClick.AddListener(() => this._0x4ae83d8a());
            }

            if (this._pops._0x63a956c3 != null)
            {
                this._pops._0x63a956c3.onClick.AddListener(() => this._0x4ae83d8a());
            }

            if (this._pops._0x0211ea19 != null)
            {
                this._pops._0x0211ea19.onClick.AddListener(() => this._0x4ae83d8a());
            }
        }

        {
#if B_LOGS
            {
                Debug.Log(_0xeb105c9a._0x9482a44c(new byte[12] { 154, 179, 180, 175, 156, 225, 181, 179, 160, 162, 170, 252 }, 193) + this._0xfcf2ba8d + _0xeb105c9a._0x9482a44c(new byte[9] { 143, 206, 219, 219, 202, 194, 223, 219, 146 }, 175) + this._0xa2729a8b + _0xeb105c9a._0x9482a44c(new byte[9] { 7, 87, 79, 85, 70, 84, 66, 84, 26 }, 39) + this._0x74dbcca4.Phrases + _0xeb105c9a._0x9482a44c(new byte[15] { 98, 50, 42, 48, 35, 49, 39, 17, 39, 33, 45, 44, 38, 49, 127 }, 66) + this._0x74dbcca4._0x707c57a0);
            }
#endif
        }
    }

    private void _0x48d29182(UnityEngine.UI.Button _0xc2bd7079, bool _0xe296f194)
    {
        if (_0xc2bd7079 == null)
        {
            return;
        }

        if (_0xe296f194)
        {
            _0xc2bd7079.onClick.AddListener(() => this._0xcecf3b70());
        }
        else
        {
            _0xc2bd7079.onClick.AddListener(() => this._0x4ae83d8a());
        }
    }

    /// Any note whose window has closed is gone, whether or not it was reached.
    private void _0xb068ee26()
    {
        if (this._0x3b53e17b == null)
        {
            return;
        }

        float _0x09c48b85 = this._0x357ccfba._0x7eb2e7e2(this._0xf63559c8);
        while (this._0xcdeacf91 < this._0x3b53e17b._0xd40d1e7f)
        {
            if (this._0x1510280f[this._0xcdeacf91] != NotePending)
            {
                this._0xcdeacf91++;
                continue;
            }

            if (this._0x00e87e89 && this._0xcdeacf91 == this._0x569b833f)
            {
                break;
            }

            _0x2758e0ed _0xd386d53c = this._0x3b53e17b._0xb69d08a8(this._0xcdeacf91);
            float _0x8f2ae34a = _0x09c48b85 + (_0xd386d53c.Beat * this._0x357ccfba._0xe0ba1140);
            if (this._0x357ccfba._0x9f687af7 <= _0x8f2ae34a + _0x81d63b54.OkWindow)
            {
                break;
            }

            this._0x57ecf240(this._0xcdeacf91, _0xd386d53c.GemIndex);
            this._0xcdeacf91++;
        }
    }

    [SerializeField]
    private Sprite _barSprite;
    private float _0xfcfbce6a;
    [SerializeField]
    private Sprite _plateSprite;
    private bool _0x5200fc57;
    private int _0x90f56899;
    private bool _0x28a5b765;
    private const int NoteStruck = 1;
    [SerializeField]
    private _0xf30072b9 _pops;
    private int _0x142d2e5f;
    private void Update()
    {
        if (this._0xe2a42393)
        {
            return;
        }

        if (!this._0x28a5b765)
        {
            // The template shows its own splash first; the run only begins once the
            // panel with the stage in it is actually on screen.
            _0xb67d6cae _0x3c281ce5 = _0xb67d6cae.Instance;
            if (_0x3c281ce5 == null || _0x3c281ce5.CurrentPanelIndex != _0xc29566dc._0x97b1c56c.DEFAULT)
            {
                return;
            }

            this._0x28a5b765 = true;
        }

        if (this._0x5200fc57)
        {
            return;
        }

        float _0x29d758c7 = Time.deltaTime;
        int _0x169bd6df = this._0x357ccfba._0x3dd05b3c(_0x29d758c7);
        for (int _0x2cc007fe = 0; _0x2cc007fe < _0x169bd6df; _0x2cc007fe++)
        {
            this._0x839699b9();
        }

        this._0x44f44f99 = Mathf.Max(0f, this._0x44f44f99 - (_0x81d63b54.MeterDrainPerSecond * _0x29d758c7));
        if (this._hud != null)
        {
            this._hud._0xd306d767(this._0x44f44f99 / _0x81d63b54.MeterMax);
        }

        if (!this._0x28195ec4 && this._0x357ccfba._0x9f687af7 > 14f)
        {
            this._0x28195ec4 = true;
            if (this._hud != null)
            {
                this._hud._0xaf042d64();
            }
        }

        this._0x0bf32807();
        this._0x5f70cccd();
    }

    private void _0xd07e4f25()
    {
        if (this._0xe2a42393 || this._0x5200fc57 || this._pops == null)
        {
            return;
        }

        this._0x5200fc57 = true;
        this._pops.FillPause(Mathf.Max(0, this._0xf63559c8), this._0x74dbcca4.Phrases, this._0x0c5696e4(), Mathf.RoundToInt((this._0x44f44f99 / _0x81d63b54.MeterMax) * 100f));
        this._pops._0xa57a3bc1();
        // The show does not hold forever. Without this the run can be parked on the
        // intermission indefinitely, which is also how an automated pass through
        // the game ends up photographing the same card over and over.
        this._0xa9915aa6();
        this._0xcceef7a9 = DOVirtual.DelayedCall(IntermissionSeconds, () => this._0xcecf3b70());
    }

    /// A hold completes itself once its full length has been kept, so the player
    /// can lift the finger at any point after that without losing the note.
    private void _0xa81458c4()
    {
        if (!this._0x00e87e89 || this._0x3b53e17b == null)
        {
            return;
        }

        _0x2758e0ed _0xd4787290 = this._0x3b53e17b._0xb69d08a8(this._0x569b833f);
        if (_0xd4787290 == null)
        {
            this._0x00e87e89 = false;
            return;
        }

        float _0xbc27ea4f = _0xd4787290.HoldBeats * this._0x357ccfba._0xe0ba1140;
        if (this._0x357ccfba._0x9f687af7 - this._0xfcfbce6a >= _0xbc27ea4f)
        {
            this._0xb254dd19(true);
        }
    }

    [SerializeField]
    private _0xc045d7a0 _board;
    [SerializeField]
    private _0x7a377452 _hud;
    private int _0xa0ec4b87;
    private Tween _0xcceef7a9;
    private int[] _0x1510280f;
}

internal static class _0xeb105c9a
{
    internal static string _0x9482a44c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}