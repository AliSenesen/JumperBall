using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public GameObject mySplash;
    private GameManager gm;

    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }


    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)  
    {
        rb.AddForce(Vector3.up * jumpForce );
        GameObject splash = Instantiate(mySplash, transform.position+new Vector3(0,-.2f,0), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        

     
   



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DangerZone")
        {
            gm.RestartGame();
        }
    }
}
