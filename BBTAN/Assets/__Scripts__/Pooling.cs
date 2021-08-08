
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour
{
    [SerializeField]private Queue<GameObject> pool;
    
    [SerializeField]private int poolSize;
    
    [SerializeField]private GameObject objectPrefab=null;
    [SerializeField]private GameObject objectPrefab0;
    [SerializeField]private GameObject objectPrefab1;
    [SerializeField]private GameObject objectPrefab2;
    [SerializeField]private GameObject objectPrefab3;
    [SerializeField]private GameObject objectPrefab4;

    
    
    //prefab random seçilsin
    public void Randomobj()
    {
        int b= Random.Range(0, 5);

        switch (b)
        {
            case(0):
                objectPrefab = objectPrefab0;//default or null
                break;
            case(1):
                objectPrefab = objectPrefab1;//SquareBlock
                break;
            case(2):
                objectPrefab = objectPrefab2;//HeartBlock
                break;
            case(3):
                objectPrefab = objectPrefab3;//PowerUp1
                break;
            case(4):
                objectPrefab = objectPrefab4;//PowerUp2
                break;
        }
        
    }
    
    private void Awake()
    {
        pool = new Queue<GameObject>();

        for (int i = 0; i < pool.Count; i++)
        {
            //
            GameObject obje = Instantiate(objectPrefab);
            obje.SetActive(false);
            pool.Enqueue(obje);
        }
        
    }

    public GameObject GetObjFromPool()
    {
        Randomobj();
        
        GameObject obj = pool.Dequeue();
        
        obj.SetActive(true);
        
        pool.Enqueue(obj);

        return obj;
    }
}
