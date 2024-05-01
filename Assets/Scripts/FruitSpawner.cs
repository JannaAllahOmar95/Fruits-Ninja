using System.Collections;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject fruitPrefab;
    [SerializeField] private Vector3 spawnDirection = Vector3.forward;
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private float initialVelocity = 5f;

    private void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    private IEnumerator SpawnFruits()
    {
        while (true)
        {
            GameObject fruit = Instantiate(fruitPrefab, transform.position, Quaternion.identity);
            Rigidbody rb = fruit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = spawnDirection.normalized * initialVelocity;
            }
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}