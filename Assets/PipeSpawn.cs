using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate=2;
    private float _timer=0;
    public float heightOffset;
    void Start()
    {
        PipeInstantiate();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer<spawnRate)
        {
            _timer = _timer + Time.deltaTime;
        }
        else
        {
            PipeInstantiate();
            _timer = 0;
        }
    }

    void PipeInstantiate()
    {
        float lowestHeight = transform.position.y - heightOffset;
        float highestHeight = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestHeight,highestHeight),0), transform.rotation);
    }
}
