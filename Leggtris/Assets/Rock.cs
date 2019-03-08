using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour {


    private bool controlEnabled = true;
    private bool collided = false;
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
        if (collision.rigidbody.position.y >= 4.3f)
        {
            GameController.Controller.EndGame();
        }

        if (!collided && !GameController.Controller.gameOver) {
            controlEnabled = false;
            collided = true;
            
            GameController.Controller.DeployShape();
        }
    }
}
