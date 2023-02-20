using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InitialScript : MonoBehaviour
{

    private Button btn_Start;
    private Button btn_Quit;
    private Button btn_Options;
    private Button btn_BackToMainMenu;
    private TextMeshProUGUI txt_Title;
    private TextMeshProUGUI txt_Options;

    // TODO hacer un boton que cambie el idioma del juego

    // Start is called before the first frame update
    void Start()
    {
        txt_Options = GameObject.Find("txt_Options").GetComponent<TextMeshProUGUI>();
        txt_Title = GameObject.Find("txt_Title").GetComponent<TextMeshProUGUI>();
        btn_BackToMainMenu = GameObject.Find("btn_BackToMainMenu").GetComponent<Button>();
        btn_BackToMainMenu.onClick.AddListener(() => { BackToMainMenu(); });
        btn_Start = GameObject.Find("btn_Start").GetComponent<Button>();
        btn_Start.onClick.AddListener(() => { SceneManager.LoadScene("LevelSelectorScene", LoadSceneMode.Single); });
        btn_Quit = GameObject.Find("btn_Quit").GetComponent<Button>();
        btn_Quit.onClick.AddListener(() => { Application.Quit(); });
        btn_Options = GameObject.Find("btn_Options").GetComponent<Button>();
        btn_Options.onClick.AddListener( () => { OptionsAction(); });

        // desactivamos los elementos que contiene el apartado de opciones

        btn_BackToMainMenu.gameObject.SetActive(false);
        txt_Options.gameObject.SetActive(false);
    }

    private void BackToMainMenu()
    {
        // Devolvemos la escena a como estaba anteriormente
        // desactivamos los elementos relacionados con el apartado de opciones
        txt_Options.gameObject.SetActive(false);
        btn_BackToMainMenu.gameObject.SetActive(false);
        // habilitamos todo el contenido que deberia de tener el menu de inicio
        txt_Title.gameObject.SetActive(true);
        btn_Start.gameObject.SetActive(true);
        btn_Quit.gameObject.SetActive(true);
        btn_Options.gameObject.SetActive(true);
    }

    private void OptionsAction()
    {
        // desactivaremos todos los botones y el titulo
        btn_Options.gameObject.SetActive(false);
        btn_Start.gameObject.SetActive(false);
        btn_Quit.gameObject.SetActive(false);
        txt_Title.gameObject.SetActive(false);
        // añadiremos los nuevos elementos del menu de opciones
        txt_Options.gameObject.SetActive(true);
        btn_BackToMainMenu.gameObject.SetActive(true);
        // finalmente abra un boton de guardado que guardara (valgame la redundancia) los valores nuevos del juego dentro de los player prefs del juego
    }
}
