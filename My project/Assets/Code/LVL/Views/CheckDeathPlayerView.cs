using System;
using UnityEngine;

public class CheckDeathPlayerView : MonoBehaviour
{
    public Action PlayerDeath;

    private void Update()
    {
        if(transform.position.y < -10)
        {
            PlayerDeath?.Invoke();
        }
    }
}
