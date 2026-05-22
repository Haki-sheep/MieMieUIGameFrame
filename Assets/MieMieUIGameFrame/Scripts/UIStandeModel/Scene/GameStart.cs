using UnityEngine;
using UnityEngine.SceneManagement;
using MieMieFrameWork;
using MieMieFrameWork.UI;
using Cysharp.Threading.Tasks;

public class GameStart : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    async void Start()
    {
        await BootstrapAsync();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (UICoreMgr.Instance == null) return;
        UICoreMgr.Instance.Init();
        UICoreMgr.Instance.BindMainCameraStack();

        if (scene.name == "MainScene")
            UICoreMgr.Instance.ShowWindow<MainPanel>();
    }

    async UniTask BootstrapAsync()
    {
        await AddressableMgr.Init();

        if (UICoreMgr.Instance == null)
        {
            Debug.LogError("[GameStart] UICoreMgr 未就绪 请确认 UIRoot 上挂有 UICoreMgr");
            return;
        }

        UICoreMgr.Instance.Init();
        UICoreMgr.Instance.BindMainCameraStack();
        UICoreMgr.Instance.ShowWindow<MainPanel>();
    }
}
