using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureManager : MonoBehaviour
{
    public GameObject[] furniturePrefabs;
    public static int s_likeability;

    public RectTransform imageTransform; // 2D �̹����� RectTransform�� ����

    enum furnitureKinds { closet, bed, dressingTable, chair, table, empty }
    private bool[] furnitureRewarded = new bool[5]; // ������ �־��� ���¸� �����ϴ� �迭

    public void addLikeability()
    {
        s_likeability++;
        Debug.Log(s_likeability);
        rewardFurniture();
        UpdateImageWidth(); // �̹��� ũ�� ������Ʈ
    }

    void rewardFurniture()
    {
        furnitureKinds reward = switchFurnitures(s_likeability);
        Debug.Log("���� :  " + reward);

        switch (reward)
        {
            case furnitureKinds.empty:
                Debug.Log("���� ������ �����ϴ�.");
                break;

            case furnitureKinds.closet:
                if (!furnitureRewarded[(int)furnitureKinds.closet])
                {
                    Instantiate(furniturePrefabs[0], new Vector3(3, 2.5f, 3), Quaternion.identity);
                    furnitureRewarded[(int)furnitureKinds.closet] = true;
                }
                break;

            case furnitureKinds.bed:
                if (!furnitureRewarded[(int)furnitureKinds.bed])
                {
                    Instantiate(furniturePrefabs[1], new Vector3(0, 0, 0), Quaternion.identity);
                    furnitureRewarded[(int)furnitureKinds.bed] = true;
                }
                break;

            case furnitureKinds.dressingTable:
                if (!furnitureRewarded[(int)furnitureKinds.dressingTable])
                {
                    Instantiate(furniturePrefabs[2], new Vector3(-3, 0, 2.5f), Quaternion.identity);
                    furnitureRewarded[(int)furnitureKinds.dressingTable] = true;
                }
                break;

            case furnitureKinds.chair:
                if (!furnitureRewarded[(int)furnitureKinds.chair])
                {
                    Instantiate(furniturePrefabs[3], new Vector3(-1.5f, 0.8f, -2.5f), Quaternion.identity);
                    furnitureRewarded[(int)furnitureKinds.chair] = true;
                }
                break;

            case furnitureKinds.table:
                if (!furnitureRewarded[(int)furnitureKinds.table])
                {
                    Instantiate(furniturePrefabs[4], new Vector3(-3, 0, -8.5f), Quaternion.identity);
                    furnitureRewarded[(int)furnitureKinds.table] = true;
                }
                break;

            default:
                Debug.Log("�� �� ���� ���� �����Դϴ�.");
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

    void UpdateImageWidth()
    {
        if (imageTransform != null)
        {
            // ���� ���̸� ������Ű�� ���� ���� Width�� s_likeability�� ����
            imageTransform.sizeDelta = new Vector2(imageTransform.sizeDelta.x + s_likeability, imageTransform.sizeDelta.y);
        }
    }
}
