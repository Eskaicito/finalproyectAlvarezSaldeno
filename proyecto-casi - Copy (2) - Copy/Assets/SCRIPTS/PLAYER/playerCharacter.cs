using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCharacter : MonoBehaviour
{
    [SerializeField] float speed = 8f;
    public Vector3 directionPlayer = Vector3.zero;
    private Vector3 directionPlayerPrivate = Vector3.zero;
    private Vector3 velocidad;
    [SerializeField] float gravedad = -9.81f;
    [SerializeField] float alturaSalto = 10f;

    [SerializeField] public CharacterController ccPlayer;
    [SerializeField] private Animator playerAnimator;
    private AudioManager audioManager;
    public ParticleSystem fuego;
    public ParticleSystem fuegoIra;
    public GameObject jardin;
    public GameObject alcantarillas;
    public GameObject laberinto;
    public GameObject arena; 
    private bool dobleJump;
    // Start is called before the first frame update
    private void Awake()
    {
        FindObjectOfType<GameManager>().OnDeath += muerto;
        audioManager = FindObjectOfType<AudioManager>();
    }
    void Start()
    {
        fuego = transform.Find("Camera").transform.Find("lanzallamasVFX").GetComponent<ParticleSystem>();
        fuegoIra = transform.Find("Camera").transform.Find("lanzallamasVFX2").GetComponent<ParticleSystem>();
        fuegoIra.gameObject.SetActive(false);
        fuego.gameObject.SetActive(true);

        ccPlayer = GetComponent<CharacterController>();
        jardin = GameObject.Find("JARDIN");
        alcantarillas = GameObject.Find("ALCANTARILLAS");
        laberinto = GameObject.Find("LABERINTO");
        fuego = transform.Find("Camera").transform.Find("lanzallamasVFX").gameObject.GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        if (PecadosSingleton.instance.pecadoIra){
           fuego.gameObject.SetActive(false);
           fuegoIra.gameObject.SetActive(true);
        }



        if (ccPlayer.isGrounded)
        {
            dobleJump = false;
            speed = 8f;
        }
        else
        {
            speed = 4.5f;
        }
        running();
        playerMoving();

        //Gravedad
        velocidad.y += gravedad * Time.deltaTime;
        ccPlayer.Move(velocidad * Time.deltaTime);
        jumpPlayer();
    }
    private void jumpPlayer()
    {
        if (PecadosSingleton.instance.pecadoPereza == true){
            if (Input.GetKeyDown(KeyCode.Space) && ccPlayer.isGrounded)
            {
                velocidad.y = Mathf.Sqrt(-alturaSalto * gravedad);
                playerAnimator.SetBool("IsJumping", true);
            }
            if (Input.GetKeyDown(KeyCode.Space) && (dobleJump ==false && PecadosSingleton.instance.pecadoPereza == true))
            {
                velocidad.y = Mathf.Sqrt(-alturaSalto * gravedad);
                playerAnimator.SetBool("IsJumping", true);
                dobleJump = true;
            }
        }
        else{
            if (Input.GetKeyDown(KeyCode.Space) && (dobleJump == false && ccPlayer.isGrounded))
            {
                velocidad.y = Mathf.Sqrt(-alturaSalto * gravedad);
                playerAnimator.SetBool("IsJumping", true);
            }
        }
    }
    private void PlayerMovement()
    {
        //transform.Translate(speed * Time.deltaTime * directionPlayer);
        ccPlayer.Move(speed * Time.deltaTime * transform.TransformDirection(directionPlayerPrivate));

    }
    private void playerMoving()
    {
        if (ccPlayer.isGrounded)
        {
            playerAnimator.SetBool("IsJumping", false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            directionPlayer = Vector3.zero;
            directionPlayer = Vector3.forward;
            directionPlayerPrivate = Vector3.forward;
            PlayerMovement();
            playerAnimator.SetBool("IsRun", true);

        }
        if (Input.GetKey(KeyCode.D))
        {
            directionPlayer = Vector3.zero;
            directionPlayer = Vector3.right;
            directionPlayerPrivate = Vector3.right;
            PlayerMovement();
            playerAnimator.SetBool("IsRunRight", true);

        }
        if (Input.GetKey(KeyCode.A))
        {
            directionPlayer = Vector3.zero;
            directionPlayer = Vector3.left; 
            directionPlayerPrivate = Vector3.left;
            PlayerMovement();
            playerAnimator.SetBool("IsRunLeft", true);

        }
        if (Input.GetKey(KeyCode.S))
        {
            directionPlayer = Vector3.zero;
            directionPlayer = Vector3.back; 
            directionPlayerPrivate = Vector3.back;
            PlayerMovement();
            playerAnimator.SetBool("IsRunBack", true);

        }
       
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnimator.SetBool("IsRun", false);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnimator.SetBool("IsRunBack", false);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            playerAnimator.SetBool("IsRunLeft", false);

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            playerAnimator.SetBool("IsRunRight", false);

        }


    }
    private void running()
    {
        if (ccPlayer.isGrounded)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                playerAnimator.SetBool("IsRunning", true);
                speed = 10;

            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                playerAnimator.SetBool("IsRunning", false);
                speed = 8;

            }
        }
    }

    

    private void muerto()
    {
        Destroy(this);
    }
    public void footsteps(){
        if(jardin){
        audioManager.seleccionAudio(0, 0.07f);
        }
        if(alcantarillas || laberinto){
            audioManager.seleccionAudio(1,0.07f);
        }
    }
    public void fireAttack(){
        audioManager.seleccionAudio(2,0.2f);
        fuego.Play();
        fuegoIra.Play();
    }
    
}
