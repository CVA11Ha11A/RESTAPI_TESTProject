using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MusicSearchButton : SearchButton
{
    protected override void Awake()
    {
        base.Awake();
    }
    protected override void Start()
    {
        base.Start();
    }

    protected override void OnClickButton()
    {        
        MusicSearchDynamicRoot roots = MakingManager.GetTopParentTransform(this.transform).GetComponent<MusicSearchDynamicRoot>();
        //DE.Log($"Null? : {roots.TryGetSearchKeywordUI() == null}");
        roots.TryGetSearchKeywordUI().OnSearchKeyWardUI(this.searchMode);
    }

}       // ClassEnd
