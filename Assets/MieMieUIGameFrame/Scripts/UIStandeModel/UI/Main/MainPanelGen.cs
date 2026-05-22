/// <summary>
/// MainPanel View层 - 自动生成，请勿手动修改
/// </summary>

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class MainPanelGen : MonoBehaviour
{
    public Button BtnStart { get; private set; }
    public Button BtnContinue { get; private set; }
    public Button BtnSetting { get; private set; }
    public Button BtnExit { get; private set; }

    private void Awake()
    {
        BtnStart = transform.Find("FatherBtns/[Btn]Start").GetComponent<Button>();
        BtnContinue = transform.Find("FatherBtns/[Btn]Continue").GetComponent<Button>();
        BtnSetting = transform.Find("FatherBtns/[Btn]Setting").GetComponent<Button>();
        BtnExit = transform.Find("FatherBtns/[Btn]Exit").GetComponent<Button>();
    }
}
