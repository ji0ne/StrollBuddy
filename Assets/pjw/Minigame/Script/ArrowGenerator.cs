using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
   public GameObject arrowPrefab;
   //Prefab ���� �̸� ������ ���� ����Ƽ���� ������ Prefab �̸���
   //�����ϰ� ���������
   float span = 1.0f; //1.0f�� 1�ʷ� ����
   float delta = 0;

   void Update()
   {
      this.delta += Time.deltaTime;
      //deltaTime�� �����Ӱ� ������ ������ �ð�
      //1�ʿ� 1000�� ���� �����Ӱ� ������ ������ �ð��� 0.001��
      if (this.delta > this.span) //this.delta�� 1�ʰ� �Ǹ�
      {
         this.delta = 0; //delta�� 0���� ���� -> 1�ʸ��� ��� �ݺ��ǰ�
         GameObject go = Instantiate(arrowPrefab);      
         int px = Random.Range(-3, 3);
         go.transform.position = new Vector3(px, 7, 0);
      }
   }
}
