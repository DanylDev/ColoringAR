using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MonkeyManager : MonoBehaviour
{
    [SerializeField] private GameObject monkey;
    [SerializeField] private Animator monkeyAnimator;
    [SerializeField] private AudioSource monkeyAudioSource;

    [SerializeField] private GameObject buttonPlay;
    [SerializeField] private GameObject buttonPause;
    [SerializeField] private GameObject buttonStop;

    public void Play()
    {
        monkeyAudioSource.Play();
        monkeyAnimator.enabled = true;
        buttonPlay.SetActive(false);
        buttonPause.SetActive(true);
    }

    public void Pause()
    {
        monkeyAnimator.enabled = false;
        monkeyAudioSource.Pause();
        buttonPause.SetActive(false);
        buttonPlay.SetActive(true);
    }

    public void Stop()
    {
        monkey.SetActive(false);
        monkey.SetActive(true);
        monkeyAnimator.enabled = false;
        monkeyAudioSource.Stop();
        buttonPause.SetActive(false);
        buttonPlay.SetActive(true);
    }
}
