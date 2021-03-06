﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPoller : MonoBehaviour {

    public static ObjectPoller current;
    public GameObject pooledObject;
    public int polledAmount;
    public bool willGrow = true;

    List<GameObject> pooledObjects;

    void Awake()
    {
        current = this;
    }

	// Use this for initialization
	void Start ()
    {

        pooledObjects = new List<GameObject>();
        for (int i = 0; i < polledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        if (willGrow)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
            return obj;
        }

        return null;

    }




}
