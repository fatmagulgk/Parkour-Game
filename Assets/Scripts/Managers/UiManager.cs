using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using System.Xml.Serialization;


public class UiManager : Singleton<UiManager>
{
    [SerializeField] private Button btnExit;
    [SerializeField] private Button btnStart;
    [SerializeField] private GameObject pnlMenu;
    [SerializeField] private GameObject pnlGame;
    [SerializeField] private TextMeshProUGUI txtLevel;
    private void Start()
    {
        btnStart.onClick.AddListener(StartGame);
        btnExit.onClick.AddListener(ExitGame);
    }
    public void StartGame()
    {
        txtLevel.text = "Level" + " " +"1";
        CameraController.Instance.StartButtonActive();
        pnlMenu.SetActive(false);
        pnlGame.SetActive(true);

    }
    public void ExitGame()
    {
        Application.Quit();
        // Eðer Editör içindeysen, aþaðýdaki kodu kullanarak çýkýþý simüle edebilirsin:
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
    public void LevelPrint()
    {
        txtLevel.text = "Level" + " " + GameManager.Instance.GameLevel;

    }
}
