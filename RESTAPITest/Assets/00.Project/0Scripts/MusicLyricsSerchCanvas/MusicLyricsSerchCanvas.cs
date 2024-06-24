using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLyricsSerchCanvas : MonoBehaviour
{
    private Vector3 originPos = default;

    private void Awake()
    {
        this.originPos = this.transform.position;
        CanvasRootManager.Instance.musicLyricsRoot = this;
    }

    void Start()
    {
        
    }


    public void OnMusicLyricsSerchCanvas()
    {
        this.transform.position = new Vector3(0, originPos.y, originPos.z);     // 중앙 위치로 이동
    }
    public void OffMusicLyricsSerchCanvas()
    {
        this.transform.position = originPos;
    }


}       // ClassEnd
