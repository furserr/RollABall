using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour {

    Rigidbody fizik;
    public int hiz;
    int sayac;
    public int toplamMat;
    public Text sayacText;
    public Text oyunBitti;

    // Use this for initialization
    void Start()
    {
       
        fizik = GetComponent<Rigidbody>();
        sayac = 0;


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vec*hiz);


    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "engel")
        {
            Destroy(other.gameObject);
            sayac++;

            sayacText.text = "Score : " + sayac;

            if (sayac == toplamMat)
            {
                oyunBitti.text = "Game Over!";
            }
        }

    }
}
