using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i=1; i<= 10; i++)
        {
            Debug.Log("10���ӹ��" + i + "Ÿ!");
        }

        int fireTime = 5;
        while (fireTime > 0)
        {
            Debug.Log("���� �پ� ���� 5�� �Ծ���!(���ӽð�" + fireTime + "�� ����)");
            fireTime--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
