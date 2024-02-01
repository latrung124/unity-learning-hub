using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectScript : MonoBehaviour
{
    // Variables
    public GameObject rectangle;
    // Start is called before the first frame update
    void Start()
    {
        if (rectangle == null) return;
        GameObject childObject = transform.GetChild(0).gameObject; // The first child in hierarchy
        childObject.SendMessageUpwards("onMessageCall", "Hello World!");
        foreach (Transform child in transform)
        {
            child.position += Vector3.up * 10.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void onMessageCall(string _message)
    {
        Debug.Log("message: parent " + _message + "!");
    }
}
