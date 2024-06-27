using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SearchKeywordUIController
{
    private Vector3 onPos = default;
    private Vector3 offPos = default;
    public SearchKeywordUIController(Transform uiTrans_)
    {
        this.offPos = uiTrans_.localPosition;
        this.onPos = new Vector3(0f, 0f, -10f);
    }

    public void MoveSearchKeywordUI(GameObject moveObj_,UIState wantState_)
    {
        if(wantState_ == UIState.On)
        {
            moveObj_.transform.localPosition = onPos;
        }
        else
        {
            moveObj_.transform.localPosition = offPos;
        }
        
    }


}       // ClassEnd
