using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public bool isPushed = false;
    public GameObject spawner;
    public GameObject ball;

    [Header("Button Color Change")]
    public Material defaultMaterial;
    public Material newMaterial;
    private MeshRenderer myMr;
    private void OnCollisionEnter(Collision collision)
    {
        if (!isPushed)
        {
            Debug.Log("Button was pushed");
            isPushed = true;
            StartCoroutine(ButtonReset());
            Instantiate(ball, spawner.transform.position, spawner.transform.rotation);

        }
    }

    IEnumerator ButtonReset()
    {
        yield return new WaitForSeconds(5);
        isPushed = false;
    }
}
