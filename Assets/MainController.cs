using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public Vector2 area = new Vector2(10f, 10f);

    public GameObject bacteriumPrefab;
    public GameObject foodPrefab;

    private float frame = 0;
    [Range(0,100)]
    public int startCount;
    [Range(0f,3f)]
    public float spawnSpeed; 
    public int bacCount;
    void Start()
    {
        Evolution();
    }

    private void Evolution()
    {
        for (int i = 0; i < startCount; i++)
        {
            Genome genome = new Genome(64);
            GameObject b = Instantiate(bacteriumPrefab, new Vector3(Random.Range(-area.x, area.x), Random.Range(-area.y, area.y), 0), Quaternion.identity);
            b.name = "bacterium";
            b.GetComponent<AI>().Init(genome);
            b.GetComponent<AI>().controller = GetComponent<MainController>();
            bacCount +=1;
        }
    }

    void FixedUpdate()
    {
        Grapher.Log(bacCount, "число существ", Color.green);
        while(frame > 1)
        {
            frame -= 1;
            GameObject food = Instantiate(foodPrefab, new Vector3(Random.Range(-area.x, area.x), Random.Range(-area.y, area.y), 0), Quaternion.identity);
            food.name = "food";
        }
        frame+=spawnSpeed;
    }
    
}
