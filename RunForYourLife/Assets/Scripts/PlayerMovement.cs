using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10f;//移動速度
    public float gravity = -9.81f;//重力
    public bool tired;

    public Transform groundCheck;
    public float grounDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public float stamina;
    float maxStamina;
    public Slider staminaBar;
    public float dValue;

    public GameObject flashlight;
    public GameObject enemy;
    public GameObject hand;

    bool beCatch = false;
    public float fillAmount = 0;
    public GameObject QTEImage;
    float i = 0;
    float d = 0;
    bool moveing;
    float life = 3;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    void Start()
    {
        transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
        maxStamina = stamina;
        staminaBar.maxValue = stamina;
        QTEImage.SetActive(false);
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, grounDistance, groundMask);

        if(Input.GetKey("w")|| Input.GetKey("a")|| Input.GetKey("s")|| Input.GetKey("d"))
        {
            moveing = true;
        }
        else
        {
            moveing = false;
        }

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");//input水平
        float z = Input.GetAxis("Vertical");//input垂直

        Vector3 move = transform.right * x + transform.forward * z;

        if(beCatch == false)
        {
            if (Input.GetKey(KeyCode.LeftShift) && stamina > 0 && tired == false && moveing == true)
            {
                speed = 20;
                controller.Move(move * speed * Time.deltaTime);
                DecreaseEnergy();
            }
            else
            {
                speed = 10;
                controller.Move(move * speed * Time.deltaTime);
                IncreaseEnergy();
            }
        }
        staminaBar.value = stamina;

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        Ray ray = new Ray(this.transform.position,this.transform.forward);
        RaycastHit hit;
        LayerMask mask = 1 << LayerMask.NameToLayer("enemy");
        if(Physics.Raycast(ray, out hit, 20, mask) && flashlight.activeInHierarchy == true)
        {
            enemy.GetComponent<enemy>().isLooking = true;
        }
        else
        {
            enemy.GetComponent<enemy>().isLooking = false;
        }

        if(beCatch == true && life != 0)
        {
            hand.SetActive(true);
            enemy.GetComponent<enemy>().isLooking = true;
            QTEImage.SetActive(true);
            i += Time.deltaTime;
            d += Time.deltaTime;
            if (Input.GetKeyDown("e"))
            {
                fillAmount += 0.2f;
            }
            if (i > 0.1)
            {
                fillAmount -= 0.03f;
                i = 0;
            }
            else if (fillAmount < 0)
            {
                fillAmount = 0;
            }
            if (fillAmount > 1)
            {
                fillAmount = 1;
                beCatch = false;
                life--;
            }
            GameObject.Find("QTEtime").GetComponent<Image>().fillAmount = fillAmount;
            if (d >= 7 )
            {
                d = 0;
                beCatch = false;
                SceneManager.LoadScene("Ava");
            }
        }else if (beCatch == false && fillAmount == 1)
        {
            StartCoroutine(QTE());
        }else if (beCatch == true && life == 0)
        {
            d = 0;
            beCatch = false;
            SceneManager.LoadScene("Ava");
        }
        if(life == 2)
        {
            life1.SetActive(false);
        }else if(life == 1)
        {
            life2.SetActive(false);
        }else if (life == 0)
        {
            life3.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            beCatch = true;
        }
        if (other.gameObject.CompareTag("light"))
        {
            GameObject.Find("player").GetComponent<Freezes>().enabled = true;
        }
    }

    private void DecreaseEnergy()
    {
        if(stamina > 0)
        {
            stamina -= dValue * Time.deltaTime * 1.5f;
        }
        if (stamina <= 0)
        {
            StartCoroutine(wait());
        }
    }
    private void IncreaseEnergy()
    {
        if (stamina <= 30)
        {
            stamina += dValue * Time.deltaTime * 1.2f;
        }
        else
        {
            tired = false;
        }
    }
    IEnumerator wait()
    {
        tired = true;
        yield return stamina >= 30;
    }

    IEnumerator QTE()
    {
        d = 0;
        enemy.GetComponent<enemy>().isLooking = true;
        hand.SetActive(false);
        QTEImage.SetActive(false);
        enemy.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(5);
        enemy.GetComponent<enemy>().isLooking = false;
        enemy.GetComponent<BoxCollider>().enabled = true;
        fillAmount = 0;
    }
}
