using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animals;
    //spawn range
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    //spawn timer
    private float startDelay = 2;
    private float frequencyInterval = 4f;
    //rotation
    private float rotation = 90f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateRandomAnimalsTop", startDelay, frequencyInterval);
        InvokeRepeating("CreateRandomAnimalsLeftRight", startDelay, frequencyInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateRandomAnimalsTop()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnXPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        Instantiate(animals[animalIndex], spawnXPos, animals[animalIndex].transform.rotation);
    }

    void CreateRandomAnimalsLeftRight()
    {
        int animalIndexR = Random.Range(0, animals.Length);
        int animalIndexL = Random.Range(0, animals.Length);
        Vector3 spawnXPos = new Vector3(spawnRangeX, 0, Random.Range(0, spawnRangeX));
        Vector3 spawnXPosL = new Vector3(-spawnRangeX, 0, Random.Range(0, spawnRangeX));
        Instantiate(animals[animalIndexR], spawnXPos, Quaternion.Euler(0f, -rotation, 0f));
        Instantiate(animals[animalIndexL], spawnXPosL, Quaternion.Euler(0f, rotation, 0f));
    }
}
