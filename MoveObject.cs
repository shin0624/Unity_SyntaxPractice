using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    float speed = 20F;
    
    void Start()
    {

    }

    void Update()
    {
        float position = Input.GetAxis("Vertical");
        position= position * speed*Time.deltaTime;
        //input = 입력장치 입력을 받을 수 있음 ,GetAxis = 입력 축을 가져옴 --> getaxis("vertical) = 세로방향의 위, 아래 방향키(0 눌리지 않을 때 / 1 위 / -1 아래)      
        //어떤 방향키를 누르는 지에 따라 position값이 양수인지 음수인지 결정 ,>position(움직이는 방향), speed(움직이는 속도) , Time.deltaTime(프레임 간격 시간)
        transform.Translate(Vector3.forward * position);
        //Translate 메서드 = 오브젝트의 위치 변경 , Vector3 = 3차원 오브젝트의 좌표값을 갖는 클래스 , forward = z축으로 1만큼 이동하라는 의미.
        //-->position값을 곱하므로, 방향키를 안누르면(position = 0) 움직이지 않다가, 어떤 버튼을 누르는지에 따라 z축의 방향이 양, 음의 방향으로 움직임.
      

    }
}
