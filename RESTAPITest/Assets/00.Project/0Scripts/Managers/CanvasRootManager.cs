using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CanvasRootManager : MonoBehaviour
{
    private static CanvasRootManager instance = null;
    public static CanvasRootManager Instance
    {
        get
        {
            if(instance == null)
            {
                GameObject obj = new GameObject("CanvasRootManager");
                obj.AddComponent<CanvasRootManager>();
            }
            return instance;
        }
    }

    public MusicLyricsSerchCanvas musicLyricsRoot = null;
    public GlobalFrontCanvas frontCanvas = null;

    private void Awake()
    {
        if(instance == null)
        {
            //DE.Log($"RootManager 인스턴스 지정");
            instance = this;
        }
        else
        {
            //DE.Log($"RootManager 이미존재 자신 파괴");
            Destroy(gameObject);
        }
    }

    
}       // ClassEnd
