using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour
{
    [SerializeField] bool isPlayingGuitar;
    [SerializeField] int age;
    // Start is called before the first frame update
    void Start()
    {
        if (isPlayingGuitar == true)
        {
            Debug.Log("��Ÿ ���� �� ����~");
        }
        else
        {
            Debug.Log("��Ÿ ���� ���ϴ� ��...");
        }

        if (age == 20)
        {
            Debug.Log("���б� ���Ի��̱���!");
        }
        else if(age>= 21)
        {
            Debug.Log("���б� ���Ի��� �ƴϱ���!");
        }
        else
        {
            Debug.Log("� ģ��");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
