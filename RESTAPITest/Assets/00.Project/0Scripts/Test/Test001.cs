using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Diagnostics;
using UnityEngine.Rendering;

public class Test001 : MonoBehaviour
{
    [SerializeField] private bool isInputTest;
    [SerializeField] private bool isTest1;
    [SerializeField] private bool isTest2;
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


        Stopwatch sw = new Stopwatch();
        sw.Start();

        List<string> filePaths = new List<string>();
        string[] drives = Environment.GetLogicalDrives();

        foreach (string drive in drives)
        {
            if (Directory.Exists(drive))
            {
                try
                {
                    GetFilesRecursive(drive, "*.mp3", filePaths);
                }
                catch (UnauthorizedAccessException e)
                {
                    DE.Log($"Access denied to {drive}: {e.Message}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error accessing {drive}: {e.Message}");
                }
            }
        }
        sw.Stop();

        // 파일 경로를 출력합니다.
        foreach (string filePath in filePaths)
        {
            DE.Log(filePath);
        }
        DE.Log($"경과시간 : {sw.ElapsedMilliseconds}");


    }       // Test0001
    private void Test0002()
    {
        if (isTest2 == false) { return; }

        List<string> filePaths = new List<string>();        


    }


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


    static void GetFilesRecursive(string path, string searchPattern, List<string> filePaths)
    {
        try
        {
            filePaths.AddRange(Directory.GetFiles(path, searchPattern));
            foreach (string directory in Directory.GetDirectories(path))
            {
                GetFilesRecursive(directory, searchPattern, filePaths);
            }
        }
        catch (UnauthorizedAccessException e)
        {
            DE.Log($"Access denied to {path}: {e.Message}");
        }
        catch (Exception e)
        {
            DE.Log($"Error accessing {path}: {e.Message}");
        }
    }
}       // ClassEnd
