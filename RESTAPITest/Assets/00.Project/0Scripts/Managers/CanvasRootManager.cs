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

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }
    void Start()
    {
        
    }
    
}
