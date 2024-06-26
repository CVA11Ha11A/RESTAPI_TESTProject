using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicLyricsSerchButton : FeatureButton
{

    public override void OnClickButton()
    {
        //DE.Log($"{CanvasRootManager.Instance.musicLyricsRoot == null} ");
        CanvasRootManager.Instance.musicLyricsRoot.OnMusicLyricsSerchCanvas();
    }

}       // ClassEnd
