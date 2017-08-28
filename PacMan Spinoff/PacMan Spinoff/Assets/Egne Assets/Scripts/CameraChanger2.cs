using UnityEngine;

public class CameraChanger2 : MonoBehaviour
{
    private Camera kamera;
    public GameObject player;
    public GameObject cameraPos;
    private bool isTopView;
    public bool IsTopView { get { return isTopView; } }
    public bool IsFirstPersonView { get { return !isTopView; } }

    [SerializeField] private Vector3 topViewPosition = new Vector3(0, 10, 0);
    [SerializeField] private Vector3 topViewRotation = new Vector3(90, 0, 0);
    [SerializeField] private float topViewTime = 3f;


    void Start()
    {
        kamera = Camera.main;
        SnapToPlayer();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && topViewTime > 0)
        {
            isTopView = !isTopView;
            ToggleView();
        }

        if (isTopView)
        {
            topViewTime -= Time.deltaTime;
            if (topViewTime <= 0)
            {
                topViewTime = 0;
                SnapToPlayer();
            }
        }
    }

    private void ToggleView()
    {
        if (isTopView)
        {
            SnapToTop();
        }
        else
        {
            SnapToPlayer();
        }
    }

    void SnapToTop()
    {
        isTopView = true;
        kamera.transform.position = cameraPos.transform.position; //topViewPosition;
        kamera.transform.eulerAngles = cameraPos.transform.eulerAngles; //topViewRotation;
    }

    void SnapToPlayer()
    {
        isTopView = false;
        kamera.transform.position = player.transform.position;
        kamera.transform.rotation = player.transform.rotation;
    }
}