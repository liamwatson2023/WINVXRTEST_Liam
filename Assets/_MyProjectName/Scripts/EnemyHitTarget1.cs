using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyHitTarget : hitTarget
{
    [SerializeField] int hitsToDestroy = 1;

    protected overide int CalculateScore()
    {
        int scoreGain=hitsToDestroy * score;
        debug("GainScore For EnemyTarget:" + scoreGain);
        return scoreGain;
    }
}
