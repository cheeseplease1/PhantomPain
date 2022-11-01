using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalPart : MonoBehaviour
{

    public enum BodyType
    {
        Legs, Torso, Head
    }

    public BodyType Type;
    [Tooltip("Does the socket have an object attached to it?")]
    public bool Attached; 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetAttached() 
    {
        //Called on socket event, when bodypart enters socket range
        print("ENTERED!");

        
    }

    public void SetUnAttached()
    {
        print("EXITED!");

    }

    public void Selected()
    {
        print("SELECTED");
        Attached = true;
    }

    public void UnSelected()
    {
        print("UNSELECTED");
        Attached = false;
    }


    public void OnTriggerEnter(Collider other)
    {
        
    }

}
