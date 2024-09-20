using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int EnemiesDefeated;
    public int DrainsBlocked;

    public int TotalEnemies = 0;
    public int TotalDrains = 0;

    public Text enemiesDefeatedText;
    public Text drainsBlockedText;

    public int FinalScore;
    // Start is called before the first frame update
    void Start()
    {
        EnemiesDefeated = 0;
        DrainsBlocked = 0;

        FinalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        enemiesDefeatedText.text = "Enemies Defeated: " + EnemiesDefeated.ToString() + "/" + TotalEnemies.ToString();
        drainsBlockedText.text = "Drains Blocked: " + DrainsBlocked.ToString(); //+ "/" + TotalDrains.ToString(); //outside ones
    }

    public void CalcFinalScore()
    {
        FinalScore = EnemiesDefeated * 2 + DrainsBlocked;
    }
}
