using UnityEngine;
using UnityEngine.SceneManagement;

public class shopmenu : MonoBehaviour
{
    public Stats Playerstats = new Stats();

    bool swordclick = false;
    bool bowclick = false;
    bool hammerclick = false;
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
    public void OnSwordClicked()
    {
        Debug.Log("sword");
        if (hammerclick == true) 
        {
            hammerclick = false; 
            Playerstats.Atk -= 20f;
            Playerstats.Speed += 20f;
        }
        if (bowclick == true)
        {
            bowclick = false;
            Playerstats.Hp += 20f;
            Playerstats.Range -= 20f;
        }
        if (swordclick == false)
        {
            Playerstats.Atk -= 20f;
            Playerstats.Speed += 20f;
            swordclick = true;
            //soll visuell anzeigen, welche weapon ausgewählt ist
        }
    }
    public void OnBowClicked()
    {
        Debug.Log("bow");
        if (swordclick == true) 
        { 
            swordclick = false;
            Playerstats.Atk += 20f;
            Playerstats.Speed -= 20f;
        }
        if(hammerclick== true)
        {  
            hammerclick = false;
            Playerstats.Atk -= 20f;
            Playerstats.Speed += 20f;
        }
        if (bowclick == false)
        {
            Playerstats.Hp -= 20f;
            Playerstats.Range += 20f;
            bowclick = true;
        }
    }
    public void OnHammerClicked()
    {
        Debug.Log("hammer");
        if (swordclick == true)
        {
            swordclick = false;
            Playerstats.Atk += 20f;
            Playerstats.Speed -= 20f;
        }
        if (bowclick == true)
        {
            bowclick = false;
            Playerstats.Hp += 20f;
            Playerstats.Range -= 20f;
        }
        if (hammerclick == false)
        {
           
            Playerstats.Atk += 20f;
            Playerstats.Speed -= 20f;
            hammerclick = true;
        }
    }
    public void OnNextlevelClick() 
    {
        if (DefaultStats.Instance != null)
        {
            DefaultStats.Instance.savedStats.CopyFrom(Playerstats);
        }
        SceneManager.LoadScene("Plantcare");
    }

    // angeklickte Armor-> stats werden aktualiert
    //armor mit random  value
    //visuelle anzeige


}
