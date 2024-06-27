using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SearchKeywordUI : MonoBehaviour
{
    private TMP_InputField musicName = null;
    private TMP_InputField artistName = null;

    private SearchKeywordUIController uiController = null;

    private SearchMode beGoingToSearch = default;

    private void Awake()
    {
        musicName = this.transform.GetChild(0).GetComponent<TMP_InputField>();
        artistName = this.transform.GetChild(1).GetComponent<TMP_InputField>();

    }

    private void Start()
    {
        uiController = new SearchKeywordUIController(this.transform);
    }

    public void OnSearchKeyWardUI(SearchMode beGoingToMode_)
    {
        // 1. UI가 보이도록 설정
        uiController.MoveSearchKeywordUI(this.transform.gameObject, UIState.On);
        // 2. 현재 선택되어있는 음악의 이름, 아티스트이름을 받아옴
        (string,string) datas = MakingManager.GetTopParentTransform(this.transform).
            GetComponent<MusicSearchDynamicRoot>().TryGetChangeMetaDataUI().GetMusicDatas();

        // 3. 받아온것 대로 설정
        this.musicName.text = datas.Item1;
        this.artistName.text = datas.Item2;
        this.beGoingToSearch = beGoingToMode_;

    }       // OnSearchKeyWardUI()

    public void OffSearchKeywardUI()
    {
        uiController.MoveSearchKeywordUI(this.transform.gameObject, UIState.Off);
        this.musicName.text = "";
        this.artistName.text = "";
        this.beGoingToSearch = SearchMode.None;
    }       // OffSearchKeywardUI()

    private void OnDestroy()
    {
        this.uiController = null;
    }


}       // ClassEnd
