using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class health : MonoBehaviour {
    public Image healthbar;

    // Update is called once per frame
    void Update () {
        healthbar.fillAmount = (float)(GlobalRules.health/100);
        Debug.Log(GlobalRules.GentleScore);
        if (healthbar.fillAmount <= 0.01f)
            EditorSceneManager.LoadSceneAsync("GameOver");
    }
}
