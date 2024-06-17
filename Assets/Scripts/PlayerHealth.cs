using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxhealth;
    [SerializeField] HeartSystem hs;
    private void Start() {
        health = 3;
        maxhealth = 3;
        hs.DrawHeart(health, maxhealth);
    }

    public void Restart() {
        health = 3;
        hs.DrawHeart(health, maxhealth);
    }

    public void damage () {
        if(health > 0) {
            health -= 1;
            hs.DrawHeart(health, maxhealth); 
        }
    }

      public void HealPlayer (int dmg) {

        if( health < maxhealth) {
            health += dmg;
            hs.DrawHeart(health, maxhealth);
        }
        
    }

}
