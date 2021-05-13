using UnityEngine;

public class Spawner : MonoBehaviour
{
    //TODO object pool
    private float counter = 0f;

    [SerializeField] private float offset = 0.5f;
    [SerializeField] private float waitTime = 1f;
    [SerializeField] private GameObject[] objectToSpawn;
    private Vector3 bounds;

    private void Start() {
        bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    private void Update() {
        counter += Time.deltaTime;

        if(counter >= waitTime){
            Instantiate(WhatToSpawn(), GetRandomSpawnPoint(), Quaternion.identity);
            counter = 0f;
        }
    }

    private Vector3 GetRandomSpawnPoint(){
        var randomPosition = Random.Range(Mathf.RoundToInt(-bounds.y + offset), Mathf.RoundToInt(bounds.y - offset));

        return new Vector3(transform.position.x, randomPosition, transform.position.z);
    }
    
    private GameObject WhatToSpawn(){
        var objNumber = Random.Range(0, objectToSpawn.Length);
        return objectToSpawn[objNumber];
    }
}
