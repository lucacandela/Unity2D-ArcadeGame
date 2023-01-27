using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float time;
    // Start is called before the first frame update

    [SerializeField] float randX;
    [SerializeField] float randY;
    
    

    private void spawnEnemy(){
        static Vector3 NextFloat(){
            float x = Random.Range(-0.2f, 0.2f);
            float y = Random.Range(-0.2f, 0.2f);
            if (x >= 0) x += 1;
            if (y >= 0) y += 1;
            Vector3 randomPoint = new(x, y, 10f);
            return randomPoint;
        }
        Vector3 v3Pos = Camera.main.ViewportToWorldPoint(NextFloat());
        Instantiate(enemyPrefab, v3Pos, Quaternion.identity);
    }
    void Awake(){
        spawnEnemy();
        time = 0;
    }

     void FixedUpdate() {
        time += Time.deltaTime;
        if (time > 5.0) {
            spawnEnemy();
            time = 0;
        }
    }
}
