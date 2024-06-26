using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TagLib;
using TMPro;

public class FindMusicData : MonoBehaviour
{
    private string fileDirectory = null;
    private string fileName = null;


    private void Start()
    {

    }

    private void OnEnable()
    {
         // TODO : 음악 선택이후 수정할창을 띄워주는 기능 이벤트 구독 (음악 가사 본격적으로 찾는 UI)
    }
    private void OnDisable()
    {
        
    }

    

    public void SetterFileDirectory(string directory_)
    {
        this.fileDirectory = directory_;
        DE.Log($"디렉토리 Setter : {this.fileDirectory}");
    }       // SetterFileDirectory()

    public void SetterFileName(string fileName_) 
    {
        this.fileName = fileName_;
        TryUpdateFileName();
        DE.Log($"파일이름 Setter : {this.fileName}");
    }

    public void FirstSetter(string directory_,string fileName_)
    {
        this.fileDirectory = directory_;
        this.fileName = fileName_;
        TryUpdateFileName();
        DE.Log($"파일이름 Setter : {this.fileName}\n경로 : {this.fileDirectory}");
    }

    private void TryUpdateFileName()
    {
        if(this.transform.GetChild(1).GetComponent<TextMeshProUGUI>())
        {
            this.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = this.fileName;
        }

    }       // TryUpdateFileName()

}       // ClassEnd
