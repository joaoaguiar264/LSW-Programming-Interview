using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;
    public List<Clothes> Clothes = new List<Clothes> ();

    public Transform content;
    public GameObject inventoryClothes;

    public GameObject inventory;
    public GameObject inventoryItems;


    void Start()
    {
        Instance = this;
    }

    public void Add(Clothes clothes)
    {
        Clothes.Add(clothes);
    }

    public void Remove(Clothes clothes)
    {
        Clothes.Remove(clothes);
    }

    public void ListClothes()
    {
        foreach(Transform item in content)
        {
            Destroy(item.gameObject);
        }

        foreach(var clothes in Clothes)
        {
            GameObject obj = Instantiate(inventoryClothes, content);
            var clothingName = obj.transform.Find("ItemName").GetComponent<Text>();
            var clothingIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            clothingName.text = clothes.itemName;
            clothingIcon.sprite = clothes.icon;
        }
    }

    public void Close()
    {
        inventory.SetActive(false);
        inventoryItems.SetActive(false);
    }

    public void OpenInventory()
    {
        inventory.SetActive(true);
        inventoryItems.SetActive(true);
    }


}
