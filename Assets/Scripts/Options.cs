using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
public class Options : MonoBehaviour {

    public void OnePlayer() {
        GlobalRules.PLAYERS = 1;
        GlobalRules.health = 100;
        EditorSceneManager.LoadSceneAsync("game");
    }

    public void TwoPlayers() {
        GlobalRules.PLAYERS = 2;
        GlobalRules.health = 100;
        EditorSceneManager.LoadSceneAsync("game");
    }

    public void Menu() {
        GlobalRules.GentleScore = 0;
        GlobalRules.KiddieScore = 0;
        EditorSceneManager.LoadSceneAsync("menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
