using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] private TMP_Text Bullets_Text;
    [SerializeField] private TMP_Text Life_Text;
    [SerializeField] private TMP_Text Keys_Text;
    [SerializeField] private float MaxTime;
    private string Bullets_String;
    private string Timer_String;
    private string Keys_String;
    public float PlayerLifes;
    public int Bullets;
    public int Keys;
    public HUD hud;
    public bool GameOver = false;
    public GameObject Player;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    void Start()
    {
        Bullets = 9;
        PlayerLifes = 100;
    }

    void Update()
    {
        MaxTime -= Time.deltaTime;
        float minutes = Mathf.FloorToInt(MaxTime / 60);
        float seconds = Mathf.FloorToInt(MaxTime % 60);
        Timer_String = minutes.ToString("00") + ":" + seconds.ToString("00");

        if (MaxTime <= 0)
        {
            MaxTime = 0;
            GameOver = true;
            SceneManager.LoadScene(2);
        }
        if (PlayerLifes <= 0)
        {
            SceneManager.LoadScene(2);
        }
        LifeHP();
    }

    public void AmmoBullets()
    {
        Bullets_Text.text = Bullets.ToString() + "/40 Bullets";
    }

    public string BulletsString()
    {
        return Bullets_String;
    }
    public void KeysCount()
    {
        Keys_Text.text = Keys.ToString() + "/20 Keys";
    }
    
    public string KeysString()
    {
        return Keys_String;
    }

    public string GetTimerString()
    {
        return Timer_String;
    }

    public void LifeHP()
    {
        Life_Text.text = PlayerLifes.ToString();
    }
    
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void KillBox()
    {
        PlayerLifes = 0;
        SceneManager.LoadScene(0);
    }
}
