using UnityEngine;
using System.Collections;

public class NextScene : MonoBehaviour {

    public bool exit = false;
    private string nextlevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        /*
        
        if (exit == true && this.gameObject.GetComponent<Bounce>().Side == Bounce.Options.Left)
        {
            Debug.Log(this.gameObject.transform.position.x);
            if ((this.gameObject.transform.position.x <= this.gameObject.GetComponent<Bounce>().OffScreenX) || (this.gameObject.transform.position.y <= this.gameObject.GetComponent<Bounce>().OffScreenY))
            {
                Application.LoadLevel(nextlevel);
            }
        }
        

        if (exit == true && this.gameObject.GetComponent<Bounce>().Side == Bounce.Options.Right)
        {
            if ((this.gameObject.transform.position.x >= this.gameObject.GetComponent<Bounce>().OffScreenX) || (this.gameObject.transform.position.y <= this.gameObject.GetComponent<Bounce>().OffScreenY))
            {
                Application.LoadLevel(nextlevel);
            }
        }

        if (exit == true && this.gameObject.GetComponent<Bounce>().Side == Bounce.Options.Top)
        {
            if ((this.gameObject.transform.position.x <= gameObject.GetComponent<Bounce>().OffScreenX) || (this.gameObject.transform.position.y >= this.gameObject.GetComponent<Bounce>().OffScreenY))
            {
                Application.LoadLevel(nextlevel);
            }
        }
        */


    }

	public void StartGame () 
	{

	}

    public void LoadTitleScreen()
    {
        exit = true;
        nextlevel = "Title";
        StartCoroutine("Wait");
    }

    public void LoadBuyMenu()
    {
        exit = true;
        nextlevel = "ShopMenu";
        StartCoroutine("Wait");
    }

    public void LoadStartMenu ()
    {
        exit = true;
        nextlevel = "MainMenu";
        StartCoroutine("Wait");
    }

    public void LoadLevelSelector()
    {
        exit = true;
        nextlevel = "LevelSelector";
        StartCoroutine("Wait");
    }

    public void LoadTestLevel1()
    {
        exit = true;
        nextlevel = "Test1";
        StartCoroutine("Wait");
    }

    public void LoadTestLevel2()
    {
        exit = true;
        nextlevel = "Test2";
        StartCoroutine("Wait");
    }

    public void GoToCreator ()
	{
        exit = true;
        nextlevel = "CharacterCustomizer";
        StartCoroutine("Wait");
    }

    void LoadLevel()
    {
        Application.LoadLevel(nextlevel);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(.6f);
        LoadLevel();
    }

}
