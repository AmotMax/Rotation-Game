using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour
{
    public GameObject canvas1, canvas2;
   

    public GameObject button;



    public void Sound()
    {
        Instantiate(button, transform.position, Quaternion.identity);
    }


    public void Gotocanvas()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(true);

        Instantiate(button, transform.position, Quaternion.identity);
    }

    public void Returntocanvas()
    {
        canvas1.SetActive(true);
        canvas2.SetActive(false);

        Instantiate(button, transform.position, Quaternion.identity);
    }

    public void Base()
   {
        SceneManager.LoadScene(0);
        Instantiate(button, transform.position, Quaternion.identity);
    }

   public void Tuto()
   {
        SceneManager.LoadScene(1);
        Instantiate(button, transform.position, Quaternion.identity);
    }
   public void Deux()
   {
        SceneManager.LoadScene(2);
        Instantiate(button, transform.position, Quaternion.identity);
    }

   public void Trois()
   {
        SceneManager.LoadScene(3);
        Instantiate(button, transform.position, Quaternion.identity);
   }

    public void Quatre()
    {
        SceneManager.LoadScene(4);
        Instantiate(button, transform.position, Quaternion.identity);
    }

    public void Cinq()
    {
        SceneManager.LoadScene(5);
        Instantiate(button, transform.position, Quaternion.identity);
    }

    public void Six()
    {
        SceneManager.LoadScene(6);
        Instantiate(button, transform.position, Quaternion.identity);
    }




    public void Quit()
   {
        Debug.Log("ça quitte");
        Application.Quit();
        Instantiate(button, transform.position, Quaternion.identity);
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Instantiate(button, transform.position, Quaternion.identity);


    }
   
public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Instantiate(button, transform.position, Quaternion.identity);
    }

}
