using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Base numbers for movespeed, turnspeed and jumpspeed
    public float moveSpeed = 5f;
    public float turnSpeed = 100f;
    public float jumpSpeed = 10f;

    //Levelled up bonuses
    public float currentMoveSpeed;
    public float currentTurnSpeed;
    public float currentJumpSpeed;
    public float xp = 0; // Amount of xp currently
    public float xpForNextLevel = 10; // xp needed for the next level, with each level becoming exponential
    public int level = 0; // Current Level
    // Start is called before the first frame update
    private void Start()
    {
        SetXpForNextLevel();
        SetCurrentMoveSpeed();
        SetCurrentTurnSpeed();
        SetCurrentJumpSpeed();
    }

    void SetXpForNextLevel()
    {
        xpForNextLevel = (10f + (level * level * 0.1f));
        Debug.Log("xpForNextLevel" + xpForNextLevel);
    }

    // 10% buff for moving when levelling up
    void SetCurrentMoveSpeed()
    {
        currentMoveSpeed = this.moveSpeed + (this.moveSpeed * 0.1f * level);
        Debug.Log("currentMoveSpeed = " + currentMoveSpeed);
    }
    // 10% buff for turning when levelling up
    void SetCurrentTurnSpeed()
    {
        currentTurnSpeed = this.turnSpeed + (this.turnSpeed * 0.1f * level);
        Debug.Log("currentTurnSpeed = " + currentTurnSpeed);
    }

    // 10% buff for jumping when levelling up
    void SetCurrentJumpSpeed()
    {
        currentJumpSpeed = this.jumpSpeed + (this.jumpSpeed * 0.1f * level);
        Debug.Log("currentJumpSpeed = " + currentJumpSpeed);
    }

    void LevelUp()
    {
        xp = 0f;
        level++;
        Debug.Log("Level" + level);
        SetXpForNextLevel();
        SetCurrentMoveSpeed();
        SetCurrentJumpSpeed();
        SetCurrentTurnSpeed();

    }
    // function to make the player game xp based on the amount you tell it.
    public void GainXP(int xpToGain)
    {
        xp += xpToGain;
        Debug.Log("Gained " + xpToGain + " Xp, Current Xp = " + xp + ", XP needed to reach next Level = " + xpForNextLevel);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) == true) { GainXP(1); }
        if (xp >= xpForNextLevel)
        {
            LevelUp();
        }
        if (Input.GetKey(KeyCode.W) == true) { this.transform.position += this.transform.forward * currentMoveSpeed * Time.deltaTime; }
        if (Input.GetKey(KeyCode.S) == true) { this.transform.position -= this.transform.forward * currentMoveSpeed * Time.deltaTime; }

        if (Input.GetKey(KeyCode.D) == true) { this.transform.Rotate(this.transform.up, Time.deltaTime * currentTurnSpeed); }
        if (Input.GetKey(KeyCode.A) == true) { this.transform.Rotate(this.transform.up, Time.deltaTime * -currentTurnSpeed); }

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(this.GetComponent<Rigidbody>().velocity.y) < 0.01f)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * currentJumpSpeed;
        }


    }
}

