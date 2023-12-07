using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.UI;

namespace HeroicArcade.CC.UI
{
    public class AvatarHealthBarController : MonoBehaviour
    {
        [SerializeField] Image AvatarBarImage;
        [SerializeField] FloatReference AvatarCurrentHealth = null;
        [SerializeField] FloatReference AvatarMaxHealth = null;

        void Awake()
        {
            AvatarCurrentHealth.Value = AvatarMaxHealth.Value;
        }

        public void UpdateHealth()
        {

            if (AvatarBarImage.fillAmount != AvatarCurrentHealth.Value / AvatarMaxHealth.Value)
            {
                AvatarBarImage.fillAmount = AvatarCurrentHealth.Value / AvatarMaxHealth.Value;
            }
        }
    }
}