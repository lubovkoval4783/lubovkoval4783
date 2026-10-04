using UnityEngine;

/// What survives between runs: the chosen track, the records worth showing on the
/// menu, and the two switches the settings sheet owns. Keys are fixed strings of
/// this class's own choosing, never derived from a symbol name, so obfuscation
/// cannot silently move a player's progress.
public sealed class _0x2a2ce1f2
{
    private static readonly string BestStreakKey = _0x0506913a._0x2e3a896f(new byte[15] { 219, 219, 194, 159, 211, 212, 194, 197, 159, 194, 197, 195, 212, 208, 218 }, 177);
    private static readonly string BestAccuracyKey = _0x0506913a._0x2e3a896f(new byte[17] { 146, 146, 139, 214, 154, 157, 139, 140, 214, 153, 155, 155, 141, 138, 153, 155, 129 }, 248);
    public string _0x6f23dc24
    {
        get
        {
            return PlayerPrefs.GetString(BestRankKey, string.Empty);
        }

        set
        {
            PlayerPrefs.SetString(BestRankKey, value);
        }
    }

    /// Stardust is the score. It lives in the template's own purse so the menu
    /// readout and the result card cannot disagree about it - and it buys nothing,
    /// by design: there is no shop, no wager and no currency in this game.
    public int _0xe3cb90cf
    {
        get
        {
            return _0xc29566dc._0xbbab0871._0x1003ec82;
        }

        set
        {
            _0xc29566dc._0xbbab0871._0x1003ec82 = Mathf.Max(0, value);
        }
    }

    public int _0xdb9e8135
    {
        get
        {
            return PlayerPrefs.GetInt(BestStreakKey, 0);
        }

        set
        {
            PlayerPrefs.SetInt(BestStreakKey, Mathf.Max(0, value));
        }
    }

    public int _0x9b01f1d4
    {
        get
        {
            return PlayerPrefs.GetInt(EncoresKey, 0);
        }

        set
        {
            PlayerPrefs.SetInt(EncoresKey, Mathf.Max(0, value));
        }
    }

    public int _0x8420aa52
    {
        get
        {
            return PlayerPrefs.GetInt(BestAccuracyKey, 0);
        }

        set
        {
            PlayerPrefs.SetInt(BestAccuracyKey, Mathf.Max(0, value));
        }
    }

    private static readonly string HapticsKey = _0x0506913a._0x2e3a896f(new byte[11] { 85, 85, 76, 17, 87, 94, 79, 75, 86, 92, 76 }, 63);
    public bool _0xfbabe7f1
    {
        get
        {
            return PlayerPrefs.GetInt(HapticsKey, 1) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(HapticsKey, value ? 1 : 0);
        }
    }

    public int _0x263cd408
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(TrackKey, 0), 0, _0x81d63b54.TrackCount - 1);
        }

        set
        {
            PlayerPrefs.SetInt(TrackKey, Mathf.Clamp(value, 0, _0x81d63b54.TrackCount - 1));
        }
    }

    private static readonly string EncoresKey = _0x0506913a._0x2e3a896f(new byte[11] { 209, 209, 200, 149, 222, 213, 216, 212, 201, 222, 200 }, 187);
    public void _0x8d1701dc()
    {
        PlayerPrefs.DeleteKey(BestAccuracyKey);
        PlayerPrefs.DeleteKey(BestRankKey);
        PlayerPrefs.DeleteKey(BestStreakKey);
        PlayerPrefs.DeleteKey(EncoresKey);
        PlayerPrefs.DeleteKey(_0x0506913a._0x2e3a896f(new byte[11] { 96, 96, 121, 36, 107, 126, 126, 111, 103, 122, 126 }, 10));
        this._0x263cd408 = 0;
        this._0xe3cb90cf = 0;
        PlayerPrefs.Save();
    }

    public void _0x7cac5506(int _0x419565ba, string _0x5a4f2703, int _0xdf3540c3, bool _0xcbfb1c6e)
    {
        if (_0x419565ba > this._0x8420aa52)
        {
            this._0x8420aa52 = _0x419565ba;
            this._0x6f23dc24 = _0x5a4f2703;
        }

        if (_0xdf3540c3 > this._0xdb9e8135)
        {
            this._0xdb9e8135 = _0xdf3540c3;
        }

        if (_0xcbfb1c6e)
        {
            this._0x9b01f1d4 = this._0x9b01f1d4 + 1;
        }

        PlayerPrefs.Save();
    }

    public int _0xe97c4c90
    {
        get
        {
            return PlayerPrefs.GetInt(_0x0506913a._0x2e3a896f(new byte[11] { 28, 28, 5, 88, 23, 2, 2, 19, 27, 6, 2 }, 118), 0);
        }
    }

    private static readonly string TrackKey = _0x0506913a._0x2e3a896f(new byte[9] { 168, 168, 177, 236, 182, 176, 163, 161, 169 }, 194);
    /// How many times this attempt has been started. It seeds the generator, so
    /// the same track never lays out the same phrases twice in a row.
    public int _0x8dbbf0ca()
    {
        int _0x8f9ab880 = PlayerPrefs.GetInt(_0x0506913a._0x2e3a896f(new byte[11] { 73, 73, 80, 13, 66, 87, 87, 70, 78, 83, 87 }, 35), 0) + 1;
        PlayerPrefs.SetInt(_0x0506913a._0x2e3a896f(new byte[11] { 178, 178, 171, 246, 185, 172, 172, 189, 181, 168, 172 }, 216), _0x8f9ab880);
        return _0x8f9ab880;
    }

    private static readonly string BestRankKey = _0x0506913a._0x2e3a896f(new byte[13] { 115, 115, 106, 55, 123, 124, 106, 109, 55, 107, 120, 119, 114 }, 25);
}

internal static class _0x0506913a
{
    internal static string _0x2e3a896f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}