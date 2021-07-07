using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using UnityEngine.UI;

public class IniciarSesionScript : MonoBehaviour
{
    public GameObject PantallaIniciarSesion;
    public GameObject FirstScene;
    public GameObject SecondScene;
    public GameObject Texto_email;
    public GameObject Texto_pass;
    public string Email;
    public string Pass;
    
    // Start is called before the first frame update
    void Start()
    {



        FirstScene.SetActive(false);
        SecondScene.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenIniciarSesionMenu()
    {
        PantallaIniciarSesion.SetActive(true);
        ChangeToFirstScene();
        Texto_email.GetComponent<Text>().text = "";
        Texto_pass.GetComponent<Text>().text = "";

    }

    public void CloseIniciarSesionMenu()
    {
        PantallaIniciarSesion.SetActive(false);

    }
    public void ChangeToSecondScene()
    {
        FirstScene.SetActive(false);
        SecondScene.SetActive(true);
    }

    public void ChangeToFirstScene()
    {
        FirstScene.SetActive(true);
        SecondScene.SetActive(false);
    }


    public void IniciarSesion()
    {
        Email = Texto_email.GetComponent<Text>().text;
        Pass = Texto_pass.GetComponent<Text>().text;

        IniciarConeccion();
    }


    // METODOS PARA ABRIR LA CONEXION Y CONECTAR CON LA BASE DE DATOS

    public void IniciarConeccion()
    {
        string connStr = "server=localhost; user=root; database=Obiodb; port=3306; password=";
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {
            Debug.Log("Conectando con el servidor...");
            conn.Open();

            string sql = "SELECT Us_email, pass FROM Usuarios WHERE Usuario='" + Email + "' AND pass= '" + Pass + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader Resultado = cmd.ExecuteReader();

            if (Resultado.Read())
            {
                Debug.Log("Login exitoso");
            }

        }
        catch (Exception ex)
        {
            Debug.Log("No se puede conectar al servidor, verifique los datos de conexion" + ex.ToString());
        }

        conn.Close();
        Debug.Log("Done.");
    }

}
