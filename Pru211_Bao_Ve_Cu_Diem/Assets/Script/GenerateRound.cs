using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRound : MonoBehaviour
{ 
    public double generateTotalEnemy(int rount)
    {
        double totalEnemy = 0;
        if(rount > 0)
        {
            totalEnemy = 47 * 1.5 * rount;
        }
        return totalEnemy;
    }
}
