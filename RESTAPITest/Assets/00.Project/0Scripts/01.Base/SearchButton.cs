using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum SearchMode
{
    None = 0,
    MusicLyrics = 10000,
    MusicPicture
}
[RequireComponent(typeof(Button))]
public class SearchButton : MonoBehaviour
{
    protected SearchMode searchMode = default;

    public event Action<SearchMode> OnClickEvent;

    protected virtual void Awake()
    {
        this.transform.GetComponent<Button>().onClick.AddListener(OnClickButton);        
    }

    protected virtual void Start()
    {
        // Virtual
    }

    protected virtual void OnClickButton()
    {
        // virtual
    }

    
}
