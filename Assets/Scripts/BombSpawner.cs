using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [SerializeField] private GameObject BombPrefab;
    [SerializeField] private Vector3 spawnDirection = Vector3.forward;
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private float initialVelocity = 5f;

    private void Start()
    {
        StartCoroutine(SpawnBombs());
    }

    private IEnumerator SpawnBombs()
    {
        while (true)
        {
            GameObject bomb = Instantiate(BombPrefab, transform.position, Quaternion.identity);
            Rigidbody rb = bomb.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = spawnDirection.normalized * initialVelocity;
            }
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}