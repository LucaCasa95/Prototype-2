using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animals;
    //spawn range
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    //spawn timer
    private float startDelay = 2;
    private float frequencyInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateRandomAnimals", startDelay, frequencyInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateRandomAnimals()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnXPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        Instantiate(animals[animalIndex], spawnXPos, animals[animalIndex].transform.rotation);
    }
}
