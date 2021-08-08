using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class BlockController : MonoBehaviour
{
    [SerializeField] private Pooling _pooling;

    private List<GameObject> row;

    private GameObject[] parents;

    private GameObject parent;

    private Vector2 row1;
    
    
        [SerializeField]private GameObject objectPrefab1;
        public int counter;
        [SerializeField]private GameObject objectPrefab2;
        [SerializeField]private GameObject objectPrefab3;
        [SerializeField]private GameObject objectPrefab4;

    private void Awake()
    {
        counter = (int)Random.Range(0, 5);
        row = new List<GameObject>(7);

        GameManager.OnPreGame += Create;
        GameManager.OnPreGame += MoveRows;
    }

    private void Update()
    {
        parents = GameObject.FindGameObjectsWithTag("parent");
    }

    // void FillList()
    // {
    //     row.Add(_pooling.GetObjFromPool());
    // }

    void Create()
    {
        //FillList
        row.Add(_pooling.GetObjFromPool());
        
        Instantiate(parent);
        parent.transform.position = row1;
        
        // Fill
            
                foreach (GameObject go in row  )
                {
                    go.transform.parent = parent.transform;
                }
                
    }

    void MoveRows()
    {
        foreach (GameObject go in parents)
        {
            go.transform.position -= Vector3.down;
        }
    }
    
}
