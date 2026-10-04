using UnityEngine;

/// Builds the phrase the show calls out. Nothing here is a fixed layout: which
/// gems appear, in which order, on which beats and whether the pearl star has to
/// be held all come out of a seeded generator, so two attempts at the same track
/// look different on the arc rather than only in the numbers (rule C.11).
///
/// A generated phrase is only shown after it has been proved playable. If twenty
/// draws in a row fail, a hand-checked phrase from the small bank below is used
/// instead - the bank is the safety net, never the game.
public sealed class _0x43db2420
{
    private _0x242ac267 _0x58f1e347(System.Random _0x81745705, _0x9739adad _0x1c667c14, int _0x00ffa1ef)
    {
        int _0x67774cfc;
        if (_0x00ffa1ef < 3)
        {
            _0x67774cfc = 3;
        }
        else if (_0x00ffa1ef < 8)
        {
            _0x67774cfc = 3 + _0x81745705.Next(2);
        }
        else
        {
            _0x67774cfc = 4 + _0x81745705.Next(2);
        }

        // Eighth-note grid across the call window, with the last half beat left
        // free so a note can never start on the very edge of the window. The
        // spacing is solved rather than walked: one beat is the floor between two
        // notes, and whatever room is left over is handed out in half beats, so a
        // phrase can never run off the end of its own window.
        float _0x33bbc802 = _0x81745705.Next(2) * 0.5f;
        float _0x7aa05152 = _0x1c667c14.CallBeats - 0.5f;
        float _0x14a6ed71 = (_0x7aa05152 - _0x33bbc802) - ((_0x67774cfc - 1) * MinGapBeats);
        int _0xd17793bd = Mathf.Max(0, Mathf.FloorToInt(_0x14a6ed71 / 0.5f));
        float[] _0x73edbf22 = new float[_0x67774cfc];
        float _0xa619164f = _0x33bbc802;
        _0x73edbf22[0] = _0xa619164f;
        for (int _0xcff9b28d = 1; _0xcff9b28d < _0x67774cfc; _0xcff9b28d++)
        {
            int extra = _0xd17793bd > 0 ? _0x81745705.Next(_0xd17793bd + 1) : 0;
            _0xd17793bd -= extra;
            _0xa619164f += MinGapBeats + (extra * 0.5f);
            _0x73edbf22[_0xcff9b28d] = _0xa619164f;
        }

        _0x242ac267 _0x953be11b = new _0x242ac267();
        _0x953be11b.Notes = new _0x2758e0ed[_0x67774cfc];
        int _0xc26177a1 = -1;
        int _0x7153ebcd = -1;
        for (int _0x49102711 = 0; _0x49102711 < _0x67774cfc; _0x49102711++)
        {
            int _0xec95e2b4 = _0x81745705.Next(5);
            if (_0xec95e2b4 == _0xc26177a1 && _0xec95e2b4 == _0x7153ebcd)
            {
                _0xec95e2b4 = (_0xec95e2b4 + 1 + _0x81745705.Next(4)) % 5;
            }

            _0x2758e0ed _0x8d735108 = new _0x2758e0ed();
            _0x8d735108.GemIndex = _0xec95e2b4;
            _0x8d735108.Beat = _0x73edbf22[_0x49102711];
            _0x8d735108.HoldBeats = 0f;
            _0x953be11b.Notes[_0x49102711] = _0x8d735108;
            _0x7153ebcd = _0xc26177a1;
            _0xc26177a1 = _0xec95e2b4;
        }

        // The hold always lands on the LAST note, so nothing can start underneath a
        // finger that is still down. Until phrase 8 it is always the pearl star -
        // that is the gem the hint names - and only after that can any gem hold.
        bool _0x4f6369b7 = _0x00ffa1ef >= 3 && _0x81745705.NextDouble() < 0.35;
        if (_0x4f6369b7)
        {
            _0x2758e0ed _0x2f1d9b3d = _0x953be11b.Notes[_0x67774cfc - 1];
            float _0xbfe47ddf = _0x1c667c14.CallBeats - _0x2f1d9b3d.Beat;
            float _0xfa58e32c = 2f + _0x81745705.Next(2);
            if (_0xbfe47ddf >= _0xfa58e32c)
            {
                _0x2f1d9b3d.HoldBeats = _0xfa58e32c;
                _0x2f1d9b3d.GemIndex = _0x00ffa1ef >= 8 ? _0x81745705.Next(5) : 4;
            }
        }

        return _0x953be11b;
    }

