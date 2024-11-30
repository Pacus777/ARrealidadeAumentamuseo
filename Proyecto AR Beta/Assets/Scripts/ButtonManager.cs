using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ButtonManager : MonoBehaviour
{

    private string itemName;
    public Sprite itemImage;
    public string itemDescription;
    public GameObject item3DModel;
    private ARscripManager scripManager;



    public string ItemName{
        set
        {
            itemName = value;
        }
    }
    
    public string ItemDescription { set => itemDescription = value; }
    public Sprite ItemImage { set => itemImage = value; }
    public GameObject Item3DModel { set => item3DModel = value; }

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = itemName;
        transform.GetChild(2).GetComponent<RawImage>().texture = itemImage.texture;
        transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = itemDescription;

        var button = GetComponent<Button>();
        button.onClick.AddListener(GameManager.instance.ARposition);
        button.onClick.AddListener(Create3DModel);

        scripManager = FindObjectOfType<ARscripManager>();
    }

    private void Create3DModel()
    {
       Instantiate(item3DModel);
    
    }


}
