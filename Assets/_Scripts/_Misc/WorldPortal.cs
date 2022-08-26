using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldPortal : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        WorldTraveler TravelerObject = collision.GetComponent<WorldTraveler>();
        if (TravelerObject != null)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
