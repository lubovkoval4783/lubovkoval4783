using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x590e74b5 : MonoBehaviour
{
    private void Awake()
    {
        this._0x33493925 = this.GetComponent<Camera>();
        _0x14b9086d = this;
        this._0xf6e0960c();
    }

    private Vector3 _0x6b14895c { get; set; }
    private Vector3 _0xf03813d5 { get; set; }
    private Vector3 _0x57ec61ac { get; set; }
    private Vector3 _0x2af17e12 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xa9eb8dfe;
        Matrix4x4 _0x848ac29d = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x33493925.orthographic)
        {
            float _0xad560695 = this._0x33493925.farClipPlane - this._0x33493925.nearClipPlane;
            float _0xbc715632 = (this._0x33493925.farClipPlane + this._0x33493925.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xbc715632), new Vector3(this._0x33493925.orthographicSize * 2 * this._0x33493925.aspect, this._0x33493925.orthographicSize * 2, _0xad560695));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x33493925.fieldOfView, this._0x33493925.farClipPlane, this._0x33493925.nearClipPlane, this._0x33493925.aspect);
        }

        Gizmos.matrix = _0x848ac29d;
    }

    private void _0xf6e0960c()
    {
        float _0xd8db708e, _0xacc29fd2, _0xbb2e3dec, _0xb040d2fe;
        if (this._0xe55b70cd == _0xda630059.Landscape)
            this._0x33493925.orthographicSize = 1f / this._0x33493925.aspect * this._0x3e6366e5 / 2f;
        else
            this._0x33493925.orthographicSize = this._0x3e6366e5 / 2f;
        this._0xb93aedb9 = 2f * this._0x33493925.orthographicSize;
        this._0x6a1481c9 = this._0xb93aedb9 * this._0x33493925.aspect;
        float _0x72121774 = this._0x33493925.transform.position.x;
        float _0xe4033a39 = this._0x33493925.transform.position.y;
        _0xd8db708e = _0x72121774 - this._0x6a1481c9 / 2;
        _0xacc29fd2 = _0x72121774 + this._0x6a1481c9 / 2;
        _0xbb2e3dec = _0xe4033a39 + this._0xb93aedb9 / 2;
        _0xb040d2fe = _0xe4033a39 - this._0xb93aedb9 / 2;
        this._0xb2974811 = new Vector3(_0xd8db708e, _0xb040d2fe, 0);
        this._0xf03813d5 = new Vector3(_0x72121774, _0xb040d2fe, 0);
        this._0x6b14895c = new Vector3(_0xacc29fd2, _0xb040d2fe, 0);
        this._0x841cbf27 = new Vector3(_0xd8db708e, _0xe4033a39, 0);
        this._0x50a59fe8 = new Vector3(_0x72121774, _0xe4033a39, 0);
        this._0x2af17e12 = new Vector3(_0xacc29fd2, _0xe4033a39, 0);
        this._0x57ec61ac = new Vector3(_0xd8db708e, _0xbb2e3dec, 0);
        this._0x67991dfa = new Vector3(_0x72121774, _0xbb2e3dec, 0);
        this._0x76eb2361 = new Vector3(_0xacc29fd2, _0xbb2e3dec, 0);
    }

    private new Camera _0x33493925;
    private Vector3 _0x67991dfa { get; set; }
    private Vector3 _0x50a59fe8 { get; set; }

    private Color _0xa9eb8dfe = Color.white;
    private float _0xb93aedb9 { get; set; }
    private Vector3 _0x841cbf27 { get; set; }

    private static _0x590e74b5 _0x14b9086d;
    //public bool executeInUpdate;
    private float _0x6a1481c9 { get; set; }

    private float _0x3e6366e5 = 1;
    public enum _0xda630059
    {
        Landscape,
        Portrait
    }

    private Vector3 _0xb2974811 { get; set; }
    private Vector3 _0x76eb2361 { get; set; }

    private _0xda630059 _0xe55b70cd = _0xda630059.Portrait;
}