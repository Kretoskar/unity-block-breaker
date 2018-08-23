using UnityEngine;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour {

    [SerializeField]
    private Text mScoreText;

    [SerializeField]
    private Text mHighScoreText;

    [Range(0.1f, 2f)][SerializeField]
    private float mGameSpeed = 1f;
    [SerializeField]
    private int mPointPerBlock = 5;

    [SerializeField]
    private int mCurrentScore = 0;

    [SerializeField]
    private bool mIsAutoPlayEnabled;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount > 1)
        {
            Destroy(gameObject);
        } 
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        mHighScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        mScoreText.text = mCurrentScore.ToString();
    }

    void Update () {
        Time.timeScale = mGameSpeed;
	}

    public void UpdateScore ()
    {
        mCurrentScore += mPointPerBlock;
        mScoreText.text = mCurrentScore.ToString();
        int highScore = PlayerPrefs.GetInt("HighScore");
        if(mCurrentScore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", mCurrentScore);
            mHighScoreText.text = mCurrentScore.ToString();
        }
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public bool IsAutoPlayEnabled()
    {
        return mIsAutoPlayEnabled;
    }
}
