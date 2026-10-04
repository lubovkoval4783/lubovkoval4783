using UnityEngine;

public class _0xe797ba9c : MonoBehaviour
{
    private void _0xd68359af()
    {
    }

    public bool IsSkipSplashEnabled;
    public bool IsBestScoreEnabled;
    public static _0xe797ba9c Instance;
    public bool IsStoryEnabled;
    public bool IsOnlyWinGameEndEnabled;
    private void _0x8c6edf07()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsTutorialEnabled;
    public bool IsCheckScoreEnabled;
    public bool IsTimerEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsLevelSelectorEnabled;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xe797ba9c>();
            DontDestroyOnLoad(this.gameObject);
            this._0x8c6edf07();
        }
        else
        {
            this._0xd68359af();
            Destroy(this.gameObject);
        }
    }
}