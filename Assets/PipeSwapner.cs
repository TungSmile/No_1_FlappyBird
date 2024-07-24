using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSwapner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawTime = 2;
    private float timer = 0;
    public float heightOffset = 3;
    void Start()
    {
        spawPipe();
    }
    void spawPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);

    }
    // Update is called once per frame
    void Update()
    {
        if (timer < spawTime)
        {

            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawPipe();
        }
    }
}
