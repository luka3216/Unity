using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    private Rigidbody _rb;
    [SerializeField]
    private float _speeed; private Renderer _rend;
    // Use this for initialization
    void Start () {
        _rb = GetComponent<Rigidbody>();
        _rend = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        _rb.AddForce(new Vector3(x, 0, y) * _speeed);
	}

    private void OnCollisionEnter(Collision collision)
    {
        Renderer colRend = collision.gameObject.GetComponent<Renderer>();
        colRend.material.color = _rend.material.color;
    }
}
