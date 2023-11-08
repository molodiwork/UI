using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
   public GameObject Main;
   public GameObject Win;
   public GameObject Lose;
    public void MenuStart()
    {
        Main.SetActive(false);
        Win.SetActive(true);
    }
    public void MenuMain()
    {
        Win.SetActive(false);
        Main.SetActive(true);
    }
    
    public void MenuLose()
    {
        Win.SetActive(false);
        Lose.SetActive(true);
    }
    public void WatchResult()
    {
        Lose.SetActive(false);
    }
}
