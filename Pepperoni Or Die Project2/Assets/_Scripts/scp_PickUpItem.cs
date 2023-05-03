using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scp_PickUpItem : MonoBehaviour
{
    [SerializeField] TMP_Text storageUI;
    [SerializeField] GameObject baseObj;

    private bool ableToPickUp;
    private bool baseInHand = false;

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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            baseInHand = true;
            baseObj.SetActive(true);
        }

        if (baseInHand && Input.GetKeyDown(KeyCode.Mouse0))
        {
            
        }
    }
}
