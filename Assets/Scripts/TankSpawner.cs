using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _tanks;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private float _spawnTime = 4f;
    private ObjectPooler _objectPooler;

    private void Start()
    {
        _objectPooler = ObjectPooler.Instance;
        StartCoroutine(SpawnTank());
    }

    IEnumerator SpawnTank()
    {
        while (true)
        {
            int limit;
            if(Stats.Level < _tanks.Count)
                limit = Stats.Level;
            else
                limit = _tanks.Count;

            yield return new WaitForSeconds(_spawnTime);
            _objectPooler.SpawFromPool(_tanks[Random.Range(0, limit)].name, _spawnPoints[Random.Range(0, _spawnPoints.Count)].position, Quaternion.identity);
        }
    }
}
