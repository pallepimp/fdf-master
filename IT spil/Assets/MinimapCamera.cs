using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCamera : MonoBehaviour {

    GameObject target;
    
    // Use this for initialization
	void Start () {
        target = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = new Vector3(target.transform.position.x, 1000, target.transform.position.z);
        gameObject.transform.eulerAngles = new Vector3(90, target.transform.eulerAngles.y, 0);
    }
}
