using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public float shirtPrice = 500;
    public float pantsPrice = 350;
    public float shoesPrice = 850;

    public static bool buyKeyActive;
    public GameObject buyKey;

    public static bool shopActive;
    public GameObject shop;

    public static bool dialogActive;
    public GameObject dialog;
    public GameObject dialog1;

    public GameObject Buy;
    public GameObject BuyTitle;
    public static bool buy = true;

    public GameObject Sell;
    public GameObject SellTitle;
    public static bool sell = false;
    public GameObject SellItems;

    public Text balance;

    public List<Text> Prices = new List<Text>();
    public Color priceColor;

    public Clothes BlShirt;
    public Clothes RShirt;
    public Clothes YShirt;

    public Clothes BlPants;
    public Clothes RPants;
    public Clothes YPants;

    public Clothes BlShoes;
    public Clothes RShoes;
    public Clothes YShoes;

    void Start()
    {
        priceColor =  Prices[0].color;
    }

    // Update is called once per frame
    void Update()
    {
        balance.text = Player.coins.ToString() + "$";
        if (buyKeyActive == true)
        {
            buyKey.SetActive(true);
        }
        else
        {
            buyKey.SetActive(false);
        }

    
        if (dialogActive == true)
        {
            StartCoroutine(ShopStarting());
            foreach(Text n in Prices)
            {
                n.color = priceColor;
            }
            Prices[0].text = "500$";
            Prices[1].text = "500$";
            Prices[2].text = "500$";
            Prices[3].text = "300$";
            Prices[4].text = "300$";
            Prices[5].text = "300$";
            Prices[6].text = "850$";
            Prices[7].text = "850$";
            Prices[8].text = "850$";
            dialogActive = false;
        }
        if(shopActive == false)
        {
            shop.SetActive(false);
        }

        if (shop.activeInHierarchy)
        {
            dialog.SetActive(false);
            buyKey.SetActive(false);
        }

        if(buy)
        {
            sell = false;
            Buy.SetActive(true);
            Sell.SetActive(false);
            BuyTitle.gameObject.GetComponent<Image>().color = new Color(144f, 144f, 144f, 255f);
            SellTitle.gameObject.GetComponent<Image>().color = new Color(202f, 202f, 202f, 255f);
           
        }
        if(sell)
        {
            buy = false;
            Buy.SetActive(false); 
            Sell.SetActive(true);
            SellItems.SetActive(true);
            BuyTitle.gameObject.GetComponent<Image>().color = new Color(202f, 202f, 202f, 255f);
            SellTitle.gameObject.GetComponent<Image>().color = new Color(144f, 144f, 144f, 255f);
        }

       
    }

    public void BuyPage()
    {
        buy = true;
        sell = false;
        SellItems.SetActive(false);
    }

    public void SellPage()
    {
        sell=true;
        buy = false;
    }

    IEnumerator ShopStarting()
    {
        dialog.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        dialog.SetActive(false);
        shop.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BuyArea")
        {
            buyKey.SetActive(true);
        }

        if(collision.gameObject.tag == "dialog")
        {
            dialog1.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

    }

    public void Close()
    {
        shop.gameObject.SetActive(false);
        SellItems.SetActive(false);
        sell = false;
    }

    public void BuyBlackShirt()
    {
         if (Player.coins >= shirtPrice)
        {
            Inventory.Instance.Add(BlShirt);
            Player.coins -= shirtPrice;
            Prices[0].text = "SOLD!";
            Prices[0].color = new Color(0,0,0,255f);
        }
    }
    public void BuyRedShirt()
    {
        if (Player.coins >= shirtPrice)
        {
            Inventory.Instance.Add(RShirt);
            Player.coins -= shirtPrice;
            Prices[1].text = "SOLD!";
            Prices[1].color = new Color(0, 0, 0, 255f);
        }
    }
    public void BuyYellowShirt()
    {
        if (Player.coins >= shirtPrice)
        {
            Inventory.Instance.Add(YShirt);
            Player.coins -= shirtPrice;
            Prices[2].text = "SOLD!";
            Prices[2].color = new Color(0, 0, 0, 255f);
        }
    }

    public void BuyBlackPants()
    {
        if (Player.coins >= pantsPrice)
        {
            Inventory.Instance.Add(BlPants);
            Player.coins -= pantsPrice;
            Prices[3].text = "SOLD!";
            Prices[3].color = new Color(0, 0, 0, 255f);
        }
    }
    public void BuyRedPants()
    {
        if (Player.coins >= pantsPrice)
        {
            Inventory.Instance.Add(RPants);
            Player.coins -= pantsPrice;
            Prices[4].text = "SOLD!";
            Prices[4].color = new Color(0, 0, 0, 255f);
        }
    }
    public void BuyYellowPants()
    {
        if (Player.coins >= pantsPrice)
        {
            Inventory.Instance.Add(YPants);
            Player.coins -= pantsPrice;
            Prices[5].text = "SOLD!";
            Prices[5].color = new Color(0, 0, 0, 255f);
        }
    }

    public void BuyBlackShoes()
    {
        if (Player.coins >= shoesPrice)
        {
            Inventory.Instance.Add(BlShoes);
            Player.coins -= shoesPrice;
            Prices[6].text = "SOLD!";
            Prices[6].color = new Color(0, 0, 0, 255f);
        }
    }
    public void BuyRedShoes()
    {
        if (Player.coins >= shoesPrice)
        {
            Inventory.Instance.Add(RShoes);
            Player.coins -= shoesPrice;
            Prices[7].text = "SOLD!";
            Prices[7].color = new Color(0, 0, 0, 255f);
        }
    }
    public void BuyYellowShoes()
    {
        if (Player.coins >= shoesPrice)
        {
            Inventory.Instance.Add(YShoes);
            Player.coins -= shoesPrice;
            Prices[8].text = "SOLD!";
            Prices[8].color = new Color(0, 0, 0, 255f);
        }
    }
}
