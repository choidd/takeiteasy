using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    Object[] O_Items;

    float f_CameraHeight;
    float f_CameraWidth;

    Vector3 ItemsPos;

    Transform PlayerPos;
    // Use this for initialization
    void Start () {
        O_Items = Resources.LoadAll("Prefabs/Items", typeof(GameObject));
        PlayerPos = GameObject.Find("Player").transform;
        f_CameraHeight = Camera.main.orthographicSize;
        f_CameraWidth = f_CameraHeight * Camera.main.aspect;

        StartCoroutine(make_Obstacle());
        ItemsPos = new Vector3(Random.Range(0, f_CameraWidth), Random.Range(1, f_CameraHeight), 0);
    }

    IEnumerator make_Obstacle()
    {
        while (true)
        {
            ItemsPos = new Vector3(Random.Range(PlayerPos.position.x + 10, PlayerPos.position.x + 30),
                Random.Range(0, f_CameraHeight ), 0);
            Instantiate(O_Items[Random.Range(0, O_Items.Length)], ItemsPos, Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
        }
    }
}
