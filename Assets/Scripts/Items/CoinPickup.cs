using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPickup : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animator.SetTrigger("destroy");
            StartCoroutine(DestroyCoin());
        }
    }

    IEnumerator DestroyCoin()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
        GameManager.Instance.AddCoins(30);
    }
}
