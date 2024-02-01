using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class ChildObjectScript : MonoBehaviour
{
    // Variables
    public GameObject childObject;
    public GameObject parentObject;
    // Start is called before the first frame update
    void Start()
    {
        if (childObject == null && parentObject == null) return;
        Debug.Log("tag: " + childObject.tag);
        Debug.Log("tag: " + parentObject.tag);
        if (childObject.GetComponent<BoxCollider>() != null)
        {
            Debug.Log("BoxCollider is available!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onMessageCall(string _message)
    {
        Debug.Log("message: " + _message);
    }
}
