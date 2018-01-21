using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

    public GameObject player;
    private Transform t;

	// Use this for initialization
	void Start () {
        t = player.transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
      this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, new Vector3(t.position.x, 3 + t.position.y, -1 + t.position.z), Time.deltaTime * 6f);
	}
}
