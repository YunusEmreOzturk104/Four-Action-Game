using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DortIslem : MonoBehaviour
{
    public TextMeshProUGUI ilkSayi,ikinciSayi,islem,cevap,sonuc;
  
    int sayi1, sayi2, islemIsareti;
    int islemSonucu;
    void Start()
    {
        YeniSoru();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CevapKontrol()
    {
       
        if (int.Parse(cevap.text) == islemSonucu )//int.Parse(cevap.text) ile stringi inteegýra cevirir
        {
            sonuc.text = "DOGRU";
        }
        else
        {
            sonuc.text = "YANLÝS";
        }
    }
    public void YeniSoru()
    {
        cevap.text = "";
        sayi1 = Random.Range(1, 10);
        sayi2 = Random.Range(1, 10);
        islemIsareti = Random.Range(1, 5);
        switch (islemIsareti)
        {
            case 1:
                islem.text = "+";
                islemSonucu = sayi1 + sayi2;
                break;
            case 2:
                islem.text = "-";
                islemSonucu = sayi1 - sayi2;
                break;
            case 3:
                islem.text = "*";
                islemSonucu = sayi1 * sayi2;
                break;
            case 4:
                islem.text = "/";
                islemSonucu = sayi1 / sayi2;
                break;
        }

        ilkSayi.text = sayi1.ToString();//stringe cevirme
        //ikinciSayi.text = sayi2 + "";//stringe cevirme
        ikinciSayi.text = sayi2.ToString();
    }
}
