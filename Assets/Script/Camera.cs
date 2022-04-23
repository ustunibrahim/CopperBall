using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Character;
    Vector3 space;
    void Start()
    {
        space = transform.position - Character.transform.position;
    }

   
    void Update()
    {
        transform.position = Character.transform.position+space;
    }
}
