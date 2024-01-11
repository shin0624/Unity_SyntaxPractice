using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    void Start()
    {
        // GameObject go = GameObject.Find("@Managers");//게임오브젝트 객체 생성 후 @Managers를 찾아라-->부하가 심한 방법이기 떄문에 자주 사용x -->싱글톤 사용(*전역변수, static)
        //Managers mg = go.GetComponent<Managers>();//managers스크립트의 객체 생성.

        Managers mg = Managers.GetInstance();//Managers 클래스에서 GetInstance()를 사용하여, 전역변수로 선언된 @Managers의 instance 값을 가져온다
    
    
    }

    
    void Update()
    {
        
    }
}
