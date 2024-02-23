using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ScriptsBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Menu(){
        SceneManager.LoadScene("menu");
    }
    public void Star()
    {
        SceneManager.LoadScene("inicio");
    }
    public void Galery(){
        SceneManager.LoadScene("galery");
    }
    public void GaleryChacters(){
        SceneManager.LoadScene("galeryPersonajes");
    }
    public void Information()
    {
        SceneManager.LoadScene("information");
    }
    //open siteweb
    /*public void goFacebook(string OpenURL)
    {
        Application.OpenURL("https:-/www.facebook.com/");
    }
    public void goSiteWeb(string OpenURL)
    {
        Application.OpenURL("http:-/www.utleon.edu.mx/");
    }*/
    public void ExitGame()
    {
        Application.Quit();


    }
}
