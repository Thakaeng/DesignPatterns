using UnityEngine;

public class MoleManager : MonoBehaviour
{
    [SerializeField] private float timeBetweenMoles = 5f;
    [SerializeField] private MolePool molePool;
    [SerializeField] private float spawnRadius = 10f;

    private float timer;
    private GameObject newMole;
    
    private void Update()
    {
        if(timer <= Time.time)
        {
            PlaceMole();
            timer = Time.time + timeBetweenMoles;
        }
    }

    private void PlaceMole()
    {
        newMole = molePool.GetFromPool();
        newMole.transform.position = new Vector3(
            Random.Range(-spawnRadius, spawnRadius), 
            -1f, 
            Random.Range(-spawnRadius, spawnRadius));
        newMole.GetComponent<Peek>().InitiatePeek();
    }
}
