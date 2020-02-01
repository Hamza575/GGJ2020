using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultController : MonoBehaviour
{

    public  float catapult_speed ;
    public  int speed_multiplier;
    public Rigidbody Catapult_Rigidbody;
    private readonly float m_backwardsWalkScale = 0.33f;
    private readonly float m_backwardRunScale = 0.80f;
    public bool walk;
    private float m_currentV=0;
    private float m_currentH=0;
    private float m_interpolation=10;
    public float m_turnSpeed=200;

    // Start is called before the first frame update
    void Start()
    {
        Catapult_Rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovementUpdate();
    }

    private void MovementUpdate()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        //walk = Input.GetKey(KeyCode.LeftShift);

        if (v < 0)
        {
            if (walk) { v *= m_backwardsWalkScale; }
            else { v *= m_backwardRunScale; }
        }
        else if (walk)
        {
            v *= speed_multiplier;
        }

        m_currentV = Mathf.Lerp(m_currentV, v, Time.deltaTime * m_interpolation);
        m_currentH = Mathf.Lerp(m_currentH, h, Time.deltaTime * m_interpolation);

        transform.position += transform.forward * m_currentV * catapult_speed * Time.deltaTime;
        transform.Rotate(0, m_currentH * m_turnSpeed * Time.deltaTime, 0);

       // m_animator.SetFloat("MoveSpeed", m_currentV);

    }

}
