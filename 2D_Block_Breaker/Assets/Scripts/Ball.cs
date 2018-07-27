using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    //config params
    [SerializeField]
    private Paddle mPaddle;

    //state
    private Vector2 mPaddleToBallVector;

	// Use this for initialization
	void Start ()
    {
        mPaddleToBallVector = transform.position - mPaddle.transform.position;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 paddlePos = new Vector2(mPaddle.transform.position.x, mPaddle.transform.position.y);
        transform.position = paddlePos + mPaddleToBallVector;
	}
}
