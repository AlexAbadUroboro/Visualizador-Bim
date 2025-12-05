using UnityEngine;
using UnityEngine.SceneManagement;
public class CambiarEscenaPorNombre : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
