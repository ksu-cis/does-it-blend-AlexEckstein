namespace DoesItBlend
{
    /// <summary>
    /// Interface for items that can be blended.
    /// </summary>
    interface IBlendable
    {
        /// <summary>
        /// Blends the object.
        /// </summary>
        /// <returns>String description of object</returns>
        string Blend();
    }
}