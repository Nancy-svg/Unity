using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class z3 : MonoBehaviour
{
    private float posx, posy, posz;
    public GameObject Player; //Объект игрок
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        posx = Player.transform.position.x+1;
        posy = Player.transform.position.y;
        posz = Player.transform.position.z;
        transform.position = new Vector3(posx, posy, posz);
    }
}
