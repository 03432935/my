using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject prompt;  //那个J提示图标
    private Door m_Door;
    private bool enterCollide = false;
    // Start is called before the first frame update
    public void Show(GameObject prompt)
    {
        prompt.SetActive(true);
    }
    public void Hide(GameObject prompt)
    {
        prompt.SetActive(false);
    }
    void Start()
    {
        m_Door = GameObject.Find("DoorShaft").GetComponent<Door>();
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("enter");
        Show(prompt);
        enterCollide = true;
       
    }

    void OnTriggerExit(Collider collider)
    {
        Debug.Log("exit");
        Hide(prompt);
        enterCollide = false;
    }


    void Update()
    {
        if (enterCollide)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                if (m_Door.GetIsOpen())
                {
                    m_Door.CloseDoorMethod();

                }
                else
                {
                    m_Door.OpenDoorMethod();
                }
            }
        }


    }
}
