using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPictureSearchFuncButton : MusicSearchButton
{
    protected override void Start()
    {
        base.Start();
        this.searchMode = SearchMode.MusicPicture;
    }

    protected override void OnClickButton()
    {
        base.OnClickButton();
    }

}
