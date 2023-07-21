using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI_Bird : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1.0f; // 移动速度
    public float amplitude = 1.0f; // y轴变化的振幅
    public AudioSource MyBGM;

    private float startY; // 初始y轴位置
    void Start()
    {
        // MyBGM.Play();
        startY = transform.position.y; // 获取初始y轴位置
    }

    // Update is called once per frame
    void Update()
    {
        // 计算新的y轴位置
        float newY = startY + amplitude * Mathf.Sin(speed * Time.time);

        // 将Transform组件的y轴位置设置为新的y轴位置
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene"); // 加载场景
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
