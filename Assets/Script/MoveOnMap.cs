using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class MoveOnMap : MonoBehaviour
{
    public static MoveOnMap instance;
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speed = 10;
    private bool isFacingRight = true;
    private float inputX;
    public Animator anim;
    public TMP_Text Level;
    public TMP_Text Level2;
    public int Level_Unlock = 1;
    public int Actual_Level = 0;
    public string[] scenePaths;
    public GameManager gameManager;
    public GameObject[] Cadenas;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        if (instance != null && instance != this) {
            Destroy(this);
        }
        instance = this;
        if (Level_Unlock < gameManager.Level_End)
        {
            Level_Unlock = gameManager.Level_End;
        }
        for (int i = 0; i <= Level_Unlock - 2; i++)
        {
            Cadenas[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(inputX));
        rb.velocity = new Vector2(inputX * speed, rb.velocity.y);
        Flip();

        if (Actual_Level == 1 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 1) {
            SceneManager.LoadScene(scenePaths[0], LoadSceneMode.Single);
        }
        if (Actual_Level == 2 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 1) {
            SceneManager.LoadScene(scenePaths[1], LoadSceneMode.Single);
        }
        if (Actual_Level == 3 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 1) {
            SceneManager.LoadScene(scenePaths[2], LoadSceneMode.Single);
        }
        if (Actual_Level == 4 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 1) {
            SceneManager.LoadScene(scenePaths[3], LoadSceneMode.Single);
        }
        if (Actual_Level == 5 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 1) {
            SceneManager.LoadScene(scenePaths[4], LoadSceneMode.Single);
        }
        if (Actual_Level == 6 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 1) {
            SceneManager.LoadScene(scenePaths[5], LoadSceneMode.Single);
            StartCoroutine(Timer());
        }
        if (Actual_Level == 1 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 2) {
            SceneManager.LoadScene(scenePaths[6], LoadSceneMode.Single);
        }
        if (Actual_Level == 2 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 2) {
            SceneManager.LoadScene(scenePaths[7], LoadSceneMode.Single);
        }
        if (Actual_Level == 3 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 2) {
            SceneManager.LoadScene(scenePaths[8], LoadSceneMode.Single);
        }
        if (Actual_Level == 4 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 2) {
            SceneManager.LoadScene(scenePaths[9], LoadSceneMode.Single);
        }
        if (Actual_Level == 5 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 2) {
            SceneManager.LoadScene(scenePaths[10], LoadSceneMode.Single);
        }
        if (Actual_Level == 6 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 2) {
            SceneManager.LoadScene(scenePaths[11], LoadSceneMode.Single);
            StartCoroutine(Timer());
        }
        if (Actual_Level == 1 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 3) {
            SceneManager.LoadScene(scenePaths[12], LoadSceneMode.Single);
        }
        if (Actual_Level == 2 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 3) {
            SceneManager.LoadScene(scenePaths[13], LoadSceneMode.Single);
        }
        if (Actual_Level == 3 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 3) {
            SceneManager.LoadScene(scenePaths[14], LoadSceneMode.Single);
        }
        if (Actual_Level == 4 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 3) {
            SceneManager.LoadScene(scenePaths[15], LoadSceneMode.Single);
        }
        if (Actual_Level == 5 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 3) {
            SceneManager.LoadScene(scenePaths[16], LoadSceneMode.Single);
        }
        if (Actual_Level == 6 && Input.GetButtonDown("Jump") && Actual_Level <= Level_Unlock && gameManager.world == 3) {
            SceneManager.LoadScene(scenePaths[17], LoadSceneMode.Single);
        }
    }

    private void Flip()
    {
        if (isFacingRight && inputX < 0f || !isFacingRight && inputX > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Level 1")
        {
            Actual_Level = 1;
            Level.SetText("Level 1");
            Level2.SetText("Level 1");
        } else if (other.name == "Level 2")
        {
            Actual_Level = 2;
            Level.SetText("Level 2");
            Level2.SetText("Level 2");
        } else if (other.name == "Level 3")
        {
            Actual_Level = 3;
            Level.SetText("Level 3");
            Level2.SetText("Level 3");
        } else if (other.name == "Level 4")
        {
            Actual_Level = 4;
            Level.SetText("Level 4");
            Level2.SetText("Level 4");
        } else if (other.name == "Level 5")
        {
            Actual_Level = 5;
            Level.SetText("Level 5");
            Level2.SetText("Level 5");
        } else if (other.name == "Level 6")
        {
            Actual_Level = 6;
            Level.SetText("Level 6");
            Level2.SetText("Level 6");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Actual_Level = 0;
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.1f);
        gameManager.world += 1;
    }
}
