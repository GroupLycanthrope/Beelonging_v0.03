using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find_Move : MonoBehaviour {

    public GameObject parent;
    public bool up,down,right,left;
    Vector3 pos;
    public float speed = 0.01f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pos = parent.transform.position;
        if (left == true) {
            pos.x -= 0.01f;
        }
        if (right == true)
        {
            pos.x += 0.01f;
        }
        if (up == true)
        {
            pos.y += 0.01f;
        }
        if (down == true)
        {
            pos.y -= 0.01f;
        }


        parent.transform.position = pos;
	}

    private void OnTriggerStay2D(Collider2D other){
        if (other.tag == "Player") {
            if(parent.transform.position.x < other.transform.position.x) {
                left = true;
                right = false;
            }
            if (parent.transform.position.y < other.transform.position.y){
                down = true;
                up = false;
            }
            if (parent.transform.position.x > other.transform.position.x){
                right = true;
                left = false;
            }
            if (parent.transform.position.y > other.transform.position.y){
                up = true;
                down = false;
            }
           
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        if(left == true) {
            left = false;
        }
        if (down == true){
            down = false;
        }
        if (right == true){
            right = false;
        }
        if (up == true){
            up = false;
        }
    }

}
