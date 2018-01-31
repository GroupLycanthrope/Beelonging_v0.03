using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeManager : MonoBehaviour {

    public GameObject m_xPlayer;

    public GameObject[] Bees;

    // Use this for initialization
    void Start() {
        Bees = GameObject.FindGameObjectsWithTag("Bee");
    }

    // Update is called once per frame
    void Update() {
        for (int i = 0; i < Bees.Length; i++) { 
            if (Bees[i] != null){
                if (Bees[i].GetComponent<ControlHealth>().getHealth() == 0){
                    Destroy(Bees[i]);
                }
            }
        }
        Bees = GameObject.FindGameObjectsWithTag("Bee");
    }

    void Formation() {

    }


}