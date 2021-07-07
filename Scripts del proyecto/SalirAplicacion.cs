using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalirAplicacion : MonoBehaviour
{
    public GameObject ZonaGris;
    public GameObject MenuOpciones;
    // Start is called before the first frame update
    private void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape) && ZonaGris.activeSelf==false)
            {
                Application.Quit();
                //return;
            }
            if(Input.GetKey(KeyCode.Escape) && MenuOpciones.GetComponent<Animator>().GetBool("Activar") == true)
            {
                ZonaGris.SetActive(false);
                MenuOpciones.GetComponent<Animator>().SetBool("Activar", false);

            }
        }
    }
}
