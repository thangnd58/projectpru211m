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
    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate<GameObject>(InfrantryEnermyPrefab, posGround, Quaternion.identity);
        Instantiate<GameObject>(AirForceEnermyPrefab, posAirForce, Quaternion.identity);
        Instantiate<GameObject>(RobotEnermyPrefab, posGround, Quaternion.identity);
        Instantiate<GameObject>(TankEnermyPrefab, posGround, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
