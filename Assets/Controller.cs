using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject Cube;
    public GameObject ExampleCube;
    public Transform SpawnPoint;
    public bool ScriptObject = true;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ScriptObject = !ScriptObject;
        }

        if (ScriptObject)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!(Cube == null))
                    Cube.SetActive(true);
                //Instant();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (!(Cube == null))
                    Cube.SetActive(false);

            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(Cube);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {   
                if(Cube == null)
                {
                    Cube = Instantiate(ExampleCube, SpawnPoint.position, SpawnPoint.rotation);
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!(Cube == null || Cube.GetComponent<MeshRenderer>() == null))
                {
                    Cube.GetComponent<MeshRenderer>().enabled = true;
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (!(Cube == null || Cube.GetComponent<MeshRenderer>() == null)) {
                    Cube.GetComponent<MeshRenderer>().enabled = false;
                }
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(Cube.GetComponent<MeshRenderer>());
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                if (!(Cube == null) && Cube.GetComponent<MeshRenderer>() == null) {
                    MeshRenderer render = Cube.AddComponent<MeshRenderer>();
                    render.material = ExampleCube.GetComponent<MeshRenderer>().sharedMaterial;
                }
            }
        }

    }
}

