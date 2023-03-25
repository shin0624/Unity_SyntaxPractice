using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{
    public AudioSource collisionSound; // 오디오 소스에 접근하기 위한 변수

    void Start()
    {
        collisionSound = GetComponent<AudioSource>(); //인스펙터 뷰에 추가한 오디오 소스 컴포넌트를 코드로 가져와 제어하는 데 필요
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        collisionSound.Play();//오디오 소스에 연결된 음향 효과 파일 재생
        print("충돌이 발생했습니다.");
    }
}
