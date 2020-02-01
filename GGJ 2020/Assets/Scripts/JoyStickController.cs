using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class JoyStickController : MonoBehaviour {

    // Use this for initialization
    [SerializeField] GameObject[] Players;
    static List<int> joinPlayers;
    int playersNum;
    int losePlayers;
    public static JoyStickController singletone;
    static List<GameObject> attendedPlayers;
    [SerializeField] AudioClip hahaha;
	void Start () {
        singletone = this;
        if(attendedPlayers==null)
        {
            attendedPlayers = new List<GameObject>();
            joinPlayers = new List<int>();
        }
        else
        {
            playersNum = attendedPlayers.Count;
            for (int i = 0; i < attendedPlayers.Count; i++)
            {
                attendedPlayers[i].transform.position = Players[i].transform.position;
                attendedPlayers[i].SetActive(true);
                Destroy(Players[i]);              
            }
        }
	}
    PlayerController pController;

    void Update() {
        if (Input.GetKey(KeyCode.Joystick1Button9)&&!joinPlayers.Contains(1))
        {
            attendedPlayers.Add(Players[playersNum]);
            Players[playersNum].SetActive(true);
            joinPlayers.Add(1);
            pController = Players[playersNum++].GetComponent<PlayerController>();
            pController.myKeys[0] = KeyCode.Joystick1Button0;
            pController.myKeys[1] = KeyCode.Joystick1Button1;
            pController.myKeys[2] = KeyCode.Joystick1Button2;
            pController.myKeys[3] = KeyCode.Joystick1Button3;
            pController.myKeys[4] = KeyCode.Joystick1Button4;
            pController.myKeys[5] = KeyCode.Joystick1Button5;
            pController.myKeys[6] = KeyCode.Joystick1Button6;
            pController.myKeys[7] = KeyCode.Joystick1Button7;
            pController.myKeys[8] = KeyCode.Joystick1Button8;
            pController.myKeys[9] = KeyCode.Joystick1Button9;
            pController.myKeys[10] = KeyCode.Joystick1Button10;
            pController.myKeys[11] = KeyCode.Joystick1Button11;
            pController.myKeys[12] = KeyCode.Joystick1Button12;
            pController.myKeys[13] = KeyCode.Joystick1Button13;
            pController.myKeys[14] = KeyCode.Joystick1Button14;
            pController.myKeys[15] = KeyCode.Joystick1Button15;
            pController.myKeys[16] = KeyCode.Joystick1Button16;
            pController.myKeys[17] = KeyCode.Joystick1Button17;
            pController.myKeys[18] = KeyCode.Joystick1Button18;
            pController.myKeys[19] = KeyCode.Joystick1Button19;
            pController.horizontalName = "Horizontal1";
            pController.verticalName = "Vertical1";
            pController.selected = true;
            
        }
        if (Input.GetKey(KeyCode.Joystick2Button9) && !joinPlayers.Contains(2))
        {
            attendedPlayers.Add(Players[playersNum]);
            Players[playersNum].SetActive(true);
            joinPlayers.Add(2);
            pController = Players[playersNum++].GetComponent<PlayerController>();
            pController.myKeys[0] = KeyCode.Joystick2Button0;
            pController.myKeys[1] = KeyCode.Joystick2Button1;
            pController.myKeys[2] = KeyCode.Joystick2Button2;
            pController.myKeys[3] = KeyCode.Joystick2Button3;
            pController.myKeys[4] = KeyCode.Joystick2Button4;
            pController.myKeys[5] = KeyCode.Joystick2Button5;
            pController.myKeys[6] = KeyCode.Joystick2Button6;
            pController.myKeys[7] = KeyCode.Joystick2Button7;
            pController.myKeys[8] = KeyCode.Joystick2Button8;
            pController.myKeys[9] = KeyCode.Joystick2Button9;
            pController.myKeys[10] = KeyCode.Joystick2Button10;
            pController.myKeys[11] = KeyCode.Joystick2Button11;
            pController.myKeys[12] = KeyCode.Joystick2Button12;
            pController.myKeys[13] = KeyCode.Joystick2Button13;
            pController.myKeys[14] = KeyCode.Joystick2Button14;
            pController.myKeys[15] = KeyCode.Joystick2Button15;
            pController.myKeys[16] = KeyCode.Joystick2Button16;
            pController.myKeys[17] = KeyCode.Joystick2Button17;
            pController.myKeys[18] = KeyCode.Joystick2Button18;
            pController.myKeys[19] = KeyCode.Joystick2Button19;
            pController.horizontalName = "Horizontal2";
            pController.verticalName = "Vertical2";
            pController.selected = true;

        }
        if (Input.GetKey(KeyCode.Joystick3Button9) && !joinPlayers.Contains(3))
        {
            attendedPlayers.Add(Players[playersNum]);
            Players[playersNum].SetActive(true);
            joinPlayers.Add(3);
            pController = Players[playersNum++].GetComponent<PlayerController>();
            pController.myKeys[0] = KeyCode.Joystick3Button0;
            pController.myKeys[1] = KeyCode.Joystick3Button1;
            pController.myKeys[2] = KeyCode.Joystick3Button2;
            pController.myKeys[3] = KeyCode.Joystick3Button3;
            pController.myKeys[4] = KeyCode.Joystick3Button4;
            pController.myKeys[5] = KeyCode.Joystick3Button5;
            pController.myKeys[6] = KeyCode.Joystick3Button6;
            pController.myKeys[7] = KeyCode.Joystick3Button7;
            pController.myKeys[8] = KeyCode.Joystick3Button8;
            pController.myKeys[9] = KeyCode.Joystick3Button9;
            pController.myKeys[10] = KeyCode.Joystick3Button10;
            pController.myKeys[11] = KeyCode.Joystick3Button11;
            pController.myKeys[12] = KeyCode.Joystick3Button12;
            pController.myKeys[13] = KeyCode.Joystick3Button13;
            pController.myKeys[14] = KeyCode.Joystick3Button14;
            pController.myKeys[15] = KeyCode.Joystick3Button15;
            pController.myKeys[16] = KeyCode.Joystick3Button16;
            pController.myKeys[17] = KeyCode.Joystick3Button17;
            pController.myKeys[18] = KeyCode.Joystick3Button18;
            pController.myKeys[19] = KeyCode.Joystick3Button19;
            pController.horizontalName = "Horizontal3";
            pController.verticalName = "Vertical3";
            pController.selected = true;

        }
        if (Input.GetKey(KeyCode.Joystick4Button9) && !joinPlayers.Contains(4))
        {
            attendedPlayers.Add(Players[playersNum]);
            Players[playersNum].SetActive(true);
            joinPlayers.Add(4);
            pController = Players[playersNum++].GetComponent<PlayerController>();
            pController.myKeys[0] = KeyCode.Joystick4Button0;
            pController.myKeys[1] = KeyCode.Joystick4Button1;
            pController.myKeys[2] = KeyCode.Joystick4Button2;
            pController.myKeys[3] = KeyCode.Joystick4Button3;
            pController.myKeys[4] = KeyCode.Joystick4Button4;
            pController.myKeys[5] = KeyCode.Joystick4Button5;
            pController.myKeys[6] = KeyCode.Joystick4Button6;
            pController.myKeys[7] = KeyCode.Joystick4Button7;
            pController.myKeys[8] = KeyCode.Joystick4Button8;
            pController.myKeys[9] = KeyCode.Joystick4Button9;
            pController.myKeys[10] = KeyCode.Joystick4Button10;
            pController.myKeys[11] = KeyCode.Joystick4Button11;
            pController.myKeys[12] = KeyCode.Joystick4Button12;
            pController.myKeys[13] = KeyCode.Joystick4Button13;
            pController.myKeys[14] = KeyCode.Joystick4Button14;
            pController.myKeys[15] = KeyCode.Joystick4Button15;
            pController.myKeys[16] = KeyCode.Joystick4Button16;
            pController.myKeys[17] = KeyCode.Joystick4Button17;
            pController.myKeys[18] = KeyCode.Joystick4Button18;
            pController.myKeys[19] = KeyCode.Joystick4Button19;
            pController.horizontalName = "Horizontal4";
            pController.verticalName = "Vertical4";
            pController.selected = true;

        }
        if (Input.GetKey(KeyCode.Joystick5Button9) && !joinPlayers.Contains(5))
        {
            attendedPlayers.Add(Players[playersNum]);
            Players[playersNum].SetActive(true);
            joinPlayers.Add(5);
            pController = Players[playersNum++].GetComponent<PlayerController>();
            pController.myKeys[0] = KeyCode.Joystick5Button0;
            pController.myKeys[1] = KeyCode.Joystick5Button1;
            pController.myKeys[2] = KeyCode.Joystick5Button2;
            pController.myKeys[3] = KeyCode.Joystick5Button3;
            pController.myKeys[4] = KeyCode.Joystick5Button4;
            pController.myKeys[5] = KeyCode.Joystick5Button5;
            pController.myKeys[6] = KeyCode.Joystick5Button6;
            pController.myKeys[7] = KeyCode.Joystick5Button7;
            pController.myKeys[8] = KeyCode.Joystick5Button8;
            pController.myKeys[9] = KeyCode.Joystick5Button9;
            pController.myKeys[10] = KeyCode.Joystick5Button10;
            pController.myKeys[11] = KeyCode.Joystick5Button11;
            pController.myKeys[12] = KeyCode.Joystick5Button12;
            pController.myKeys[13] = KeyCode.Joystick5Button13;
            pController.myKeys[14] = KeyCode.Joystick5Button14;
            pController.myKeys[15] = KeyCode.Joystick5Button15;
            pController.myKeys[16] = KeyCode.Joystick5Button16;
            pController.myKeys[17] = KeyCode.Joystick5Button17;
            pController.myKeys[18] = KeyCode.Joystick5Button18;
            pController.myKeys[19] = KeyCode.Joystick5Button19;
            pController.horizontalName = "Horizontal5";
            pController.verticalName = "Vertical5";
            pController.selected = true;

        }
        if (Input.GetKey(KeyCode.Joystick6Button9) && !joinPlayers.Contains(6))
        {
            attendedPlayers.Add(Players[playersNum]);
            Players[playersNum].SetActive(true);
            joinPlayers.Add(6);
            pController = Players[playersNum++].GetComponent<PlayerController>();
            pController.myKeys[0] = KeyCode.Joystick6Button0;
            pController.myKeys[1] = KeyCode.Joystick6Button1;
            pController.myKeys[2] = KeyCode.Joystick6Button2;
            pController.myKeys[3] = KeyCode.Joystick6Button3;
            pController.myKeys[4] = KeyCode.Joystick6Button4;
            pController.myKeys[5] = KeyCode.Joystick6Button5;
            pController.myKeys[6] = KeyCode.Joystick6Button6;
            pController.myKeys[7] = KeyCode.Joystick6Button7;
            pController.myKeys[8] = KeyCode.Joystick6Button8;
            pController.myKeys[9] = KeyCode.Joystick6Button9;
            pController.myKeys[10] = KeyCode.Joystick6Button10;
            pController.myKeys[11] = KeyCode.Joystick6Button11;
            pController.myKeys[12] = KeyCode.Joystick6Button12;
            pController.myKeys[13] = KeyCode.Joystick6Button13;
            pController.myKeys[14] = KeyCode.Joystick6Button14;
            pController.myKeys[15] = KeyCode.Joystick6Button15;
            pController.myKeys[16] = KeyCode.Joystick6Button16;
            pController.myKeys[17] = KeyCode.Joystick6Button17;
            pController.myKeys[18] = KeyCode.Joystick6Button18;
            pController.myKeys[19] = KeyCode.Joystick6Button19;
            pController.horizontalName = "Horizontal6";
            pController.verticalName = "Vertical6";
            pController.selected = true;

        }
    }

    public void Losing()
    {
        ++losePlayers;
        if(playersNum- losePlayers==1|| playersNum - losePlayers == 0)
        {
            AudioSource.PlayClipAtPoint(hahaha, new Vector2(0, 0));
            StartCoroutine(Waiting());
        }
    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
