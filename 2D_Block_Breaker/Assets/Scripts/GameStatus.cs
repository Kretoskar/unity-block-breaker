using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour {

    [SerializeField]
    Text mScoreText;

    [Range(0.1f, 2f)][SerializeField]
    private float mGameSpeed = 1f;
    [SerializeField]
    private int mPointPerBlock = 5;

    [SerializeField]
    private int mCurrentScore = 0;

    private void Start()
    {
        mScoreText.text = mCurrentScore.ToString();
    }

    void Update () {
        Time.timeScale = mGameSpeed;
	}

    public void UpdateScore ()
    {
        mCurrentScore += mPointPerBlock;
        mScoreText.text = mCurrentScore.ToString();
    }
}
