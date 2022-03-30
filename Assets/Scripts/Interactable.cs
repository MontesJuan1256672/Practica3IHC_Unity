using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    protected bool IsInsideZone;
    public GameObject dialog;

    void start()
    {
        if (dialog != null)
        {
            dialog.SetActive(false);
        }
    }

    void Update()
    {
        if (IsInsideZone && Input.GetKeyDown(KeyCode.I))
        {
            Interac();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        Debug.Log ("Collition" + other.name);  
        IsInsideZone = true;
        if (dialog != null) dialog.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        Debug.Log ("Collition Exit" + other.name);
        IsInsideZone = false;
        if (dialog != null) dialog.SetActive(false);
    }

    protected virtual void Interac()
    {
        Debug.Log("Do in something");
    }
}
