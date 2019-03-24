namespace UnityEngine.PostProcessing
{
    public sealed class MinAttributeFix : PropertyAttribute
    {
        public readonly float min;

        public MinAttributeFix(float min)
        {
            this.min = min;
        }
    }
}
