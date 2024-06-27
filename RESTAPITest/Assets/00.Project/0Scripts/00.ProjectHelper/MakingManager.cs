using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MakingManager
{
     public static Transform GetTopParentTransform(GameObject targetObj_)
    {
        Transform nowObj = targetObj_.transform;
        while(nowObj.parent != null)
        {
            nowObj = nowObj.transform.parent;
        }
        return nowObj;
    }
    public static Transform GetTopParentTransform(Transform targetTrans_)
    {
        Transform nowObj = targetTrans_;
        while (nowObj.parent != null)
        {
            nowObj = nowObj.parent;
        }
        return nowObj;
    }
}       // ClassEnd
