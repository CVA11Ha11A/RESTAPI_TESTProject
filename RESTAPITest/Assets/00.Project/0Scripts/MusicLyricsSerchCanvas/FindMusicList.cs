using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FindMusicList : MonoBehaviour
{
    [SerializeField]
    private GameObject objPrefab;
    private int nowCreateCount = 0;


    private void OnEnable()
    {
        this.transform.parent.GetComponent<MusicLyricsSerchCanvas>().MusicFindEndEvent += CreateFindMusicObj;
    }
    private void OnDisable()
    {
        this.transform.parent.GetComponent<MusicLyricsSerchCanvas>().MusicFindEndEvent -= CreateFindMusicObj;
    }

    private void CreateFindMusicObj(List<string> findList_)
    {
        Transform parentTrs = this.transform.GetChild(0).GetChild(0).transform;
        for (int i = 0; i < findList_.Count; i++)
        {
            GameObject obj = Instantiate(objPrefab, parentTrs);
            obj.AddComponent<FindMusicData>();

        }
    
    }
}       // ClassEnd
