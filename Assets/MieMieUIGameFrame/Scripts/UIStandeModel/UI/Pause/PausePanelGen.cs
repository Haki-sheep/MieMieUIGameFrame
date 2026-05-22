/// <summary>
/// PausePanel View层 - 自动生成，请勿手动修改
/// </summary>

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class PausePanelGen : MonoBehaviour
{
    public Button BtnContinue { get; private set; }
    public Button BtnSetting { get; private set; }
    public Button BtnReturnMainPanel { get; private set; }

    private void Awake()
    {
        BtnContinue = transform.Find("Main/FatherButtons/[Btn]Continue").GetComponent<Button>();
        BtnSetting = transform.Find("Main/FatherButtons/[Btn]Setting").GetComponent<Button>();
        BtnReturnMainPanel = transform.Find("Main/FatherButtons/[Btn]ReturnMainPanel").GetComponent<Button>();
    }
}
