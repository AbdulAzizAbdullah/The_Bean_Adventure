using UnityEngine;
public class TimeCtrl : MonoBehaviour
{

 public float SlowDownFactor = 0.05f;
 public float SlowTime = 2f;
 
  void Update()
  {
    Time.timeScale += ( 1f / SlowTime ) * Time.unscaledDeltaTime;
    Time.timeScale = Mathf.Clamp( Time.timeScale, 0f, 1f);
  }



  public void doslowmotion()
  {
    Time.timeScale = SlowDownFactor;
    Time.fixedDeltaTime = Time.timeScale * .02f;
  }


}
