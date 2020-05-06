using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScene : MonoBehaviour {
    static public bool end = false;
    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.CompareTag("Player")) {
            Done();
        }
    }

    // Update is called once per frame
    void Done() {
        end = !end;
        SceneManager.LoadScene("title");
    }
}
