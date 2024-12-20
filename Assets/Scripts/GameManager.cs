using System;
using System.Collections;
using System.Collections.Generic;
using Environment;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private BoardBehaviour board;
    [SerializeField] private RoundManagerBehaviour roundManager;
    public BoardBehaviour Board => board;
    public RoundManagerBehaviour RoundManager => roundManager;

    public void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            return;
        }
        Destroy(this);
    }
    
    
    
}
