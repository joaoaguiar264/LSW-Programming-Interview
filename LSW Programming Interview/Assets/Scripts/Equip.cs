using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Equip : MonoBehaviour
{
    public Clothes BlShirt;
    public Clothes RShirt;
    public Clothes YShirt;

    public Clothes BlPants;
    public Clothes RPants;
    public Clothes YPants;

    public Clothes BlShoes;
    public Clothes RShoes;
    public Clothes YShoes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Choose()
    {
        if(this.gameObject.GetComponentInChildren<Text>().text == "Black Shirt")
        {
            Player.blackShirt = true;
            Player.redShirt = false;
            Player.yellowShirt = false;
        }
        else if(this.gameObject.GetComponentInChildren<Text>().text == "Red Shirt")
        {
            Player.redShirt = true;
            Player.blackShirt = false;
            Player.yellowShirt = false;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Yellow Shirt")
        {
            Player.yellowShirt = true;
            Player.redShirt = false;
            Player.blackShirt = false;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Black Pants")
        {
            Player.blackPants = true;
            Player.redPants = false;
            Player.yellowPants = false;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Red Pants")
        {
            Player.redPants = true;
            Player.blackPants = false;
            Player.yellowPants = false;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Yellow Pants")
        {
            Player.yellowPants = true;
            Player.redPants = false;
            Player.blackPants = false;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Black Shoes")
        {
            Player.blackShoes = true;
            Player.redShoes = false;
            Player.yellowShoes = false;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Red Shoes")
        {
            Player.redShoes = true;
            Player.blackShoes = false;
            Player.yellowShoes = false;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Yellow Shoes")
        {
            Player.yellowShoes = true;
            Player.redShoes = false;
            Player.blackShoes = false;
        }
    }

    public void Sell()
    {
        if(Shop.sell == true)
        {
            Destroy(this.gameObject);
            if (this.gameObject.GetComponentInChildren<Text>().text == "Black Shirt")
            {
                Inventory.Instance.Remove(BlShirt);
                Player.coins += 500;
                if(Player.blackShirt == true)
                {
                    Player.blackShirt = false;
                    Player.defaultShirt = true;
                }
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Red Shirt")
            {
                Inventory.Instance.Remove(RShirt);
                Player.coins += 500;
                if (Player.redShirt == true)
                {
                    Player.redShirt = false;
                    Player.defaultShirt = true;
                }
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Yellow Shirt")
            {
                Inventory.Instance.Remove(YShirt);
                Player.coins += 500;
                if (Player.yellowShirt == true)
                {
                    Player.yellowShirt = false;
                    Player.defaultShirt = true;
                }
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Black Pants")
            {
                Inventory.Instance.Remove(BlPants);
                Player.coins += 300;
                if (Player.blackPants == true)
                {
                    Player.blackPants = false;
                    Player.defaultPants = true;
                }
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Red Pants")
            {
                Inventory.Instance.Remove(RPants);
                Player.coins += 300;
                if (Player.redPants == true)
                {
                    Player.redPants = false;
                    Player.defaultPants = true;
                }
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Yellow Pants")
            {
                Inventory.Instance.Remove(YPants);
                Player.coins += 300;
                if (Player.yellowPants == true)
                {
                    Player.yellowPants = false;
                    Player.defaultPants = true;
                }
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Black Shoes")
            {
                Inventory.Instance.Remove(BlShoes);
                Player.coins += 850;
                if (Player.blackShoes == true)
                {
                    Player.blackShoes = false;
                    Player.defaultShoes = true;
                }
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Red Shoes")
            {
                Inventory.Instance.Remove(RShoes);
                Player.coins += 850;
                if (Player.redShoes == true)
                {
                    Player.redShoes = false;
                    Player.defaultShoes = true;
                }
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Yellow Shoes")
            {
                Inventory.Instance.Remove(YShoes);
                Player.coins += 850;
                if (Player.yellowShoes == true)
                {
                    Player.yellowShoes = false;
                    Player.defaultShoes = true;
                }
            }
        }
    }

}
