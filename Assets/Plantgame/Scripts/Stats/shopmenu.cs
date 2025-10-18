using System.Collections.Generic;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shopmenu : MonoBehaviour
{
    public Stats Playerstats = new Stats();

    [SerializeField] TMP_Text atktext;
    [SerializeField] TMP_Text deftext;
    [SerializeField] TMP_Text speedtext;
    [SerializeField] TMP_Text rangetext;
    [SerializeField] TMP_Text hptext;

    public static int pickaxt = 0;
    public static int kratzer = 0;
    public static int flamethrowerclick = 0;
    void Start()
    {
        if (DefaultStats.Instance != null)
        {
            Playerstats.CopyFrom(DefaultStats.Instance.savedStats);
        }
    }
    void Update()
    {

    }
    void Weaponsave()
    {
        //welche waffe ausgewählt war soll 1. übertragen werden
        //2. waffe soll als ausgewählt bleiben als defould
    }
    void UpdateStats() 
    {
        // boxen anzeigen/aktualieieren

    }
    public void OnPickaxtClicked()
    {
        Debug.Log("pickaxt");
        if (flamethrowerclick == 1) 
        {
            flamethrowerclick = 0; 
            Playerstats.Atk -= 20f;
            Playerstats.Speed += 20f;
        }
        if (kratzer == 1)
        {
            kratzer = 0;
            Playerstats.Hp += 20f;
            Playerstats.Range -= 20f;
        }
        if (pickaxt == 0)
        {
            Playerstats.Atk -= 20f;
            Playerstats.Speed += 20f;
            pickaxt = 1;
            //soll visuell anzeigen, welche weapon ausgew�hlt ist 1/3
        }
    }
    public void OnkratzerClicked()
    {
        Debug.Log("kratzer");
        if (pickaxt == 1) 
        {
            pickaxt = 0;
            Playerstats.Atk += 20f;
            Playerstats.Speed -= 20f;
        }
        if(flamethrowerclick == 1)
        {
            flamethrowerclick = 0;
            Playerstats.Atk -= 20f;
            Playerstats.Speed += 20f;
        }
        if (kratzer == 0)
        {
            Playerstats.Hp -= 20f;
            Playerstats.Range += 20f;
            kratzer = 1;
        }
    }
    public void OnFlamethrowerClicked()
    {
        Debug.Log("flamethrower");
        if (pickaxt == 1)
        {
            pickaxt= 0;
            Playerstats.Atk += 20f;
            Playerstats.Speed -= 20f;
        }
        if (kratzer == 1)
        {
            kratzer = 0;
            Playerstats.Hp += 20f;
            Playerstats.Range -= 20f;
        }
        if (flamethrowerclick == 0)
        {
           
            Playerstats.Atk += 20f;
            Playerstats.Speed -= 20f;
            flamethrowerclick = 1;
        }
    }

    public void OnItem1Clicked ()
    {
        Debug.Log("bressed 1");
        int randomIndex = Random.Range(0, 5);
        
        

        //random range
        //Anzeige der werte
        // wenn was anderers selectet reset
       
    }
    public void OnItem2Clicked()
    {
        Debug.Log("bressed 2");
        //random range
        //Anzeige der werte
        // wenn was anderers selectet reset
    }
    public void OnItem3Clicked()
    {
        Debug.Log("bressed 3");
        //random range
        //Anzeige der werte
        // wenn was anderers selectet reset
    }
    public void OnItem4Clicked()
    {
        Debug.Log("bressed 4");
        //random range
        //Anzeige der werte
        // wenn was anderers selectet reset
    }
    public void OnItem5Clicked()
    {
        Debug.Log("bressed 5");
        //random range
        //Anzeige der werte
        // wenn was anderers selectet reset

    }

    public void OnNextlevelClick() 
    {
        if (pickaxt==1| kratzer==1| flamethrowerclick == 1) 
        {
            if (DefaultStats.Instance != null)
            {
                DefaultStats.Instance.savedStats.CopyFrom(Playerstats);
            }

            SceneManager.LoadScene("Plantcare");
        }
    }

    // angeklickte Armor-> stats werden aktualiert
    //armor mit random  value
    //visuelle anzeige


}
