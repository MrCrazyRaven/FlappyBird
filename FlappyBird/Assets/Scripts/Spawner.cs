using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstacles;
	void Start()
    {
        StartCoroutine(ObstaclesSpawner());
    }

    IEnumerator ObstaclesSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.4f);
            float _rend = Random.Range(1f, -4.4f);
            Instantiate(_obstacles,
                 new Vector3(transform.position.x,
                _rend, 0), Quaternion.identity);
        }
    }
}
