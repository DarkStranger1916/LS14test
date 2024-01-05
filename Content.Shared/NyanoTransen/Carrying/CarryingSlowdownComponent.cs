using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Carrying
{
    [RegisterComponent, NetworkedComponent, Access(typeof(CarryingSlowdownSystem))]

    public sealed partial class CarryingSlowdownComponent : Component
    {
        [DataField("walkModifier", required: true)] [ViewVariables(VVAccess.ReadWrite)]
        public float WalkModifier = 0.6f;

        [DataField("sprintModifier", required: true)] [ViewVariables(VVAccess.ReadWrite)]
        public float SprintModifier = 0.8f;
    }

    [Serializable, NetSerializable]
    public sealed class CarryingSlowdownComponentState : ComponentState
    {
        public float WalkModifier;
        public float SprintModifier;
        public CarryingSlowdownComponentState(float walkModifier, float sprintModifier)
        {
            WalkModifier = walkModifier;
            SprintModifier = sprintModifier;
        }
    }
}
