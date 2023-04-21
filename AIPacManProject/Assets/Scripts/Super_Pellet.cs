using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider2D))]
public class Super_Pellet : MonoBehaviour
{
   
    public int points = 20;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {
            eat();
        }
    }

    protected virtual void eat()
    {
        FindObjectOfType<GM_PackMan>().super_pelleteaten(this);
    }
}
