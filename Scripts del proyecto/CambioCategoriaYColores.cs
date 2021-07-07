using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioCategoriaYColores : MonoBehaviour
{
    private bool ArtesaniaCategory = false;
    private bool MarcasCategory = false;
    private bool CafeCategory = false;
    private bool MielCategory = false;
    private bool CacaoCategory = false;
    private bool HerbolariaCategory = false;
    private bool CuidadoPielCategory = false;

    [Header("Barras de la app")]
    public GameObject Barra1;
    public GameObject Barra2;
    public GameObject BarraMenuLateral;
    public GameObject SearchButton;

    [Header("obj de los botones categorias")]
    public GameObject BTNMarca;
    public GameObject BTNArtesania;


    [Header("Pantalla de cada categoria")]
    public GameObject PantallaArtesania;
    public GameObject PantallaMarca;
    public GameObject PantallaCafe;
    public GameObject PantallaMiel;
    public GameObject PantallaCacao;
    public GameObject PantallaHerbolaria;
    public GameObject PantallaPiel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void FixedUpdate()
    {
        // -------------------

        // -------------------- CATEGORIA ARTESANÍA -----------------------------
        if (ArtesaniaCategory == true)
        {
            PantallaArtesania.SetActive(true);
            Barra1.GetComponent<RawImage>().color = new Color32(99, 101, 105, 255);
            Barra2.GetComponent<RawImage>().color = new Color32(99, 101, 105, 255);
            BarraMenuLateral.GetComponent<RawImage>().color = new Color32(99, 101, 105, 255);
            SearchButton.GetComponent<Image>().color = new Color32(63, 65, 72, 255);
        }
        else
        {
            PantallaArtesania.SetActive(false);
        }
        // ----------------------------------------------------------------------

        // -------------------- CATEGORIA MARCAS --------------------------------
        if (MarcasCategory == true)
        {
            PantallaMarca.SetActive(true);
            Barra1.GetComponent<RawImage>().color = new Color32(189, 154, 95, 255);
            Barra2.GetComponent<RawImage>().color = new Color32(189, 154, 95, 255);
            BarraMenuLateral.GetComponent<RawImage>().color = new Color32(189, 154, 95, 255);
            SearchButton.GetComponent<RawImage>().color = new Color32(164, 163, 83, 255);
        }
        else
        {
            PantallaMarca.SetActive(false);
        }
        // ----------------------------------------------------------------------

        // ---------------- CATEGORIA CAFÉ ---------------------------------------
        if (CafeCategory == true)
        {
            PantallaCafe.SetActive(true);
            Barra1.GetComponent<RawImage>().color = new Color32(189, 154, 95, 255);
            Barra2.GetComponent<RawImage>().color = new Color32(189, 154, 95, 255);
            BarraMenuLateral.GetComponent<RawImage>().color = new Color32(189, 154, 95, 255);
            SearchButton.GetComponent<RawImage>().color = new Color32(179, 154, 95, 255);
        }
        else
        {
            PantallaCafe.SetActive(false);
        }
        // -----------------------------------------------------------------------

        // ---------------- CATEGORIA MIEL ---------------------------------------
        if (MielCategory == true)
        {
            PantallaMiel.SetActive(true);
            Barra1.GetComponent<RawImage>().color = new Color32(252, 175, 26, 255);
            Barra2.GetComponent<RawImage>().color = new Color32(252, 175, 26, 255);
            BarraMenuLateral.GetComponent<RawImage>().color = new Color32(252, 175, 26, 255);
            SearchButton.GetComponent<RawImage>().color = new Color32(242, 175, 26, 255);
        }
        else
        {
            PantallaMiel.SetActive(false);
        }
        // -----------------------------------------------------------------------

        // ---------------- CATEGORIA CACAO ---------------------------------------
        if (CacaoCategory == true)
        {
            PantallaCacao.SetActive(true);
            Barra1.GetComponent<RawImage>().color = new Color32(50, 62, 72, 255);
            Barra2.GetComponent<RawImage>().color = new Color32(50, 62, 72, 255);
            BarraMenuLateral.GetComponent<RawImage>().color = new Color32(50, 62, 72, 255);
            SearchButton.GetComponent<Image>().color = new Color32(40, 62, 72, 255);
        }
        else
        {
            PantallaCacao.SetActive(false);
        }
        // -----------------------------------------------------------------------

        // ---------------- CATEGORIA HERBOLARIA ---------------------------------------
        if (HerbolariaCategory == true)
        {
            PantallaHerbolaria.SetActive(true);
            Barra1.GetComponent<RawImage>().color = new Color32(117, 123, 99, 255);
            Barra2.GetComponent<RawImage>().color = new Color32(117, 123, 99, 255);
            BarraMenuLateral.GetComponent<RawImage>().color = new Color32(117, 123, 99, 255);
            SearchButton.GetComponent<Image>().color = new Color32(107, 123, 99, 255);
        }
        else
        {
            PantallaHerbolaria.SetActive(false);
        }
        // -----------------------------------------------------------------------

        // ---------------- CATEGORIA CUIDADO DE LA PIEL ---------------------------------------
        if (CuidadoPielCategory == true)
        {
            PantallaPiel.SetActive(true);
            Barra1.GetComponent<RawImage>().color = new Color32(255, 11, 74, 255);
            Barra2.GetComponent<RawImage>().color = new Color32(255, 11, 74, 255);
            BarraMenuLateral.GetComponent<RawImage>().color = new Color32(255, 11, 74, 255);
            SearchButton.GetComponent<Image>().color = new Color32(245, 11, 74, 255);
        }
        else
        {
            PantallaPiel.SetActive(false);
        }
        // -----------------------------------------------------------------------


        if (ArtesaniaCategory == false && MarcasCategory == false && CafeCategory == false && MielCategory == false
            && CacaoCategory == false && HerbolariaCategory == false && CuidadoPielCategory == false)
        {

            Barra1.GetComponent<RawImage>().color = new Color32(189, 154, 95, 255);
            Barra2.GetComponent<RawImage>().color = new Color32(189, 154, 95, 255);
            BarraMenuLateral.GetComponent<RawImage>().color = new Color32(189, 154, 95, 255);
            SearchButton.GetComponent<RawImage>().color = new Color32(164, 163, 83, 255);
        }
        // -------------------

    }

    public void BTNARTESANIA_PRECIONAR()
    {
        ArtesaniaCategory = !ArtesaniaCategory;

        MarcasCategory = false;
        CafeCategory = false;
        MielCategory = false;
        CacaoCategory = false;
        HerbolariaCategory = false;
        CuidadoPielCategory = false;

    }

    public void BTNMARCAS_PRECIONAR()
    {
        MarcasCategory = !MarcasCategory;

        CafeCategory = false;
        CuidadoPielCategory = false;
        ArtesaniaCategory = false;
        MielCategory = false;
        CacaoCategory = false;
        HerbolariaCategory = false;
    }

    public void BTNCAFE_PRECIONAR()
    {
        CafeCategory = !CafeCategory;

        MielCategory = false;
        ArtesaniaCategory = false;
        MarcasCategory = false;
        CacaoCategory = false;
        HerbolariaCategory = false;
        CuidadoPielCategory = false;
    }

    public void BTNMIEL_PRECIONAR()
    {
        MielCategory = !MielCategory;

        CacaoCategory = false;
        ArtesaniaCategory = false;
        MarcasCategory = false;
        CafeCategory = false;
        HerbolariaCategory = false;
        CuidadoPielCategory = false;
    }

    public void BTNCACAO_PRECIONAR()
    {
        CacaoCategory = !CacaoCategory;

        ArtesaniaCategory = false;
        MarcasCategory = false;
        CafeCategory = false;
        MielCategory = false;
        HerbolariaCategory = false;
        CuidadoPielCategory = false;
    }

    public void BTNHERBOLARIA_PRECIONAR()
    {
        HerbolariaCategory = !HerbolariaCategory;

        ArtesaniaCategory = false;
        MarcasCategory = false;
        CafeCategory = false;
        MielCategory = false;
        CacaoCategory = false;
        CuidadoPielCategory = false;
    }

    public void BTNCUIDADOPIEL_PRECIONAR()
    {
        CuidadoPielCategory = !CuidadoPielCategory;

        ArtesaniaCategory = false;
        MarcasCategory = false;
        CafeCategory = false;
        MielCategory = false;
        CacaoCategory = false;
        HerbolariaCategory = false;
    }
}
