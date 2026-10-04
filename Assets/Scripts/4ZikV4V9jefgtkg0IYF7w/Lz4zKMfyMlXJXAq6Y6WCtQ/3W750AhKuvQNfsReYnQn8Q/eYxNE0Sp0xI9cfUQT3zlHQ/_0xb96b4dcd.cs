using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xb96b4dcd : MonoBehaviour
{
    public int LoadSceneId;
    public bool IsLoadCurrentScene;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xe83c15f0.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xe83c15f0.Instance.LoadSceneByIndex(this.LoadSceneId));
    }
}