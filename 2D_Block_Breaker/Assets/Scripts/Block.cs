using UnityEngine;

public class Block : MonoBehaviour {

    private Level mLevel;
    private GameStatus mGameStatus;

    private void Start()
    {
        mLevel = FindObjectOfType<Level>();
        mLevel.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        mGameStatus = FindObjectOfType<GameStatus>();
        mGameStatus.UpdateScore();
        Destroy(gameObject);
        mLevel.BlockDestroyed();
    }
}
