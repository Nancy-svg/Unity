using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NewBehaviourScript1 : MonoBehaviour
{

    public Vector3 newpos;
    public Vector3 newposold;
    public RaycastHit hit;
    public float _speed;
    public GameObject obj;
    float time = 0;
    void Start()
    {
        newpos = new Vector3(0, 0, 0);
        _speed  = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                
                newpos = new Vector3(hit.point.x, 1.5f, hit.point.z);
                newposold = new Vector3(hit.point.x, 1.5f, hit.point.z);
            }

        }
        obj.transform.LookAt(newposold);
        obj.transform.position = Vector3.Lerp(obj.transform.position, newpos, Time.deltaTime * _speed);

        /*
        if (_speed < 1)
        {
            _speed += 0.001f;
            obj.transform.Translate = new Vector3(hit.point.x * _speed, 1.5f, hit.point.z * _speed);
        }
        */
    }  
}
