using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnShoot : MonoBehaviour
{
    [SerializeField] public float Number;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Rasho Laser")
        {
            Debug.Log(Number);
        }
    }

}
