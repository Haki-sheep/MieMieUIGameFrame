/// <summary>
/// SettingPanel View层 - 自动生成，请勿手动修改
/// </summary>

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class SettingPanelGen : MonoBehaviour
{
    public Slider SliderBgmSlider { get; private set; }
    public Slider SliderSfxSlider { get; private set; }
    public Button BtnClose { get; private set; }

    private void Awake()
    {
        SliderBgmSlider = transform.Find("Main/Setting/Bgm/[Slider]BgmSlider").GetComponent<Slider>();
        SliderSfxSlider = transform.Find("Main/Setting/Sfx/[Slider]SfxSlider").GetComponent<Slider>();
        BtnClose = transform.Find("Main/[Btn]Close").GetComponent<Button>();
    }
}
