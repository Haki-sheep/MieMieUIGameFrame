using UnityEngine;
using MieMieFrameWork;
using MieMieFrameWork.UI;

public class GameStart : MonoBehaviour
{
     void Awake(){
        DontDestroyOnLoad(this.gameObject);
     }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    async void Start()
    {
        await AddressableMgr.Init();
        UICoreMgr.Instance.Init();
        UICoreMgr.Instance.ShowWindow<MainPanel>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
