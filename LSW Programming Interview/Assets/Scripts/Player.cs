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

        //Shirts
        if (blackShirt)
        {
            shirt.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 255f);
            blackShirt = false;
        }

        if (redShirt)
        {
            shirt.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 0f, 0f, 255f);
            redShirt = false;
        }

        if (yellowShirt)
        {
            shirt.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 0f, 255f);
            yellowShirt = false;
        }

        //Pants

        if (blackPants)
        {
            pants.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 255f);
            blackPants = false;
        }

        if (redPants)
        {
            pants.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 0f, 0f, 255f);
            redPants = false;
        }

        if (yellowPants)
        {
            pants.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 0f, 255f);
            yellowPants = false;
        }

        //Shoes

        if (blackShoes)
        {
            shoes.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 255f);
            blackShoes = false;
        }

        if (redShoes)
        {
            shoes.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 0f, 0f, 255f);
            redShoes = false;
        }

        if (yellowShoes)
        {
            shoes.gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 0f, 255f);
            yellowShoes = false;
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
