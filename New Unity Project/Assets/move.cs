using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class move : MonoBehaviour
{
    
    [SerializeField]
    private float speed = 1; //그냥 public 써도 상관 ㄴㄴ

    [Header("부드러운 움직임")]    //인스펙터에서 글자 보이게 하는거
    public bool smoothMovement;

    void Update()
    {
        Vector2 position = transform.position;

        /*밑에 코드도 좋은데 훨씬 간단히 하는 방법이 있음!
         * 
        if (Input.GetKey(KeyCode.A))
        {
            position.x += -0.1f * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            position.x += 0.1f * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            position.y += -0.1f * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            position.y += 0.1f * speed * Time.deltaTime;
        }
        */



        /*---------------------------------------------------------------
         * Input.GetAxisRaw("Horizontal"): D 누르면 1 반환, A 누르면 -1 반환
         * Input.GetAxisRaw("Vertical"): W 누르면 1 반환, S 누르면 -1 반환
         * 
         * Input.GetAxis는 1과 -1 사이를 부드럽게 움직임 (Edit/Project Settings/Input Manager/Axes 의 Horizontal 또는 Vertical 에서 Sensitivity를 통해 조정 가능)
         * 이거 읽어보면 좋음: https://m.blog.naver.com/PostView.nhn?blogId=dd1587&logNo=221041455817&proxyReferer=https:%2F%2Fwww.google.com%2F
         */
        if (!smoothMovement)    //딱딱한 움직임
        {
            position.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
            position.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        }
        else    //부드러운 움직임
        {
            position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            position.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        }
        
        transform.position = position;
    }
}
