using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureManager : MonoBehaviour
{
    public GameObject[] furniturePrefabs;
    public static int s_likeability;

    enum furnitureKinds { closet, bed, dressingTable, chair, table, empty }

    public void addLikeability()
    {
        s_likeability++;
        Debug.Log(s_likeability);
        rewardFurniture();
    }



    void rewardFurniture()
    {
        furnitureKinds reward = switchFurnitures(s_likeability);
        Debug.Log("보상 :  " + reward);

        switch (reward)
        {
            case furnitureKinds.empty:
                Debug.Log("현재 보상이 없습니다.");
                break;

            case furnitureKinds.closet:
                Instantiate(furniturePrefabs[0], new Vector3(3, 2.5f, 3), Quaternion.identity);
                break;

            case furnitureKinds.bed:
                Instantiate(furniturePrefabs[1], new Vector3(0, 0, 0), Quaternion.identity);
                break;

         
            case furnitureKinds.dressingTable:
                Instantiate(furniturePrefabs[2], new Vector3(-3, 0, 2.5f), Quaternion.identity);
                break;

            case furnitureKinds.chair:
                Instantiate(furniturePrefabs[3], new Vector3(-1.5f, 0.8f, -2.5f), Quaternion.identity);
                break;

            case furnitureKinds.table:
                Instantiate(furniturePrefabs[4], new Vector3(-3, 0, -8.5f), Quaternion.identity);
                break;

            default:
                Debug.Log("알 수 없는 보상 종류입니다.");
                break;
        }
    }

    furnitureKinds switchFurnitures(int likeability)
    {
        if (likeability >= 50)
        {
            return furnitureKinds.table;

        }
        else if (likeability >= 40)
        {
            return furnitureKinds.chair;
            
        }
        else if (likeability >= 30)
        {
            return furnitureKinds.dressingTable;
           
        }
        else if (likeability >= 20)
        {
            return furnitureKinds.bed;
            
        }
        else if (likeability >= 10)
        {
            return furnitureKinds.closet;
            
        }
        else
        {
            return furnitureKinds.empty;
        }
    }
}
