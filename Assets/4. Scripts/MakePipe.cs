using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Pipe;
    public float TimeDiff;

    float timer = 0;
    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > TimeDiff)
        {
            GameObject newPipe = Instantiate(Pipe);
            newPipe.transform.position = new Vector3(0.52f, Random.Range(6.4f, 2.9f), 0);
            timer = 0;
        }


    }
}
