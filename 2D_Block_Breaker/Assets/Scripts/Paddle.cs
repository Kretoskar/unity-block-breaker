using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField]
    private float mMinX = 1f;

    [SerializeField]
    private float mMaxX = 15f;

    [SerializeField]
    private float mScreenWidthInUnits = 16f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float mousePositionInUnits = Input.mousePosition.x / Screen.width * mScreenWidthInUnits;
        Vector2 paddlePosition = new Vector2(transform.position.x, transform.position.y);
        paddlePosition.x = Mathf.Clamp(mousePositionInUnits, mMinX, mMaxX);
        transform.position = paddlePosition;
	}
}
