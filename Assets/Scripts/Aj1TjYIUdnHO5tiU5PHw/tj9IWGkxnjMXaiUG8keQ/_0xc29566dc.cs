using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xc29566dc
{
    public static class _0xbbab0871
    {
        public static int _0x1003ec82
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x3a282ffd._0x059b4484(new byte[5] { 52, 24, 30, 25, 4 }, 119)))
                    PlayerPrefs.SetInt(_0x3a282ffd._0x059b4484(new byte[5] { 74, 102, 96, 103, 122 }, 9), 0);
                return PlayerPrefs.GetInt(_0x3a282ffd._0x059b4484(new byte[5] { 79, 99, 101, 98, 127 }, 12));
            }

            set
            {
                PlayerPrefs.SetInt(_0x3a282ffd._0x059b4484(new byte[5] { 111, 67, 69, 66, 95 }, 44), value);
                _0xe83c15f0.Instance._0xf983954c();
            }
        }
    }

    public static class _0x4e12825d
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0xf58e677e
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x97b1c56c
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public class _0x58f55d4e
    {
        private static readonly _0x58f55d4e _0xb2101022 = new();
        public static readonly _0x58f55d4e[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xb2101022,
            _0xb2101022,
            _0xb2101022,
        };
        private int _0xcbec64f2 => 0;
        private int _0x080c64bf => 10;
        private string _0x2b6393ea => _0x3a282ffd._0x059b4484(new byte[4] { 249, 209, 218, 193 }, 180);
        private string _0xa5ba30e3 => _0x3a282ffd._0x059b4484(new byte[8] { 81, 88, 75, 88, 81, 102, 45, 96 }, 29);

        private int _0xcff01cec
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x3a282ffd._0x059b4484(new byte[25] { 97, 87, 80, 80, 71, 76, 86, 101, 78, 77, 64, 67, 78, 97, 74, 67, 82, 86, 71, 80, 107, 76, 70, 71, 90 }, 34)))
                    PlayerPrefs.SetInt(_0x3a282ffd._0x059b4484(new byte[25] { 205, 251, 252, 252, 235, 224, 250, 201, 226, 225, 236, 239, 226, 205, 230, 239, 254, 250, 235, 252, 199, 224, 234, 235, 246 }, 142), 0);
                return PlayerPrefs.GetInt(_0x3a282ffd._0x059b4484(new byte[25] { 45, 27, 28, 28, 11, 0, 26, 41, 2, 1, 12, 15, 2, 45, 6, 15, 30, 26, 11, 28, 39, 0, 10, 11, 22 }, 110));
            }

            set => PlayerPrefs.SetInt(_0x3a282ffd._0x059b4484(new byte[25] { 135, 177, 182, 182, 161, 170, 176, 131, 168, 171, 166, 165, 168, 135, 172, 165, 180, 176, 161, 182, 141, 170, 160, 161, 188 }, 196), value);
        }

        public int _0xbd571846
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x2b6393ea}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x2b6393ea}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x2b6393ea}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x2b6393ea}CurrentLevelIndex", value);
        }

        public int _0xfaacfd22
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x2b6393ea}BestScore"))
                    this._0xfaacfd22 = 0;
                return PlayerPrefs.GetInt($"{this._0x2b6393ea}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x2b6393ea}BestScore", value);
        }

        public bool _0x8eca3f99
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x2b6393ea}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x2b6393ea}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x2b6393ea}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x2b6393ea}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }
}

internal static class _0x3a282ffd
{
    internal static string _0x059b4484(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}