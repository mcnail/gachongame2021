using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //��������
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //��������
        //Ű���� a(-1), d(+1)�� �̿��ؼ� ���� �Է��ϰڴ�
        float h = Input.GetAxis("Horizontal");
        //������ �����Ѵ�
        Vector3 dir = new Vector3(h, 0, 0);
        //������ ������ �÷��̾� ������Ʈ�� �̵���Ű�ڴ�
        //P = p0 + vt
        //transform.Translate(dir * speed * Time.deltaTime);
        //transform.position = transform.position + dir * speed * Time.deltaTime;
        transform.position += dir * speed * Time.deltaTime;
    }
}
