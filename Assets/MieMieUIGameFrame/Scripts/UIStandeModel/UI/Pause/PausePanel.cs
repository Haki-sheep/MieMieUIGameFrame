/// <summary>
/// PausePanel Logic层 - 用户编写
/// </summary>

using MieMieFrameWork;
using MieMieFrameWork.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

internal class PausePanel : UIWindowBase
{
    internal PausePanelGen View { get; private set; }

    internal protected override void OnAwake()
    {
        base.OnAwake();
        View = UIContent.GetComponent<PausePanelGen>();

        View.BtnContinue.onClick.AddListener(OnBtnContinueBtnClick);
        View.BtnSetting.onClick.AddListener(OnBtnSettingBtnClick);
        View.BtnReturnMainPanel.onClick.AddListener(OnBtnExitGameBtnClick);
    }

    internal protected override void OnShow()
    {
        base.OnShow();
        Time.timeScale = 0;
    }

    internal protected override void OnHide()
    {
        base.OnHide();
        Time.timeScale = 1;
    }

    internal protected override void OnDestroy()
    {
        base.OnDestroy();
    }

    private void OnBtnContinueBtnClick()
    {
        UICoreMgr.Instance.HideWindow<PausePanel>();
    }
    private void OnBtnSettingBtnClick()
    {
        UICoreMgr.Instance.ShowWindow<SettingPanel>();
    }
    private void OnBtnExitGameBtnClick()
    {
        SceneManager.LoadScene("MainScene");
        UICoreMgr.Instance.ShowWindow<MainPanel>();
        UICoreMgr.Instance.HideWindow<PausePanel>();
    }



}
