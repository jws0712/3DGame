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

        Debug.Log("0 번 학생의 점: " + students[0]);
        Debug.Log("1 번 학생의 점: " + students[1]);
        Debug.Log("2 번 학생의 점: " + students[2]);
        Debug.Log("3 번 학생의 점: " + students[3]);
        Debug.Log("4 번 학생의 점: " + students[4]);
        //반복문
        //bool isDead = false;
        //int hp = 100;

        //while (!isDead)
        //{
        //    Debug.Log("현재 체력 : " + hp);

        //    hp = hp - 33;

        //    if(hp <= 0)
        //    {
        //        isDead = true;
        //        Debug.Log("플레이어는 죽었습니다.");
        //    }
        //}
        //int i = 0;

        //while(i < 10)
        //{
        //    Debug.Log(i + " 번째 루프입니다.");
        //    i++;
        //}
        //int i;

        //for(i = 0; i < 10; i++)
        //{
        //    Debug.Log(i + " 번째 순번입니다.");
        //}
        //Debug.Log(i);
        //논리 연산자
        //int age = 11;

        //if(age > 7 && age < 18)
        //{
        //    Debug.Log("의무 교육을 받고 있습니다.");
        //}

        //if(age < 13 || age > 70)
        //{
        //    Debug.Log("일을 할 수 없는 나이입니다.");
        //}
        //if문 연습
        //int love = 80;

        //if(love > 90)
        //{
        //    Debug.Log("트루엔딩: 히로인과 결혼했다!");
        //}
        //else if(love > 70)
        //{
        //    Debug.Log("굿엔딩: 히로인과 사귀게 되었다!");
        //}
        //else
        //{
        //    Debug.Log("배드엔딩: 히로인에게 차였다.");
        //}

        //두점 사이의 거리 구하기
        //float distance = GetDistance(2, 2, 5, 6);
        //Debug.Log("(2,2)에서 (5,6)까지의 거리 : " + distance);

        //캐릭터의 프로필을 변수로 만들기
        //string characterName = "라라";
        //char bloodType = 'A';
        //int age = 17;
        //float height = 168.3f;
        //bool isFemale = true;

        //Debug.Log("캐릭터 이름 :" + characterName);
        //Debug.Log("혈액형 :" + bloodType);
        //Debug.Log("나이 :" + age);
        //Debug.Log("키 :" + height);
        //Debug.Log("여성인가? :" + isFemale);

        // Debug.Log("Hello World");
    }

    //두점 사이의 거리 구하기
    //float GetDistance(float x1, float y1, float x2, float y2)
    //{
    //    float width = x2 - x1;
    //    float height = y2 - y1;

    //    float distance = width * width + height * height;
    //    distance = Mathf.Sqrt(distance);

    //    return distance;
    //}
}
