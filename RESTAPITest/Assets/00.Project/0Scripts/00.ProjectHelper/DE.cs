using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DE
{
    public static void Log(string log_)
    {
#if UNITY_EDITOR
        Debug.Log($"{log_}");
#endif
    }

    public static void LogError(string log_)
    {
#if UNITY_EDITOR
        Debug.LogError($"{log_}");
#endif
    }

    public static void DrawRay(Vector3 start_, Vector3 dir_, Color color_, float duration_)
    {
#if UNITY_EDITOR
        Debug.DrawRay(start_, dir_, color_, duration_);
#endif
    }
}
