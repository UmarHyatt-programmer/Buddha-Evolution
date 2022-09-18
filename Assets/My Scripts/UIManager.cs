using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public GameState gameState;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        gameState = GameState.Mainmenu;
    }
    public GameObject gameOverPanel, gameWinPanel,Tut;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && gameState == GameState.Mainmenu) {

            gameState = GameState.GamePlay;
            Tut.SetActive(false);
        }
    }
}
public enum GameState
{ 
       Mainmenu,
   GamePlay,
   LevelComplete,
   LevelFail

}