using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    private Level mLevel;

    private void Start()
    {
        mLevel = FindObjectOfType<Level>();
        mLevel.CountBreakableBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
