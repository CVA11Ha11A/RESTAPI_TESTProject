using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSearchDynamicRoot : MonoBehaviour
{   
    public ChangeMetaDataUI TryGetChangeMetaDataUI()
    {
        if(this.transform.GetChild(2).GetComponent<ChangeMetaDataUI>())
        {
            return this.transform.GetChild(2).GetComponent<ChangeMetaDataUI>();
        }
        else
        {
            return null;
        }
    }   // TryGetChangeMetaDataUI()

    public SearchKeywordUI TryGetSearchKeywordUI()
    {
        if (this.transform.GetChild(2).GetChild(6).GetComponent<SearchKeywordUI>())
        {
            return this.transform.GetChild(2).GetChild(6).GetComponent<SearchKeywordUI>();
        }
        else
        {
            return null;
        }
    }   // TryGetSearchKeywordUI()

}   // ClassEnd
