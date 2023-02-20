using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelectorSceneScript : MonoBehaviour
{
    private Button btn_Forward;
    private Button btn_Backward;
    private Image img_Level;
    private TextMeshPro txt_NameLevel;

    private TextAsset jsonLevels;

    public LevelList MyLevelsList;

    // Start is called before the first frame update
    void Start()
    {
        // pruebas 
        jsonLevels = Resources.Load<TextAsset>("JsonLevel/JSON_Levels") as TextAsset;
        Debug.Log("!! fichero " + jsonLevels.text);
        MyLevelsList = JsonUtility.FromJson<LevelList>(jsonLevels.text);
        // fin de las pruebas

        btn_Backward = GameObject.Find("btn_Backward").GetComponent<Button>();
        btn_Backward.onClick.AddListener(() => { });
        btn_Forward = GameObject.Find("btn_Forward").GetComponent<Button>();
        btn_Forward.onClick.AddListener(() => { });
        img_Level = GameObject.Find("img_Level").GetComponent<Image>();
        txt_NameLevel = GameObject.Find("txt_NameLevel").GetComponent<TextMeshPro>();

    }

}
