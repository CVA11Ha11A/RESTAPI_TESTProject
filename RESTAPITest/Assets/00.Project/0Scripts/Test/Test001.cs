using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Diagnostics;
using UnityEngine.Rendering;
using TagLib;
using TagLib.Id3v2;
using File = TagLib.File;
using TMPro;
//using Tag = TagLib.Id3v2.Tag;

public class Test001 : MonoBehaviour
{
    [SerializeField] private bool isInputTest;
    [SerializeField] private bool isTest1;
    [SerializeField] private bool isTest2;
    
    Vector3 originPos;
    // Start is called before the first frame update
    void Start()
    {
        Test0001();
        Test0002();
    }

    // Update is called once per frame
    void Update()
    {
        TestInput();
    }

    private void Test0001()
    {
        if (isTest1 == false) { return; }
        File file = File.Create("E:\\zChrome Down\\Crush (크러쉬) - 나빠 (NAPPA).mp3");
        TagLib.Tag musicMetaData = file.Tag;
        musicMetaData.Lyrics = "적용되나?";
        DE.Log($"Album : {musicMetaData.Album}\n Disc : {musicMetaData.Disc}" +
            $"\n Title : {musicMetaData.Title}\n AlbumArtists : {musicMetaData.AlbumArtists}");
        file.Save();
        file.Dispose();

        //musicMetaData.

    }       // Test0001
    private void Test0002()
    {
        if (isTest2 == false) { return; }

        

    }       // Test0002()


    public void TestInput()
    {
#if UNITY_EDITOR
        if (isInputTest)
        {
            // 테스트 진행할 함수 호출
            if (Input.GetKeyDown(KeyCode.Z))
            {
                CanvasRootManager.Instance.frontCanvas.InvokeStartLoadingEvent();
            }
            else if (Input.GetKeyDown(KeyCode.X))
            {
                CanvasRootManager.Instance.frontCanvas.InvokeEndLoadingEvent();
            }
        }
#endif
    }



}       // ClassEnd
