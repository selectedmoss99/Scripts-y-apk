using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control_MenuPrincipal : MonoBehaviour
{

    public GameObject animButton01;
    public GameObject ZonaAntiTouch01;
    
    public GameObject IniciarSesion01;
    public GameObject IniciarSesion02;
    public GameObject IniciarSesionEmailTXT;
    public GameObject IniciarSesionPassTXT;

    public GameObject InicioExitoso;

    public GameObject IMGProfile_Huron;
    public GameObject TXT_MensajeMenu1;
    public GameObject TXT_MensajeMenu2;

    public GameObject ItemVender;

    [Header("GameObjects de el submenu Options")]
    public bool CambioSubMenu;
    public GameObject BTNsubmenu;
    public GameObject SubMenuPadre;
    public GameObject SubMenuHijo;


    private Animator anim01;

    // Start is called before the first frame update
    void Start()
    {
        CambioSubMenu = false;
        anim01 = animButton01.GetComponent<Animator>();
        IniciarSesionEmailTXT.GetComponent<Text>().text = "";
        IniciarSesionPassTXT.GetComponent<Text>().text = "";
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ABRIR_MENU_OPCIONES()
    {
        anim01.SetBool("Activar", true);
        ZonaAntiTouch01.SetActive(true);
    }

    public void TOCAR_ZONA_ANTITOUCH()
    {
        anim01.SetBool("Activar", false);
        ZonaAntiTouch01.SetActive(false);
    }

    public void IniciarSesionExitoso()
    {
        InicioExitoso.GetComponent<Animator>().SetBool("Activo", true);

        IniciarSesion01.GetComponent<Animator>().SetBool("Activo", false);
        IniciarSesion02.GetComponent<Animator>().SetBool("Activo", false);

        IMGProfile_Huron.SetActive(true);
        TXT_MensajeMenu1.GetComponent<Text>().text = "Bienvenido a la plataforma";
        TXT_MensajeMenu2.GetComponent<Text>().text = "¿Qué vamos a hacer hoy?";

        ItemVender.SetActive(true);
    }

    public void IniciarSesion_inicio_Pantallas()
    {

        IniciarSesion01.GetComponent<Animator>().SetBool("Activo", true);
        IniciarSesion02.GetComponent<Animator>().SetBool("Activo", false);

        IniciarSesionEmailTXT.GetComponent<Text>().text = "";
        IniciarSesionPassTXT.GetComponent<Text>().text = "";
    }

    public void IniciarSesion_Change_Pantalla2()
    {
        if(IniciarSesionEmailTXT.GetComponent<Text>().text != "" || IniciarSesionEmailTXT.GetComponent<Text>().text != "")
        {
            IniciarSesion01.GetComponent<Animator>().SetBool("Activo", false);
            IniciarSesion02.GetComponent<Animator>().SetBool("Activo", true);

        }
    }

    public void IniciarSesion_Change_Pantalla1()
    {
        if (IniciarSesionEmailTXT.GetComponent<Text>().text != "" || IniciarSesionEmailTXT.GetComponent<Text>().text != "")
        {
            IniciarSesion01.GetComponent<Animator>().SetBool("Activo", true);
            IniciarSesion02.GetComponent<Animator>().SetBool("Activo", false);

        }
    }

    public void IniciarSesionAtras()
    {
        IniciarSesion01.GetComponent<Animator>().SetBool("Activo", false);
        IniciarSesion02.GetComponent<Animator>().SetBool("Activo", false);
        InicioExitoso.GetComponent<Animator>().SetBool("Activo", false);
    }


    public void ActivarSubmenu()
    {
        CambioSubMenu = !CambioSubMenu;

        if(CambioSubMenu == true)
        {
            BTNsubmenu.GetComponent<Animator>().SetBool("Activo", true);
        }
        else
        {
            BTNsubmenu.GetComponent<Animator>().SetBool("Activo", false);
        }
        

        if (BTNsubmenu.GetComponent<Animator>().GetBool("Activo") == true)
        {
            SubMenuPadre.GetComponent<Animator>().SetBool("Activo", true);
            SubMenuHijo.GetComponent<Animator>().SetBool("Activo", true);

        }
        else
        {
            SubMenuPadre.GetComponent<Animator>().SetBool("Activo", false);
            SubMenuHijo.GetComponent<Animator>().SetBool("Activo", false);
        }
    }

}
