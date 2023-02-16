using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour
{
    [SerializeField] private ParticleSystem ps;
    [SerializeField] private GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ExplousionCourutine());
    }

    private IEnumerator ExplousionCourutine()
    {
        ps.Play();
        yield return new WaitForSeconds(0.3f);
        player.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
