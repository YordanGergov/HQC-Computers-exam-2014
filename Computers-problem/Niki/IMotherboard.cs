// <copyright file="IMotherboard.cs" company="Unknown">
// Copyright(c) 2015 Team "Game-Fifteen-4"
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
        /// <returns>A string value</returns>
        int LoadRamValue();

        /// <summary>
        /// The method required to save a value
        /// </summary>
        /// <returns>A string value</returns>
        /// 
        void SaveRamValue(int value);

        /// <summary>
        /// The method required to draw on video card
        /// </summary>
        /// <returns>A string value</returns>
        void DrawOnVideoCard(string data);
    }
}
