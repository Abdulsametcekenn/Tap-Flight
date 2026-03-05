using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Birdy birdy;
    [SerializeField] GameObject Pipe;

    [SerializeField] float Height;
    [SerializeField] float SpawnTime;

    private void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    IEnumerator SpawnPipe()
    {
        while (!birdy.GetIsDead())
        {
            Instantiate(Pipe, new Vector3(3, Random.Range(-Height, Height), 0), Quaternion.identity);
            yield return new WaitForSeconds(SpawnTime);
        }
    }
}
