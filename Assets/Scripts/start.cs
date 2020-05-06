using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject endMenu;
    void Start()
    {
        try {
            if (endScene.end == true) {
                startMenu.SetActive(false);
                endMenu.SetActive(true);
                endScene.end = false;
            }
        } catch {
            ;
        }
    }

    private void Update() {
        if (Input.GetKey("escape")) {
            Application.Quit();
        }
    }

}
