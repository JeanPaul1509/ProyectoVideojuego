using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float velocidad;
    public int nroPelotas = 0;
    private bool recogioPelota = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")* velocidad, 0, Input.GetAxis("Vertical")* velocidad);
        transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "objeto")

        {

            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            if (recogioPelota == false)
            {
                recogioPelota = true;
                nroPelotas = nroPelotas + 1;
                Debug.Log("Puntos :"+ nroPelotas);
                StartCoroutine(activar());
        }
    }

}
    IEnumerator activar()

    {
        yield return new WaitForSeconds(0.1f);
        recogioPelota = false;


    }
    }
