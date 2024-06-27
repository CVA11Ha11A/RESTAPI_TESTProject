using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchCancelButton : MonoBehaviour
{
    private void Start()
    {
        this.transform.GetComponent<Button>().onClick.AddListener(OnClickButtonEvent);
    }

    private void OnClickButtonEvent()
    {
        if(this.transform.parent.GetComponent<SearchKeywordUI>())
        {
            this.transform.parent.GetComponent<SearchKeywordUI>().OffSearchKeywardUI();
        }
        else
        {
            DE.LogError($"취소버튼에서 Component를 가져오지 못했음");
        }
        
    }

}   // ClassEnd
