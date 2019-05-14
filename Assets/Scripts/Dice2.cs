using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice2 : MonoBehaviour
{
    private Sprite[] diceSides2;

    private SpriteRenderer rend2;

    private void Start()
    {
        rend2 = GetComponent<SpriteRenderer>();

        diceSides2 = Resources.LoadAll<Sprite>("DiceSides/");
    }

    private void OnMouseDown()
    {
        StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        int randomDiceSide = 0;

        int finalSide = 0;


        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 5);

            rend2.sprite = diceSides2[randomDiceSide];

            yield return new WaitForSeconds(0.05f);
        }

        finalSide = randomDiceSide + 1;
        
        Debug.Log(finalSide);
    }
}
