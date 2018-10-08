using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour {

    private Color _color;
   
	
	// Update is called once per frame
	void Update () {
        _color = GetComponent<Renderer>().material.color;
	}

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Renderer>().material.color = _color;
        GetComponent<Renderer>().material.color = _color;
    }

}
