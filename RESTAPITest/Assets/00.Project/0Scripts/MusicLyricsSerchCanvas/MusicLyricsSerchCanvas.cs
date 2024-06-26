using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MusicLyricsSerchCanvas : MonoBehaviour
{
    private Vector3 originPos = default;    

    // 음악찾기 시작 종료 이벤트
    public event Action MusicFindStartEvent;
    public event Action<List<string>> MusicFindEndEvent;


    private void Awake()
    {
        this.originPos = this.transform.position;
        CanvasRootManager.Instance.musicLyricsRoot = this;
        
    }

    void Start()
    {        
    }


    public void InvokeMusicFindStartEvent()
    {
        CanvasRootManager.Instance.frontCanvas.InvokeStartLoadingEvent();
        this.MusicFindStartEvent?.Invoke();
    }
    public void InvokeMusicFindEndEvent(List<string> findMusicList_)
    {
        this.MusicFindEndEvent?.Invoke(findMusicList_);       // TODO : 여기에 Output해줄 객체가 Output함수를 체이닝 해야함
        CanvasRootManager.Instance.frontCanvas.InvokeEndLoadingEvent();
    }


    public void OnMusicLyricsSerchCanvas()
    {
        this.transform.position = new Vector3(0, originPos.y, originPos.z);     // 중앙 위치로 이동
        InvokeMusicFindStartEvent();
    }
    public void OffMusicLyricsSerchCanvas()
    {
        this.transform.position = originPos;
    }


}       // ClassEnd
