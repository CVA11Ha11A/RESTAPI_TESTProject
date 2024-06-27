using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TagLib;
using TMPro;
using UnityEngine.UI;

public class FindMusicData : MonoBehaviour
{
    private string fileDirectory = null;
    private string fileName = null;


    private void Start()
    {
        Button button = this.transform.GetComponent<Button>();
        button.onClick.AddListener(MusicObjOnClickEvent);
    }

    private void MusicObjOnClickEvent()
    {
        Transform target = MakingManager.GetTopParentTransform(this.transform);
        if(target.GetChild(2).GetComponent<ChangeMetaDataUI>())
        {
            target.GetChild(2).GetComponent<ChangeMetaDataUI>().OutPutMetaDataUI(this.fileDirectory);
        }
        else
        {
            DE.LogError($"ChangeMetaDataUI를 찾지 못했음");
        }
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
