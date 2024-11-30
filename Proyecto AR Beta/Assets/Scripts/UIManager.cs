using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class UIManager : MonoBehaviour
{

// Creacion de los GameObjects de la interfaz

    [SerializeField] private GameObject MainMenuCanvas;
    [SerializeField] private GameObject ItemsMenuCanvas;
    [SerializeField] private GameObject ARPositionCanvas;

    // Start is called before the first frame update
    void Start()
    {
        //suscribiendo a los eventos del GameManager y creando funciones

        GameManager.instance.onMainMenu += ActivatedMainMenu;
        GameManager.instance.onItemsMenu += ActivatedItemsMenu;
        GameManager.instance.onARPosition += ActivatedArPosition;
    }

    private void ActivatedMainMenu()
    {

        //el menu principal se activa y da el efecto al entrar y salir

        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1,1,1), 0.3f );
        MainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1,1,1), 0.3f );
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1,1,1), 0.3f );


        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0), 0.5f );
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0), 0.5f );
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0), 0.3f );
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0), 0.3f );

    }

    private void ActivatedItemsMenu()
    {
        // vista de los objetos que llegaran a mostrarse


        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0), 0.3f );
        MainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0), 0.3f );
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0,0,0), 0.3f );


        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1,1,1), 0.5f );
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1,1,1), 0.5f );
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);

    }

    private void ActivatedArPosition()
    {
        //seleccion de objeto que se va a mostrar



        MainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0), 0.3f );
        MainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0), 0.3f );
        MainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0,0,0), 0.3f );

        ItemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0,0,0), 0.5f );
        ItemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0,0,0), 0.5f );
        ItemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1,1,1), 0.3f );
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1,1,1), 0.3f );



    }




}
