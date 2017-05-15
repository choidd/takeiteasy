using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    Object[] Obstacles;

    float f_CameraHeight;
    float f_CameraWidth;

    Vector3 ObstaclePos;

    Transform PlayerPos;
    // Use this for initialization
    void Start () {
        Obstacles = Resources.LoadAll("Prefabs/Obstacle", typeof(GameObject));
        PlayerPos = GameObject.Find("Player").transform;
        f_CameraHeight = Camera.main.orthographicSize;
        f_CameraWidth = f_CameraHeight * Camera.main.aspect;
        
        //StartCoroutine(make_Obstacle());
        ObstaclePos = new Vector3(Random.Range(0, f_CameraWidth), Random.Range(1, f_CameraHeight), 0);
    }

    //IEnumerator make_Obstacle()
    //{
    //    while (true)
    //    {
    //        ObstaclePos = new Vector3(Random.Range(PlayerPos.position.x + 10, PlayerPos.position.x + f_CameraWidth + 10),
    //            Random.Range(0, f_CameraHeight - 4), 0);
    //        Instantiate(Obstacles[Random.Range(0, 2)], ObstaclePos, Quaternion.identity);

    //        yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
    //    }
    //}
}
