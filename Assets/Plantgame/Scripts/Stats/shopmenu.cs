using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shopmenu : MonoBehaviour
{
    public Stats Playerstats = new Stats();
    public List<Stats> statsListe = new List<Stats>();


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
        Debug.Log("bressed");
        int randomIndex = Random.Range(0, 5);
        
       Debug.Log("");

        //random range
        //Anzeige der werte
        // wenn was anderers selectet reset
       
    }
    public void OnItem2Clicked()
    {
        //random range
        //Anzeige der werte
        // wenn was anderers selectet reset
    }
    public void OnItem3Clicked()
    {
        //random range
        //Anzeige der werte
        // wenn was anderers selectet reset
    }
    public void OnItem4Clicked()
    {
        //random range
        //Anzeige der werte
        // wenn was anderers selectet reset
    }
    public void OnItem5Clicked()
    {
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
