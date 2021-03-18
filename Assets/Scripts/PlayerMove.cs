using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //전역변수
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //지역변수
        //키보드 a(-1), d(+1)를 이용해서 값을 입력하겠다
        float h = Input.GetAxis("Horizontal");
        //방향을 설정한다
        Vector3 dir = new Vector3(h, 0, 0);
        //설정된 방향대로 플레이어 오브젝트를 이동시키겠다
        //P = p0 + vt
        //transform.Translate(dir * speed * Time.deltaTime);
        //transform.position = transform.position + dir * speed * Time.deltaTime;
        transform.position += dir * speed * Time.deltaTime;
    }
}
