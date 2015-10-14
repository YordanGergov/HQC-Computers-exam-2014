// <copyright file="IMotherboard.cs" company="Unknown">
// Copyright(c) 2015 Team "Unknown"
// </copyright>
// <summary>
// IMotherboard interface
// </summary>
// <author>Unknown</author>
namespace Computers.UI.Console
{
    /// <summary>
    /// The IMotherboard interface
    /// </summary>
    public interface IMotherboard
    {
        /// <summary>
        /// The method required to load a value
        /// </summary>
        /// <returns>A int value</returns>
        int LoadRamValue();

       /// <summary>
        /// The method required to save a value
       /// </summary>
       /// <param name="value"type"int">The value to save to ram</param>
        void SaveRamValue(int value);

       /// <summary>
        /// The method required to draw on video card
       /// </summary>
       /// <param name="data">The string to draw</param>
        void DrawOnVideoCard(string data);
    }
}
