using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NewBehaviourScript : MonoBehaviour
{

    private Animator myAnimator;
    private float distance;
    public Transform target;
    private bool k;
    private float timer;
     void Start()
    {

        myAnimator = GetComponent<Animator>();
        k = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        distance = Vector3.Distance(target.position, transform.position);
        if(distance > 10 || k == true)
        {

            myAnimator.Play("Armature|Action");
        }
        if (distance < 10 && k == false)
        {
            timer += Time.deltaTime;
            myAnimator.Play("Armature|sssi");
            if (timer > 4)
            {
                k = true;
            }
        }
    }
}
