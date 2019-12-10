using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    
   public static int health = 100;
    public static int points = 0;
    public Text healthText;
    public Text pointsText;
    public static bool isInvincible = false;

    // Start is called before the first frame update
    void Start()
    {
        healthText.text = "Health = " + health.ToString();
        pointsText.text = "Points = " + points.ToString();
    }

    // Update is called once per frame
    void Update()
    {


        if(health > 200)
        {
            health = 200;
        }
        if(isInvincible == true)
        {
            healthText.text = "Health = INVINCIBLE";
            pointsText.text = "Points = " + points.ToString();
            Invoke("isNotInvincible", 20f);
        }
        else
        {
            healthText.text = "Health = " + health.ToString();
            pointsText.text = "Points = " + points.ToString();
        }

        
    }

    void isNotInvincible()
    {
        isInvincible = false;
    }

    void OnTriggerEnter(Collider col)
    {
   
        if(col.gameObject.CompareTag("Diamond"))
        {
            SceneManager.LoadScene("Winner");
        }


        if (col.gameObject.CompareTag("Banana"))
        {
            if(isInvincible == true)
            {
                
                healthText.text = "Health = INVINCIBLE";

                points += 10;
                pointsText.text = "Points =  " + points.ToString();
            }

            else
            {
                health += 10;
                healthText.text = "Health =  " + health.ToString();

                points += 5;
                pointsText.text = "Points =  " + points.ToString();
            }
         
        }

        if (col.gameObject.CompareTag("Apple"))
        {

            if (isInvincible == true)
            {

                healthText.text = "Health = INVINCIBLE";

                points += 10;
                pointsText.text = "Points =  " + points.ToString();
            }

            else
            {
                health += 5;
                healthText.text = "Health =  " + health.ToString();

                points += 5;
                pointsText.text = "Points =  " + points.ToString();
            }

        }

        if (col.gameObject.CompareTag("Enemy"))
        {
            if(isInvincible == true)
            {
                healthText.text = "Health = INVINCIBLE";
            }
            else
            {
                health -= 20;
                healthText.text = "Health = " + health.ToString();
                if (health <= 0)
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
            
        }

        if (col.gameObject.CompareTag("Cookie"))
        {
            if(isInvincible == true)
            {
                healthText.text = "Health = INVINCIBLE";
            }
            else
            {
                health -= 5;
                healthText.text = "Health = " + health.ToString();
                points -= 5;
                pointsText.text = "Points = " + points.ToString();
            }
           

        }

        if (col.gameObject.CompareTag("Cake"))
        {
            if (isInvincible == true)
            {
                healthText.text = "Health = INVINCIBLE";
            }
            else
            {
                health -= 5;
                healthText.text = "Health = " + health.ToString();
                points -= 5;
                pointsText.text = "Points = " + points.ToString();
            }
        }

        if (col.gameObject.CompareTag("MegaFruit"))
        {
            Debug.Log("MEGAFRUIT");
            healthText.text = "Player Health = INVINCIBLE";

            points += 50;
            pointsText.text = "Points =  " + points.ToString();
            isInvincible = true;
        }

    
    }

    public static void addEnemyHealth()
    {
        if(isInvincible == true)
        {
            points += 40;
        }
        else
        {
            health += 10;
            points += 20;
        }
        
    }

    

   
    
    

  
  
}
