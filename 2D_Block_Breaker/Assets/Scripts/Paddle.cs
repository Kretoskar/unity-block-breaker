using UnityEngine;

public class Paddle : MonoBehaviour {

    //config params
    [SerializeField]
    private float mMinX = 1f;

    [SerializeField]
    private float mMaxX = 15f;

    [SerializeField]
    private float mScreenWidthInUnits = 16f;

    //cached references
    private GameStatus mGameStatus;
    private Ball mBall;

	// Use this for initialization
	void Start ()
    {
        mGameStatus = FindObjectOfType<GameStatus>();
        mBall = FindObjectOfType<Ball>();
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
        if (mGameStatus.IsAutoPlayEnabled())
        {
            return mBall.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * mScreenWidthInUnits;
        }
    }
}
