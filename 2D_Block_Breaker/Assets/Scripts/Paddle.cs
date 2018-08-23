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
        Vector2 paddlePosition = new Vector2(transform.position.x, transform.position.y);
        paddlePosition.x = Mathf.Clamp(GetXPos(), mMinX, mMaxX);
        transform.position = paddlePosition;
	}

    private float GetXPos()
    {
        if (FindObjectOfType<GameStatus>().IsAutoPlayEnabled())
        {
            return FindObjectOfType<Ball>().transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * mScreenWidthInUnits;
        }
    }
}
