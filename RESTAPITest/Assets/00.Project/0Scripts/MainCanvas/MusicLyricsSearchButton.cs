using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicLyricsSearchButton : FeatureButton
{

    public override void OnClickButton()
    {
        //DE.Log($"{CanvasRootManager.Instance.musicLyricsRoot == null} ");
        CanvasRootManager.Instance.musicLyricsRoot.OnMusicLyricsSerchCanvas();
    }

}       // ClassEnd
