using UnityEngine;
using UnityEngine.UI;

public class CircleButtonSelection : MonoBehaviour
{
    [SerializeField] private GameObject[] contentImage;
    [SerializeField] private Image[] imageButton;

    private void Start()
    {
        for (int i = 0; i < imageButton.Length; i++)
        {
            imageButton[i].alphaHitTestMinimumThreshold = 0.5f; 
        }
    }

    public void EnterMouse(int index)
    {
        contentImage[index].transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
    }
    public void ExitMouse(int index)
    {
        contentImage[index].transform.localScale = new Vector3(1, 1, 1);
    }
}
