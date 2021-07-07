using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscenaTouc : MonoBehaviour
{
    public string EscenaACargar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarEscenaAlTocar()
    {
        SceneManager.LoadScene(EscenaACargar);
        VariablesAGuardar.FirstLaunch = false;
        PlayerPrefs.SetInt("FirstLaunch", 1);
    }


}