    private _0x242ac267 _0x90c42af1(System.Random _0xc7fd26aa, _0x9739adad _0xda2b885e)
    {
        int[] _0xe7022f9d =
        {
            0,
            1,
            2,
            3,
            4
        };
        for (int _0x78aa05dd = _0xe7022f9d.Length - 1; _0x78aa05dd > 0; _0x78aa05dd--)
        {
            int _0x47d44b0c = _0xc7fd26aa.Next(_0x78aa05dd + 1);
            int _0x5a61adeb = _0xe7022f9d[_0x78aa05dd];
            _0xe7022f9d[_0x78aa05dd] = _0xe7022f9d[_0x47d44b0c];
            _0xe7022f9d[_0x47d44b0c] = _0x5a61adeb;
        }

        float _0x59153686 = Mathf.Max(1f, Mathf.Floor((_0xda2b885e.CallBeats - 1f) / 2f));
        _0x242ac267 _0x7a035a33 = new _0x242ac267();
        _0x7a035a33.Notes = new _0x2758e0ed[3];
        for (int _0x5e1a3a2b = 0; _0x5e1a3a2b < 3; _0x5e1a3a2b++)
        {
            _0x2758e0ed _0x0d6131e2 = new _0x2758e0ed();
            _0x0d6131e2.GemIndex = _0xe7022f9d[_0x5e1a3a2b];
            _0x0d6131e2.Beat = _0x5e1a3a2b * _0x59153686;
            _0x0d6131e2.HoldBeats = 0f;
            _0x7a035a33.Notes[_0x5e1a3a2b] = _0x0d6131e2;
        }

        return _0x7a035a33;
    }

    public bool _0x226ca84e(_0x242ac267 _0xbcc7a757, _0x9739adad _0x5210d6bf)
    {
        if (_0xbcc7a757 == null || _0xbcc7a757._0xd40d1e7f < 3 || _0xbcc7a757._0xd40d1e7f > 5)
        {
            return false;
        }

        float _0xb1e5ec48 = _0x5210d6bf._0x7ac219a1;
        int _0x7d61f0dc = 1;
        for (int _0x4a25c0d2 = 0; _0x4a25c0d2 < _0xbcc7a757._0xd40d1e7f; _0x4a25c0d2++)
        {
            _0x2758e0ed _0xf8e5bb85 = _0xbcc7a757.Notes[_0x4a25c0d2];
            if (_0xf8e5bb85.Beat < 0f || _0xf8e5bb85._0x49c18b46 > _0x5210d6bf.CallBeats)
            {
                return false;
            }

            if (_0xf8e5bb85.HoldBeats > 0f && _0x4a25c0d2 != _0xbcc7a757._0xd40d1e7f - 1)
            {
                return false;
            }

            if (_0x4a25c0d2 > 0)
            {
                _0x2758e0ed _0x10b358a9 = _0xbcc7a757.Notes[_0x4a25c0d2 - 1];
                float _0x1ea6ad2d = _0xf8e5bb85.Beat - _0x10b358a9._0x49c18b46;
                if (_0x1ea6ad2d < MinGapBeats - 0.001f || _0x1ea6ad2d * _0xb1e5ec48 < MinGapSeconds)
                {
                    return false;
                }

                _0x7d61f0dc = _0xf8e5bb85.GemIndex == _0x10b358a9.GemIndex ? _0x7d61f0dc + 1 : 1;
                if (_0x7d61f0dc >= 3)
                {
                    return false;
                }
            }
        }

        return true;
    }

