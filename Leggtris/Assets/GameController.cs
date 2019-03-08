using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public int score;
    public GameObject nextShape;
    public GameObject shapePrefab;
    public bool gameOver;

    public static GameController Controller { get { return Camera.main.GetComponent<GameController>(); } }

    // Use this for initialization
    void Start () {

        DeployShape();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CheckLines()
    {

    }

    public void DeployShape()
    {
        Instantiate(shapePrefab, new Vector3(0f, 5.69f, -1.38f), Quaternion.identity);
    }

    public void IncreaseScore()
    {
        score++;
    }

    public void EndGame()
    {
        gameOver = true;
    }
}
