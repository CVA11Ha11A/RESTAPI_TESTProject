using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalFrontCanvas : MonoBehaviour
{
    public event Action StartLoadingEvent;   // 로딩시작 이벤트
    public event Action EndLoadingEvent;    // 로딩 끝 이벤트
    private MusicSerch serchSystem = null;  // 음악 찾기 위한 Class
    private void Awake()
    {
        CanvasRootManager.Instance.frontCanvas = this;
        
    }

    private void Start()
    {
        serchSystem = new MusicSerch();
    }




    public void InvokeStartLoadingEvent()
    {
        StartLoadingEvent?.Invoke();
    }

    public void InvokeEndLoadingEvent()
    {
        EndLoadingEvent?.Invoke();
    }

}       // ClassEnd