using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    public string itemName;
    private InventorySystem iSystem;

    private void Start()
    {
        iSystem = GameObject.Find("Player").GetComponent<InventorySystem>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (iSystem.CheckItem(itemName))
        {
            Destroy(gameObject);
        }
    }
}
