using UnityEngine;

public class TriggerController : MonoBehaviour
{
   [SerializeField] private Color _colorBin;
   [SerializeField] private SpriteRenderer _spriteRenderer;

   public Color Color
   {
      get => _colorBin;
      set
      {
         _colorBin = value;
         _spriteRenderer.color = value;
      }
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.TryGetComponent(out Ball ball))
      {
         if (ball.BallColor == _colorBin)
         {
            StatesController.onRightAction?.Invoke();
         }
         else
         {
            StatesController.onMissAction?.Invoke();
         }

         InstantiateBallsController.onSetBall?.Invoke();
      }
   }
    
}