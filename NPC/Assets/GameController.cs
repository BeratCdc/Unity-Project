using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI kalansayi;
    public TextMeshProUGUI navkalansayi;
    public GameObject GameOverPanel;
    public int kalansayideger;
    public int navkalansayideger;
    public GameObject olusacaknesne;
    public GameObject navmeshengel;
    public Image Healthbar;
    private float health;
    public GameObject[] noktalar;
    public Button[] butoniptal;
    public Button[] butoniptal2;
    
    void Start()
    {
        health = 100;
        kalansayideger = 30;
        navkalansayideger = 5;
        kalansayi.text = kalansayideger.ToString();
        navkalansayi.text = navkalansayideger.ToString();
    }

    void Update()
    {
        
    }
    void butonkontrol()
    {
        foreach (var gelenbuton in butoniptal2)
        {
            if (kalansayideger == 0)
            {
                gelenbuton.interactable = false;
            }
        }
    }
    void navbutonkontrol()
    {
        foreach (var gelenbuton in butoniptal)
        {
            if (navkalansayideger == 0)
            {
                gelenbuton.interactable = false;
            }
        }
    }
    public void NoktaButonlari(int indisler)
    {
        kalansayideger--;
        kalansayi.text = kalansayideger.ToString();
        Instantiate(olusacaknesne, noktalar[indisler].transform.position,Quaternion.identity);
        butonkontrol();
    }
    public void NavNoktaButonlari(int indisler)
    {
        navkalansayideger--;
        navkalansayi.text = navkalansayideger.ToString();
        Instantiate(navmeshengel, noktalar[indisler].transform.position, Quaternion.identity);
        navbutonkontrol();
    }
    public void CanDusur(float darbe)
    {
        health -= darbe;
        
        Healthbar.fillAmount = health/100;
        
        if (health <= 0)
        {
            GameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
