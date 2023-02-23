using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountNumber : MonoBehaviour
{
    int count = 0;

    private void OnMouseDown()
    {
        count++;
        print("Count : " + count);
        print(count + " 번 눌렸습니다.");
    }
}
