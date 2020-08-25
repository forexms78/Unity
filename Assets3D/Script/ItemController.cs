using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameObject itemPrifeb;
    public GameObject itemContainer;

    public void DestroyItem(Collider item)
    {
        if (item == null)
            return;
        Destroy(item.gameObject);
    }
}
