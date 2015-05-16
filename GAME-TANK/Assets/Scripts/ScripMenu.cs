using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartGame : MonoBehaviour
{

    public GameObject UIMessageExit;
    public GameObject UIMainMenu;
    public GameObject UIMenuHelp;
    
    public Slider Slider;

    private Animator animatorUIMainMenu;
    private Animator animatorUIMenuHelp;
    

    private float HEALTH = 100;


    public void Start ()
    {
        animatorUIMainMenu = UIMainMenu.GetComponent<Animator>();
        animatorUIMenuHelp = UIMenuHelp.GetComponent<Animator>();
        
    }

    public void Update()
    {
        
    }

    public void OnClickPlay ()
    {
        Debug.Log("play");
        animatorUIMainMenu.SetBool("IsOpen", false);
        //UIMainMenu.animation;
        //Destroy(gameObject);
        Application.LoadLevel("Map01");
    }

    public void OnClickHelp ()
    {
        if (!animatorUIMenuHelp.GetBool("IsHelp"))
            animatorUIMenuHelp.SetBool("IsHelp", true);
        else
            animatorUIMenuHelp.SetBool("IsHelp", false);
    }

    public void OnClickMoreGame ()
    {
        Debug.Log("MOre");
        Application.OpenURL("https://www.facebook.com/vietkhue.phan");
    }

    public void OnClickExit()
    {
        Instantiate(UIMessageExit);
    }


}
