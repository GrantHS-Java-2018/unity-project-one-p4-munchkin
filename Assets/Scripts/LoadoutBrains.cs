using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadoutBrains : MonoBehaviour
{

   [SerializeField] private GameObject returnButton;


   public void returnLoadout()
   {
      SceneManager.LoadScene("GamerTime");


   }



}
