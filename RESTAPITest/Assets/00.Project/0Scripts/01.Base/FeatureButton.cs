using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class FeatureButton : MonoBehaviour
{
    protected virtual void Awake()
    {        
        Button buttonRoot = this.transform.GetComponent<Button>();
        buttonRoot.onClick.AddListener(OnClickButton);
    }
           
    public abstract void OnClickButton();
}
