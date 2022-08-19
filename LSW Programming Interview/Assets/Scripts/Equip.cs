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
        }
        else if(this.gameObject.GetComponentInChildren<Text>().text == "Red Shirt")
        {
            Player.redShirt = true;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Yellow Shirt")
        {
            Player.yellowShirt = true;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Black Pants")
        {
            Player.blackPants = true;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Red Pants")
        {
            Player.redPants = true;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Yellow Pants")
        {
            Player.yellowPants = true;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Black Shoes")
        {
            Player.blackShoes = true;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Red Shoes")
        {
            Player.redShoes = true;
        }
        else if (this.gameObject.GetComponentInChildren<Text>().text == "Yellow Shoes")
        {
            Player.yellowShoes = true;
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
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Red Shirt")
            {
                Inventory.Instance.Remove(RShirt);
                Player.coins += 500;
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Yellow Shirt")
            {
                Inventory.Instance.Remove(YShirt);
                Player.coins += 500;
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Black Pants")
            {
                Inventory.Instance.Remove(BlPants);
                Player.coins += 300;
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Red Pants")
            {
                Inventory.Instance.Remove(RPants);
                Player.coins += 300;
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Yellow Pants")
            {
                Inventory.Instance.Remove(YPants);
                Player.coins += 300;
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Black Shoes")
            {
                Inventory.Instance.Remove(BlShoes);
                Player.coins += 850;
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Red Shoes")
            {
                Inventory.Instance.Remove(RShoes);
                Player.coins += 850;
            }
            else if (this.gameObject.GetComponentInChildren<Text>().text == "Yellow Shoes")
            {
                Inventory.Instance.Remove(YShoes);
                Player.coins += 850;
            }
        }
    }

}
