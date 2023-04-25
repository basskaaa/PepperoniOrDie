using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scp_PickUpItem : MonoBehaviour
{
    [SerializeField] TMP_Text storageUI;

    private bool ableToPickUp;

    private void Start()
    {
        storageUI.enabled = false;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Item Storage")
        {
            storageUI.enabled = true;
            ableToPickUp = true;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Item Storage")
        {
            storageUI.enabled = false;
            ableToPickUp = false;
        }
    }

}
