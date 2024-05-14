using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private bool _IsCollected;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"));
        {
            _IsCollected = true;
            Destroy(this.gameObject);
        }
    }

    public bool IsCollected()
    {
        return _IsCollected;
    }
}
