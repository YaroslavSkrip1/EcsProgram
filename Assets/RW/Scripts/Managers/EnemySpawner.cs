using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using Entitas;
using Unity.Collections;
using Unity.Transforms;
using Random = UnityEngine.Random;


/// <summary>
/// spawns a swarm of enemy entities offscreen, encircling the player
/// </summary>
public class EnemySpawner : MonoBehaviour
{

    [Header("Spawner")]
    // number of enemies generated per interval
    [SerializeField] private int spawnCount = 30;

    // time between spawns
    [SerializeField] private float spawnInterval = 3f;

    // enemies spawned on a circle of this radius
    [SerializeField] private float spawnRadius = 30f;

    // extra enemy increase each wave
    [SerializeField] private int difficultyBonus = 5;

    [Header("Enemy")]
    // random speed range
    [SerializeField] float minSpeed = 4f;
    [SerializeField] float maxSpeed = 12f;

    // counter
    private float spawnTimer;

    // flag from GameManager to enable spawning
    private bool canSpawn;

    private Entity _entityManager;
    public PlayerContext _playerContext;

    [SerializeField] private Mesh _enemyMesh;
    [SerializeField] private Material _enemyMaterial;
    [SerializeField] private GameObject enemyPrefab;

    private Entity enemyEntityPrefab;

    private void Start()
    {
        var entity = _playerContext.CreateEntity();

        var settings = entity.rWScriptsECSComponentDataGameObject.value;
        
        

        SpawnWave();
    }

    // spawns enemies in a ring around the player
    private void SpawnWave()
    {
        List<Entity> listEntity = new List<Entity>(spawnCount);

        for (int i = 0; i < listEntity.Count; i++)
        {
            listEntity[i] = enemyEntityPrefab;
            
                // (listEntity[i], new Translation{Value = RandomPointOnCircle(spawnRadius)});
        }

    }

    // get a random point on a circle with given radius
    private float3 RandomPointOnCircle(float radius)
    {
        Vector2 randomPoint = Random.insideUnitCircle.normalized * radius;

        // return random point on circle, centered around the player position
        return new float3(randomPoint.x, 0.5f, randomPoint.y) + (float3)GameManager.GetPlayerPosition();
    }

    // signal from GameManager to begin spawning
    public void StartSpawn()
    {
        canSpawn = true;
    }

    private void Update()
    {
        // disable if the game has just started or if player is dead
        if (!canSpawn || GameManager.IsGameOver())
        {
            return;
        }

        // count up until next spawn
        spawnTimer += Time.deltaTime;

        // spawn and reset timer
        if (spawnTimer > spawnInterval)
        {
            SpawnWave();
            spawnTimer = 0;
        }
    }
}
