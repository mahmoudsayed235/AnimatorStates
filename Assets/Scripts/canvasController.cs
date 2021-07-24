using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasController : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
    }


    public void exit()
    {
        Application.Quit();
    }
}
