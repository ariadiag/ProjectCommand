using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = 0.3f;
	
	public GameObject car;
	
	public Transform[] spawnPoints;
	
	float nextTimeToSpawn = 0f;
	
	void Start(){
		spawnPoints = GetComponentsInChildren<Transform>();
	}
	
	void Update(){
		if (nextTimeToSpawn <=Time.time){
			SpawnCar();
			nextTimeToSpawn = Time.time+spawnDelay;
		}
	}
	
	void SpawnCar(){
		if (spawnPoints.Length != 0){
			int randomIndex = Random.Range(1, spawnPoints.Length);
			Transform spawnPoint = spawnPoints[randomIndex];
			
			Instantiate(car, spawnPoint.position, spawnPoint.rotation);
		}
	}
}
