using UnityEngine;
using System.Collections.Generic;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform levelPart_Start;
    [SerializeField] private List<Transform> levelPartList;
    [SerializeField] private List<Transform> BonusPartList;
    [SerializeField] private newgirl newgirl;
    [SerializeField] private newredbot newredbot;
    [SerializeField] private newopp newopp;
    /// //////
    public GameObject Background1;
    public GameObject Background2;
    public GameObject Background3;
    public GameObject BackgroundBonusTime;
    public GameObject Floor1;
    public GameObject Floor2;
    public GameObject Floor3;
    public GameObject FloorBonusTime;
    //////////
    private readonly string SelectedCharacter = "SelectedCharacter";
    private readonly string Timescale = "Timescale";
    int Characteruse3;
    private Vector3 PositionChar;
    private Vector3 lastEndPosition;
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 100f;

    /// //////////////

    int spawntime;

    private void Awake()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetFloat("Timescale", Time.timeScale);
        spawntime = 1;
        lastEndPosition = levelPart_Start.Find("EndPosition").position;
        Characteruse3 = PlayerPrefs.GetInt(SelectedCharacter);
    }
    private void Update()
    {
        switch (Characteruse3)
        {
            case 1:
                PositionChar = newopp.GetPosition1();
                break;
            case 2:
                PositionChar = newgirl.GetPosition2();
                break;
            case 3:
                PositionChar = newredbot.GetPosition3();
                break;
            default:
                PositionChar = newgirl.GetPosition2();
                break;
        }
        if (Vector3.Distance(PositionChar, lastEndPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART && (spawntime % 5 != 0))
        {
            if (Time.timeScale <= 1.6)
            {
                Time.timeScale += 0.05f;
                PlayerPrefs.SetFloat("Timescale", Time.timeScale);
            }
            SpawnLevelPart();
            spawntime++;
        }
        if (Vector3.Distance(PositionChar, lastEndPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART && (spawntime % 5 == 0))
        {
            BonusLevelPart();
            spawntime++;
        }
    }
    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }
    private void BonusLevelPart()
    {
        Transform chosenLevelPart = BonusPartList[Random.Range(0, BonusPartList.Count)];
       Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }    
    private Transform SpawnLevelPart (Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
