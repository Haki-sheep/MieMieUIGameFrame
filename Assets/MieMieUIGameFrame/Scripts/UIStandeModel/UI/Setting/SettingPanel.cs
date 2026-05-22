/// <summary>
/// SettingPanel Logic层 - 用户编写
/// </summary>

using MieMieFrameWork;
using MieMieFrameWork.UI;
using UnityEngine;
using UnityEngine.UI;

internal class SettingPanel : UIWindowBase
{
    internal SettingPanelGen View { get; private set; }

    internal protected override void OnAwake()
    {
        base.OnAwake();
        View = UIContent.GetComponent<SettingPanelGen>();

        View.BtnClose.onClick.AddListener(OnBtnCloseBtnClick);
        View.SliderBgmSlider.onValueChanged.AddListener(OnBtnBgmSliderValueChanged);
        View.SliderSfxSlider.onValueChanged.AddListener(OnBtnSfxSliderValueChanged);
    }

    internal protected override void OnShow()
    {
        base.OnShow();
    }

    internal protected override void OnHide()
    {
        base.OnHide();
    }

    internal protected override void OnDestroy()
    {
        base.OnDestroy();
    }

    private void OnBtnCloseBtnClick()
    {
        UICoreMgr.Instance.HideWindow<SettingPanel>();
    }

    private void OnBtnBgmSliderValueChanged(float value)
    {
        // TODO: 更新背景音乐音量
        Debug.Log("背景音乐音量: " + value);
    }
    private void OnBtnSfxSliderValueChanged(float value)
    {
        // TODO: 更新音效音量
        Debug.Log("音效音量: " + value);
    }

}
