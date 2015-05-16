using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StopGame : MonoBehaviour
{

    public static bool ISWIN;
    public static bool ISLOST;

    public Slider slider;
    public GameObject UIExit;
    public GameObject UIWin;
    public Text text;
    public GameObject win;
    public GameObject lost;

    
    private Animator animatorUIMenu;
    private Animator animatorUIWin;
    private AudioSource auWin, auLost;

    
	// Use this for initialization
    void Start()
    {
        ISWIN = false;
        ISLOST = false;
        animatorUIMenu = this.GetComponent<Animator>();
        animatorUIWin = UIWin.GetComponent<Animator>();
        auWin = win.GetComponent<AudioSource>();
        auLost = lost.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        
        //Chien thang
        if (ISWIN == true)
        {
            auWin.Play();
            animatorUIMenu.SetBool("IsOpen", false);
            animatorUIWin.SetBool("IsWin", true);
        }
        if (ISLOST == true)
        {
            auLost.Play();
            text.text = "Thất bại";
            animatorUIMenu.SetBool("IsOpen", false);
            animatorUIWin.SetBool("IsWin", true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!animatorUIMenu.GetBool("IsOpen"))
            {
                animatorUIMenu.SetBool("IsOpen", true);
                
            }
            else
            {
                animatorUIMenu.SetBool("IsOpen", false);
            }
        }
	}

    public void OnclickRe ()
    {
        animatorUIMenu.SetBool("IsOpen", false);
    }
    public void OnclickNew()
    {
        animatorUIMenu.SetBool("IsOpen", false);

        Info.hp = Info.hpMax;
        Info.score = 0;

        Application.LoadLevel("Map01");
    }
    public void OnclickExit()
    {
        animatorUIMenu.SetBool("IsOpen", false);
        Instantiate(UIExit);
    }
}
//Chiến thắng
