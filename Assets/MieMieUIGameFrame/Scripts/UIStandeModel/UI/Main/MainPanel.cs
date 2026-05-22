/// <summary>
/// MainPanel Logic层 - 用户编写
/// </summary>

using MieMieFrameWork;
using MieMieFrameWork.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

internal class MainPanel : UIWindowBase
{
    internal MainPanelGen View { get; private set; }

    internal protected override void OnAwake()
    {
        base.OnAwake();
        View = UIContent.GetComponent<MainPanelGen>();

        UICoreMgr.Instance.BindMainCameraStack();

        View.BtnStart.onClick.AddListener(OnBtnStartClick);
        View.BtnContinue.onClick.AddListener(OnBtnContinueClick);
        View.BtnSetting.onClick.AddListener(OnBtnSettingClick);
        View.BtnExit.onClick.AddListener(OnBtnExitClick);
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

    private void OnBtnStartClick()
    {
        // 切换场景
        Debug.Log("切换场景");
        UICoreMgr.Instance.HideWindow<MainPanel>();
        SceneManager.LoadScene("Temp1");
        UICoreMgr.Instance.BindMainCameraStack();
        UICoreMgr.Instance.ShowWindow<PlayerPanel>();
    }

    private void OnBtnContinueClick()
    {
        // TODO: 继续游戏
    }

    private void OnBtnSettingClick()
    {
        UICoreMgr.Instance.ShowWindow<SettingPanel>();
    }

    private void OnBtnExitClick(){
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

}
