using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeTheColor : MonoBehaviour
{
    public ParticleSystem ps;
    string collided = "nothing";
    Vector4 normalColor = new Vector4 (.976f,.7f,.17f,1f) ;
    Vector4 fireColor = new Vector4 (.6f,1f,0f,1f) ;
    Vector4 orangeColor = new Vector4 (1f,.7f,0f,1f) ;
    Vector4 caesiumColor = new Vector4 (.3f,1f,1f,1f) ;

    [SerializeField] GameManager gameManager;

    // Update is called once per frame
    void Update()
    {

        // using the parameter to 'collided to change the color of the fire and view the text on the screen 

        if (collided=="cupper")
        {   
            ps.startColor = Color.red;
            gameManager.SetCurrentStep(3) ;
        }
        else if (collided=="barium")
        { 
            ps.startColor = Color.green;
            gameManager.SetCurrentStep(4) ;

        }
        else if (collided=="sodium")
        {
            ps.startColor = orangeColor;
            gameManager.SetCurrentStep(5) ;

        }
        else if (collided=="caesium")
        { 
            ps.startColor = caesiumColor ;
            gameManager.SetCurrentStep(6) ;

        }
        else 
        { 
            
            ps.startColor = fireColor;

        }
        
    }
  

    void OnTriggerEnter(Collider other)
    {
        
        // when material enters the the trigger area, detects the name of the matarial from the tag

        if (other.CompareTag("cupper"))
        {
            collided = "cupper";
        }
        else if (other.CompareTag("sodium"))
        {
            collided = "sodium";
        }
        else if (other.CompareTag("barium"))
        {
            collided = "barium";
        }
        else if (other.CompareTag("caesium"))
        {
            collided = "caesium";
            
        }
        else
        {
            collided = "nothing";
        }
    }

    void OnTriggerExit(Collider other)
    {
        // when the material exit the triiger area the collied prameter 
        // set to nothing to make the fire back to it's original color
        // and destro the matarial as an effect of the burning  
        if (other.CompareTag("cupper"))
            {
                collided = "nothing";
                Destroy(other.gameObject);
            }
        else if (other.CompareTag("sodium"))
            {
                collided = "nothing";
                Destroy(other.gameObject);
            }
        else if (other.CompareTag("barium"))
            {
                collided = "nothing";
                Destroy(other.gameObject);
            }
        else  if (other.CompareTag("caesium"))
            {
                collided = "nothing";
                Destroy(other.gameObject);
            }

    }



}


