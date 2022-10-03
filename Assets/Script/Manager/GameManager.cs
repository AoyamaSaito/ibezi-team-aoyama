using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager 
{
    public event Action OnPause;
    public event Action OnResume;

    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameManager();
            }
            return _instance;
        }
    }

    //StageStateのインスタンス
    private static StageState _stageState = new StageState();
    public static StageState StageState => _stageState;

    //Playerのインスタンス
    private GameObject _player;
    public GameObject Player => _player;
    public void SetPlayer(GameObject p)
    {
        _player = p;
    }
}
