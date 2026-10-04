using UnityEngine;

/// One note of a phrase: which gem lights up, on which beat of the call window,
/// and for how many beats it must be held. HoldBeats 0 is an ordinary tap.
public sealed class _0x2758e0ed
{
    public float Beat;
    public float HoldBeats;
    public float _0x49c18b46
    {
        get
        {
            return this.Beat + this.HoldBeats;
        }
    }

    public int GemIndex;
}

/// A whole call-and-response phrase, plus the seed that produced it so a run can
/// be reproduced from a log line.
public sealed class _0x242ac267
{
    public bool FromFallback;
    public int _0xd40d1e7f
    {
        get
        {
            return this.Notes == null ? 0 : this.Notes.Length;
        }
    }

    public int Seed;
    public _0x2758e0ed[] Notes;
    /// How many gems this phrase uses. Shown on the track card so the player can
    /// see one track is denser than another before choosing it.
    public int _0x94108a00()
    {
        int _0x7ab16e04 = 0;
        int _0x2a75abd4 = 0;
        for (int _0x775d2900 = 0; _0x775d2900 < this._0xd40d1e7f; _0x775d2900++)
        {
            int bit = 1 << Mathf.Clamp(this.Notes[_0x775d2900].GemIndex, 0, 4);
            if ((_0x7ab16e04 & bit) == 0)
            {
                _0x7ab16e04 |= bit;
                _0x2a75abd4++;
            }
        }

        return _0x2a75abd4;
    }

    public _0x2758e0ed _0xb69d08a8(int _0xc88e7cb0)
    {
        if (this.Notes == null || _0xc88e7cb0 < 0 || _0xc88e7cb0 >= this.Notes.Length)
        {
            return null;
        }

        return this.Notes[_0xc88e7cb0];
    }
}