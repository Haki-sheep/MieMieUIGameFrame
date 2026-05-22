/// <summary>
/// PlayerPanel View层 - 自动生成，请勿手动修改
/// </summary>

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class PlayerPanelGen : MonoBehaviour
{
    public Button BtnPauseBtn { get; private set; }
    public TextMeshProUGUI TmpGoldNumber { get; private set; }

    private void Awake()
    {
        BtnPauseBtn = GetComponentInChildren<Button>();
        TmpGoldNumber = transform.Find("GoldCoin/[Tmp]GoldNumber").GetComponent<TextMeshProUGUI>();
    }
}
