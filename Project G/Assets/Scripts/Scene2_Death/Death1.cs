using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death1 : MonoBehaviour
{

    [SerializeField] GameObject Player;
    [SerializeField] private AudioSource deathsound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Player)
        {
            Player.transform.position = new Vector3(-1f, 0f, 0f);
        deathsound.Play();
        }
    }
}
