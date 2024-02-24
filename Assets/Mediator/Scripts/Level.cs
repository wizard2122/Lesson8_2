using System;
using UnityEngine;

public class Level
{
    public event Action Defeat;

    public void Start()
    {
        //Логика старта 
        Debug.Log("Start level");
    }

    public void Restart()
    {
        //Логика очистки уровня
        Start();
    }

    public void OnDefeat()
    {
        //Логика остановки игры
        Defeat?.Invoke();
    }
}
