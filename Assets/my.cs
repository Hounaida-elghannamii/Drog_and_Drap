using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class my : MonoBehaviour
{
    public GameObject a, b, c, d, ab, bb, cb, db;
    Vector2 aP, bP, cP, dP;
    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;
    //public AudioClip Fin;
    public GameObject im;
    bool aC, bC, cC, dC = false;
    // Start is called before the first frame update
    void Start()
    {
        aP = a.transform.position;
        bP = b.transform.position;
        cP = c.transform.position;
        dP = d.transform.position;
        im.SetActive(false);
        
    }

    // Update is called once per frame


    public void Draga()
    {
        a.transform.position = Input.mousePosition;
    }
    public void Dragb()
    {
        b.transform.position = Input.mousePosition;
    }
    public void Dragc()
    {
        c.transform.position = Input.mousePosition;
    }
    public void Dragd()
    {
        d.transform.position = Input.mousePosition;
    }
    //-----------------------------------------------------------------------------

    public void Drapa()
    {
        float Dis = Vector3.Distance(a.transform.position, ab.transform.position);
        if (Dis < 50)
        {
            a.transform.position = ab.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            aC = true;
        }
        else
        {
            a.transform.position = aP;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Drapb()
    {
        float Dis = Vector3.Distance(b.transform.position, bb.transform.position);
        if (Dis < 50)
        {
            b.transform.position = bb.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            bC = true;
        }
        else
        {
            b.transform.position = bP;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Drapc()
    {
        float Dis = Vector3.Distance(c.transform.position, cb.transform.position);
        if (Dis < 50)
        {
            c.transform.position = cb.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            cC = true;
        }
        else
        {
            c.transform.position = cP;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void Drapd()
    {
        float Dis = Vector3.Distance(d.transform.position, db.transform.position);
        if (Dis < 50)
        {
            d.transform.position = db.transform.position;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            dC = true;
        }
        else
        {
            d.transform.position = dP;
            source.clip = incorrect;
            source.Play();
        }
    }
    void Update()
    {
        
        if (aC && bC && cC && dC)
        {
            Debug.Log("You Winnnnnnnnnnnnnnnn");
            im.SetActive(true);
            

        }
        
    }
    public void retu(){
        SceneManager.LoadScene("2");
    }
    public void play()
    {
        SceneManager.LoadScene("3");
    }
    public void next1()
    {
        SceneManager.LoadScene("2");
    }
    public void next2()
    {
        SceneManager.LoadScene("1");
    }
    public void next3()
    {
        SceneManager.LoadScene("1");
    }
    public void retttt()
    {
        SceneManager.LoadScene("3");
    }
    public void retggggg()
    {
        SceneManager.LoadScene("4");
    }
}
