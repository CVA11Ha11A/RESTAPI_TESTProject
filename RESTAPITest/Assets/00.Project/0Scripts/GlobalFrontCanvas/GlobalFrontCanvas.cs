using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalFrontCanvas : MonoBehaviour
{
    public event Action StartLoadingEvent;   // 로딩시작 이벤트
    public event Action EndLoadingEvent;    // 로딩 끝 이벤트
   
    private void Awake()
    {
        CanvasRootManager.Instance.frontCanvas = this;
        
    }

    private void Start()
    {        
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
