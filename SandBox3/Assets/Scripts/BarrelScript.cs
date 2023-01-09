using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BarrelScript : MonoBehaviour
{ 

  //  public GameObject Player;
//public PlayerController playercontroller;

    public int m_gallons;
    public int m_size;

    public void fill(int gallons)
    {
        m_gallons += gallons;

        if (m_gallons > m_size)
            m_gallons = m_size;
    //gameObject.transform.localScale += new Vector3(0, 0, m_gallons);
    }
    public void drain(int gallons)
    {
        m_gallons -= gallons;

        if (m_gallons < 0)
            m_gallons = 0;
   // gameObject.transform.localScale -= new Vector3(0, 0, m_gallons);
}
    // Start is called before the first frame update
    void Start()
    {
       
    }
     void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        Debug.Log(movementVector.x + "," + movementVector.y);

        if (movementVector.y == 1)
            fill((int)(m_size * 0.1));

        if (movementVector.y == -1)
            drain((int)(m_size * 0.1));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
