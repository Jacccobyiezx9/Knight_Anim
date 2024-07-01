using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightControls : MonoBehaviour
{
    public Animator knight;
    // Start is called before the first frame update
    void Start()
    {
        knight = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            knight.SetBool("Run", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            knight.SetBool("Run", false);
        }
        while (Input.GetKeyDown(KeyCode.Space))
        {
            knight.SetBool("Attack", true);
        }
    }
}
