using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public int coins;
    public TMP_Text coinUI;
    public ShopItemSO[] shopItemsSO;
    public GameObject[] shopPanelsGO;
    public ShopTemplate[] shopPanels;
    public Button[] myPurchaseBtns;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < shopItemsSO.Length; i++){
            shopPanelsGO[i].SetActive(true);
        }
        coinUI.text = "Coins: " + coins.ToString();
        LoadPanels();
        CheckPurchaseable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddCoins(int amount)
    {
        coins ++;
        coinUI.text = "Coins: " + coins.ToString();
        CheckPurchaseable();
    }

    public void LoadPanels(){
        for (int i = 0; i < shopItemsSO.Length ; i++){
            shopPanels[i].tilteTxt.text = shopItemsSO[i].title;
            shopPanels[i].descriptionTxt.text = shopItemsSO[i].description;
            shopPanels[i].costTxt.text = shopItemsSO[i].baseCost.ToString();
        }
    }

    public void CheckPurchaseable(){
        for (int i = 0; i < shopItemsSO.Length; i++){
            if (coins >= shopItemsSO[i].baseCost)
                myPurchaseBtns[i].interactable = true;
            else
                myPurchaseBtns[i].interactable = false;
        }
    }

    public void PurchaseItem(int btnNo){
        if (coins > shopItemsSO[btnNo].baseCost){
            coins = coins - shopItemsSO[btnNo].baseCost;
            coinUI.text = "Coins: " + coins.ToString();
            CheckPurchaseable();
        }
    }
}
