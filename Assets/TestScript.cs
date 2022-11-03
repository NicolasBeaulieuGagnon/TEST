using System.Timers;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestScript : MonoBehaviour, IPointerClickHandler
{
    private readonly Timer mouseSingleClickTimer = new Timer();


    [SerializeField]
    GameObject spellDetailPrefab;

    void Start()
    {
        mouseSingleClickTimer.Interval = 500;
        mouseSingleClickTimer.Elapsed += SingleClick;
    }

    private void SingleClick(object sender, ElapsedEventArgs e)
    {
        mouseSingleClickTimer.Stop();
        Debug.Log("Entering if");
        GameObject myTest = Instantiate(spellDetailPrefab);
        Debug.Log($"Spawned test: {myTest}");

    }

    private void DoubleClick()
    {
        Debug.Log("firing doubleclick");
    }

    public void OnPointerClick(PointerEventData data)
    {
        if (mouseSingleClickTimer.Enabled == false)
        {
            mouseSingleClickTimer.Start();
            return;
        }
        else
        {
            mouseSingleClickTimer.Stop();
            DoubleClick();
        }
    }

}
