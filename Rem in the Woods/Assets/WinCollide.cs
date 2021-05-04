using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCollide : MonoBehaviour
{

    public GameObject uiObject;
    [SerializeField] bool contact = false;

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            contact = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (contact)
        {
            uiObject.SetActive(true);
        }
    }
}
