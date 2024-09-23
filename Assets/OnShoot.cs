using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OnShoot : MonoBehaviour
{
    [SerializeField] public string character;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Rasho Laser")
        {
            Debug.Log(character);
            TheCalculator.currentInput += character;
        }
    }

}
