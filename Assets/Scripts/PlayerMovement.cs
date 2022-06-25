using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000F;
    public float sidewaysForce = 500F;


    /**
     * 该方法固定时间更新 用于存放与物理相关代码
     * 
     * 区别于 Update() 按每帧更新，帧率会影响函数执行频率
     */
    private void FixedUpdate()
    {
        // 添加前进力
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey("a")) rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}