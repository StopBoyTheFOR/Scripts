using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    public int health = 5;
    public int level = 2;
    public string name = "Cube";

    public float speed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        //���� ���� ���� ��������� ���������� �������� �������� � �������� � �������
        print("�������� ������: " + health);
        health += level;
        print("�������� ������: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
