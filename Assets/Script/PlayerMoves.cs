using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMoves: MonoBehaviour
{
    public Animator animator;
    public Animator player2;
    public Camera mainCamera;
    public Slider hpbar_blue;
    public Slider epbar_blue;
    public Slider hpbar_red;
    public Slider epbar_red;
    public AudioSource ending;
  

    public float distanceUp = 1.5f;
    public float distanceAway = 1.5f;
    public float smooth = 2.2f;
    public float timer = 1.0f;
    private bool isOver = false;
    private bool isTime = false;
    private float timer2 = 0.0f;
    private bool isPlayed = false;
    private void Awake()
    {
        PlayerPrefs.SetFloat("PlayerRed_HP", 100);
        PlayerPrefs.SetFloat("PlayerRed_EP", 100);
        PlayerPrefs.SetFloat("PlayerBlue_HP", 100);
        PlayerPrefs.SetFloat("PlayerBlue_EP", 100);
        animator.SetBool("isDead", false);
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isOver == true)
        {
            if (!ending.isPlaying && isPlayed == false)
            {
                isPlayed = true;
                ending.Play();
            }

            timer2 -= Time.deltaTime;
            if (timer2 <= -3.0f)
            {
                SceneManager.LoadScene("Ending");
            }
        }

        timer -= Time.deltaTime;

        if (timer <= -8.0f)
        {
            isTime = true;
        }


        if (isTime == true && isOver == false)
        {
            animator.SetBool("rightMove", false);
            animator.SetBool("leftMove", false);
            animator.SetBool("frontMove", false);
            animator.SetBool("backMove", false);
            animator.SetBool("isPush", false);
            animator.SetBool("isPushing", false);
            animator.SetBool("headPunch", false);
            animator.SetBool("bodyPunch", false);
            animator.SetBool("isPush", false);
            animator.SetBool("headHit", false);
            animator.SetBool("stomachHit", false);


            player2.SetBool("rightMove", false);
            player2.SetBool("leftMove", false);
            player2.SetBool("frontMove", false);
            player2.SetBool("backMove", false);
            player2.SetBool("isPush", false);
            player2.SetBool("isPushing", false);
            player2.SetBool("headPunch", false);
            player2.SetBool("bodyPunch", false);
            player2.SetBool("isPush", false);
            player2.SetBool("headHit", false);
            player2.SetBool("stomachHit", false);



            float x1 = Input.GetAxis("Horizontal");
            float z1 = Input.GetAxis("Vertical");
            if (x1 != 0 || z1 != 0)
            {
                Vector3 targetDirection = new Vector3(x1, 0, z1);
                float y = Camera.main.transform.rotation.eulerAngles.y;
                targetDirection = Quaternion.Euler(0, y, 0) * targetDirection;
                animator.transform.Translate(targetDirection * Time.deltaTime * smooth, Space.World);
            }


            hpbar_red.value = PlayerPrefs.GetFloat("PlayerRed_HP");
            hpbar_blue.value = PlayerPrefs.GetFloat("PlayerBlue_HP");


            if (Input.GetKey(KeyCode.W)){
                animator.SetBool("frontMove", true);
                if (animator.name == "RED_Player@Sumo High Pull")
                {
                    PlayerPrefs.SetFloat("PlayerRed_EP", PlayerPrefs.GetFloat("PlayerRed_EP") - 0.03f);
                    epbar_red.value = PlayerPrefs.GetFloat("PlayerRed_EP");
                }
                else {
                    PlayerPrefs.SetFloat("PlayerBlue_EP", PlayerPrefs.GetFloat("PlayerBlue_EP") - 0.03f);
                    epbar_blue.value = PlayerPrefs.GetFloat("PlayerBlue_EP");
                }

            }

            if (Input.GetKey(KeyCode.A)){
                animator.SetBool("leftMove", true);
                if (animator.name == "RED_Player@Sumo High Pull")
                {
                    PlayerPrefs.SetFloat("PlayerRed_EP", PlayerPrefs.GetFloat("PlayerRed_EP") - 0.03f);
                    epbar_red.value = PlayerPrefs.GetFloat("PlayerRed_EP");
                }
                else {
                    PlayerPrefs.SetFloat("PlayerBlue_EP", PlayerPrefs.GetFloat("PlayerBlue_EP") - 0.03f);
                    epbar_blue.value = PlayerPrefs.GetFloat("PlayerBlue_EP");
                }
            }

            if (Input.GetKey(KeyCode.S)){
                animator.SetBool("backMove", true);
                if (animator.name == "RED_Player@Sumo High Pull")
                {
                    PlayerPrefs.SetFloat("PlayerRed_EP", PlayerPrefs.GetFloat("PlayerRed_EP") - 0.03f);
                    epbar_red.value = PlayerPrefs.GetFloat("PlayerRed_EP");
                }
                else {
                    PlayerPrefs.SetFloat("PlayerBlue_EP", PlayerPrefs.GetFloat("PlayerBlue_EP") - 0.03f);
                    epbar_blue.value = PlayerPrefs.GetFloat("PlayerBlue_EP");
                }
            }

            if (Input.GetKey(KeyCode.D)){
                animator.SetBool("rightMove", true);
                if (animator.name == "RED_Player@Sumo High Pull")
                {
                    PlayerPrefs.SetFloat("PlayerRed_EP", PlayerPrefs.GetFloat("PlayerRed_EP") - 0.03f);
                    epbar_red.value = PlayerPrefs.GetFloat("PlayerRed_EP");
                }
                else {
                    PlayerPrefs.SetFloat("PlayerBlue_EP", PlayerPrefs.GetFloat("PlayerBlue_EP") - 0.03f);
                    epbar_blue.value = PlayerPrefs.GetFloat("PlayerBlue_EP");
                }
            }

            if (Input.GetKey(KeyCode.Space)&& Input.GetKey(KeyCode.W))
            {
                animator.SetBool("isPush", true);
                if (animator.name == "RED_Player@Sumo High Pull")
                {
                    PlayerPrefs.SetFloat("PlayerRed_EP", PlayerPrefs.GetFloat("PlayerRed_EP") - 0.06f);
                    epbar_red.value = PlayerPrefs.GetFloat("PlayerRed_EP");
                }
                else {
                    PlayerPrefs.SetFloat("PlayerBlue_EP", PlayerPrefs.GetFloat("PlayerBlue_EP") - 0.06f);
                    epbar_blue.value = PlayerPrefs.GetFloat("PlayerBlue_EP");
                }
            }

            if (Input.GetMouseButton(0))
            {
                animator.SetBool("bodyPunch", true);
                if (animator.name == "RED_Player@Sumo High Pull")
                {
                    PlayerPrefs.SetFloat("PlayerRed_EP", PlayerPrefs.GetFloat("PlayerRed_EP") - 0.06f);
                    epbar_red.value = PlayerPrefs.GetFloat("PlayerRed_EP");
                }
                else {
                    PlayerPrefs.SetFloat("PlayerBlue_EP", PlayerPrefs.GetFloat("PlayerBlue_EP") - 0.06f);
                    epbar_blue.value = PlayerPrefs.GetFloat("PlayerBlue_EP");
                }
            }

            if (Input.GetMouseButton(1))
            {
                animator.SetBool("headPunch", true);
                if (animator.name == "RED_Player@Sumo High Pull")
                {
                    PlayerPrefs.SetFloat("PlayerRed_EP", PlayerPrefs.GetFloat("PlayerRed_EP") - 0.06f);
                    epbar_red.value = PlayerPrefs.GetFloat("PlayerRed_EP");
                }
                else {
                    PlayerPrefs.SetFloat("PlayerBlue_EP", PlayerPrefs.GetFloat("PlayerBlue_EP") - 0.06f);
                    epbar_blue.value = PlayerPrefs.GetFloat("PlayerBlue_EP");
                }
            }


            //===========================AI=========================================

            float x2 = Random.Range(-1.0f,1.0f);
            float z2 = Random.Range(-1.0f, 1.0f);
            x2 += Random.Range(-1.0f, 1.0f);
            z2 += Random.Range(-1.0f, 1.0f);
            Debug.Log(x2);
            Debug.Log(z2);
            if (isOver == true)
            {
                x2 = z2 = 0;
            }
            if (x2 != 0 || z2 != 0)
            {
                Vector3 targetDirection = new Vector3(x2, 0, z2);
                float y = Camera.main.transform.rotation.eulerAngles.y;
                targetDirection = Quaternion.Euler(0, y, 0) * targetDirection;
                player2.transform.Translate(targetDirection * Time.deltaTime * smooth, Space.World);
                if (x2 > 0)
                    player2.SetBool("backMove", true);
                if (x2 < 0)
                    player2.SetBool("frontMove", true);
                if (z2 > 0)
                    player2.SetBool("leftMove", true);
                if (z2 < 0)
                    player2.SetBool("rightMove", true);

                if (Random.Range(0.0f, 1.0f) >= 0.7) {
                    player2.SetBool("bodyPunch", true);
                }
                if (Random.Range(0.0f, 1.0f) >= 0.33 && Random.Range(0.0f, 1.0f) < 0.7)
                {
                    player2.SetBool("bodyPunch", true);
                }

            }

        }

        if (animator.name == "RED_Player@Sumo High Pull") {
            if (PlayerPrefs.GetFloat("PlayerRed_HP") <= 0 && PlayerPrefs.GetFloat("PlayerBlue_HP") > 0)
            {
                animator.SetBool("isDead", true);
                PlayerPrefs.SetString("winer", "PlayerBlue");
                isOver = true;
            }

            if (PlayerPrefs.GetFloat("PlayerBlue_HP") <= 0 && PlayerPrefs.GetFloat("PlayerRed_HP") > 0)
            {
                player2.SetBool("isDead", true);
                PlayerPrefs.SetString("winer", "PlayerRed");
                isOver = true;
            }
        }

        if (animator.name == "BLUE_Player@Sumo High Pull")
        {
            if (PlayerPrefs.GetFloat("PlayerRed_HP") <= 0 && PlayerPrefs.GetFloat("PlayerBlue_HP") > 0)
            {
                player2.SetBool("isDead", true);
                PlayerPrefs.SetString("winer", "PlayerBlue");
                isOver = true;

            }

            if (PlayerPrefs.GetFloat("PlayerBlue_HP") <= 0 && PlayerPrefs.GetFloat("PlayerRed_HP") > 0)
            {
                animator.SetBool("isDead", true);
                PlayerPrefs.SetString("winer", "PlayerRed");
                isOver = true;
            }
        }

        if (PlayerPrefs.GetFloat("PlayerBlue_HP") <= 0 && PlayerPrefs.GetFloat("PlayerRed_HP") <= 0)
        {
            animator.SetBool("isDead", true);
            player2.SetBool("isDead", true);
            PlayerPrefs.SetString("winer", "Draw");
            isOver = true;
        }

 


       



    }


    void LateUpdate()
    {
        Vector3 disPos = animator.transform.position + Vector3.up * distanceUp - animator.transform.forward * distanceAway + new Vector3(-1.0f, 1.0f, 0.0f);
        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, disPos, Time.deltaTime * smooth);
        mainCamera.transform.LookAt(player2.transform.position);
        animator.transform.LookAt(player2.transform.position);
        player2.transform.LookAt(animator.transform.position);
    }


}
