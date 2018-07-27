using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    //config params
    [SerializeField]
    private Paddle mPaddle;

    [SerializeField]
    private float mXPush = 0f;

    [SerializeField]
    private float mYPush = 15f;

    //state
    private Vector2 mPaddleToBallVector;
    private bool mHasStarted = false;

	// Use this for initialization
	void Start ()
    {
        mPaddleToBallVector = transform.position - mPaddle.transform.position;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!mHasStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(mXPush, mYPush);
            mHasStarted = true;
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(mPaddle.transform.position.x, mPaddle.transform.position.y);
        transform.position = paddlePos + mPaddleToBallVector;
    }
}
