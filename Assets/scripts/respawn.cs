using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnpoint;
    [SerializeField] private GameObject prefab;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Player.transform.position = respawnpoint.transform.position;
            Physics.SyncTransforms();
        }

        GameObject prefab_gameobject = Instantiate(prefab, new Vector3(2.5f, 1, -0.5f), Quaternion.identity, transform);
        _ = Instantiate(prefab, new Vector3(7.5f, 1, -.05f), Quaternion.identity, transform);
        _ = Instantiate(prefab, new Vector3(11.5f, 0, -0.5f), Quaternion.identity, transform);
        _ = Instantiate(prefab, new Vector3(16.25f,0.5f, -0.5f), Quaternion.identity, transform);
        _ = Instantiate(prefab, new Vector3(19.75f, 2.3f, -0.5f), Quaternion.identity, transform);
        _ = Instantiate(prefab, new Vector3(22, 1, -0.5f), Quaternion.identity, transform);
        prefab_gameobject.name = "coin";

    }

    
}
