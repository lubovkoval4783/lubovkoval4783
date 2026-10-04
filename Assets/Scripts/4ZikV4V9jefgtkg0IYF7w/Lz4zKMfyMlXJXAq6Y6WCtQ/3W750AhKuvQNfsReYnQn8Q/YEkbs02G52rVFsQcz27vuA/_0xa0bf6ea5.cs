using UnityEngine;
using UnityEngine.UI;

public class _0xa0bf6ea5 : MonoBehaviour
{
    public int NextTutorialPanelIndex;
    public int EndTutorialPanelIndex = 1;
    public Button TutorialEndButton;
    public Button NextTutorialButton;
    public bool IsTutorialEndPanel;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xb67d6cae.Instance._0xc4f3524a(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xe83c15f0.Instance._0x67fa7bf6());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xb67d6cae.Instance._0xc4f3524a(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0xb67d6cae.Instance._0xc4f3524a(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xe83c15f0.Instance._0x67fa7bf6());
        }
    }
}