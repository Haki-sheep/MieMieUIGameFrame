/// <summary>
/// MainPanel View层 - 自动生成，请勿手动修改
/// </summary>

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class MainPanelGen : MonoBehaviour
{
    public Button Btns { get; private set; }
    public Button BtnStart { get; private set; }
    public Button BtnContinue { get; private set; }
    public Button BtnSetting { get; private set; }

    private void Awake()
    {
        Btns = GetComponent<Button>();
        BtnStart = transform.Find("Btns/[Btn]Start").GetComponent<Button>();
        BtnContinue = transform.Find("Btns/[Btn]Continue").GetComponent<Button>();
        BtnSetting = transform.Find("Btns/[Btn]Setting").GetComponent<Button>();
    }
}
