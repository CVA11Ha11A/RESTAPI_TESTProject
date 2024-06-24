using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ProjectNameText : MonoBehaviour
{

    private void Awake()
    {
        TextMeshProUGUI textRoot = this.gameObject.GetComponent<TextMeshProUGUI>();
        textRoot.text = "RestAPI_Test";
    }


}
