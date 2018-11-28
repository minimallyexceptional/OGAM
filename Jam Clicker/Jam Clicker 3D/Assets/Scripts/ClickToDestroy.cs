using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDestroy : MonoBehaviour {
    public Animator anim;
    public ParticleSystem particles;
    public int particleCount;
    private EZCameraShake.CameraShaker shaker;

    public void Start()
    {
        anim = this.GetComponent<Animator>();
        FloatingTextController.Initalize();
        shaker = EZCameraShake.CameraShaker.GetInstance("CameraTarget");

        anim.SetBool("isClicked", false);
        particles.Stop();
    }
    private void OnMouseDown()
    {
        Root.incrementScore(1);
        anim.SetBool("isClicked", true);
        particles.Emit(this.particleCount);
        FloatingTextController.createFloatingText(1, this.transform);
        shaker.ShakeOnce(20, 40, 1, 1);
    }

    private void OnMouseUp()
    {
        anim.SetBool("isClicked", false);
        particles.Stop();
    }
}
