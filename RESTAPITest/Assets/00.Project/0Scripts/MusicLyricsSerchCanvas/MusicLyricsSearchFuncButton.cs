using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicLyricsSearchFuncButton : MusicSearchButton
{
    protected override void Start()
    {
        base.Start();
        this.searchMode = SearchMode.MusicLyrics;
    }

    protected override void OnClickButton()
    {
        base.OnClickButton();
    }
}       // ClassEnd
