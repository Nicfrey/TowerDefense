using System;
using System.Collections;
using System.Collections.Generic;
using Environment;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private BoardBehaviour board;
    public BoardBehaviour Board => board;

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
