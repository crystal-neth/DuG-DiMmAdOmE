using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject grenadePreFab;
    public float speed = 1f;
    private Vector3 playerposition;

	// Use this for initialization
	void Start () {
        playerposition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        float xpos = transform.position.x + (Input.GetAxis("Horizontal") * speed);
        playerposition = new Vector3(Mathf.Clamp(xpos, -7.5f, 7.5f), 3.1f, 0f);
        transform.position = playerposition;

        if(Input.GetKeyDown("space"))
        {
            grenadePreFab.GetComponent<Transform>().position = new Vector3(playerposition.x, 2.72f, 0);
            Instantiate(grenadePreFab);
        }
	}
}
