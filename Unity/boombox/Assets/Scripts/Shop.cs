using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [System.Serializable] class ShopItem
    {
        public Sprite Image;
        public int Price;
        public bool IsPurchased = false;
    }
    [SerializeField] List<ShopItem> ShopItemsList;
    GameObject ItemTemplate;
    GameObject g;
    [SerializeField] Transform ShopScrollView;
    Button buyBtn; 
    // Start is called before the first frame update
    void Start()
    {
        ItemTemplate = ShopScrollView.GetChild (0).gameObject;
        int len = ShopItemsList.Count;
        for (int i = 0; i < len; i++)
        {
            g = Instantiate(ItemTemplate, ShopScrollView);
            g.transform.GetChild(0).GetComponent <Image> ().sprite = ShopItemsList [i].Image;
            g.transform.GetChild(1).GetChild (0).GetComponent <Text>().text = ShopItemsList [i].Price.ToString ();
            buyBtn = g.transform.GetChild(2).GetComponent<Button>();
            buyBtn.interactable = !ShopItemsList [i].IsPurchased;
            int index = i;
            //buyBtn.GetComponent<Button>().onClick.AddEventListener(() => {
                //ItemClicked(index);
            //});
        }

        Destroy(ItemTemplate);
    }
    void OnShopItemBtnClicked(int itemIndex)
    {
        Debug.Log(itemIndex);
    }
}
