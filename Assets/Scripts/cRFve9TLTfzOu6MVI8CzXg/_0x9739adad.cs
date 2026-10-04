using UnityEngine;

/// One track of the show. A phrase is a fixed number of beats split into five
/// phases, and the beat length comes from the tempo, so the whole run length is
/// arithmetic rather than a guess.
public sealed class _0x9739adad
{
    public float _0x7ac219a1
    {
        get
        {
            return 60f / Mathf.Max(1, this.Bpm);
        }
    }

    public int GapBeats;
    public int CallBeats;
    public float _0x707c57a0
    {
        get
        {
            return this._0x5a8114f9 * this._0x7ac219a1;
        }
    }

    public int EchoBeats;
    public int Phrases;
    public int LeadInBeats;
    public string Title;
    public int Bpm;
    public int ResolveBeats;
    public int _0x5a8114f9
    {
        get
        {
            return this.LeadInBeats + this.CallBeats + this.GapBeats + this.EchoBeats + this.ResolveBeats;
        }
    }
}

/// The three tracks, and the timing rules shared by all of them.
///
/// The beats per phrase differ per tempo ON PURPOSE: a phrase must never be
/// shorter than 12.5 seconds, because a run that nobody plays has to survive the
/// review capture window. With the count-in, five missed phrases in a row land at
/// 65.0 s (96 BPM), 67.1 s (84 BPM) and 66.4 s (112 BPM) - every one of them past
/// the 60 s floor, and past the last gameplay frame the capture takes.
public static class _0x81d63b54
{
    public const float MeterPhrasePerfectBonus = 3f;
    /// Half the notes of a phrase missed means the phrase itself was missed.
    public const float PhraseMissFraction = 0.5f;
    /// The accuracy an encore is worth. Below it the show closes, however far the
    /// player got.
    public const int PassAccuracy = 85;
    public const float MeterGoodGain = 1.1f;
    public const float MeterPerfectGain = 1.6f;
    public const float MeterDrainPerSecond = 0.85f;
    public const float MeterMax = 100f;
    public static _0x9739adad Track(int _0x3b8139cd)
    {
        int _0xa93b1ea6 = Mathf.Clamp(_0x3b8139cd, 0, TrackCount - 1);
        _0x9739adad _0x4d509e9f = new _0x9739adad();
        _0x4d509e9f.LeadInBeats = 2;
        _0x4d509e9f.GapBeats = 2;
        _0x4d509e9f.ResolveBeats = 4;
        if (_0xa93b1ea6 == 0)
        {
            _0x4d509e9f.Title = _0x23ba7fe1._0x20431bcd(new byte[11] { 117, 106, 127, 116, 115, 116, 125, 26, 123, 121, 110 }, 58);
            _0x4d509e9f.Bpm = 96;
            _0x4d509e9f.CallBeats = 6;
            _0x4d509e9f.EchoBeats = 6;
            _0x4d509e9f.Phrases = 12;
            return _0x4d509e9f;
        }

        if (_0xa93b1ea6 == 1)
        {
            _0x4d509e9f.Title = _0x23ba7fe1._0x20431bcd(new byte[12] { 34, 49, 56, 34, 49, 32, 84, 35, 53, 56, 32, 46 }, 116);
            _0x4d509e9f.Bpm = 84;
            _0x4d509e9f.CallBeats = 5;
            _0x4d509e9f.EchoBeats = 5;
            _0x4d509e9f.Phrases = 10;
            return _0x4d509e9f;
        }

        _0x4d509e9f.Title = _0x23ba7fe1._0x20431bcd(new byte[12] { 25, 8, 21, 13, 20, 122, 28, 19, 20, 27, 22, 31 }, 90);
        _0x4d509e9f.Bpm = 112;
        _0x4d509e9f.CallBeats = 8;
        _0x4d509e9f.EchoBeats = 8;
        _0x4d509e9f.Phrases = 16;
        return _0x4d509e9f;
    }

    /// Rank thresholds, and the wording used for each of them on the result card.
    public static string RankFor(int _0x89128881)
    {
        if (_0x89128881 >= 97)
        {
            return _0x23ba7fe1._0x20431bcd(new byte[1] { 224 }, 179);
        }

        if (_0x89128881 >= 92)
        {
            return _0x23ba7fe1._0x20431bcd(new byte[1] { 226 }, 163);
        }

        if (_0x89128881 >= PassAccuracy)
        {
            return _0x23ba7fe1._0x20431bcd(new byte[1] { 234 }, 168);
        }

        return _0x23ba7fe1._0x20431bcd(new byte[1] { 180 }, 247);
    }

    public const int TrackCount = 3;
    public const int StreakBonusFrom = 8;
    /// A run ends when this many phrases in a row have been let through.
    public const int MissedPhraseLimit = 5;
    public const float GoodWindow = 0.22f;
    public const int CountInBeats = 4;
    public const float OkWindow = 0.33f;
    public const float PerfectWindow = 0.11f;
    public const float MeterMissedPhrasePenalty = 6f;
    public const float MeterOkGain = 0.6f;
    public const float MeterStreakBonus = 2f;
}

internal static class _0x23ba7fe1
{
    internal static string _0x20431bcd(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}