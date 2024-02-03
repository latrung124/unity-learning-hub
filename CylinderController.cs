using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
    // Variables
    public Transform objectTransformToFollow;
    public float followSpeed = 1;

    [SerializeField]
    private string name = string.Empty;

    // Start is called before the first frame update
    void Start()
    {
        followSpeed = 1;
        Debug.Log(name);
    }

    // Update is called once per frame
    void Update()
    {
        var delta = objectTransformToFollow.position - transform.position;
        transform.position += delta * Time.deltaTime * followSpeed;
    }
}
