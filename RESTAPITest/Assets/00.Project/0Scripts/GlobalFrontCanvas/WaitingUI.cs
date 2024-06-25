using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingUI : MonoBehaviour
{
    private bool isWaiting = false;
    private bool isCompleate = false;

    private GameObject loadingObj = null;       // 로딩중에는 Rotation이 매프레임마다 참조되기에 캐싱해둠    


    private void Awake()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);

        loadingObj = this.transform.GetChild(0).GetChild(1).gameObject;        
    }

    private void OnEnable()
    {
        this.transform.parent.GetComponent<GlobalFrontCanvas>().StartLoadingEvent += StartWaiting;
        this.transform.parent.GetComponent<GlobalFrontCanvas>().EndLoadingEvent += EndWaiting;
    }

    private void OnDisable()
    {
        this.transform.parent.GetComponent<GlobalFrontCanvas>().StartLoadingEvent -= StartWaiting;
        this.transform.parent.GetComponent<GlobalFrontCanvas>().EndLoadingEvent -= EndWaiting;
    }


    private void StartWaiting()
    {
        if (isWaiting == false)
        {
            this.transform.GetChild(0).gameObject.SetActive(true);
            this.isCompleate = false;
            StartCoroutine(RollingImage());
        }
        else
        {
            return;
        }
    }       // StartWaiting()

    private void EndWaiting()
    {
        StopCoroutine(RollingImage());        
        this.isCompleate = true;
        this.isWaiting = false;
        this.transform.GetChild(0).gameObject.SetActive(false);
    }

    private IEnumerator RollingImage()
    {
        this.isWaiting = true;
        float rotationZ = default;
        while (isCompleate == false)
        {
            //DE.Log($"While진입 , {rotationZ}");
            rotationZ = rotationZ - (Time.deltaTime * 100);
            loadingObj.transform.rotation = Quaternion.Euler(0, 0, rotationZ);
            yield return null;
        }
    }       // RollingImage()

}       // ClassEnd
