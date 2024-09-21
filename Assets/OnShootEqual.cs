using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class OnShootEqual : MonoBehaviour
{
    public static bool equallActivated;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Rasho Laser")
        {
            equallActivated = true;
        }
        else
        {
            equallActivated = false;
        }
    }
}
