using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeObject : MonoBehaviour
{   
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;

    public void ObjectA()
       {
        A.SetActive(true);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
        E.SetActive(false);
        
        
        }   
    public void ObjectB()
       {
        A.SetActive(false);
        B.SetActive(true);
        C.SetActive(false);
        D.SetActive(false);
        E.SetActive(false);
        
        }    
     public void ObjectC()
       {
        A.SetActive(false);
        B.SetActive(false);
        C.SetActive(true);
        D.SetActive(false);
        E.SetActive(false);
        
       } 
     public void ObjectD()
       {
        A.SetActive(false);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(true);
        E.SetActive(false);
        
       }  
     public void ObjectE()
     {
        A.SetActive(false);
        B.SetActive(false);
        C.SetActive(false);
        D.SetActive(false);
        E.SetActive(true);
        
     }               
}           

