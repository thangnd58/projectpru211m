using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class GenerateEnermy : MonoBehaviour
{
    private static Vector2 posGround = new Vector2(9f,-4.55f);
    private static Vector2 posAirForce = new Vector2(9f, 3.5f);
    
    [SerializeField]
    GameObject InfrantryEnermyPrefab;
    [SerializeField]
    GameObject AirForceEnermyPrefab;
    [SerializeField]
    GameObject RobotEnermyPrefab;
    [SerializeField]
    GameObject TankEnermyPrefab;

    Timer timer;
    GenerateRound generateRound;
    List<GameObject> listEnermy;

    int countRound;


    double countPower;
    // Start is called before the first frame update
    void Start()
    {
        countRound = 1; 
        countPower = 0;
        listEnermy = new List<GameObject>();
        listEnermy.Add(InfrantryEnermyPrefab);
        listEnermy.Add(AirForceEnermyPrefab);
        listEnermy.Add(RobotEnermyPrefab);
        listEnermy.Add(TankEnermyPrefab);

        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 2f;
        timer.run();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.Finished)
        {
            if(countPower.CompareTo(generateRound.generateTotalEnemy(countRound)) >0)
            {
                spawnEnermy();
                Debug.Log(countPower);
            }
            else
            {
                Debug.Log("Done");
                if(listEnermy.Count == 0)
                {
                    countPower = 0;
                    countRound++;
                }
            }
            
            timer.run();
            
        }
    }

    public void spawnEnermy()
    {
        int site = Random.Range(0,listEnermy.Count);
        if (listEnermy[site] == AirForceEnermyPrefab)
        {
            countPower += 3;
            Instantiate<GameObject>(AirForceEnermyPrefab, posAirForce, Quaternion.identity);
        }
        else if (listEnermy[site] == InfrantryEnermyPrefab)
        {
            countPower += 1;
            Instantiate<GameObject>(InfrantryEnermyPrefab, posGround, Quaternion.identity);
        }
        else if (listEnermy[site] == RobotEnermyPrefab)
        {
            countPower += 7;
            Instantiate<GameObject>(RobotEnermyPrefab, posGround, Quaternion.identity);

        }
        else if (listEnermy[site] == TankEnermyPrefab)
        {
            countPower += 10;
            Instantiate<GameObject>(TankEnermyPrefab, posGround, Quaternion.identity);
        }
    }
}
