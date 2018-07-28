using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    [SerializeField]
    private int mBreakableBlocks;

	public void CountBreakableBlocks()
    {
        mBreakableBlocks++;
    }
}
