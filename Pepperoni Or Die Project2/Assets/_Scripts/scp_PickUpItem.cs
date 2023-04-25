using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scp_PickUpItem : MonoBehaviour
{
    [SerializeField] GameObject item;
    [SerializeField] bool itemInHand;
    [SerializeField] Transform itemTf;

    private void Update()
    {
        if (itemInHand)
        {
            item.GetComponent<MeshCollider>().enabled = false;
            item.GetComponent<MeshRenderer>().enabled = true;
            item.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
