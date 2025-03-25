using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{

    private Vector3 startPosition;
    public int GameLevel = 1;
   
    private void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            startPosition = player.transform.position;
        }
    }

    public void OnPlayerEnterFinishArea(GameObject player)
    {
        // Oyuncuyu baþlangýç konumuna ýþýnla
        player.transform.position = startPosition;
        LevelController.Instance.LevelBoost();
    }
}
