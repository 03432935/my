
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animation ani;
    Transform tf;   
    private bool isOpen = false;
 
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
        ani = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
    }
    

    public void OpenDoorMethod()
    {
      //  tf.Rotate(Vector3.up, 70);
        Debug.Log("close");
        isOpen = !isOpen;
        ani.Play("DoorOpen");

    }
    public void CloseDoorMethod()
    {
     //   tf.Rotate(Vector3.up, -70);
        Debug.Log("open");
        isOpen = !isOpen;
        ani.Play("DoorClose");

    }
    public bool GetIsOpen()
    {
        return isOpen;
    }
    public void SetIsOpen(bool b)
    {
        isOpen = b;
    }
}
