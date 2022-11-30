using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class second_level : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform newlevel;
    [SerializeField] private GameObject prefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.transform.position = newlevel.transform.position;
            Physics.SyncTransforms();
        }


    }
}
