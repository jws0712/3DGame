using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCod : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] students = new int[5];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        Debug.Log("0 �� �л��� ��: " + students[0]);
        Debug.Log("1 �� �л��� ��: " + students[1]);
        Debug.Log("2 �� �л��� ��: " + students[2]);
        Debug.Log("3 �� �л��� ��: " + students[3]);
        Debug.Log("4 �� �л��� ��: " + students[4]);
        //�ݺ���
        //bool isDead = false;
        //int hp = 100;

        //while (!isDead)
        //{
        //    Debug.Log("���� ü�� : " + hp);

        //    hp = hp - 33;

        //    if(hp <= 0)
        //    {
        //        isDead = true;
        //        Debug.Log("�÷��̾�� �׾����ϴ�.");
        //    }
        //}
        //int i = 0;

        //while(i < 10)
        //{
        //    Debug.Log(i + " ��° �����Դϴ�.");
        //    i++;
        //}
        //int i;

        //for(i = 0; i < 10; i++)
        //{
        //    Debug.Log(i + " ��° �����Դϴ�.");
        //}
        //Debug.Log(i);
        //�� ������
        //int age = 11;

        //if(age > 7 && age < 18)
        //{
        //    Debug.Log("�ǹ� ������ �ް� �ֽ��ϴ�.");
        //}

        //if(age < 13 || age > 70)
        //{
        //    Debug.Log("���� �� �� ���� �����Դϴ�.");
        //}
        //if�� ����
        //int love = 80;

        //if(love > 90)
        //{
        //    Debug.Log("Ʈ�翣��: �����ΰ� ��ȥ�ߴ�!");
        //}
        //else if(love > 70)
        //{
        //    Debug.Log("�¿���: �����ΰ� ��Ͱ� �Ǿ���!");
        //}
        //else
        //{
        //    Debug.Log("��忣��: �����ο��� ������.");
        //}

        //���� ������ �Ÿ� ���ϱ�
        //float distance = GetDistance(2, 2, 5, 6);
        //Debug.Log("(2,2)���� (5,6)������ �Ÿ� : " + distance);

        //ĳ������ �������� ������ �����
        //string characterName = "���";
        //char bloodType = 'A';
        //int age = 17;
        //float height = 168.3f;
        //bool isFemale = true;

        //Debug.Log("ĳ���� �̸� :" + characterName);
        //Debug.Log("������ :" + bloodType);
        //Debug.Log("���� :" + age);
        //Debug.Log("Ű :" + height);
        //Debug.Log("�����ΰ�? :" + isFemale);

        // Debug.Log("Hello World");
    }

    //���� ������ �Ÿ� ���ϱ�
    //float GetDistance(float x1, float y1, float x2, float y2)
    //{
    //    float width = x2 - x1;
    //    float height = y2 - y1;

    //    float distance = width * width + height * height;
    //    distance = Mathf.Sqrt(distance);

    //    return distance;
    //}
}
