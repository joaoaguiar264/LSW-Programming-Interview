using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public static float coins = 6000;
    public Text coinsText;

    public bool buyRange;

    public static bool dialogOn;

    public static bool defaultShirt = true;
    public static bool defaultPants = true;
    public static bool defaultShoes = true;

    public static bool redShirt;
    public static bool yellowShirt;
    public static bool blackShirt;

    public static bool redPants;
    public static bool yellowPants;
    public static bool blackPants;

    public static bool redShoes;
    public static bool yellowShoes;
    public static bool blackShoes;

    public GameObject shirt;
    public GameObject pants;
    public GameObject shoes;

    public GameObject welcomeDialog;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // WEAR CLOTHES

        //Defaults
        if (defaultShirt)
        {
            shirt.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, 255f);
            defaultShirt = false;
        }

        if (defaultPants)
        {
            pants.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, 255f);
            defaultPants = false;
        }

        if (defaultShoes)
        {
            shoes.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, 255f);
            defaultShoes = false;
        }

        //Shirts
        if (blackShirt)
        {
            shirt.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 255f);
            
        }

        if (redShirt)
        {
            shirt.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 0f, 0f, 255f);
            
        }

        if (yellowShirt)
        {
            shirt.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 0f, 255f);
            
        }

        //Pants

        if (blackPants)
        {
            pants.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 255f);
        }

        if (redPants)
        {
            pants.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 0f, 0f, 255f);
        }

        if (yellowPants)
        {
            pants.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 0f, 255f);
        }

        //Shoes

        if (blackShoes)
        {
            shoes.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 255f);
        }

        if (redShoes)
        {
            shoes.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 0f, 0f, 255f);
        }

        if (yellowShoes)
        {
            shoes.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 0f, 255f);
        }


        if (buyRange)
        {
            Shop.buyKeyActive = true;
            if (Input.GetKey(KeyCode.E))
            {
                Shop.dialogActive = true;
                Shop.shopActive = true;
            }
        }
        else
        {
            Shop.buyKeyActive = false;
            Shop.shopActive = false;
            Shop.dialogActive = false;
        }

        coinsText.text = coins.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BuyArea")
        {
            buyRange = true;
        }

        if (collision.gameObject.tag == "dialog")
        {
            welcomeDialog.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BuyArea")
        {
            buyRange = false;
        }

        if (collision.gameObject.tag == "dialog")
        {
            welcomeDialog.SetActive(false);
        }
    }


}
