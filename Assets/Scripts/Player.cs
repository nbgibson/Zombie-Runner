using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform playerSpawnPoints;

    private bool reSpawn = false;
    private Transform[] spawnPoints;
    private bool lastRespawnToggle = false;
    

    // Use this for initialization
    void Start () {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
		if(lastRespawnToggle != reSpawn)
        {
            Respawn();
            reSpawn = false;
        }
        else
        {
            lastRespawnToggle = reSpawn;
        }
	}

    private void Respawn()
    {
        int i = Random.Range(1, spawnPoints.Length);
        transform.position = spawnPoints[i].position;
    }

    void OnFindClearArea()
    {
        Debug.Log("Flare?");
        Invoke("DropFlare", 3f);
    }

    void DropFlare()
    {
        //drop a flare
    }
}
