using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hub1FD2 : MonoBehaviour
{

    [SerializeField] GameObject Player;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            Player.transform.position = new Vector3(21f, 17f, 0f);
        }
    }
}
