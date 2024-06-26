using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Android;

public class MusicSearch : MonoBehaviour
{
    private List<string> musicExtension = null;     // 찾을 확장자
    private List<string> findDirectory = null;      // 찾을 폴더목록
    private List<string> searchFileList = null;      // 찾은 파일경로 ! 찾고 이벤트 실행이후 목록을 생성한후 Clear되는 객체
    public List<string> SerchFileList
    {
        get
        {
            return this.searchFileList;
        }
    }

    private void Start()
    {
        findDirectory = new List<string>();
        musicExtension = new List<string>();
        searchFileList = new List<string>(500);
        musicExtension.Add("*.mp3");
        musicExtension.Add("*.wav");
        AddToSerchDirectory();
    }

    private void OnEnable()
    {
        this.transform.GetComponent<MusicLyricsSerchCanvas>().MusicFindStartEvent += SerchMusicFileDirectorys;        
    }

    private void OnDisable()
    {
        this.transform.GetComponent<MusicLyricsSerchCanvas>().MusicFindStartEvent -= SerchMusicFileDirectorys;        
    }

    private void AddToSerchDirectory()
    {

#if UNITY_ANDROID
        // 안드로이드용

        findDirectory.Add("\\storage\\emulated\\0\\Download");
        findDirectory.Add("\\storage\\emulated\\0\\NAVER MYBOX");
        findDirectory.Add("\\storage\\emulated\\0\\mp3");
#elif UNITY_STANDALONE_WIN
        // Window용 

        findDirectory.Add("E:\\zChrome Down");
        findDirectory.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
#endif
    }       // AddToSerchDirectory()

    private void SerchMusicFileDirectorys()
    {
        StartCoroutine(CSerchMusicFileDirectorys());
    }

    private IEnumerator CSerchMusicFileDirectorys()
    {        
        foreach (string directory in findDirectory)
        {
            if (Directory.Exists(directory))
            {
                try
                {
                    for (int i = 0; i < musicExtension.Count; i++)
                    {   // for : 지정한 확장자가 다중일 경우를 위한 반복문
                        searchFileList.AddRange(Directory.GetFiles(directory, musicExtension[i]));
                        //searchFileList.AddRange(Directory.GetFiles(directory, musicExtension[i], SearchOption.AllDirectories));
                    }

                }
                catch (UnauthorizedAccessException e)
                {
                    DE.Log($"Access denied to {directory}: {e.Message}");
                }
                catch (Exception e)
                {
                    DE.Log($"Error accessing {directory}: {e.Message}");
                }
                yield return null;
            }

        }       // foreach

#if UNITY_EDITOR
        DE.Log($"찾은 음악파일 출력\n현재 찾은것 갯수 : {SerchFileList.Count}");
        foreach (string directory in SerchFileList)
        {
            DE.Log($"{directory}");
        }
#endif 

        this.transform.GetComponent<MusicLyricsSerchCanvas>().InvokeMusicFindEndEvent(searchFileList);
        
    }       // CSerchStart()



}       // ClassEnd
