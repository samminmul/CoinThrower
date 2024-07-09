using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinStatusChecker : MonoBehaviour
{
    [HideInInspector] public bool isFallenOver = false;

    private bool touchedGround = false;
    private const float yPosCriterionOfFallenOver = 1f;
    [SerializeField] private float waitingSeconds = 15f;
    Transform tr;
    Rigidbody rb;

    private void Awake()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Ground":
                if (!touchedGround)
                {
                    rb.velocity = Vector3.zero;
                    StartCoroutine(FallenOverCheck());
                    touchedGround = true;
                    Debug.Log("touched");
                }
                break;
        }
    }

    IEnumerator FallenOverCheck()
    {
        yield return new WaitForSeconds(waitingSeconds);
        isFallenOver = (tr.position.y < yPosCriterionOfFallenOver);
        Debug.Log(isFallenOver);

        if (isFallenOver)
        {
            CoinCounter coinCounter = FindObjectOfType<CoinCounter>();
            coinCounter.AddFallenCoinsCount(1);
        }
    }
}
