using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text life;
    int lives = 3;

    public void lifeLost()
    {
        lives--;
        life.text = lives.ToString();
    }
}
