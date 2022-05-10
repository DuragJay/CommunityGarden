using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshTest : MonoBehaviour
{
    public EventManager touch;
    public Camera cam;
    public GameObject plant;

    private void OnEnable()
    {
        EventManager.startClick += plantPlacer;
    }

    private void OnDisable()
    {
        EventManager.startClick -= plantPlacer;
    }
    private void plantPlacer()
    {
        Vector2 touchPos = touch.touchPosition;

        Ray myRay = cam.ScreenPointToRay(touchPos);
        RaycastHit hit;

        if (Physics.Raycast(myRay, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.CompareTag("Grass"))
            {
                Debug.Log("Hello");
                Instantiate(plant, hit.transform.position, Quaternion.identity);
            }
        }


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
