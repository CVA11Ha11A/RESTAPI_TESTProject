using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using TagLib;
using System.IO;
using System.Text;

// OutPut예외에 사용될것임 On 상태에서 새로운 메타데이터를 호출할수 있는 경우를 방지하기 위함 2024.06.27
// UI들의 State를 설정함 UI의 움직임을 설정할때 State가 어떤것인지 보내주고 해당 State에 따라서 이동될 위치가 변경됨 2024.06.28
public enum UIState        
{
    On = 10000,
    Off = 20000
}

public class ChangeMetaDataUI : MonoBehaviour
{



    private TMP_InputField musicName = null;
    private TMP_InputField artistName = null;
    private TMP_InputField lyrics = null;
    private StringBuilder lastRefDirectory = null;

    private Vector3 offPos = default;
    private Vector3 onPos = default;
    private UIState state;


    private void Awake()
    {
        this.musicName = this.transform.GetChild(3).GetComponent<TMP_InputField>();
        this.artistName = this.transform.GetChild(4).GetComponent<TMP_InputField>();
        this.lyrics = this.transform.GetChild(5).GetComponent<TMP_InputField>();
        this.offPos = this.transform.localPosition;
        this.onPos = new Vector3(0f, 0f, this.transform.localPosition.z);
        this.lastRefDirectory = new StringBuilder(100);
        this.state = UIState.Off;

    }


    /// <summary>
    /// 메타데이터를 수정할 파일의 데이터를 출력
    /// </summary>
    /// <param name="targetDirectory_">수정할 파일의 경로</param>
    public void OutPutMetaDataUI(string targetDirectory_)
    {
        DE.Log($"TargetDirectory : {targetDirectory_}");
        if(this.state == UIState.Off)
        {
            this.transform.localPosition = onPos;

            using (TagLib.File targetFile = TagLib.File.Create(targetDirectory_))
            {
                Tag musicTag = targetFile.Tag;
                this.musicName.text = Path.GetFileNameWithoutExtension(targetDirectory_);
                this.artistName.text = musicTag.FirstPerformer;
                this.lyrics.text = musicTag.Lyrics;                
            }
        }
        else
        {
            DE.LogError($"이미 켜져있는데 또 요청이 들어옴");
            return;
        }
    }       // OutPutMetaDataUI()

    private void CloseUI()
    {
        // TODO : 화면 원위치, 수정된 정보 저장
    }

    public (string,string) GetMusicDatas()
    {
        return (this.musicName.text, this.artistName.text);
    }


}       // ClassEnd
