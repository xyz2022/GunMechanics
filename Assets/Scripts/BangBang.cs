using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BangBang : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private GameObject chamber;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            FireGun();
        }  
    }

    private void FireGun()
    {
        Debug.Log("Bang");

        //Add code here for firing the gun.
        //Hint:
        //  [1] Instantiate a new bullet from the prefab using: GameObject b = Instantiate(bulletPrefab);
        //  [2] Set the position of the new bullet to the position of the chamber using:  b.transform.position = ...
        //  [3] Set the new bullet to active using: b.SetAct...

    }
}
