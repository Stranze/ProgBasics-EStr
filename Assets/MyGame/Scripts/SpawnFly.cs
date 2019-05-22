using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFly : MonoBehaviour 
{
    public Fly flyPrefab;

    private void Update()
    {
        SpawnFlyy();
    }

    private void SpawnFlyy()
    {
        Fly flyClone = (Fly)Instantiate(flyPrefab, transform.position, transform.rotation);
        flyClone.transform.SetParent(flyParent.transform);
        flyClone.transform.localPosition = new Vector3(Random.Range(xMinLeft, xMaxLeft), flyParent.transform.position.y, 0f);
    }
}
