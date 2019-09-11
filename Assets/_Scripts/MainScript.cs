using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    public Transform Player;
    public GameObject PauseMenuUI;
    public GameObject CoinUi;
    public GameObject Hint;
    public static int Coins = 0;
    public Vector3 CurrentPos;
    public int SIndx;

    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene(0);
        PausedMenu.PauseMenuUI = PauseMenuUI;
        CurrentPos = new Vector3 { x = Player.position.x, y = Player.position.y, z = Player.position.z };
        //SIndx = 
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausedMenu.GameIsPaused)
            {
                PausedMenu.resume();
            }
            else
            {
                PausedMenu.Pause();
            }
        }

        CoinUi.GetComponent<Text>().text = $"Coins: {Coins.ToString()}";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            Coins++;
        }
        else if(other.gameObject.CompareTag("Water"))
        {
            Player.position = CurrentPos;
        }
        else if (other.gameObject.CompareTag("Platform"))
        {
             CurrentPos = Player.position;
        }
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
        Debug.Log("Saved");
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadData();

        SceneManager.LoadScene(data.SIndx);

        Player.transform.position = new Vector3 { x = data.Pos[0], y = data.Pos[1], z = data.Pos[2] };
        CurrentPos = Player.transform.position;
    }
}
