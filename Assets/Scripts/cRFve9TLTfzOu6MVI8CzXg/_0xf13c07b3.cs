using UnityEngine;

/// The five phases one phrase moves through. LeadIn counts the player in, Call is
/// the show speaking, Gap is the hand-over, Echo is the player's window and
/// Resolve is where the phrase is scored.
public enum _0x6640e3cb
{
    CountIn,
    LeadIn,
    Calling,
    Handover,
    Echoing,
    Resolving,
}

/// Keeps the beat for the run. There is no audio in this game, so the clock is
/// the single source of truth for tempo: the ring, the footlight, the beat dots
/// and every hit window are all read off the numbers here, which means they can
/// never drift apart from each other.
public sealed class _0xf13c07b3
{
    /// Absolute time at which the given phrase opens its echo window. Every hit is
    /// judged against this plus the note's own beat offset.
    public float _0x7eb2e7e2(int _0x32c9265b)
    {
        if (this._0x7aa69292 == null)
        {
            return 0f;
        }

        float _0x66daa6fb = this._0x19ac4704 + (_0x32c9265b * this._0x7aa69292._0x707c57a0);
        int _0x8fa27b82 = this._0x7aa69292.LeadInBeats + this._0x7aa69292.CallBeats + this._0x7aa69292.GapBeats;
        return _0x66daa6fb + (_0x8fa27b82 * this._0xe0ba1140);
    }

    /// Which phrase the clock is inside, counting from zero once the count-in is
    /// over. Negative while the count-in runs.
    public int _0xa7b7e9bd
    {
        get
        {
            if (this._0x7aa69292 == null || this._0x80216391 < this._0x19ac4704)
            {
                return -1;
            }

            return Mathf.FloorToInt((this._0x80216391 - this._0x19ac4704) / this._0x7aa69292._0x707c57a0);
        }
    }

    /// Where in the bar of four the current beat sits. Drives the four counter
    /// dots in the HUD, and tells the footlight when to flash gold.
    public int _0x9bba6874
    {
        get
        {
            return ((this._0xdc550bd0 % 4) + 4) % 4;
        }
    }

    private int _0xdc550bd0;
    public float _0x19ac4704
    {
        get
        {
            return _0x81d63b54.CountInBeats * this._0xe0ba1140;
        }
    }

    public void _0xb2637c29(_0x9739adad _0x20d0bed2)
    {
        this._0x7aa69292 = _0x20d0bed2;
        this._0x80216391 = 0f;
        this._0xdc550bd0 = 0;
    }

    private _0x9739adad _0x7aa69292;
    /// Advances the clock and reports how many whole beats have just elapsed.
    /// Returning a count rather than a flag means a long frame cannot swallow one.
    public int _0x3dd05b3c(float delta)
    {
        this._0x80216391 += delta;
        int _0x89f5a203 = Mathf.FloorToInt(this._0x80216391 / Mathf.Max(0.0001f, this._0xe0ba1140));
        int _0xe486f6ac = _0x89f5a203 - this._0xdc550bd0;
        if (_0xe486f6ac > 0)
        {
            this._0xdc550bd0 = _0x89f5a203;
        }

        return Mathf.Max(0, _0xe486f6ac);
    }

    public float _0xe0ba1140
    {
        get
        {
            return this._0x7aa69292 == null ? 0.5f : this._0x7aa69292._0x7ac219a1;
        }
    }

    /// Absolute time at which the given phrase starts calling its notes out.
    public float _0x35e95df8(int _0xdb06184f)
    {
        if (this._0x7aa69292 == null)
        {
            return 0f;
        }

        float _0x4430ba1a = this._0x19ac4704 + (_0xdb06184f * this._0x7aa69292._0x707c57a0);
        return _0x4430ba1a + (this._0x7aa69292.LeadInBeats * this._0xe0ba1140);
    }

    /// Position inside the current phrase, measured in beats.
    public float _0x5a385924
    {
        get
        {
            if (this._0x7aa69292 == null || this._0x80216391 < this._0x19ac4704)
            {
                return this._0x80216391 / this._0xe0ba1140;
            }

            float _0xcb3b3579 = (this._0x80216391 - this._0x19ac4704) % this._0x7aa69292._0x707c57a0;
            return _0xcb3b3579 / this._0xe0ba1140;
        }
    }

    public _0x6640e3cb _0x88ba590c
    {
        get
        {
            if (this._0x7aa69292 == null || this._0x80216391 < this._0x19ac4704)
            {
                return _0x6640e3cb.CountIn;
            }

            float _0x83fa2574 = this._0x5a385924;
            float _0x562c831b = this._0x7aa69292.LeadInBeats;
            float _0x84cae772 = _0x562c831b + this._0x7aa69292.CallBeats;
            float _0x624ad47c = _0x84cae772 + this._0x7aa69292.GapBeats;
            float _0xbf60cfb1 = _0x624ad47c + this._0x7aa69292.EchoBeats;
            if (_0x83fa2574 < _0x562c831b)
            {
                return _0x6640e3cb.LeadIn;
            }

            if (_0x83fa2574 < _0x84cae772)
            {
                return _0x6640e3cb.Calling;
            }

            if (_0x83fa2574 < _0x624ad47c)
            {
                return _0x6640e3cb.Handover;
            }

            if (_0x83fa2574 < _0xbf60cfb1)
            {
                return _0x6640e3cb.Echoing;
            }

            return _0x6640e3cb.Resolving;
        }
    }

    public float _0x9f687af7
    {
        get
        {
            return this._0x80216391;
        }
    }

    private float _0x80216391;
    public int _0x66e1a32b
    {
        get
        {
            return this._0xdc550bd0;
        }
    }
}