    /// A thumb needs this long between two taps. Below it a phrase is unplayable
    /// however pretty it looks on the grid.
    private const float MinGapSeconds = 0.45f;
    public _0x242ac267 _0xa01e94da(int _0x9d5dfb94, int _0xc43fa7e8, int _0x14f44101, _0x9739adad _0xdf40eff4)
    {
        int _0xa2fe2252 = (_0x9d5dfb94 * 7919) ^ (_0xc43fa7e8 * 104729) ^ ((_0x14f44101 + 1) * 15485863);
        System.Random _0x3487acfe = new System.Random(_0xa2fe2252);
        // The opening phrase is deliberately gentle: three taps, no hold, two beats
        // apart, all gems different. The first thing a player meets has to be
        // playable at sight - which is also what makes the review capture useful.
        if (_0x14f44101 == 0)
        {
            _0x242ac267 _0xe36ff302 = this._0x90c42af1(_0x3487acfe, _0xdf40eff4);
            _0xe36ff302.Seed = _0xa2fe2252;
            return _0xe36ff302;
        }

        _0x242ac267 _0x7da91307 = null;
        for (int _0xf9d12af9 = 0; _0xf9d12af9 < MaxDraws; _0xf9d12af9++)
        {
            _0x7da91307 = this._0x58f1e347(_0x3487acfe, _0xdf40eff4, _0x14f44101);
            if (this._0x226ca84e(_0x7da91307, _0xdf40eff4))
            {
                _0x7da91307.Seed = _0xa2fe2252;
                {
#if B_LOGS
                    {
                        Debug.Log(_0x51f3ca15._0xac5e679a(new byte[15] { 123, 80, 72, 82, 65, 83, 69, 125, 0, 84, 82, 65, 67, 75, 29 }, 32) + _0x9d5dfb94 + _0x51f3ca15._0xac5e679a(new byte[7] { 11, 66, 69, 79, 78, 83, 22 }, 43) + _0x14f44101 + _0x51f3ca15._0xac5e679a(new byte[6] { 227, 176, 166, 166, 167, 254 }, 195) + _0xa2fe2252 + _0x51f3ca15._0xac5e679a(new byte[7] { 56, 124, 106, 121, 111, 107, 37 }, 24) + (_0xf9d12af9 + 1) + _0x51f3ca15._0xac5e679a(new byte[7] { 67, 13, 12, 23, 6, 16, 94 }, 99) + _0x7da91307._0xd40d1e7f);
                    }
#endif
                }

                return _0x7da91307;
            }
        }

        _0x242ac267 _0x86ba220b = this._0xdd6eefe4(_0x14f44101, _0xdf40eff4);
        _0x86ba220b.Seed = _0xa2fe2252;
        _0x86ba220b.FromFallback = true;
        {
#if B_LOGS
            {
                Debug.Log(_0x51f3ca15._0xac5e679a(new byte[24] { 205, 230, 254, 228, 247, 229, 243, 203, 182, 240, 247, 250, 250, 244, 247, 245, 253, 182, 226, 228, 247, 245, 253, 171 }, 150) + _0x9d5dfb94 + _0x51f3ca15._0xac5e679a(new byte[7] { 231, 174, 169, 163, 162, 191, 250 }, 199) + _0x14f44101 + _0x51f3ca15._0xac5e679a(new byte[6] { 216, 139, 157, 157, 156, 197 }, 248) + _0xa2fe2252);
            }
#endif
        }

        return _0x86ba220b;
    }

    private const int MaxDraws = 20;
    private const float MinGapBeats = 1f;
    /// Four phrases checked by hand. They exist so a run can never stall on a bad
    /// draw; they are picked in rotation only when twenty draws have failed.
    private _0x242ac267 _0xdd6eefe4(int _0xc40d8875, _0x9739adad _0xfa98f415)
    {
        int[][] _0x93e8f21b =
        {
            new[]
            {
                0,
                2,
                4
            },
            new[]
            {
                1,
                3,
                0
            },
            new[]
            {
                2,
                4,
                1,
                3
            },
            new[]
            {
                3,
                1,
                4,
                2
            },
        };
        int[] _0x0906f42b = _0x93e8f21b[((_0xc40d8875 % _0x93e8f21b.Length) + _0x93e8f21b.Length) % _0x93e8f21b.Length];
        float _0xe11a25a3 = Mathf.Max(1f, Mathf.Floor((_0xfa98f415.CallBeats - 0.5f) / Mathf.Max(1, _0x0906f42b.Length - 1)));
        _0x242ac267 _0x0f09d383 = new _0x242ac267();
        _0x0f09d383.Notes = new _0x2758e0ed[_0x0906f42b.Length];
        for (int _0x7ad3bdd3 = 0; _0x7ad3bdd3 < _0x0906f42b.Length; _0x7ad3bdd3++)
        {
            _0x2758e0ed _0xcf782a05 = new _0x2758e0ed();
            _0xcf782a05.GemIndex = _0x0906f42b[_0x7ad3bdd3];
            _0xcf782a05.Beat = Mathf.Min(_0x7ad3bdd3 * _0xe11a25a3, _0xfa98f415.CallBeats - 0.5f);
            _0xcf782a05.HoldBeats = 0f;
            _0x0f09d383.Notes[_0x7ad3bdd3] = _0xcf782a05;
        }

        return _0x0f09d383;
    }
}

internal static class _0x51f3ca15
{
    internal static string _0xac5e679a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}