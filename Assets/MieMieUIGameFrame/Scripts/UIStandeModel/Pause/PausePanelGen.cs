/// <summary>
/// PausePanel View层 - 自动生成，请勿手动修改
/// </summary>

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class PausePanelGen : MonoBehaviour
{
    public Button Btns { get; private set; }
    public Button BtnContinue { get; private set; }
    public Button BtnRePlay { get; private set; }
    public Button BtnExit { get; private set; }
    public Button BtnClose { get; private set; }

    private void Awake()
    {
        Btns = transform.Find("Main/Btns").GetComponent<Button>();
        BtnContinue = transform.Find("Main/Btns/[Btn]Continue").GetComponent<Button>();
        BtnRePlay = transform.Find("Main/Btns/[Btn]RePlay").GetComponent<Button>();
        BtnExit = transform.Find("Main/Btns/[Btn]Exit").GetComponent<Button>();
        BtnClose = transform.Find("Main/[Btn]Close").GetComponent<Button>();
    }
}
