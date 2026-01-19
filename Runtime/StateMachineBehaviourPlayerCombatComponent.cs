using System.Collections.Generic;
using AV.Unity.Extend.Runtime.Cache;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AV.StateMachineBehaviour.Runtime
{
    [HelpURL("https://github.com/IAFahim/AV.StateMachineBehaviour")]
    public class StateMachineBehaviourPlayerCombatComponent : UnityEngine.StateMachineBehaviour
    {
        private static readonly Dictionary<EntityId, PlayerCombatComponent> Lookup = new();
        [SerializeField] private string tag = "Attack";
        private int _targetTagHash;

        private void OnEnable()
        {
            _targetTagHash = Animator.StringToHash(tag);
        }

        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (stateInfo.tagHash != _targetTagHash) return;

            var id = animator.GetEntityId();
            if (!animator.TryGetComponentInParentCached(id, Lookup, out var combatComponent)) return;
            combatComponent.AttackFinished();
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void InitGlobal()
        {
            Lookup.Clear();

            SceneManager.activeSceneChanged -= OnSceneChanged;
            SceneManager.activeSceneChanged += OnSceneChanged;
        }

        private static void OnSceneChanged(Scene current, Scene next)
        {
            Lookup.Clear();
        }
    }
}