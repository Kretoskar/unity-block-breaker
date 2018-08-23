using UnityEngine;

public class Ball : MonoBehaviour {

    //config params
    [SerializeField]
    private Paddle mPaddle;

    [SerializeField]
    private float mXPush = 0f;

    [SerializeField]
    private float mYPush = 15f;

    [SerializeField]
    private AudioClip[] mAudioClips;

    [SerializeField]
    private float randomFactor = 0.2f;

    //state
    private Vector2 mPaddleToBallVector;
    private bool mHasStarted = false;

    //Chached component references
    private AudioSource mAudioSource;
    private Rigidbody2D mRigidbody2D;

	// Use this for initialization
	void Start ()
    {
        mAudioSource = GetComponent<AudioSource>();
        mPaddleToBallVector = transform.position - mPaddle.transform.position;
        mRigidbody2D = GetComponent<Rigidbody2D>();
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
            mRigidbody2D.velocity = new Vector2(mXPush, mYPush);
            mHasStarted = true;
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(mPaddle.transform.position.x, mPaddle.transform.position.y);
        transform.position = paddlePos + mPaddleToBallVector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocityTweak = new Vector2
            (Random.Range(0f, randomFactor),
            (Random.Range(0f, randomFactor)));
        if (mHasStarted)
        {
            AudioClip clip = mAudioClips[UnityEngine.Random.Range(0, mAudioClips.Length)];
            mAudioSource.PlayOneShot(clip);
            mRigidbody2D.velocity += velocityTweak;
        }
    }
}
