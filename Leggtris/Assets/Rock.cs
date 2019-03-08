using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour {


    private bool controlEnabled = true;
    protected Rigidbody rockRigidbody;
    private SphereCollider collidertest;



    // Use this for initialization
    void Start () {
        rockRigidbody = GetComponent<Rigidbody>();
        collidertest = GetComponent<SphereCollider>();

    }
	
	// Update is called once per frame
	void Update () {

        if (controlEnabled) { 
            float rMove = Input.GetAxisRaw("Horizontal");

            if (rMove != 0)
            {
                rockRigidbody.AddForce(new Vector2(rMove*10, 0));
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        controlEnabled = false;
        GameController.Controller.DeployShape();
    }
}
