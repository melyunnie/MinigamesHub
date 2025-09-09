using UnityEngine;
using UnityEngine.SceneManagement;

public class shopmenu : MonoBehaviour
{
    public Stats Playerstats;
    bool swordclick = false;
    bool bowclick = false;
    bool hammerclick = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnSwordClicked()
    {
        Debug.Log("sword");
        // alte stats werden übernommen/ resettet bei jeden weaponclick
        bowclick = false;
        hammerclick = false;
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
        swordclick = false;
        hammerclick = false;
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
        swordclick = false;
        bowclick = false;

        if (hammerclick == false)
        {
            Playerstats.Atk += 20f;
            Playerstats.Speed -= 20f;
            hammerclick = true;
        }
    }
    public void OnNextlevelClick() 
    {
        // klick next level-> stats werden übernommen
        SceneManager.LoadScene("Plantcare");
        //levelcount

    }
    
    // angeklicktes item-> stats werden aktualiert

    //stats müssen noch auf den spieler übertragen werden und vorherige stats sollen übernommen werden
   
    

}
