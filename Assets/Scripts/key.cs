using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour {
    public GameObject menu;
    private bool isShowing = false;

    // gate animation
    public GameObject gate;
    Animator gateAnim;
    public GameObject goal;

    private void Start() {

        gateAnim = gate.GetComponent<Animator>();

    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.CompareTag("Player")) {
            isShowing = true;
            menu.SetActive(isShowing);
            gateAnim.enabled = isShowing;
            goal.SetActive(isShowing);
        }
    }
}