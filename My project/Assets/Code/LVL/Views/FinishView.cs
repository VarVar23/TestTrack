using UnityEngine;
using System;

public class FinishView : MonoBehaviour
{
    public Action Finish;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 3) Finish?.Invoke();
    }
}
